CREATE PROCEDURE [dbo].[GetAllVisits]

AS
begin
	SELECT * from VisitorTbl where Deleted=0
end
