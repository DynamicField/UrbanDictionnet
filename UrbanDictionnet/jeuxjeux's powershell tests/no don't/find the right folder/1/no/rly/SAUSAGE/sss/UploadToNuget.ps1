class Mom { 
[String]$Name
Mom([String] $name) {
        $this.Name = $name;
        Write-Warning "Hello i'm a new mom named $name !";
    }
    [void] EatSomething([String] $omnom) {
Write-Warning "Me, $this.Name, i ate a $omnom.";
    }
}
class Idk {
[void] GoAway([Int32]  $first,
              [Int32]  $second = 5) {
              Write-Host "$first and $second"
    }
}
$mommy = [Mom]::new("nath");
$mommy.EatSomething("pizza");
$idk = [Idk]::new();
$idk.GoAway(1,1);