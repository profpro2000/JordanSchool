/****** Script for SelectTopNRows command from SSMS  ******/
create  view reg_stud_yearly_vw_dtl as
SELECT  [Id]
      ,[ParentId]
      ,[AdmId] as studentId
	  ,(select firstName from Adm_Stud where id=a.admid) as firstname
	  ,schoolId
      ,[SectionId]
      ,[EntryDate]
      ,[BirthDate]
      ,[YearId]
	  ,(select max(id) from Lkp_Year where Active=1)as currentYEarId
      ,[JoinTermId]
      ,[ClassId]
	  
      ,[ClassPrice]
      ,[ClassSeqId]
	  
	   ,(select id from Lkp_class where  schoolId=a.schoolID and classseq=
	  (select min(ClassSeq) from Lkp_Class where  schoolId=a.schoolID and   yearid=(select max(yearid) from Lkp_Class) and ClassSeq>
	   (select ClassSeq from Lkp_Class where id=a.classId ) 
	   )
	   )as nextClassId
	    ,(select amt from Lkp_class where  schoolId=a.schoolID and classseq=
	  (select min(ClassSeq) from Lkp_Class where  schoolId=a.schoolID and   yearid=(select max(yearid) from Lkp_Class) and ClassSeq>
	   (select ClassSeq from Lkp_Class where id=a.classId ) 
	   )
	   )as nextClassPrice
      ,[TourId]
      ,[TourTypeId]
      ,[BusId]
      ,[TourPrice]
      ,[ApprovedId]
      ,[ApprovedDate]
      ,[StudentBrotherSeq]
      ,[BrotherDescountType]
      ,[DescountValue]
      ,[BusNote]
      ,[Note]
      ,[StudStatusId]
  FROM [JordanSchool3].[dbo].[Reg_StudYearly] a
  where classID=(select max(classId) from reg_studYearly b where admid=a.admid and yearId=a.yearId)
   and id=(select max(id) from reg_studYearly where admid=a.admid and yearid=a.yearid)
 -- order by admid
