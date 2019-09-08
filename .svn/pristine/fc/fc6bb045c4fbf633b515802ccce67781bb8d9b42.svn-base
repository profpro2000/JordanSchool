USE [JordanSchool3]
GO
/****** Object:  Trigger [dbo].[TRG_YearlyStudReg]    Script Date: 25/07/2019 6:32:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
alter TRIGGER [dbo].[TRG_student_fees] 
ON [dbo].[Reg_StudYearly]
AFTER UPDATE, INSERT, DELETE 
AS
BEGIN
SET NOCOUNT ON;
DECLARE @RegFeesItemId int=6;
declare @ClassFeesItemId int=7;
declare @TourFeesItemId int =8;
declare @DescountFeesItemId int =9;

DECLARE @StudentId Int; DECLARE @ClassPrice INT;  declare @descountValue int; DECLARE @TourPrice INT; 
declare @yearId int; declare @ApprovedId int; Declare @RegFees int; declare @SchoolId int;

--DECLARE @ClassPrice INT
SELECT @StudentId = del.admId, @yearId = yearId,@SchoolId=SchoolId, @ApprovedId=ApprovedId FROM deleted del;
SELECT @ClassPrice = ins.ClassPrice, @descountValue=ins.DescountValue,@TourPrice=ins.TourPrice,
@StudentId = ins.admId, @yearId = ins.yearId , @SchoolId=SchoolId, @ApprovedId=ApprovedId
 FROM inserted ins;

 

 select  @RegFees=max(Value) from School_Fees
 where SchoolId=@SchoolId and FinItemId=@RegFeesItemId;
 

 --PRINT '@ClassPrice='+@ClassPrice
-- update]

--IF UPDATE(DescountValue)
-- update
if (@ApprovedId=1)
begin
IF EXISTS (SELECT * FROM inserted) AND EXISTS (SELECT * FROM deleted)
BEGIN
   update   student_fees
   set Db=@RegFees
	where StudentId=@StudentId and  yearid=@yearId and FinItemId=@RegFeesItemId;
	
	update   student_fees
   set Db=@ClassPrice
	where StudentId=@StudentId and  yearid=@yearId and FinItemId=@ClassFeesItemId;

	 update   student_fees
   set Db=@TourPrice
	where StudentId=@StudentId and  yearid=@yearId and FinItemId=@TourFeesItemId;

	 update   student_fees
   set cr= @descountValue
	where StudentId=@StudentId and  yearid=@yearId and FinItemId=@DescountFeesItemId;
END
end;


if (@ApprovedId=1)
begin
-- insert
IF EXISTS (SELECT * FROM inserted) AND NOT EXISTS(SELECT * FROM deleted)

IF UPDATE(ApprovedId)
BEGIN
 INSERT INTO student_fees ( StudentId,YearId,FinItemId,Db,Cr)
select AdmId,YearId,@RegFeesItemId,@RegFees,0 FROM INSERTED;

INSERT INTO student_fees ( StudentId,YearId,FinItemId,Db, Cr)
SELECT AdmId,YearId,@ClassFeesItemId,ClassPrice,0 FROM INSERTED;

INSERT INTO student_fees ( StudentId,YearId,FinItemId,Db,Cr)
SELECT AdmId,YearId,@TourFeesItemId,TourPrice,0 FROM INSERTED;

INSERT INTO student_fees ( StudentId,YearId,FinItemId,Db,Cr)
SELECT AdmId,YearId,@DescountFeesItemId,0,descountValue FROM INSERTED;

END
end

-- delete
IF EXISTS (SELECT * FROM deleted) AND NOT EXISTS(SELECT * FROM inserted)
BEGIN
    delete from student_fees
	where StudentId=@StudentId and yearid=@yearId;
END

END

