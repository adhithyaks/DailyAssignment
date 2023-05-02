CREATE OR ALTER PROCEDURE SHOWClientNo(@Clientno int )



AS

begin

select * from CLIENT_MASTER WHERE clientno = @ClientNo;

END;

EXEC SHOWClientNo 1



