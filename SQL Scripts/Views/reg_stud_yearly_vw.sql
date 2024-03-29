/****** Script for SelectTopNRows command from SSMS  ******/
create view reg_stud_yearly_vw
as
SELECT  [Id]
      ,[ParentId]
      ,[studentId]
      ,[firstname]
	  ,schoolId
      ,[SectionId]
      ,[EntryDate]
      ,[BirthDate]
      ,[YearId]
      ,[currentYEarId]
      ,[JoinTermId]
      ,[ClassId]
      ,[ClassPrice]
      ,[ClassSeqId]
     -- ,nextClass
	  ,case  when yearid=currentyearId then classid
	   else nextClassId end  nextClassId 
      --,[nextClassPrice]
	  ,case  when yearid=currentyearId then ClassPrice
	   else nextClassPrice end  nextClassPrice 
	  
      ,[TourId]
      ,[TourTypeId]
      ,[BusId]
      ,[TourPrice]
	 , case  when yearid=currentyearId then ApprovedId
	   else null end  ApprovedId 
      --,[ApprovedId]
      ,[ApprovedDate]
      ,[StudentBrotherSeq]
      ,[BrotherDescountType]
      ,[DescountValue]
      ,[BusNote]
      ,[Note]
      ,[StudStatusId]
  FROM [JordanSchool3].[dbo].[reg_stud_yearly_vw_dtl]