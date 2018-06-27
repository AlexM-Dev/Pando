@echo off
mkdir "output"
xcopy ".\pando\bin\x64\debug\pando.exe" output
xcopy ".\pandoRun\bin\x64\debug\pandoRun.exe" output
xcopy ".\pandoCommons\bin\x64\debug\pandoCommons.dll" output