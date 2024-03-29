USE [JordanSchool3]
GO
/****** Object:  Trigger [dbo].[TRG_YearlyStudReg]    Script Date: 25/07/2019 6:32:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER TRIGGER [dbo].[TRG_YearlyStudReg] 
ON [dbo].[Adm_Stud]
AFTER UPDATE, INSERT, DELETE 
AS
BEGIN
SET NOCOUNT ON;
DECLARE @Id Int; DECLARE @ClassPrice INT; declare @ParentId int; declare @schoolId int; declare @descountValue int;
Declare @BirthDate date; declare @ClassId int;  declare @TourId int; declare @TourTypeId int; declare @BusId int;
declare @yearId int; declare @StudentBrotherSeq int; declare @BrotherDescountType int;

--DECLARE @ClassPrice INT
SELECT @Id = del.Id, @ClassId = ClassId, @yearId = yearId FROM deleted del;
SELECT @ClassPrice = ClassPrice, @ParentId = ParentId, @schoolId=schoolId,@descountValue=descountValue,
@TourId=TourId, @TourTypeId=TourTypeId,@BusId=BusId, @StudentBrotherSeq=StudentBrotherSeq,
@BrotherDescountType=BrotherDescountType FROM inserted;

-- PRINT '@Id='+@Id
-- update
IF EXISTS (SELECT * FROM inserted) AND EXISTS (SELECT * FROM deleted)
BEGIN
    update Reg_StudYearly
	set parentId=@ParentId,-- schoolId,sectionId,classPrice,descountValue)
	schoolId=@schoolId,
	sectionId=sectionId,
	classPrice=@ClassPrice,
	descountValue=@descountValue,
	BirthDate=@BirthDate,
	ClassId=@ClassId,
	TourId=@TourId,
	TourTypeId=@TourTypeId,
	BusId=@BusId,
	StudentBrotherSeq=@StudentBrotherSeq,
	BrotherDescountType=@BrotherDescountType

	where admId=@Id and  yearid=@yearId;
END


-- insert
IF EXISTS (SELECT * FROM inserted) AND NOT EXISTS(SELECT * FROM deleted)
BEGIN
 INSERT INTO Reg_StudYearly (
 ParentId
      ,admId
      ,SchoolId
      ,SectionId
      ,EntryDate
      ,BirthDate
      ,YearId
      ,JoinTermId
      ,ClassId
      ,ClassPrice
      ,ClassSeqId
      ,TourId
      ,TourTypeId
      ,BusId
      ,TourPrice
      ,ApprovedId
      ,ApprovedDate
      ,StudentBrotherSeq
      ,BrotherDescountType
      ,DescountValue
      ,BusNote
      ,Note
      ,StudStatusId
 )
SELECT 
ParentId
      ,id
      ,SchoolId
      ,SectionId
      ,EntryDate
      ,BirthDate
      ,YearId
      ,JoinTermId
      ,ClassId
      ,ClassPrice
      ,ClassSeqId
      ,TourId
      ,TourTypeId
      ,BusId
      ,TourPrice
      ,ApprovedId
      ,ApprovedDate
      ,StudentBrotherSeq
      ,BrotherDescountType
      ,DescountValue
      ,BusNote
      ,Note
	  ,1
     
FROM INSERTED
END

-- delete
IF EXISTS (SELECT * FROM deleted) AND NOT EXISTS(SELECT * FROM inserted)
BEGIN
    delete from Reg_StudYearly
	where admId=@Id and ClassId=@ClassId and yearid=@yearId;
END

END

