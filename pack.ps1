del *.nupkg
$files = Get-ChildItem FubarDev.*\*.nuspec
$version = '0.2.3.2'
ForEach ($file in $files)
{
	$proj = [System.IO.Path]::ChangeExtension($file, ".csproj")
	# write-host $proj
	& nuget pack -Symbols -IncludeReferencedProjects -Properties "Configuration=Release;Version=$version" $proj
}
