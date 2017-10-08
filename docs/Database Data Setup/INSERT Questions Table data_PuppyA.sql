DECLARE @test AS UNIQUEIDENTIFIER = '6ad247e9-6eca-4380-88f3-e9c5b4ba6ff1';
DECLARE @sectionId AS UNIQUEIDENTIFIER = 'A1565307-B86F-4267-AC9A-66E78918C7A8';
DECLARE @lastEditBy AS UNIQUEIDENTIFIER = '50c112b0-488c-4a63-ab6c-3df970f5beb8';
DECLARE @lastEditDate AS DATETIME = '10/5/2017';
INSERT INTO [dbo].[Questions] ([Id], [Test], [Text], [MustPass], [Section], [QuestionNumber], [HasYesNo], [LastEditedBy], [LastEditedDate]) VALUES
('150f3f94-9ee8-41f9-b031-ec7e2a32dfea', @test, 'Approach puppy at normal walking pace and interact with person. Does puppy acknowledge the examiner and/or solicit attention?', 1, @sectionId, 1, 0, @lastEditBy, @lastEditDate),
('7790ac6a-7798-4399-a149-aecde64e1ddb', @test, 'Ask handler to touch puppy''s collar. Is puppy accepting?', 1, @sectionId, 2, 0, @lastEditBy, @lastEditDate),
('d737431e-b65a-4f68-ac67-33570c65af81', @test, 'Touch puppy''s collar. Is puppy accepting?', 1, @sectionId, 3, 0, @lastEditBy, @lastEditDate),
('4061f055-73c3-4a9d-93ef-9bfa91d5f274', @test, 'Ask to touch puppy. Is puppy eager to interact?', 1, @sectionId, 4, 0, @lastEditBy, @lastEditDate),
('aac0f51f-2d15-40dc-a42d-d18644fd8081', @test, 'Have handler place puppy on floor next to him/herself. Observe interactions and play between handler and puppy.', 1, @sectionId, 5, 0, @lastEditBy, @lastEditDate),
('cf5e4c1f-01d6-4f3a-927a-bb314c28b9c1', @test, 'Have assistant sit 5 ft. away from puppy and tap floor or clap to get its attention. Does puppy approach assistant?', 0, @sectionId, 6, 0, @lastEditBy, @lastEditDate),
('36901e9e-7008-4d06-a3e7-9d75017bb2f3', @test, 'Ask handler to have puppy sit at his/her side. Handler and examiner pet puppy together. Is puppy accepting?', 0, @sectionId, 7, 0, @lastEditBy, @lastEditDate),
('168cbb10-736a-47be-b2fa-6b45287bf512', @test, 'Begin stroking puppy in a neutral/non-threatening area, then progress to stroking back, patting side, patting head, and finally initiate more affectionate interaction. Is puppy accepting?', 0, @sectionId, 8, 0, @lastEditBy, @lastEditDate),
('ca85ed2e-3fdf-45a0-bc09-c5db641851d0', @test, 'Place puppy in assistant''s lap and turn puppy on its back. (If puppy is too large to place on lap, gently assist it onto its side or back and lightly restrain with one hand.) Observe puppy''s reaction for 30 seconds.', 0, @sectionId, 9, 0, @lastEditBy, @lastEditDate),
('ca85ed2e-3fdf-45a0-bc09-c5db641851d1', @test, 'Have assistant gently squeeze puppy between toes. Observe puppy''s reaction for 10 seconds.', 0, @sectionId, 10, 0, @lastEditBy, @lastEditDate),
('f144137e-8d81-408e-a413-b4989d7802c5', @test, 'Have assistant place puppy in center of room. Drop a metal bowl.', 0, @sectionId, 11, 0, @lastEditBy, @lastEditDate),
('97ad6b58-70c1-4fc4-bf90-53974c419f06', @test, 'Have assistant show puppy a crumpled piece of paper, then toss paper a short distance.', 0, @sectionId, 12, 0, @lastEditBy, @lastEditDate),
('9885da97-203d-4866-bbbd-28f08c91ab97', @test, 'Have assistant show puppy a toy or rolled towel on a long line and drag past puppy quickly. Observe puppy''s reaction. Did puppy observe? Jump to chase? Grab and shake item?', 0, @sectionId, 13, 0, @lastEditBy, @lastEditDate),
('f3422ec9-2760-4c45-bb8a-54ef70585c15', @test, 'Ask handler to examine puppy''s feet, ears, teeth, abdomen, tail, and hips. Is puppy accepting?', 0, @sectionId, 14, 0, @lastEditBy, @lastEditDate),
('5180b4f3-85cd-4822-afce-053c398edd2a', @test, 'Visually check that puppy appears healthy overall and well groomed.', 0, @sectionId, 15, 0, @lastEditBy, @lastEditDate),
('fd33de09-7ade-4c7e-a15c-916fb5ec1787', @test, 'Examine puppy''s feet, ears, teeth, abdomen, tail, and hips. Does puppy appear healthy and accept exam?', 0, @sectionId, 16, 0, @lastEditBy, @lastEditDate),
('962d5689-b3c4-442c-a072-04beb88fc715', @test, 'Place finger/hand in front of puppy''s face/mouth. Puppy may show interest, lick, or even open its mouth, but it should not actively seek finger/hand as something to bite/chew.', 1, @sectionId, 17, 0, @lastEditBy, @lastEditDate);

SET @sectionId = 'F17BB1D4-A588-4F81-90BE-F9EA9A3040D6';
INSERT INTO [dbo].[Questions] ([Id], [Test], [Text], [MustPass], [Section], [QuestionNumber], [HasYesNo], [LastEditedBy], [LastEditedDate]) VALUES
('07c051d1-1c75-4a0f-954a-df17078da5ff', @test, 'Ask handler to walk puppy on a loose leash a distance of 10 ft. Does puppy display a happy attitude?', 0, @sectionId, 1, 0, @lastEditBy, @lastEditDate),
('4dafe6dc-311d-4efb-ac0b-565dcec85c60', @test, 'Ask handler to request puppy to sit.', 0, @sectionId, 2, 0, @lastEditBy, @lastEditDate),
('54903d07-e8ae-4ddb-ae3f-41f446356d3d', @test, 'Ask handler to request puppy to down.', 0, @sectionId, 3, 0, @lastEditBy, @lastEditDate),
('0b91e41e-3193-44ca-b53b-03c08efab25c', @test, 'Ask handler to request puppy to stay and remain attentive for 5 seconds.', 0, @sectionId, 4, 0, @lastEditBy, @lastEditDate),
('a51645a8-5944-453b-8591-f6f7fa40f2f6', @test, 'Ask handler to request puppy to come a distance of 3 ft.', 0, @sectionId, 5, 0, @lastEditBy, @lastEditDate),
('54903d07-e8ae-4ddb-ae3f-41f446356d3e', @test, 'Ask handler what he/she does to positively reinforce puppy and have him/her demonstrate. At the tester''s discretion this may be satisfactorily addressed in the above exercises.', 0, @sectionId, 6, 0, @lastEditBy, @lastEditDate),
('b116b2c1-5a70-4334-bc50-29e9f39fbe3d', @test, 'Ask handler to walk puppy, on leash, past a neutral dog.', 0, @sectionId, 7, 0, @lastEditBy, @lastEditDate),
('6ff28bdc-3777-468a-8048-cb92575caae9', @test, 'Ask handler to demonstrate playing with puppy. Do handler and puppy have the rapport to engage in safe, interactive play?', 0, @sectionId, 8, 0, @lastEditBy, @lastEditDate);

SET @sectionId = '6707CB00-1314-41DC-8D53-5A388A4128AA';
INSERT INTO [dbo].[Questions] ([Id], [Test], [Text], [MustPass], [Section], [QuestionNumber], [HasYesNo], [LastEditedBy], [LastEditedDate]) VALUES
('a74faf86-00d4-4e6f-8c8a-bf413c26fdf3', @test, 'Throw an object in the general vicinity of puppy. Does puppy respond appropriately to the unexpected movement and noise?', 1, @sectionId, 1, 0, @lastEditBy, @lastEditDate),
('4b66d9f0-6809-4958-853a-a61c8b44b8c1', @test, 'Have assistant walk toward puppy while simulating a motor disability. Does puppy respond appropriately to unexpected movements in a person?', 1, @sectionId, 2, 0, @lastEditBy, @lastEditDate),
('924da643-0fde-4663-896d-476c98ee873e', @test, 'Have assistant use a walker or wheel a wheelchair near puppy. Does puppy respond appropriately to medical equipment?', 1, @sectionId, 3, 0, @lastEditBy, @lastEditDate),
('4e514a85-d4cd-4bfc-b485-85f3d3a657a4', @test, 'Drop several boxes near puppy. Does puppy respond appropriately to the unexpected movement and noise?', 1, @sectionId, 4, 0, @lastEditBy, @lastEditDate),
('bb2ad59e-3c41-4bb3-8fb0-bb2c4966fb6f', @test, 'Engage in simulated angry yelling with assistant. Does puppy respond appropriately to heightened emotions?', 1, @sectionId, 5, 0, @lastEditBy, @lastEditDate),
('6d4383d5-f9d3-4e8e-980a-b5ded098275b', @test, 'Have assistant approach puppy while wearing a hat. Does puppy respond appropriately to a person in a hat?', 1, @sectionId, 6, 0, @lastEditBy, @lastEditDate),
('625b2899-ae89-4cf5-a6bc-b2089e0968a1', @test, 'Place a toy near puppy. Will puppy respond to a “leave it” or “drop it” cue when requested?', 1, @sectionId, 7, 0, @lastEditBy, @lastEditDate);

SET @sectionId = 'FF2FFA38-2058-4DBB-9ACD-1F50AD2A5A8C';
INSERT INTO [dbo].[Questions] ([Id], [Test], [Text], [MustPass], [Section], [QuestionNumber], [HasYesNo], [LastEditedBy], [LastEditedDate]) VALUES
('ce2a859a-b788-4bb1-9a25-909289e10446', @test, 'Does the puppy display appropriate bit inhibition and control?', 1, @sectionId, 1, 0, @lastEditBy, @lastEditDate),
('c6d2531b-d581-43d9-8582-0ae578fa1b67', @test, 'Does puppy display appropriate confidence?', 1, @sectionId, 2, 0, @lastEditBy, @lastEditDate),
('96674147-4784-4569-ac02-777eec68113d', @test, 'Does puppy display age appropriate neutral “calmness”? (Relative to puppy behavior.)', 1, @sectionId, 3, 0, @lastEditBy, @lastEditDate),
('20e5f19d-d7a5-4293-8a68-89001236e565', @test, 'Does puppy display appropriate interest in interacting while accompanied by handler?', 1, @sectionId, 4, 0, @lastEditBy, @lastEditDate),
('cfc50f7a-5164-41e5-8643-abf0209895d7', @test, 'Does puppy display appropriate ability to adjust to/recover from surprise?', 1, @sectionId, 5, 0, @lastEditBy, @lastEditDate),
('8ebb54cf-3fb4-4ef6-849e-57f192400073', @test, 'Does puppy display appropriate arousal levels for therapy visits?', 1, @sectionId, 6, 0, @lastEditBy, @lastEditDate),
('b2292195-5ef1-45e0-9c86-7f2569531bda', @test, 'Does puppy display appropriate calming signals related to excessive stress or fear? If excessive calming signals are present, please describe notes.', 1, @sectionId, 7, 0, @lastEditBy, @lastEditDate),
('fb59a51d-2961-40f4-b906-1611d7b10faa', @test, 'Does puppy appropriately accept attention from a new person?', 1, @sectionId, 10, 0, @lastEditBy, @lastEditDate),
('1391b198-6bda-4f95-bf95-c7f54838cd6e', @test, 'Does puppy show willingness to accept support from the handler?', 1, @sectionId, 11, 0, @lastEditBy, @lastEditDate),
('dd30554b-800b-467d-929a-3e16671f07e1', @test, 'Is puppy able to engage in interactive play safely?', 1, @sectionId, 12, 0, @lastEditBy, @lastEditDate);

SET @sectionId = 'EA46CBD5-CB10-4C4E-AAA3-F6E1185E5730';
INSERT INTO [dbo].[Questions] ([Id], [Test], [Text], [MustPass], [Section], [QuestionNumber], [HasYesNo], [LastEditedBy], [LastEditedDate]) VALUES
('9d45a984-a71b-401e-ba8a-16e889c578fa', @test, 'Have assistant pet puppy exuberantly. Does puppy respond appropriately to exuberant and unexpectedly rough petting?', 1, @sectionId, 1, 0, @lastEditBy, @lastEditDate),
('60947041-99bd-4ac7-9d04-0013d2103ad1', @test, 'Have assistant restrain puppy briefly in a hug. Does puppy respond appropriately to a close-range restraining hug?', 1, @sectionId, 2, 0, @lastEditBy, @lastEditDate),
('0ff2bd90-4f6b-495d-b00a-5fc0bd421b79', @test, 'Place a handful of treats on the floor and allow puppy to begin eating them. While puppy is eating, pick up several of the treats. Does puppy safely tolerate having a high value item removed?', 1, @sectionId, 3, 0, @lastEditBy, @lastEditDate),
('cd322fc0-a19c-43c9-8c4c-30051139604f', @test, 'Give puppy a high value treat. Once puppy is engrossed, attempt to exchange the high value item for a lower value item. Does the puppy safely tolerate having the higher value item removed?', 1, @sectionId, 4, 0, @lastEditBy, @lastEditDate),
('403fd9e5-af3e-46f9-9254-ebd2f66a0ec9', @test, 'Assistant and examiner each give puppy a treat. Does puppy safely accept treat from two people?', 1, @sectionId, 5, 0, @lastEditBy, @lastEditDate);

SET @sectionId = 'A0BA66C1-EDB3-4DF2-A3B6-BC5F0016D67D';
INSERT INTO [dbo].[Questions] ([Id], [Test], [Text], [MustPass], [Section], [QuestionNumber], [HasYesNo], [LastEditedBy], [LastEditedDate]) VALUES
('0376c4cf-9b54-4f08-8bd2-da461255e5c7', @test, 'Examiner Note: Handler has demonstrated safe and humane treatment of puppy.', 1, @sectionId, 1, 0, @lastEditBy, @lastEditDate),
('33b9cfcb-762b-4992-9992-f67bf12a94c7', @test, 'Examiner Note: Handler has met standards for professional interactions and appearance.', 1, @sectionId, 2, 0, @lastEditBy, @lastEditDate),
('b7536d3b-07d6-407e-a183-3386355777d3', @test, 'Describe how socialize your puppy?', 1, @sectionId, 3, 0, @lastEditBy, @lastEditDate),
('430b0803-1931-49dc-8bad-4eef60f17868', @test, 'Describe three signs of stress in dogs? What does your puppy do when under stress?', 1, @sectionId, 4, 0, @lastEditBy, @lastEditDate),
('b7d6f260-455a-4cc0-9112-d12f8a2d5f3c', @test, 'What is your puppy''s breed or breed mix? What characteristics does this breed/mix possess that may assist or detract in a therapy visit situation?', 1, @sectionId, 5, 0, @lastEditBy, @lastEditDate),
('70f43031-3c69-4cd8-9412-79b9d8579542', @test, 'How do you “correct” your puppy?', 1, @sectionId, 6, 0, @lastEditBy, @lastEditDate),
('8aee0964-5f7e-4d9e-afba-79a68758f9ab', @test, 'What is your puppy''s living situation?', 1, @sectionId, 7, 0, @lastEditBy, @lastEditDate),
('5c510993-9e48-4f08-94ee-7e6f6ea7decc', @test, 'Describe what you do to groom your puppy.', 1, @sectionId, 8, 0, @lastEditBy, @lastEditDate),
('6afc5a5b-85eb-4286-a04c-a531e6d3bacc', @test, 'Who is your vet?', 1, @sectionId, 9, 0, @lastEditBy, @lastEditDate),
('55f0e57e-c3d8-456a-ae12-853467a8678a', @test, 'What is your schedule for vaccinating or titering? How many rounds of vaccines/boosters has your puppy had? Handler to show proof of current vaccines.', 1, @sectionId, 10, 1, @lastEditBy, @lastEditDate),
('40a18336-739a-4589-935d-1734a6594be3', @test, 'How do you treat for internal and external parasites? How frequently do you do this? Handler to show proof of current negative fecal text.', 1, @sectionId, 11, 1, @lastEditBy, @lastEditDate),
('c1473366-a5f0-415c-baaf-4977c527c928', @test, 'Does your puppy have any physical or medical issues that might be of concern when visiting?', 1, @sectionId, 12, 0, @lastEditBy, @lastEditDate),
('1f11bcf5-f51b-445a-b799-ca8cc6225537', @test, 'If yes, how do you manage that in order to keep both your puppy and those you visit safe?', 1, @sectionId, 13, 0, @lastEditBy, @lastEditDate),
('8b99d961-610c-4b8e-8cb6-b28c2fc5c6c7', @test, 'What are the differences between therapy and service dogs?', 1, @sectionId, 14, 0, @lastEditBy, @lastEditDate),
('428dbf85-d554-4237-ab79-3f2973102d97', @test, 'What will you do to manage your puppy safely and humanely in all visit settings?', 1, @sectionId, 15, 0, @lastEditBy, @lastEditDate),
('73165164-42cd-4b73-970b-6bd9d5e885c8', @test, 'If you visit in an environment where you and your puppy might be exposed to infectious illnesses, what procedures do you follow to keep yourself and your puppy safe from infection? (This question addresses handler''s ability to protect his/herself and puppy.)', 1, @sectionId, 16, 0, @lastEditBy, @lastEditDate),
('5c10f099-d077-4eca-a6d6-734a3a1a1cc0', @test, 'How do you address the need for health barriers with others while visiting? (This question addresses handler''s ability to protect others.)', 1, @sectionId, 17, 0, @lastEditBy, @lastEditDate),
('f3db5229-2dec-497f-8730-0203bce219ff', @test, 'Give 3 examples of times when you should not visit and should cancel.', 1, @sectionId, 18, 0, @lastEditBy, @lastEditDate),
('572ee226-4032-4304-95ad-08add6908d7f', @test, 'List three items you should have with you on a visit?', 1, @sectionId, 19, 0, @lastEditBy, @lastEditDate),
('dd33ead5-a31a-44ea-af1b-23e7efc9b097', @test, 'Why are you interested in obtaining this credential?', 1, @sectionId, 20, 0, @lastEditBy, @lastEditDate);