#	Bone Doc - Bonelab SDK updater
#
#	Author - Crypto Neo
#	Description: This python script takes a BASE SDK folder (containing your current SDK files)
#	and a DUMP folder containing the ripped files from BoneLab. It then traverses each directory
# 	and finds all the CS.META files, and then copies all the new ones into SDK_UPDATE and generates
#	a GUID mapping for UnFracture to use on your prefabs. Unfracture can be used to automagically
#	repair broken prefabs (provided they weren't before updating!). I make no plans to maintain this
#	rigorously so heed that as a warning, it's a tool for me to use and if it helps other people then
#	yay for that.

# Imports
from os import listdir, getcwd, makedirs
from os.path import isfile, exists, join
import shutil

# Extension for the meta files
_ext = ".cs.meta"

# Keep the copy of the SDK Base in SDK_BASE
# Put your ripped files in DUMP
# Extracted SDK files will be present in SDK_UPDATE
base_path = "\\BASE"
dump_path = "\\DUMP"
patch_path = "\\SDK_UPDATE"

class MetaInfo:
	fileNames = []
	guidPairs = {}
	filePaths = {}
	
	def __init__(self, value):
		self.name = []
		self.fileNames = []
		self.guidPairs = {}
		self.filePaths = {}
	
	def add(self, _fileName, _guid, _path = ""):
		self.name = []
		self.fileNames.append(_fileName)
		self.guidPairs[_fileName] = _guid
		if(not _path == ""):
			self.filePaths[_fileName] = _path
			
	def len(self):
		return len(self.fileNames)
		
	def filename(self, i):
		return self.fileNames[i]
		
	def guid(self, fn):
		return self.guidPairs[fn]
		
	def path(self, fn):
		return self.filePaths[fn]
			
# Objects to hold GUID metadata for each file
baseInfo = MetaInfo("base")
upgradeInfo = MetaInfo("dump")

metaFiles = []
metaGUIDs = {}

newFiles = []
newGUIDs = {}
newPaths = {}

# Reads a .meta file and returns the GUID
def getguid(file):
	f = open(file)
	for g in f:
		if "guid:" in g:
			#print(g[6:len(g)])
			f.close()
			return g[6:len(g)-1]
	
	
# Scans a directory for all .cs.meta files and
# generates a dictionary of file:guid pairs
def traverse(_path, _info):
	for _dir in listdir(_path): # From _path, get a list of directory items, for each one		
		if isfile(join(_path, _dir)): # Check to see if it is a file
			if _ext in _dir: # Check to see if this file is a .cs.meta file
				_file = _dir # For readability to show that we are working with a file (not a directory)
				# Add the metainfo
				_info.add(_file, getguid(join(_path, _file)), _path)
		else:
			if ("UnityEngine" in _dir):
				continue;
			# Otherwise traverse the next directory level
			traverse(join(_path, _dir), _info)

# Do directory traversal		
print("Scanning for script meta files in the SDK base directory...", end='')		
traverse(getcwd() + base_path + "\\", baseInfo)
print("done!\nScanning for matches in the ripped BoneLab files...", end='')
traverse(getcwd() + dump_path, upgradeInfo)
print("done!\nCreating SDK patch...", end='')

# Open up a file to store the new-to-old GUID mapping
f = open(getcwd() + "\\guidmap.txt", "w");
f.write("{ ");

# Go through each directory containing cs.meta files
for i in range(baseInfo.len()):
	_file = baseInfo.filename(i)
	_guid_a = baseInfo.guid(_file)
	
	# Try to see if we have a match between the base sdk and the ripped files (we should)
	try:
		_guid_b = upgradeInfo.guid(_file)
	except KeyError:
		continue
		
	# Get the path to the file
	_path = upgradeInfo.path(_file)
		
	_src = _path + "\\" + _file # Path + Filename
	_dst = getcwd() + patch_path + _path[len(getcwd() + dump_path):len(_path)] # Move the base of the folder to SDK_UPDATE
	
	# Check to see if the directory exists
	if not exists(_dst):
		makedirs(_dst)	

	# Copy the .cs.meta file
	shutil.copy(_src, _dst)
	
	# Write GUID map
	f.write("'" + _guid_a + "': '" + _guid_b + "',\n")

# close the file
f.write(" }")
f.close()

print("done!")