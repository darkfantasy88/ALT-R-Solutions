CREATE PROCEDURE [dbo].[AddPrisoner]
@first varchar(150),
@last varchar(150),
@gender varchar(7),
@dob datetime2,
@prison int,
@finger varbinary(max),
@convictiondate datetime2,
@convictid int,
@timeserved float,
@photo varbinary(max),
@type varchar(max),
@rehab varchar(max)

as 
begin 

insert into PrisonerTbl(FirstName,LastName,Gender,DOB,PrisonID,FingerPrint
,DateOfConviction,ConvictionID,TimeServed,Photo,PrisonerType,RehabPrograms)

values(@first,@last,@gender,@dob,@prison,@finger,@convictiondate,@convictid
,@timeserved,@photo,@type,@rehab);

end;