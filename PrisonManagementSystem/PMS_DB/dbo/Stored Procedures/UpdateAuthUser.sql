CREATE PROCEDURE [dbo].[UpdateAuthUser]
	@id int,
	@firstname varchar(150),
	@lastname varchar(150),
	@gender varchar(7),
	@role varchar(200),
	@email varchar(250),
	@password varchar(max)
AS
begin
	update AuthTbl set FirstName=@firstname, LastName=@lastname, 
						Gender=@gender,[Role]=@role,
						[EmailAddress]=@email,[Password]=CONVERT(varbinary(max),@password)
	where AuthID=@id
end
