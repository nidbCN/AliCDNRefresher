#/bin/bash
if [ ! -d "/Release" ]; then
    echo "\tNew Release Directory."
    mkdir /Release
else
    echo "\tClean Release Directory."
    rm -rf /Release/*
fi

dotnet publish -c Release --no-self-contained -r ubuntu.20.04-x64 -o ./Release 
