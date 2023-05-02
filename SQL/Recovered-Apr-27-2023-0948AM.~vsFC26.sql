CREATE OR ALTER PROCEDURE SHOWProductno(@Productno int )



AS

begin

select * from CLIENT_MASTER WHERE productno = @Productno;

END;

EXEC SHOWProductno 1 ;

