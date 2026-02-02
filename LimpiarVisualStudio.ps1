## ==========================================================
#  LIMPIADOR DEFINITIVO DE VISUAL STUDIO (SIN EMOJIS)
#  Borra:
#    - Cache del proyecto (.vs, bin, obj, packages)
#    - Cache global NuGet
#    - ComponentModelCache (que frisa WinForms)
#    - MEF Cache
#    - Temp de Visual Studio
# ==========================================================

Write-Host "Limpiando solucion..."

# 1. Limpiar carpetas del proyecto
$solutionRoot = Get-Location

Get-ChildItem -Path $solutionRoot -Recurse -Directory -Force |
Where-Object { $_.Name -in @(".vs", "bin", "obj", "packages") } |
ForEach-Object {
    Write-Host "Eliminando carpeta del proyecto: $($_.FullName)"
    Remove-Item $_.FullName -Force -Recurse -ErrorAction SilentlyContinue
}

# 2. Limpiar Cache de NuGet
Write-Host "`nLimpiando cache de NuGet..."

$nugetExe = "$env:SystemDrive\nuget\nuget.exe"
if (Test-Path $nugetExe) {
    & $nugetExe locals all -clear | Out-Null
} else {
    Write-Host "NuGet.exe no encontrado en C:\nuget. Si quieres limpiar NuGet automaticamente, copia nuget.exe a esa ruta."
}

# 3. Borrar caches internas de Visual Studio
Write-Host "`nLimpiando caches internas de Visual Studio..."
$vsCachePaths = @(
    "$env:LOCALAPPDATA\Microsoft\VisualStudio",
    "$env:LOCALAPPDATA\Microsoft\VSCommon"
)

foreach ($path in $vsCachePaths) {
    if (Test-Path $path) {
        Get-ChildItem -Path $path -Directory -Recurse -Force |
        Where-Object { $_.Name -in @("ComponentModelCache", "MEFCache") } |
        ForEach-Object {
            Write-Host "Eliminando cache interna: $($_.FullName)"
            Remove-Item $_.FullName -Force -Recurse -ErrorAction SilentlyContinue
        }
    }
}

# 4. Limpiar TEMP del usuario
Write-Host "`nLimpiando TEMP..."
Remove-Item "$env:TEMP\*" -Force -Recurse -ErrorAction SilentlyContinue

Write-Host "`nLIMPIEZA COMPLETA"
Write-Host "Ahora abre Visual Studio y recompila la solucion"
# ==========================================================

