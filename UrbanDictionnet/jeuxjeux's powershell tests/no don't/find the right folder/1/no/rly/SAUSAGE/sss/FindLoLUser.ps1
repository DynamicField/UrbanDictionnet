$directory = "C:\Riot Games\League of Legends\Logs\Game - R3d Logs";
$find = Read-Host -Prompt "Please type in the username you want to search.";
cd $directory;
$r = Get-ChildItem $directory -Recurse
foreach ($item in $r) {
$c = Get-Content $item
foreach ($str in $c) {
        if ($str.ToString().Contains($find)) {
            Write-Host "Found in $($item.FullName);"
        }
    }
}
