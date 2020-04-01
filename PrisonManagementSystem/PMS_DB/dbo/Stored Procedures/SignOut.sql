CREATE PROCEDURE [dbo].[SignOut]
	@id varchar(10)
AS
begin
	update StaffTbl set Active=0 where StaffID=@id;
end
