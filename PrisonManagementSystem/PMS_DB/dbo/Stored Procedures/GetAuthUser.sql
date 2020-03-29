CREATE PROCEDURE [dbo].[GetAuthUser]
	@email varchar(250),
	@password varchar(max)
AS
begin
set nocount on;
	SELECT AuthID,FirstName,LastName,Gender,[Role],[EmailAddress],CONVERT(varchar(max),[Password]) from AuthTbl where [EmailAddress]=@email and [Password]=@password and[Deleted]=0
end
