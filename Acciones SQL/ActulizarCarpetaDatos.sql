use GestionEmpresa
UPDATE    Presupuesto
SET              Carpeta_Datos = Proyectos.Datos
FROM         Presupuesto INNER JOIN
                      Proyectos ON Presupuesto.Id_proyecto_Presupuestos = Proyectos.Id_Proyecto