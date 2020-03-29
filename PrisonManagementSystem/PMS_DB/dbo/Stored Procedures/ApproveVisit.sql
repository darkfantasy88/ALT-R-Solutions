CREATE PROCEDURE [dbo].[ApproveVisit]
	@id int ,
	@status varchar(max)
AS
	update VisitorTbl set VisitStatus=@status where VisitID=@id 
RETURN 0
