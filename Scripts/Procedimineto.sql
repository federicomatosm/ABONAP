CREATE PROCEDURE infoPrestamo
    @codigo varchar(30) ,  
    @nombre varchar(100) OUTPUT,
    @codigo_o varchar(30) OUTPUT  
AS    
  
    SELECT @codigo_o=codigo, @nombre=nombre from prestamo pr join cliente c on pr.ClienteId = c.Id join persona pe on  c.PersonaId = pe.Id where pr.codigo = @codigo

    RETURN;
GO 

