/****** Script for SelectTopNRows command from SSMS  ******/

create view RegStudYearlyVw as
SELECT  [Id]
      ,[ParentId]
	  
      ,[studentId]
      ,[firstname]
      ,[SectionId]
	  ,schoolId
      ,[EntryDate]
      ,[BirthDate]
      ,[YearId]
      ,[currentYEarId]
      ,[JoinTermId]
      ,[ClassId]
	  ,(select aname from Lkp_class where  schoolId=a.schoolID and id=a.classid) ClassName
      ,[ClassPrice]
      ,[ClassSeqId]
      ,[nextClassId]
	   ,(select aname from Lkp_class where  schoolId=a.schoolID and id=a.nextClassId) NextClassName
      ,[nextClassPrice]
      ,[TourId]
      ,[TourTypeId]
      ,[BusId]
      ,[TourPrice]
      ,[ApprovedId]
      ,[ApprovedDate]
      ,[StudentBrotherSeq]
      ,[BrotherDescountType]
	   ,(select nextClassPrice * value from  Lkp_Brothers_Discount_Rate where id=StudentBrotherSeq )  DescountValue
      --,[DescountValue]
      ,[BusNote]
      ,[Note]
      ,[StudStatusId]
  FROM [JordanSchool3].[dbo].[reg_stud_yearly_vw] a