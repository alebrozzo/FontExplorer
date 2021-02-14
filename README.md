# FontExplorer
Explores local fonts and shows entered text with them.

# Publishing
## single file not working: dotnet publish -r win-x64 -c Release -o publish /p:PublishSingleFile=true /p:IncludeNativeLibrariesForSelfExtract=true /p:PublishTrimmed=true
dotnet publish -r win-x64 -c Release -o publish /p:PublishTrimmed=true
