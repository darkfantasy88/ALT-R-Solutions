CREATE PROCEDURE [dbo].[DeleteAuthUser]
	@id int
AS
BEGIN
	Update AuthTbl set Deleted=1 where AuthID=@id;
END
