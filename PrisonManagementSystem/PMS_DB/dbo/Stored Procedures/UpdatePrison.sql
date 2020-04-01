CREATE PROCEDURE [dbo].[UpdatePrison]
	@id varchar(10),
	@name varchar(max),
	@location varchar(max),
	@history varchar(max),
	@image varbinary(max),
	@maxcap int,
	@currentcap int,
	@type varchar(100)

AS
begin
 set nocount on;
	update PrisonTbl set [Name]=@name,
	[Location]=@location, [History]=@history, [Image]=@image,
	MaxCapacity=@maxcap,CurrentCapacity=@currentcap,PrisonType=@type
	where PrisonID=@id;
end
