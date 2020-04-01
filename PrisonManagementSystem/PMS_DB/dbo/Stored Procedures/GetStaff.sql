CREATE PROCEDURE [dbo].[GetStaff]
	@id varchar(10),
	@password varchar(max)
AS
begin
	select * from AuthTbl,StaffTbl 
	where StaffTbl.StaffID=@id and [Password]=@password;

	update StaffTbl set Active=1 where StaffID=@id;
end
