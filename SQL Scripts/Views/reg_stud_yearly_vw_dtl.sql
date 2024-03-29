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
      , (select max(StudentBrotherSeq) from Adm_stud where id=a.AdmId) StudentBrotherSeq
      ,[BrotherDescountType]
      ,[DescountValue]
      ,[BusNote]
      ,[Note]
      ,[StudStatusId]
  FROM [JordanSchool3].[dbo].[Reg_StudYearly] a
  where classID=(select max(classId) from Reg_StudYearly b where admid=a.admid 
   and yearid=(select max(yearid) from Reg_StudYearly where admid=a.admid ))
 -- order by admid,classID