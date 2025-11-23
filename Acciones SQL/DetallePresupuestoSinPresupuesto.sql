

DELETE FROM PresupuestoDetalle
FROM         PresupuestoDetalle LEFT OUTER JOIN
                      Presupuesto ON PresupuestoDetalle.Presupuesto = Presupuesto.Id_Presupuesto
WHERE     (Presupuesto.Id_Presupuesto IS NULL)