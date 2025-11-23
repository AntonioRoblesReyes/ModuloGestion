DELETE FROM Presupuesto
FROM            Presupuesto LEFT OUTER JOIN
                         PresupuestoDetalle ON Presupuesto.Id_Presupuesto = PresupuestoDetalle.Presupuesto
WHERE        (PresupuestoDetalle.Presupuesto IS NULL)