CREATE PROCEDURE [dbo].[DeleteVisit]
	@id int
AS
begin
	update VisitorTbl set Deleted=1
	where VisitID=@id
end
