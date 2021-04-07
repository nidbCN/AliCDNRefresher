#/bin/bash
if [ ! -d "/Release" ]; then
    echo "\t[1]New Release Directory."
    mkdir /Release
else
    echo "\t[1]Clean Release Directory."
    rm -rf /Release/*
fi

echo "[2]Start build project."
dotnet publish -c Release --no-self-contained -r ubuntu.20.04-x64 -o ./Release 

echo "[3]Copy config file."
cp appSettings.json ./Release/

