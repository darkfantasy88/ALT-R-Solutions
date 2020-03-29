CREATE PROCEDURE [dbo].[GetAllAuthUsers]

AS
begin
set nocount on;
	SELECT AuthID,FirstName,LastName,Gender,[Role],[EmailAddress],CONVERT(varchar(max),[Password]) from AuthTbl where Deleted like 0
end