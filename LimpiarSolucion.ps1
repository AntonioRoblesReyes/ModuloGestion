# Limpieza de una solución de VB.NET
Write-Host "Iniciando limpieza de solución..." -ForegroundColor Cyan

# Eliminar carpetas bin y obj
Get-ChildItem -Recurse -Include bin,obj -Directory | ForEach-Object {
    Write-Host "Eliminando: $($_.FullName)" -ForegroundColor Yellow
    Remove-Item $_.FullName -Recurse -Force -ErrorAction SilentlyContinue
}

# Eliminar carpeta .vs (opcional)
$vsFolder = ".vs"
if (Test-Path $vsFolder) {
    Write-Host "Eliminando carpeta .vs..." -ForegroundColor Yellow
    Remove-Item $vsFolder -Recurse -Force -ErrorAction SilentlyContinue
}

# Eliminar archivos *.user, *.suo, *.cache
Get-ChildItem -Recurse -Include *.user,*.suo,*.cache -File | ForEach-Object {
    Write-Host "Eliminando archivo: $($_.FullName)" -ForegroundColor Yellow
    Remove-Item $_.FullName -Force -ErrorAction SilentlyContinue
}

Write-Host "Limpieza completada." -ForegroundColor Green
