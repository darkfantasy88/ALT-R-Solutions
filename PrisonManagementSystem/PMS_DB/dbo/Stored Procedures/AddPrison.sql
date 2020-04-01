CREATE PROCEDURE [dbo].[AddPrison]
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
	insert into PrisonTbl(PrisonID,[Name],[Location],History
							,[Image],MaxCapacity,CurrentCapacity,PrisonType)
					values(@id,@name,@location,@history,@image,@maxcap,
							@currentcap,@type);
end
