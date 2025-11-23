use GestionEmpresa
UPDATE    Clientes
SET     CarpetaDatos = REPLACE(CarpetaDatos , 'ANTONIO-LENOVO','ANTONIO-DELL')
UPDATE    Proyectos
SET     Datos = REPLACE(Datos , 'ANTONIO-LENOVO','ANTONIO-DELL')
UPDATE    Presupuesto
SET              Carpeta_Datos = Proyectos.Datos
FROM         Presupuesto INNER JOIN
                      Proyectos ON Presupuesto.Id_proyecto_Presupuestos = Proyectos.Id_Proyecto
					  UPDATE    Empresas
SET             Logo = REPLACE(logo , 'ANTONIO-LENOVO','ANTONIO-DELL')
