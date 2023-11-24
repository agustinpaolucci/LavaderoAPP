use LAVADERO;

SELECT * FROM T_PRODUCTOS;

GO;

CREATE PROCEDURE SP_PROXIMO_ID
@NEXT INT OUTPUT
AS
	BEGIN
	SET @NEXT = (SELECT MAX(ID_PRODUCTO) + 1 FROM T_PRODUCTOS);
	END;

/*
PRUEBA DE SP
*/
DECLARE @PROXIMA INT
EXECUTE SP_PROXIMO_ID @next = @proxima output;
SELECT @PROXIMA;
GO;

CREATE PROCEDURE SP_ULTIMO_ID
@LAST INT OUTPUT
AS
	BEGIN
	SET @LAST = (SELECT MAX(ID_PRODUCTO) FROM T_PRODUCTOS);
	END;

/*
PRUEBA DE SP
*/
DECLARE @ULTIMO INT
EXECUTE SP_ULTIMO_ID @LAST = @ULTIMO OUTPUT
SELECT @ULTIMO;

