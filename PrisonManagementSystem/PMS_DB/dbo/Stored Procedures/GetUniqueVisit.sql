CREATE PROCEDURE [dbo].[GetUniqueVisit]
	@institution varchar(max),
	@firstname varchar(150),
	@lastname varchar(150),
	@type varchar(max)
AS
begin try
	SELECT * from VisitorTbl where InstitutionName=@institution
								or FirstName=@firstname or LastName=@lastname
								or PurposeOfVisit=@type
end try
begin catch
throw;
end catch
