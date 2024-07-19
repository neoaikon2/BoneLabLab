from os import listdir, getcwd, makedirs
from os.path import isfile, exists, join
import shutil

configGroups = [
    '_allianceData',
    '_allianceDataGlobal',
    '_ammoGroup',
    '_arenaProfiles',
    '_audioFXData',
    '_radioStations',
    '_radioSongs',
    '_audioVarData',
    '_baseEnemyCfg',
    '_gunCartridgeData',
    '_curveData',
    '_poseDataEnemy',
    '_handPoseData',
    '_handPoseDataEnemy',
    '_LeaderboardData',
    '_LootTables',
    '_gunMagazineData',
    '_gunProjectileData',
    '_spawnPolicyData',
    '_surfaceData',
    '_spawnPolicyDataVFX'
 ]

configFileGUIDs = {
    '_allianceData': '40742ca002ced5ec51cbd66427f619a4', # grab from Crablet_AllianceData.asset
    '_allianceDataGlobal': 'f7e4314f1ac62c50bbc8474c9b3aec08',
	'_ammoGroup': '80455f5ce5030ab827e259daca1420f5',
    '_arenaProfiles': 'fdb0e423dbf71c37b1e8cfd59d3602d4',
    '_audioFXData': '37eedab185f26df4ca6c7ba65dbb72c9',
    '_radioStations': '7f1976560009862e3c6af2cc8de0ebcc',
    '_radioSongs': 'ab38d7cbe537df5b70cf720f697b445e',
    '_audioVarData': 'b28eb85c6ef8edc49b01114eef913a4e',
    '_baseEnemyCfg': 'c632c5c6ce09ce68cf3a5aa465261389',
    '_gunCartridgeData': '5e577ead1b08f5b16bbf47483da1626d',
    '_curveData': '882c5be2f3c618291672aa1a52e8222a',
    '_poseDataEnemy': 'a2135d2d49da8565857610eb02fd31a6',
    '_handPoseData': '07fe0efe3fed9a88f2c4bd31c1678251',
    '_handPoseDataEnemy': 'd0ce6502e56c82d5ad30307007765bbf',
    '_LeaderboardData': '9708b3cbbd1ef9a04a152b26fcc96c16',
    '_LootTables': '87af7f299ae4d5075667ed003fd5ee11',
    '_gunMagazineData': '569a14dc6986dfffcccc3a7328d4afc5',
    '_gunProjectileData': '626083810fec7ac6c520d1cfc30444f6',
    '_spawnPolicyData': 'cff073db5ae9d8fd807eeb0284bddf33',
    '_surfaceData': 'da29abf0dd58da209ec414fa7049aa61',
    '_spawnPolicyDataVFX': '626d8de29310312a1bc706286dc6ebd1'
}

configFileFolders = {
    '_allianceData': 'Alliance Data',
    '_allianceDataGlobal': 'Alliance Data',
    '_ammoGroup': 'Ammo Groups',
    '_arenaProfiles': 'Arena Profiles',
    '_audioFXData': 'Audio FX Data',
    '_radioStations': 'Audio Radio',
    '_radioSongs': 'Audio Radio/RadioMusic_BoneLab',
    '_audioVarData': 'Audio Variance',
    '_baseEnemyCfg': 'Base Enemy Configs',
    '_gunCartridgeData': 'Guns/Cartridge Data',
    '_curveData': 'Curves',
    '_poseDataEnemy': 'Enemy Pose Data',
    '_handPoseData': 'Hand Poses',
    '_handPoseDataEnemy': 'Enemy Hand Poses',
    '_LeaderboardData': 'Leaderboard Data',
    '_LootTables': 'Loot Tables',
    '_gunMagazineData': 'Guns/Magazine Data',
    '_gunProjectileData': 'Guns/Projectile Data',
    '_spawnPolicyData': 'Spawn Policy Data',
    '_surfaceData': 'Surface Data',
    '_spawnPolicyDataVFX': 'VFX Spawn Policy Data'
}

def getguid(file):
	f = open(file)
	for g in f:
		if "guid:" in g:
			#print(g[6:len(g)])
			f.close()
			return g[37:len(g)-11]

def traverse(_path, _guid, _dst):
    for _dir in listdir(_path):
        if isfile(join(_path, _dir)):
            if ('.asset' in _dir):
                _file = _dir
                
                _fileGuid = getguid(join(_path, _file))                    
                if(_guid == _fileGuid):
                    print(_file)
                    if not exists(_dst):
                        makedirs(_dst)
                    # Copy files to destination
                    shutil.copy(join(_path, _file), join(_dst, _file))
                    shutil.copy(join(_path, _file+'.meta'), join(_dst, _file+'.meta'))
        else:
            traverse(join(_path, _dir), _guid, _dst)
              
for cg in configGroups:
    print(cg)
    traverse('./UNSORTED', configFileGUIDs[cg], join('./SORTED', configFileFolders[cg]))