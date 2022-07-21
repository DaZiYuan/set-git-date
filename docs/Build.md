# Pack
```
dotnet pack

```
# Local Test
```
dotnet pack -o ./packages/ -c Release -p:PackageID=SGD
dotnet tool uninstall -g SGD
dotnet tool install --global --add-source ./packages/ SGD

```
# Upload 
dotnet pack SetGitDate -o ../../LocalNuget/packages -c Release -p:PackageID=SGD