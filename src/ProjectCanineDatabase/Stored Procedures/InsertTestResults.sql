CREATE PROCEDURE [dbo].[InsertTestResults]
	@json VARCHAR(MAX)
AS

	/* SAMPLE JSON:
	declare @json varchar(max) = '{ 
		"Id": "5CB0E06A-C72D-4AF0-AAE0-18888EBD5A7E",
		"Test": "2BA84E43-7C86-4D58-AC06-72C861169B81", 
		"Handler": "107b9dee-b6ca-49ad-b9da-28f827865bbc", 
		"Dog": "32b0270b-bdc0-4f2f-9bbf-71dbbb2d3c99",
		"PassedTest": 0,
		"ReasonForFailure": "Bit handler",
		"Notes": "Bad doggy",
		"PassedConnectingCanines": 0,
		"ShadowVisitRequirement": 0,
		"EligibleToRetest": 0,
		"TestDate": "11/11/2017",
		"ScoringExaminer": "50c112b0-488c-4a63-ab6c-3df970f5beb8",
		"HandsOnExaminer": "50c112b0-488c-4a63-ab6c-3df970f5beb8",
		"CertificationType": "1147053c-5b8b-4aba-b125-0af472eb8f80",
		"EquipmentRestrictions": "647ef84c-c927-4066-be03-848bfa4cb1fa",
		"OtherRestrictions": "Not allowed near children",
		"PracticeLabRequirement": 0,
		"TestResultsSections": [
			{
				"Id": "17014543-4D0E-4C22-A403-95A3F5932F9A",
				"TestResult": "5CB0E06A-C72D-4AF0-AAE0-18888EBD5A7E",
				"Section": "A3D63308-8192-478D-9C99-686150DD9F0A",
				"Notes": "Section1 notes",
				"TestResultsAnswers": [
					{
						"Id": "63908682-B030-419F-83FF-DCDF05A53F25",
						"TestResult": "5CB0E06A-C72D-4AF0-AAE0-18888EBD5A7E",
						"Question": "1E609E2D-D6E2-42EB-BCEB-C88A3D0F1371",
						"Answer": "P",
						"YesNo": 0
					},
					{
						"Id": "1C8C30B2-65EA-4835-87F0-64D57C7940D8",
						"TestResult": "5CB0E06A-C72D-4AF0-AAE0-18888EBD5A7E",
						"Question": "590A640C-C9B1-4996-AA47-E72BA3EAB0D8",
						"Answer": "P",
						"YesNo": 0
					}
				]
			},
			{
				"Id": "5F80ACA0-BA26-4122-AA7F-85F31A089D04",
				"TestResult": "5CB0E06A-C72D-4AF0-AAE0-18888EBD5A7E",
				"Section": "FB2A5FE8-E52D-4A99-9C2E-13B29A810811",
				"Notes": "Section2 notes"
			}
		]
	}';
	*/

	INSERT INTO dbo.TestResults (
		Id, Test, Handler, Dog, PassedTest, ReasonForFailure, Notes, ShadowVisitRequirement, 
		EligibleToRetest, TestDate, ScoringExaminer, HandsOnExaminer, CertificationType, 
		EquipmentRestrictions, OtherRestrictions, PracticeLabRequirement)

	SELECT 
		Id, Test, Handler, Dog, PassedTest, ReasonForFailure, Notes, ShadowVisitRequirement, 
		EligibleToRetest, TestDate, ScoringExaminer, HandsOnExaminer, CertificationType, 
		EquipmentRestrictions, OtherRestrictions, PracticeLabRequirement

	FROM OPENJSON(@json)

	WITH (
			Id uniqueidentifier
		   ,Test uniqueidentifier
           ,Handler uniqueidentifier
           ,Dog uniqueidentifier
           ,PassedTest bit
           ,ReasonForFailure varchar(5000)
           ,Notes varchar(5000)
           ,PassedConnectingCanines bit
           ,ShadowVisitRequirement bit
           ,EligibleToRetest bit
           ,TestDate datetime
           ,ScoringExaminer uniqueidentifier
           ,HandsOnExaminer uniqueidentifier
           ,CertificationType uniqueidentifier
           ,EquipmentRestrictions uniqueidentifier
           ,OtherRestrictions varchar(300)
           ,PracticeLabRequirement bit);


	INSERT INTO dbo.TestResultsSections (Id, TestResult, Section, Notes)
	SELECT Id, TestResult, Section, Notes
	FROM OPENJSON(@json, '$.TestResultsSections')
	WITH (Id uniqueidentifier, TestResult uniqueidentifier, Section uniqueidentifier, Notes varchar(5000));


	INSERT INTO dbo.TestResultsAnswers (Id, TestResult, Question, Answer, YesNo)
	SELECT
		JSON_Value (ans.[value], '$.Id') AS Id, 
		JSON_Value (ans.[value], '$.TestResult') AS TestResult, 
		JSON_Value (ans.[value], '$.Question') AS Question, 
		JSON_Value (ans.[value], '$.Answer') AS Answer,
		JSON_Value (ans.[value], '$.YesNo') AS YesNo 
	FROM OPENJSON (@json, '$.TestResultsSections') AS sec
	CROSS APPLY OPENJSON (sec.value, '$.TestResultsAnswers') AS ans