import json
import os
import pathlib
import hashlib

# Put the files you want to move to the binaries directory here
filesToMove = [
    "PluginAutoUpdateTest.dll",
    "module.json"
]

relativePath = "PluginAutoUpdateTest\\bin\\x64\\Release"

for f in os.listdir(relativePath):
    if (f.replace(relativePath, "") in filesToMove):
        os.rename(f"{relativePath}\\{f}", f"binaries\\{f.replace(relativePath, '')}")

        #test
