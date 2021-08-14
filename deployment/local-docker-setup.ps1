Param(
    [String] $Tag
)

Function ExecCmd($Cmd) {
    Write-Host "Executing command: $Cmd" -ForegroundColor Yellow
    Invoke-Expression $Cmd
}

Function ExecDocker($Cmd) {
    ExecCmd "docker $Cmd"
}

Function ExecDockerCompose($Cmd) {
    ExecCmd "docker-compose $Cmd"
}

ExecDocker 'rmi -f $(docker images -f "dangling=true" -q)'
