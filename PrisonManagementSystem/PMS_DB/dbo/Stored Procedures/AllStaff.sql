CREATE PROCEDURE [dbo].[AllStaff]
	
AS
begin 
set nocount on; 
	SELECT * from StaffTbl where Deleted=0
end
