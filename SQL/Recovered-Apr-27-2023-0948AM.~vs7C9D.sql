select a.AccountNo as ACNO,
a.Name as [Account Holder Name],
a.Balance,
a.RefAcNo as [Ref Acno],
r.Name [Name of Referer]
from bank a join bank r
on a.RefAcno = r.AccountNo;