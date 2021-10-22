echo "restore starting"
dotnet restore
echo "restore finish"

echo "build starting"
dotnet build --no-restore --configuration Release
echo "build finish"

echo "publish starting"
dotnet publish -c Release -o release\myapp
echo "publish finished"
