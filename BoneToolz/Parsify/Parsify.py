# Removes spurious code from the ripped source files
#
# !** VOID WARNING !! VOID WARNING **!
# !** AI Generated, Human Verified **!


import os
import re

# Removes the compiler generated private structs
def remove_compiler_generated_structs(directory):
    # Define the regex pattern to match the class definition start
    struct_start_pattern = re.compile(r'\s*\[StructLayout\([0-9]\)\]\s*\[CompilerGenerated\]\s*private struct [^{]+{', re.DOTALL)

    # Traverse through the directory
    for root, _, files in os.walk(directory):
        for file in files:
            if file.endswith('.cs'):
                file_path = os.path.join(root, file)
                with open(file_path, 'r', encoding='utf-8') as f:
                    content = f.read()

                # Remove the matching class definitions
                new_content = content
                while True:
                    match = re.search(struct_start_pattern, new_content)
                    if not match:
                        break
                    start_index = match.start()
                    open_braces = 1
                    index = match.end()
                    while open_braces > 0 and index < len(new_content):
                        if new_content[index] == '{':
                            open_braces += 1
                        elif new_content[index] == '}':
                            open_braces -= 1
                        index += 1
                    new_content = new_content[:start_index] + new_content[index+1:]

                # Write the updated content back to the file
                with open(file_path, 'w', encoding='utf-8') as f:
                    f.write(new_content)

# Removes the compiler generated private sealed classes
def remove_compiler_generated_classes(directory):
    # Define the regex pattern to match the class definition start
    class_start_pattern = re.compile(r'[\r\n]\s*\[CompilerGenerated\]\s*private sealed class [^{]+{', re.DOTALL)

    # Traverse through the directory
    for root, _, files in os.walk(directory):
        for file in files:
            if file.endswith('.cs'):
                file_path = os.path.join(root, file)
                with open(file_path, 'r', encoding='utf-8') as f:
                    content = f.read()

                # Remove the matching class definitions
                new_content = content
                while True:
                    match = re.search(class_start_pattern, new_content)
                    if not match:
                        break
                    start_index = match.start()
                    open_braces = 1
                    index = match.end()
                    while open_braces > 0 and index < len(new_content):
                        if new_content[index] == '{':
                            open_braces += 1
                        elif new_content[index] == '}':
                            open_braces -= 1
                        index += 1
                    new_content = new_content[:start_index] + new_content[index+1:]

                # Write the updated content back to the file
                with open(file_path, 'w', encoding='utf-8') as f:
                    f.write(new_content)

# Removes spurious tags related to the removed classes
def remove_state_machine_tags(directory):
    # Define the regex pattern to match the state machine tags
    state_machine_pattern = re.compile(
        r'[\r\n]\s*\[IteratorStateMachine\(typeof\([^\)]+\)\)\]|[\r\s]\s*\[AsyncStateMachine\(typeof\([^\)]+\)\)\]|System\.Runtime\.CompilerServices\.Unsafe\.As.*?\.|[\r\n]\s*\[StructLayout\(0\,.*?\)\]|Awaiter\>\(.*?\)\.|Callback\>\(.*?\)\.|Enumerator\>\(.*?\)\.|[\r\n]\s*internal unsafe fixed.*?;|\[ProviderAlias\(.*?\)\]|[\r\n]\s*\[FieldOffset\(0\)\]', re.DOTALL
    )

    # Traverse through the directory
    for root, _, files in os.walk(directory):
        for file in files:
            if file.endswith('.cs'):                
                file_path = os.path.join(root, file)
                with open(file_path, 'r', encoding='utf-8') as f:
                    content = f.read()                
                # Remove the state machine tags
                new_content = re.sub(state_machine_pattern, '', content)

                # Write the updated content back to the file
                with open(file_path, 'w', encoding='utf-8') as f:
                    f.write(new_content)
                    
# Run the functions
print("Removing compiler generated classes...", end='')
remove_compiler_generated_classes('./')
print("DONE!\r\nRemoving compiler generated structs...", end='')
remove_compiler_generated_structs('./')
print("DONE!\r\nRemoving spurious tags and headers...", end='')
remove_state_machine_tags('./')

print("DONE!\r\nCompiler generated classes and state machine tags have been removed.")
