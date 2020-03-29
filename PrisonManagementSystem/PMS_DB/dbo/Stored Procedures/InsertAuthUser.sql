CREATE PROCEDURE [dbo].[InsertAuthUser]
	@firstname varchar(150),
	@lastname varchar(150),
	@gender varchar(7),
	@role varchar(200),
	@email varchar(250),
	@password varchar(max)
as
begin try
	insert into AuthTbl values(@firstname,@lastname,@gender,@role,@email,Convert(varbinary(max),@password))
end try
begin catch
	throw;
end catch


