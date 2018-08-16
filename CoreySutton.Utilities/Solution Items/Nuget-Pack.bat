@echo off
@echo **************
@echo * Nuget Pack *
@echo **************

cd "..\CoreySutton.Utilities"
nuget pack -Build -OutputDirectory "Nuget Packages" -Verbosity detailed