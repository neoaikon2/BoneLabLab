import os
import shutil
from pathlib import Path

def copy_files_by_namespace(source_folder, destination_folder):
    # Iterate through all files in the source folder and its subfolders
    for root, _, files in os.walk(source_folder):
        for file in files:
            if file.endswith(".cs"):
                cs_file_path = os.path.join(root, file)
                
                # Create the destination folder based on the namespace
                namespace = extract_namespace(cs_file_path)
                destination_path = os.path.join(destination_folder, *namespace.split("."))
                os.makedirs(destination_path, exist_ok=True)
                
                # Copy the .cs file
                shutil.copy(cs_file_path, destination_path)
                
                # Check for corresponding .meta file
                meta_file_path = os.path.join(root, file + ".meta")
                print(meta_file_path)
                if os.path.exists(meta_file_path):
                    shutil.copy(meta_file_path, destination_path)

def extract_namespace(cs_file_path):
    # You may need to customize this based on your project structure
    with open(cs_file_path, 'r', encoding='utf-8') as cs_file:
        for line in cs_file.readlines():
            if line.strip().startswith("namespace "):
                return line.split()[1].rstrip(";")
    return "Uncategorized"

# Replace 'source_folder' and 'destination_folder' with your actual folder paths
source_folder = '.\\UNSORTED'
destination_folder = '.\\SORTED'

copy_files_by_namespace(source_folder, destination_folder)
