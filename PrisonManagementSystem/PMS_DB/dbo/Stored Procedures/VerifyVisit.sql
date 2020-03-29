CREATE PROCEDURE [dbo].[VerifyVisit]
	@id int,
	@type varchar(max),
	@number varchar(max),
	@expiry datetime2
AS
begin
	update VisitorTbl set ValidIDType=@type,ValidIDNumber=@number
						,ValidIDDateOfExpiry=@expiry
	where VisitID=@id
end
