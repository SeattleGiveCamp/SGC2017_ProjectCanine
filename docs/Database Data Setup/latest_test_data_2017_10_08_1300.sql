USE [ProjectCanine2]
GO

-- The inserts are in the correct order.

-- Order for Scripts: 
--	Certification Type, 
--	Dogs, 
--	Equipment Restrictions, 
--	Handlers, 
--	Tests, 
--	Examiners, 
--	Sections,
--	Questions, 
--	Test Results, 
--	Test Result Answers


--INSERT [dbo].[CertificationTypes] ([Id], [Name]) VALUES (N'83261fc8-73dd-4afb-aa69-f9367a872b35', N'Adult Dog Certification')

--INSERT [dbo].[Dogs] ([Id], [Name]) VALUES (N'ee034027-cb14-486d-baac-36077676a0f5', N'Rufus')
--INSERT [dbo].[Dogs] ([Id], [Name]) VALUES (N'86c7ecd5-b468-4cb2-91c7-6c25ed9742f0', N'Rusty')

--INSERT [dbo].[EquipmentRestrictions] ([Id], [Name]) VALUES (N'3aba4a52-d8d6-4b01-a893-34ccdcba77d9', N'Harness (any type)')
--INSERT [dbo].[EquipmentRestrictions] ([Id], [Name]) VALUES (N'647ef84c-c927-4066-be03-848bfa4cb1fa', N'Martingale Collar')
--INSERT [dbo].[EquipmentRestrictions] ([Id], [Name]) VALUES (N'b5e223c9-70b8-41f9-9f1a-bed531c2fbac', N'Flat Collar')
--INSERT [dbo].[EquipmentRestrictions] ([Id], [Name]) VALUES (N'c7ae403a-42d4-40eb-a47b-e2dfce281910', N'Head Halter')

--INSERT [dbo].[Examiners] ([Id], [FirstName], [LastName]) VALUES (N'ed378076-c969-4fca-8fa6-7058b3ffd888', N'Donna', N'Frindt')

--INSERT [dbo].[Handlers] ([Id], [FirstName], [LastName]) VALUES (N'e30ed2be-3a53-4800-a8c4-feda77461bf2', N'Donna', N'Frindt')

--INSERT [dbo].[Tests] ([Id], [ShortName], [Name], [HandlerSignatureText], [LastEditedBy], [LastEditedDate]) 
--	VALUES (N'aa152cee-1e83-4573-b3ce-604100f88c76', N'Puppy C', N'Puppy Level C (6 Months to 1 Year)-Handler Examination',
--		'HSC Data goes here 001',
--		N'ed378076-c969-4fca-8fa6-7058b3ffd888', CAST(N'2017-10-08T08:59:25.460' AS DateTime))
--INSERT [dbo].[Tests] ([Id], [ShortName], [Name], [HandlerSignatureText], [LastEditedBy], [LastEditedDate]) 
--	VALUES (N'7f9aed60-0fd1-4f13-93d5-6f75c2b21f35', N'Adult Exam', N'Adult Dog-Handler and Junior Handler-Adult Dog Examination', 
--		'HSC Data goes here 002',
--		N'ed378076-c969-4fca-8fa6-7058b3ffd888', CAST(N'2017-10-08T08:59:25.453' AS DateTime))
--INSERT [dbo].[Tests] ([Id], [ShortName], [Name], [HandlerSignatureText], [LastEditedBy], [LastEditedDate]) 
--	VALUES (N'26ffed23-87fb-4db5-98cb-ab95e6acdd58', N'Puppy A', N'Puppy Level A (Up to 6 Months)-Handler Examination', 
--		'HSC Data goes here 003',
--		N'ed378076-c969-4fca-8fa6-7058b3ffd888', CAST(N'2017-10-08T08:59:25.460' AS DateTime))

--INSERT [dbo].[Sections] ([Id], [Test], [SectionNumber], [Title], [Description], [LastEditedBy], [LastEditedDate])
--	VALUES (
--	N'01712A0F-4674-4E33-B6E4-7F23779FD336', N'7f9aed60-0fd1-4f13-93d5-6f75c2b21f35', 1, 'Test Section Title', 
--	'Test Section Desc', null, '2017-10-08')

--INSERT [dbo].[Questions] ([Id], [Test], [Text], [MustPass],
--		[Section], [QuestionNumber], [HasYesNo], [LastEditedBy], [LastEditedDate]) 
--	VALUES (N'27097b6e-1f70-493f-aaa5-039589b4038f', N'7f9aed60-0fd1-4f13-93d5-6f75c2b21f35',
--		N'Examiner asks to touch dog. Is dog accepting and appropriate about interacting?', 
--		1, '01712A0F-4674-4E33-B6E4-7F23779FD336', 2, 0, NULL, CAST(N'2017-10-08T08:59:39.770' AS DateTime))

--INSERT [dbo].[Questions] ([Id], [Test], [Text], [MustPass],
--		[Section], [QuestionNumber], [HasYesNo], [LastEditedBy], [LastEditedDate]) 
--	VALUES (N'8aede8d7-c6c0-4e53-b5bb-1e0b1f87e81d', N'7f9aed60-0fd1-4f13-93d5-6f75c2b21f35',
--		N'Examiner and team start at opposite ends of the space and walk towards each other at a normal walking pace. When they come together they stop, greet and shake hands and move on. Dog must not interact with examiner at this time. Did handler manage dog appropriately? Was dog responsive to request not to interact?',
--		1, '01712A0F-4674-4E33-B6E4-7F23779FD336', 1, 0, NULL, CAST(N'2017-10-08T08:59:39.770' AS DateTime))

--INSERT [dbo].[Questions] ([Id], [Test], [Text], [MustPass],
--		[Section], [QuestionNumber], [HasYesNo], [LastEditedBy], [LastEditedDate]) 
--	VALUES (N'940d7974-eff8-4e1f-807c-26157ceb8166', N'7f9aed60-0fd1-4f13-93d5-6f75c2b21f35', 
--		N'Examiner now does the same and feels underneath dog’s collar. Is dog accepting?', 
--		1, '01712A0F-4674-4E33-B6E4-7F23779FD336', 4, 0, NULL, CAST(N'2017-10-08T08:59:39.770' AS DateTime))

--INSERT [dbo].[Questions] ([Id], [Test], [Text], [MustPass],
--		[Section], [QuestionNumber], [HasYesNo], [LastEditedBy], [LastEditedDate]) 
--	VALUES (N'174bb235-ee87-4791-8fc2-527513a0763a', N'7f9aed60-0fd1-4f13-93d5-6f75c2b21f35', 
--		N'Ask handler to feel underneath dog’s collar all around especially in throat area. Is dog accepting?', 
--		1, '01712A0F-4674-4E33-B6E4-7F23779FD336', 3, 0, NULL, CAST(N'2017-10-08T08:59:39.770' AS DateTime))

--INSERT [dbo].[TestResults] (
--	[Id], [Test], [Handler], [Dog], 
--	[PassedTest], [ReasonForFailure], 
--	[Notes], [PassedConnectingCanines], 
--	[ShadowVisitRequirement], [EligibleToRetest],
--	[TestDate], 
--	[ScoringExaminer], [HandsOnExaminer], 
--	[CertificationType], [EquipmentRestrictions], 
--	[OtherRestrictions], [PracticeLabRequirement],
--	[ScoringExaminerSignature], [HandsOnSignature], [HandlerSignature]) 
--VALUES (N'dadc6501-c848-45f7-a211-1fa93ecd7a88', N'aa152cee-1e83-4573-b3ce-604100f88c76',
--	N'e30ed2be-3a53-4800-a8c4-feda77461bf2', N'ee034027-cb14-486d-baac-36077676a0f5',
--	1, 
--	'reason for failure txt',
--	'Notes', 
--	1, -- passed connecting
--	0, -- shadow visit
--	1, -- [EligibleToRetest]
--	CAST(N'2017-10-08T00:00:00.000' AS DateTime),
--	N'ed378076-c969-4fca-8fa6-7058b3ffd888', N'ed378076-c969-4fca-8fa6-7058b3ffd888', 
--	N'83261fc8-73dd-4afb-aa69-f9367a872b35', N'3aba4a52-d8d6-4b01-a893-34ccdcba77d9',
--	'[OtherRestrictions]',
--	0, -- [PracticeLabRequirement]
--	NULL, NULL, NULL)

--INSERT [dbo].[TestResults] (
--	[Id], [Test], [Handler], [Dog], 
--	[PassedTest], [ReasonForFailure], 
--	[Notes], [PassedConnectingCanines], 
--	[ShadowVisitRequirement], [EligibleToRetest],
--	[TestDate], 
--	[ScoringExaminer], [HandsOnExaminer], 
--	[CertificationType], [EquipmentRestrictions], 
--	[OtherRestrictions], [PracticeLabRequirement],
--	[ScoringExaminerSignature], [HandsOnSignature], [HandlerSignature]) 
--VALUES (N'5339504C-CDE1-441A-B539-197B8BD9D2B0', N'7f9aed60-0fd1-4f13-93d5-6f75c2b21f35', 
--	N'e30ed2be-3a53-4800-a8c4-feda77461bf2', N'86c7ecd5-b468-4cb2-91c7-6c25ed9742f0',
--	1, 
--	'reason for failure txt',
--	'Notes', 
--	1, -- passed connecting
--	0, -- shadow visit
--	1, -- [EligibleToRetest]	
--	CAST(N'2017-10-03T00:00:00.000' AS DateTime), 
--	N'ed378076-c969-4fca-8fa6-7058b3ffd888', N'ed378076-c969-4fca-8fa6-7058b3ffd888', 
--	N'83261fc8-73dd-4afb-aa69-f9367a872b35', N'3aba4a52-d8d6-4b01-a893-34ccdcba77d9',
--	'[OtherRestrictions]',
--	0, -- [PracticeLabRequirement]
--	NULL, NULL, NULL)

--INSERT [dbo].[TestResultsAnswers] ([Id], [TestResult], [Question], [Answer], [YesNo]) 
--	VALUES (N'A0401C76-0F25-4466-AF58-7F7B7B2ACD4F', 
--		N'dadc6501-c848-45f7-a211-1fa93ecd7a88', 
--		N'174bb235-ee87-4791-8fc2-527513a0763a', N'P', 0)
--INSERT [dbo].[TestResultsAnswers] ([Id], [TestResult], [Question], [Answer], [YesNo]) 
--	VALUES (N'6649FD45-15DD-4096-85DB-44A713234C78', 
--		N'5339504C-CDE1-441A-B539-197B8BD9D2B0', 
--		N'8aede8d7-c6c0-4e53-b5bb-1e0b1f87e81d', N'P', 0)

--INSERT [dbo].[TestResultsSections] (
--		[Id], [TestResult], [Section], [Notes]
--	) 
--	VALUES (
--		N'EA88AF93-2B81-42EC-A60A-5B6BF8058D23', N'5339504C-CDE1-441A-B539-197B8BD9D2B0', N'01712A0F-4674-4E33-B6E4-7F23779FD336',
--		'TestResultsSections test note right here.')
--
