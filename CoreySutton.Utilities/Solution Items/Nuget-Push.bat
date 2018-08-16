@echo off
@echo **************
@echo * Nuget Push *
@echo **************

set versionNumber=%1
set apiKey=%2

cd "..\CoreySutton.Utilities\NuGet Packages"
nuget push CoreySutton.Utilities.%versionNumber%.nupkg -Source https://api.nuget.org/v3/index.json -Verbosity detailed -ApiKey %apiKey%