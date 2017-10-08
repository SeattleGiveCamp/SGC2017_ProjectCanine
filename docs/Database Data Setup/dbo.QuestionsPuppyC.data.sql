DECLARE @test AS UNIQUEIDENTIFIER = '2ba84e43-7c86-4d58-ac06-72c861169b81';
DECLARE @sectionId AS UNIQUEIDENTIFIER = 'A3D63308-8192-478D-9C99-686150DD9F0A';
DECLARE @lastEditBy AS UNIQUEIDENTIFIER = '50c112b0-488c-4a63-ab6c-3df970f5beb8';
DECLARE @lastEditDate AS UNIQUEIDENTIFIER = @lastEditDate;
INSERT INTO [dbo].[Questions] ([Id], [Test], [Text], [MustPass], [Section], [QuestionNumber], [HasYesNo], [LastEditedBy], [LastEditedDate]) VALUES
('2892d5d8-f6e2-465e-a33e-a0b415c24201', @test, 'Approach puppy at normal walking pace and interact with person. Does puppy acknowledge the examiner and/or solicit attention?', 1, @sectionId, 1, 0, @lastEditBy, @lastEdityDate),
('7973df8a-375e-41c1-ac5a-b1d2184907bd', @test, 'Ask handler to touch puppy''s collar. Is puppy accepting?', 1, @sectionId, 2, 0, @lastEditBy, @lastEdityDate),
('ae8717bb-234a-4bb8-83c1-5f09e7dd792f', @test, 'Touch puppy''s collar. Is puppy accepting?', 1, @sectionId, 3, 0, @lastEditBy, @lastEdityDate),
('c8ec5a1e-23ac-413e-be68-7f4e87237db1', @test, 'Ask handler to have puppy sit at his/her side. Handler and examiner pet puppy together. Is puppy accepting?', 1, @sectionId, 4, 0, @lastEditBy, @lastEdityDate),
('1eb3d5bc-55bc-4f75-960c-be79457d0a03', @test, 'Begin stroking puppy in a neutral/non-threatening area, then progress to stroking back, patting side, patting head, and finally initiate more affectionate interaction. Is puppy accepting?', 1, @sectionId, 5, 0, @lastEditBy, @lastEdityDate),
('dd354a31-91dd-4cc8-bb04-331100c9158f', @test, 'Turn puppy on back. Observe puppy''s reaction for 30 seconds. (Depending on breed/size of dog you may have the puppy lay on its side on the ground.)', 1, @sectionId, 6, 0, @lastEditBy, @lastEdityDate),
('fc08afe5-baf6-4304-a2d9-53505cbb81f7', @test, 'Have assistant gently hold paw. Observe puppy''s reaction for 10 seconds.', 1, @sectionId, 7, 0, @lastEditBy, @lastEdityDate),
('23221b1f-8c27-4b55-b35e-f4c314b6e639', @test, 'Have assistant place puppy in center of room. Drop a metal bowl. Observe puppy''s reaction', 1, @sectionId, 8, 0, @lastEditBy, @lastEdityDate),
('23221b1f-8c27-4b55-b35e-f4c314b6e649', @test, 'Have assistant show puppy a crumpled piece of paper, then toss paper a short distance.', 1, @sectionId, 9, 0, @lastEditBy, @lastEdityDate),
('7ceeca6d-683b-4988-ad7f-2c7af2c35062', @test, 'Have assistant show puppy a toy or rolled towel on a long line and drag past puppy quickly. Does puppy immediately jump to chase? Just observe? Grab and shake item?', 1, @sectionId, 10, 0, @lastEditBy, @lastEdityDate),
('aded2618-de9e-4d1a-8b55-72eec8bb6cbc', @test, 'Ask handler to examine puppy''s feet, ears, teeth, abdomen, tail, and hips. Is puppy accepting?', 1, @sectionId, 11, 0, @lastEditBy, @lastEdityDate),
('aded2618-de9e-4d1a-8b55-72eec8bb6cbc', @test, 'Show puppy a toy & engage it in play, then ask the puppy to give the toy back. Puppy''s reaction- did the puppy willingly and with appropriate coaxing give the toy up? Growl? Nip?', 1, @sectionId, 12, 0, @lastEditBy, @lastEdityDate),
('ffd61834-2e99-421e-8cd7-cb2a88e339c6', @test, 'Visually check that puppy appears healthy overall and well groomed.', 1, @sectionId, 13, 0, @lastEditBy, @lastEdityDate),
('8dba41f8-2846-4e9b-a971-7cdc6d324ebe', @test, 'Examine puppy''s feet, ears, teeth, abdomen, tail, and hips. Does puppy appear healthy and accept exam?', 1, @sectionId, 14, 0, @lastEditBy, @lastEdityDate),
('bb184162-8033-4d9f-acfb-6d359e3fc190', @test, 'Place finger/hand in front of puppy''s face/mouth. Puppy may show interest, lick, or even open its mouth, but it should not actively seek finger/hand as something to bite/chew.', 1, @sectionId, 15, 0, @lastEditBy, @lastEdityDate);

SET @sectionId = 'FB2A5FE8-E52D-4A99-9C2E-13B29A810811';
INSERT INTO [dbo].[Questions] ([Id], [Test], [Text], [MustPass], [Section], [QuestionNumber], [HasYesNo], [LastEditedBy], [LastEditedDate]) VALUES
('1e609e2d-d6e2-42eb-bceb-c88a3d0f1371', @test, 'Ask handler to walk puppy on a loose leash a distance of 15 ft. Does puppy display a happy attitude?', 1, @sectionId, 1, 0, @lastEditBy, @lastEdityDate),
('590a640c-c9b1-4996-aa47-e72ba3eab0d8', @test, 'Ask handler to request puppy to sit.', 1, @sectionId, 2, 0, @lastEditBy, @lastEdityDate),
('a9ba0a1e-9971-4cb0-87c7-6e97c9a3554a', @test, 'Ask handler to request puppy to down.', 0, @sectionId, 3, 0, @lastEditBy, @lastEdityDate),
('26366edb-ad58-40f5-8e2f-ea54233f90b1', @test, 'Ask handler to request puppy to stay and remain attentive for 10 seconds.', 0, @sectionId, 4, 0, @lastEditBy, @lastEdityDate),
('391dc60d-53f0-4bac-aade-4a14249bc758', @test, 'Ask handler to request puppy to come a distance of 3 ft.', 0, @sectionId, 5, 0, @lastEditBy, @lastEdityDate),
('214d3d73-dacb-4996-a8b7-dad9177a0185', @test, 'Ask handler what he/she does to positively reinforce puppy and have him/her demonstrate. At the tester''s discretion this may be satisfactorily addressed in the above exercises.', 1, @sectionId, 6, 0, @lastEditBy, @lastEdityDate),
('47034d9f-76ba-4ae3-9bbb-b40d66f91b22', @test, 'Ask handler to walk puppy, on leash, past a neutral dog.', 0, @sectionId, 7, 0, @lastEditBy, @lastEdityDate),
('1f14f5bf-1fb3-4c7a-afa9-f355f37031f8', @test, 'Ask handler to demonstrate playing with puppy. Do handler and puppy have the rapport to engage in safe, interactive play?', 1, @sectionId, 8, 0, @lastEditBy, @lastEdityDate);

SET @sectionId = '593140C7-C2F7-4EB6-89DA-81DCA9F03061';
INSERT INTO [dbo].[Questions] ([Id], [Test], [Text], [MustPass], [Section], [QuestionNumber], [HasYesNo], [LastEditedBy], [LastEditedDate]) VALUES
('730b1f51-14c8-45af-b24a-516bb6df454a', @test, 'Throw an object in the general vicinity of puppy. Does puppy respond appropriately to the unexpected movement and noise?', 1, @sectionId, 1, 0, @lastEditBy, @lastEdityDate),
('730b1f51-14c8-45af-b24a-516bb6df454b', @test, 'Have assistant walk toward puppy while simulating a motor disability. Does puppy respond appropriately to unexpected movements in a person?', 1, @sectionId, 2, 0, @lastEditBy, @lastEdityDate),
('730b1f51-14c8-45af-b24a-516bb6df454c', @test, 'Have assistant use a walker or wheel a wheelchair near puppy. Does puppy respond appropriately to medical equipment?', 1, @sectionId, 3, 0, @lastEditBy, @lastEdityDate),
('730b1f51-14c8-45af-b24a-516bb6df454e', @test, 'Drop several boxes near puppy. Does puppy respond appropriately to the unexpected movement and noise?', 1, @sectionId, 4, 0, @lastEditBy, @lastEdityDate),
('aa4191a9-1c54-4d97-ae55-fc954f490d45', @test, 'Engage in simulated angry yelling with assistant. Does puppy respond appropriately to heightened emotions?', 1, @sectionId, 5, 0, @lastEditBy, @lastEdityDate),
('8ba6d02a-0892-4edf-bac5-8abc8f624570', @test, 'Have assistant approach puppy while wearing a hat. Does puppy respond appropriately to a person in a hat?', 1, @sectionId, 6, 0, @lastEditBy, @lastEdityDate),
('8da1c11f-ca71-43f4-9a8b-a7763a393eba', @test, 'Place a toy near puppy. Will puppy respond to a “leave it” or “drop it” cue when requested?', 0, @sectionId, 7, 0, @lastEditBy, @lastEdityDate);

SET @sectionId = 'F35BBBBA-1514-46FA-AF6D-BD1844D59CBA';
INSERT INTO [dbo].[Questions] ([Id], [Test], [Text], [MustPass], [Section], [QuestionNumber], [HasYesNo], [LastEditedBy], [LastEditedDate]) VALUES
('0c996ee1-1485-41d5-8b13-2468c72b79dc', @test, 'Does the puppy display appropriate bit inhibition and control? (This is the MOST important item in this section.)', 1, @sectionId, 1, 0, @lastEditBy, @lastEdityDate),
('867eb1fb-43de-44a0-a38d-ed30ec6d7af1', @test, 'Does puppy display appropriate confidence?', 1, @sectionId, 2, 0, @lastEditBy, @lastEdityDate),
('e96e04a0-1bac-400e-b3cc-ae5297852431', @test, 'Does puppy display age appropriate neutral “calmness”?', 1, @sectionId, 3, 0, @lastEditBy, @lastEdityDate),
('5be6a74a-400b-4cd1-991b-43d369c21972', @test, 'Does puppy display appropriate interest in interacting while accompanied by handler?', 1, @sectionId, 4, 0, @lastEditBy, @lastEdityDate),
('2553797a-f8cd-4dee-9640-943d9b38b0f0', @test, 'Does puppy display appropriate ability to adjust to/recover from surprise?', 1, @sectionId, 5, 0, @lastEditBy, @lastEdityDate),
('9621ffd8-d347-4ab1-95d2-80fa520833c6', @test, 'Does puppy display appropriate arousal levels for therapy visits?', 1, @sectionId, 6, 0, @lastEditBy, @lastEdityDate),
('9058a54a-3512-4568-a5dd-b455eb36e152', @test, 'Does puppy display appropriate calming signals related to excessive stress or fear? If excessive calming signals are present, describe', 1, @sectionId, 7, 0, @lastEditBy, @lastEdityDate),
('7795b5b0-a404-484d-8bc9-7841aa30abbd', @test, 'Does puppy appropriately accept attention from a new person?', 1, @sectionId, 8, 0, @lastEditBy, @lastEdityDate),
('1372ae6a-b381-46bd-8db6-323814095f48', @test, 'Does puppy show willingness to accept support from the handler?', 1, @sectionId, 9, 0, @lastEditBy, @lastEdityDate),
('1372ae6a-b381-46bd-8db6-323814095f49', @test, 'Is puppy able to engage in interactive play safely?', 1, @sectionId, 10, 0, @lastEditBy, @lastEdityDate);

SET @sectionId = 'E824FDFF-5615-4963-99FA-371DD1084080';
INSERT INTO [dbo].[Questions] ([Id], [Test], [Text], [MustPass], [Section], [QuestionNumber], [HasYesNo], [LastEditedBy], [LastEditedDate]) VALUES
('692c57d3-61ff-4db0-995c-6cbb15c87b4c', @test, 'Have assistant pet puppy exuberantly. Does puppy respond appropriately to exuberant and unexpectedly rough petting?', 1, @sectionId, 1, 0, @lastEditBy, @lastEdityDate),
('20f5f77f-5b46-4581-af1c-8af72f1606b7', @test, 'Have assistant restrain puppy briefly in a hug. Does puppy respond appropriately to a close-range restraining hug?', 1, @sectionId, 2, 0, @lastEditBy, @lastEdityDate),
('20f5f77f-5b46-4581-af1c-8af72f1606b7', @test, 'Place a handful of treats on the floor and allow puppy to begin eating them. While puppy is eating, pick up several of the treats. Does puppy safely tolerate having a high value item removed?', 1, @sectionId, 3, 0, @lastEditBy, @lastEdityDate),
('095966ad-69b0-4cf8-9ea5-cbfc34c0fa8c', @test, 'Give puppy a high value treat. Once puppy is engrossed, attempt to exchange the high value item for a lower value item. Does the puppy safely tolerate having the higher value item removed?', 1, @sectionId, 4, 0, @lastEditBy, @lastEdityDate),
('5e6aee5b-0ba3-4fbf-b843-9551189edfe1', @test, 'Assistant and examiner each give puppy a treat. Does puppy safely accept treat from two people?', 1, @sectionId, 5, 0, @lastEditBy, @lastEdityDate);

SET @sectionId = '5717B389-484F-4661-932B-EA7B34BC15AB';
INSERT INTO [dbo].[Questions] ([Id], [Test], [Text], [MustPass], [Section], [QuestionNumber], [HasYesNo], [LastEditedBy], [LastEditedDate]) VALUES
('688b9b0c-13e7-4beb-a4c0-f418b887fc33', @test, 'Examiner Note: Handler has demonstrated safe and humane treatment of puppy.', 1, @sectionId, 1, 0, @lastEditBy, @lastEdityDate),
('6e857b65-2fda-4cbf-a23e-6c9c72db970c', @test, 'Examiner Note: Handler has met standards for professional interactions and appearance.', 1, @sectionId, 2, 0, @lastEditBy, @lastEdityDate),
('46766c61-7c2f-4759-a645-b1de50cc1752', @test, 'Describe how socialize your puppy?', 1, @sectionId, 3, 0, @lastEditBy, @lastEdityDate),
('97257897-f2c6-420e-bc47-335b0cd8afb4', @test, 'Describe three signs of stress in dogs? What does your puppy do when under stress?', 1, @sectionId, 4, 0, @lastEditBy, @lastEdityDate),
('5a2c72c1-4acc-4f88-a781-dca6b9757daf', @test, 'What is your puppy''s breed or breed mix? What characteristics does this breed/mix possess that may assist or detract in a therapy visit situation?', 1, @sectionId, 5, 0, @lastEditBy, @lastEdityDate),
('ca189cfe-0579-4a65-8359-ff2e96d1c6fd', @test, 'How do you “correct” your puppy?', 1, @sectionId, 6, 0, @lastEditBy, @lastEdityDate),
('ad6ac696-7286-4841-80ed-42d2b998ca4d', @test, 'What is your puppy''s living situation?', 1, @sectionId, 7, 0, @lastEditBy, @lastEdityDate),
('64d436c7-a03c-4c0e-88db-721635e82cc0', @test, 'Describe what you do to groom your puppy.', 1, @sectionId, 8, 0, @lastEditBy, @lastEdityDate),
('a674032a-0e6c-49f8-8e3d-d64d04d1d3f5', @test, 'Who is your vet?', 1, @sectionId, 9, 0, @lastEditBy, @lastEdityDate),
('876fc246-546f-4006-a4fc-0ad94e5fec47', @test, 'What is your schedule for vaccinating or titering? How many rounds of vaccines/boosters has your puppy had? Handler has shown proof of current vaccines.', 1, @sectionId, 10, 1, @lastEditBy, @lastEdityDate),
('4798ea6e-6343-4fd9-8c99-7433c4dc16e5', @test, 'How do you treat for internal and external parasites? How frequently do you do this? Handler has show proof of current, negative fecal exam.', 1, @sectionId, 11, 1, @lastEditBy, @lastEdityDate),
('4798ea6e-6343-4fd9-8c99-7433c4dc16e6', @test, 'Does your puppy have any physical or medical issues that might be of concern when visiting?', 1, @sectionId, 12, 0, @lastEditBy, @lastEdityDate),
('d8d57772-50a9-4dc1-bb5b-9717f70b7a27', @test, 'If yes, how do you manage that in order to keep both your puppy and those you visit safe?', 1, @sectionId, 13, 0, @lastEditBy, @lastEdityDate),
('dbc1e711-410e-411c-a0d1-3842a360e547', @test, 'What are the differences between therapy and service dogs?', 1, @sectionId, 14, 0, @lastEditBy, @lastEdityDate),
('cb159506-13f3-4415-9033-52a5d209c152', @test, 'What will you do to manage your puppy safely and humanely in all visit settings?', 1, @sectionId, 15, 0, @lastEditBy, @lastEdityDate),
('32526866-2164-4c42-9379-9710ce47b60b', @test, 'If you visit in an environment where you and your puppy might be exposed to infectious illnesses, what procedures do you follow to keep yourself and your puppy safe from infection? (This question addresses handler''s ability to protect his/herself and puppy.)', 1, @sectionId, 16, 0, @lastEditBy, @lastEdityDate),
('bedc9678-fe2c-4484-9b0b-c52d4b9db7c1', @test, 'How do you address the need for health barriers with others while visiting? (This question addresses handler''s ability to protect others.)', 1, @sectionId, 17, 0, @lastEditBy, @lastEdityDate),
('f51a5a22-ea70-4917-a40b-eb94647b0f7c', @test, 'Give 3 examples of times when you should not visit or should cancel a visit.', 1, @sectionId, 18, 0, @lastEditBy, @lastEdityDate),
('e3eb088b-8f0f-49d7-85b5-dcdbe8b9d5be', @test, 'List three items you should have with you on a visit?', 1, @sectionId, 19, 0, @lastEditBy, @lastEdityDate),
('79e9ca28-33dc-4708-a12d-b68dd90b568a', @test, 'Why are you interested in obtaining this credential?', 1, @sectionId, 20, 0, @lastEditBy, @lastEdityDate);