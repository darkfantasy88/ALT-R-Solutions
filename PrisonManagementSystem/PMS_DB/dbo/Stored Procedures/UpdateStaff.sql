CREATE PROCEDURE [dbo].[UpdateStaff]
	@id varchar(10),
	@firstname varchar(150),
	@lastname varchar(150),
	@middle varchar(1),
	@dob datetime2,
	@type varchar(15),
	@role varchar(50),
	@officeid int,
	@prisonid int,
	@hoffice bit
as
begin
begin try 

update StaffTbl set StaffType=@type,StaffRole=@role,
					ProbationOfficeID=@officeid,PrisonID=@prisonid,
					HeadOffice=@hoffice
				where StaffID=@id
end try
begin catch
throw;
end catch
end;
