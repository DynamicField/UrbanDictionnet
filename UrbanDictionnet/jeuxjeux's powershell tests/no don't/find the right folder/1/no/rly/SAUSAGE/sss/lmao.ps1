function Print {
param(
[Parameter(Position=0,
        Mandatory=$true,
        ValueFromPipeline=$true,
        ValueFromPipelineByPropertyName=$true)]
[Alias("lol")]
[Object]$thing
)
process {
        Write-Host $thing
    }
}
Get-Random -Minimum 1 -Maximum 10 | Print 
$owo = [System.String[]]::new(75);
