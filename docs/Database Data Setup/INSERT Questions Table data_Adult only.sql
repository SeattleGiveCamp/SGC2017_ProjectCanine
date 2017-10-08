DECLARE @test AS UNIQUEIDENTIFIER = 'c5197bc7-4b29-45d6-bdd6-b03bdcd33900';
DECLARE @sectionId AS UNIQUEIDENTIFIER = 'ae9c9845-ea32-476a-a081-307439fda62a';
DECLARE @lastEditBy AS UNIQUEIDENTIFIER = '50c112b0-488c-4a63-ab6c-3df970f5beb8';
DECLARE @lastEditDate AS UNIQUEIDENTIFIER = @lastEditDate;
INSERT INTO [dbo].[Questions] ([Id], [Test], [Text], [MustPass], [Section], [QuestionNumber], [HasYesNo], [LastEditedBy], [LastEditedDate]) VALUES
('8AEDE8D7-C6C0-4E53-B5BB-1E0B1F87E81D', @test, 'Examiner and team start at opposite ends of the space and walk towards each other at a normal walking pace. When they come together they stop, greet and shake hands and move on. Dog must not interact with examiner at this time. Did handler manage dog appropriately? Was dog responsive to request not to interact?', 1, @sectionId, 1, 0, @lastEditBy, @lastEditDate),
('27097B6E-1F70-493F-AAA5-039589B4038F', @test, 'Examiner asks to touch dog. Is dog accepting and appropriate about interacting?', 1, @sectionId, 2, 0, @lastEditBy, @lastEditDate),
('174BB235-EE87-4791-8FC2-527513A0763A', @test, 'Ask handler to feel underneath dog''s collar all around especially in throat area. Is dog accepting?', 1, @sectionId, 3, 0, @lastEditBy, @lastEditDate),
('940D7974-EFF8-4E1F-807C-26157CEB8166', @test, 'Examiner now does the same and feels underneath dog''s collar. Is dog accepting?', 1, @sectionId, 4, 0, @lastEditBy, @lastEditDate),
('EB4A9FBF-32C0-4B4D-A2CC-DA389B99F97A', @test, 'Snap clipboard. Does dog show acceptable startle response and recovery?', 0, @sectionId, 5, 0, @lastEditBy, @lastEditDate),
('F8D39291-7BAD-4C62-8B92-15936A9B2B34', @test, 'Ask handler to have dog sit at his/her side. Handler and examiner pet dog together. Is dog accepting?', 1, @sectionId, 6, 0, @lastEditBy, @lastEditDate),
('51F1B6B1-D5F9-40A1-95D4-5D2FE6B20A0B', @test, 'Ask handler to pet the dog from the tip of its nose to the tip of its tail. Is dog accepting?', 1, @sectionId, 7, 0, @lastEditBy, @lastEditDate),
('AB7CCAE1-D876-4569-9C7E-4D1C4B9C8FA3', @test, 'Examiner pets dog from the tip of its nose to the tip of its tail. Is dog accepting?', 1, @sectionId, 8, 0, @lastEditBy, @lastEditDate),
('8D8F970E-DD07-4C99-836C-14F4DDA83E27', @test, 'Ask handler to pat dog on head. Is dog accepting?', 1, @sectionId, 9, 0, @lastEditBy, @lastEditDate),
('BF582042-49FE-49B7-9047-873DB4133F4E', @test, 'Examiner to pat dog on head. Is dog accepting?', 1, @sectionId, 10, 0, @lastEditBy, @lastEditDate),
('2E4981DC-B144-42FC-9AA1-D3788881827E', @test, 'Ask handler to examine dog''s paws, ears, teeth, abdomen, and tail. Is dog accepting?', 1, @sectionId, 11, 0, @lastEditBy, @lastEditDate),
('865E9DCC-F7D0-45FB-9F93-FA229BE1BD3C', @test, 'For Senior Dogs (Senior Dogs defined as - Giant breed = 6yrs and over, medium to large = 8yrs and over, small breeds = 10yrs and over): Ask the handler to touch the dog''s joints (shoulders, elbows, wrists, hips, and knees) applying gentle pressure and testing for mobility. Is dog accepting?', 1, @sectionId, 13, 0, @lastEditBy, @lastEditDate),
('7306C5FE-38CA-4E57-A3E8-992D8AAE4328', @test, 'For Senior Dogs (Senior Dogs defined as - Giant breed = 6yrs and over, medium to large = 8yrs and over, small breeds = 10yrs and over): Examiner Touch the dog''s joints (shoulders, elbows, wrists, hips, and knees) applying gentle pressure and testing for mobility. Does dog appear healthy and accept exam?', 1, @sectionId, 14, 0, @lastEditBy, @lastEditDate),
('AF47B251-DA5B-40DE-A1A0-A179614175E2', @test, 'Ask handler to lightly brush dog on neck and back. Is dog accepting? Examiner to brush dog lightly on neck and back. Is dog accepting?', 1, @sectionId, 15, 0, @lastEditBy, @lastEditDate),
('0ADC0C70-489A-4422-BBF9-FDFFA3A2ED35', @test, 'Note: If neutral dogs are highly visible skip this step. If prospective dog has not seen neutral dog have neutral dog walk into and out of exam area. Does dog remain calm? (If dog has already seen the neutral dog write score and move past this step.)', 1, @sectionId, 16, 0, @lastEditBy, @lastEditDate),
('E1070FD8-9A43-4DC6-880D-74EFE55FF1A1', @test, 'Ask handler to sit in a chair with dog in front of them. Examiner reaches over dog to touch handler/shake their shoulders. Does dog remain composed?', 1, @sectionId, 17, 0, @lastEditBy, @lastEditDate),
('0A277C47-3566-4706-B5A1-15B6EC455DDE', @test, 'Examiner note: visually check that dog appears healthy overall and well groomed. If yes, score P. If not, discuss with handler.', 1, @sectionId, 18, 0, @lastEditBy, @lastEditDate);

SET @sectionId = '4aafd1ed-c068-4fec-bccc-ba36ad11916b';
INSERT INTO [dbo].[Questions] ([Id], [Test], [Text], [MustPass], [Section], [QuestionNumber], [HasYesNo], [LastEditedBy], [LastEditedDate]) VALUES
('DC7B828A-0C14-4190-82BE-66C69A364F53', @test, 'Ask handler to walk dog on a loose leash a distance of approx.15 ft. Is dog able to walk on a loose leash?', 1, @sectionId, 1, 0, @lastEditBy, @lastEditDate),
('00892F20-9DB6-4433-BC44-09C4CA8E83FD', @test, 'Ask handler to request dog to sit. Does dog sit and remain seated?', 1, @sectionId, 2, 0, @lastEditBy, @lastEditDate),
('EC0752C2-D4BD-4BC9-8C34-F3CBA1866294', @test, 'Ask handler to request dog to down. Does dog down and remain down?', 0, @sectionId, 3, 0, @lastEditBy, @lastEditDate),
('F315FD0F-611B-486B-ABF0-3A720022EC8C', @test, 'Ask handler to request dog to stay in either a sit or down position. Ask handler to walk to the end of the leash, wait for 15 seconds, and then return to the dog. Does dog remain in place until the handler returns?', 0, @sectionId, 4, 0, @lastEditBy, @lastEditDate),
('07ED5281-3EE9-4576-8ECA-92E98E4E9E19', @test, 'Ask handler to request dog to stay in either a sit or down position. Assistant will pet dog lightly as a distraction. Ask handler to walk to the end of the leash and then recall the dog to them. Does the dog immediately return to the handler? (Note: we are testing recall here.)', 1, @sectionId, 5, 0, @lastEditBy, @lastEditDate),
('63783333-FD59-418F-8952-18372C856522', @test, 'Examiner note: Has handler positively reinforced dog? If yes, mark P. If not, discuss with handler and ask for demonstration. Confirm that handler understands the concept.', 1, @sectionId, 6, 0, @lastEditBy, @lastEditDate),
('989D4193-4DC6-471A-9BF1-746C6DC4FEE0', @test, 'Examiner and a neutral dog and prospective team start at opposite ends of the space and walk towards each other at a normal walking pace. When they come together they stop, greet and shake hands and move on. Dogs must not interact and testing dog must not interact with Examiner at this time. Did handler manage dog appropriately? Was dog responsive to request not to interact?', 1, @sectionId, 7, 0, @lastEditBy, @lastEditDate),
('B1754C62-D793-4953-A777-DF427C725AC8', @test, 'Ask handler to demonstrate playing with dog. Do handler and dog have the rapport to engage in safe, interactive play?', 1, '4aafd1ed-c068-4fec-bccc-ba36ad11916b', 8, 0, @lastEditBy, @lastEditDate);

SET @sectionId = '909ab883-75af-4863-aa61-11666a35a258';
INSERT INTO [dbo].[Questions] ([Id], [Test], [Text], [MustPass], [Section], [QuestionNumber], [HasYesNo], [LastEditedBy], [LastEditedDate]) VALUES
('0546F0A4-2236-4083-BA98-A92F2749A21B', @test, 'Throw an object, (usually an empty plastic water bottle) in the general vicinity of dog. Does dog respond appropriately to the unexpected movement and noise?', 1, @sectionId, 1, 0, @lastEditBy, @lastEditDate),
('EACFA2D3-CE93-40AD-8DAE-FFA350FD505F', @test, 'Have assistant walk toward dog while simulating a motor disability. Does dog respond appropriately to unexpected movements in a person? Is dog still willing to engage with Examiner?', 1, @sectionId, 2, 0, @lastEditBy, @lastEditDate),
('3403BC32-164D-4E28-9333-3A7DD2E3D98C', @test, 'Have assistant use a walker or wheel a wheelchair near dog. The equipment should have a stuffed animal attached to the front. Does dog respond appropriately to medical equipment?', 1, @sectionId, 3, 0, @lastEditBy, @lastEditDate),
('9F66B2F1-30AB-49E4-ACAC-1022F05815DB', @test, 'Have assistant walk near the dog with a walker that has tennis balls on the bottom of the legs. Does the dog respond appropriately in the presence of tennis balls?', 1, @sectionId, 4, 0, @lastEditBy, @lastEditDate),
('B07C84F3-B31B-477C-8215-5202CC84E8C2', @test, 'Drop several items at the same time near dog. Does dog respond appropriately to the unexpected movement and noise?', 1, @sectionId, 5, 0, @lastEditBy, @lastEditDate),
('73DE7F69-08AE-4CED-9130-7AB7B3EB064F', @test, 'Engage in simulated angry yelling with assistant. Does dog respond appropriately to heightened emotions?', 1, @sectionId, 6, 0, @lastEditBy, @lastEditDate),
('0995F1E0-CD76-46B8-AA52-DF3710DBE40D', @test, 'Have assistant approach dog while wearing a hat. Does dog respond appropriately to a person in a hat?', 1, @sectionId, 7, 0, @lastEditBy, @lastEditDate),
('12A389BD-CDF2-4BD4-87B9-1482DABD8DF0', @test, 'Place a high value toy on the floor and have handler walk dog past the toy (handler may not be between dog and toy). Is dog able to respond to handler''s request to ''leave it''?', 0, @sectionId, 8, 0, @lastEditBy, @lastEditDate),

SET @sectionId = '4fb6eb34-ecf6-4935-a990-2ac8c9806b27';
INSERT INTO [dbo].[Questions] ([Id], [Test], [Text], [MustPass], [Section], [QuestionNumber], [HasYesNo], [LastEditedBy], [LastEditedDate]) VALUES
('5537113c-f787-4212-af42-ab997b880018', @test, 'Does dog display appropriate confidence?', 1, @sectionId, 1, 0, @lastEditBy, @lastEditDate),
('be327b74-2aca-41c5-8ef4-6bac191d3c5a', @test, 'Does dog display appropriate neutral ÒcalmnessÓ?', 1, @sectionId, 2, 0, @lastEditBy, @lastEditDate),
('1f0b389f-e527-4e6a-a0ae-d62f7543fe3b', @test, 'Does dog display appropriate independence?', 1, @sectionId, 3, 0, @lastEditBy, @lastEditDate),
('1e8e7a69-f3b1-4acf-adc0-1721cef1565e', @test, 'Does dog display appropriate interest in interacting while accompanied by handler?', 1, @sectionId, 4, 0, @lastEditBy, @lastEditDate),
('e5425ce3-bb2f-423a-b6b1-a27f611fb4fa', @test, 'Is dog able to interact independently and with interest when directed by handler?', 0, @sectionId, 5, 0, @lastEditBy, @lastEditDate),
('e4fa90cd-6550-4b2e-aebc-41d6df22ded7', @test, 'Does dog display appropriate ability to adjust to/recover from surprise?', 1, @sectionId, 6, 0, @lastEditBy, @lastEditDate),
('08254afd-6ffc-4118-8614-388aee4c954b', @test, 'Does dog display appropriate arousal levels for therapy visits?', 1, @sectionId, 7, 0, @lastEditBy, @lastEditDate),
('3e177242-fdbe-4598-a471-412c06672ae1', @test, 'Does dog display appropriate calming signals? If excessive calming signals are present, please describe', 1, @sectionId, 8, 0, @lastEditBy, @lastEditDate),
('5fd9daaa-04f3-4bd7-81f8-a0cab6e2ab54', @test, 'Does dog appropriately accept attention from a new person?', 1, @sectionId, 9, 0, @lastEditBy, @lastEditDate),
('92b4dad1-a7df-42a1-9d2f-f979e8d9d345', @test, 'Does dog show willingness to accept support from the handler?', 1, @sectionId, 10, 0, @lastEditBy, @lastEditDate),
('df30adbd-0ea9-42cd-9d03-bacdb6c99457', @test, 'Is dog able to engage in interactive play safely?', 0, @sectionId, 11, 0, @lastEditBy, @lastEditDate);

SET @sectionId = 'ba24b9c3-3755-45cd-8051-d0e8a6bbe7d07';
INSERT INTO [dbo].[Questions] ([Id], [Test], [Text], [MustPass], [Section], [QuestionNumber], [HasYesNo], [LastEditedBy], [LastEditedDate]) VALUES
('9acbc776-5c44-4ca2-bc92-00203e9b1ccf', @test, 'Have assistant pet dog exuberantly. Does dog respond appropriately to exuberant and unexpectedly rough petting? Is handler able to successfully redirect the inappropriate behavior to a more positive interaction for their dog?', 1, @sectionId, 1, 0, @lastEditBy, @lastEditDate),
('84f9ab4e-a5df-48d3-aaf5-28c5de5846ec', @test, 'Have assistant restrain dog briefly in a hug. Does dog respond appropriately to a close-range restraining hug? (Note: handler must allow this step. We do not have them redirect us.)', 1, @sectionId, 2, 0, @lastEditBy, @lastEditDate),
('e736a860-f4fe-4d87-bda8-56cd688663c5', @test, 'Place a handful of treats on the floor and allow dog to begin eating them. While dog is eating, Examiner puts their hand in close proximity to dogÕs mouth on the floor and grabs treats too. Does dog safely tolerate having a high value item removed?', 1, @sectionId, 3, 0, @lastEditBy, @lastEditDate),
('47e1c2ed-74ba-4930-b9ee-642614d318ed', @test, 'Give dog a high value treat. Once dog is engrossed, attempt to exchange the high value item for a lower value item. Does the dog safely tolerate having the higher value item removed?', 1, @sectionId, 4, 0, @lastEditBy, @lastEditDate),
('24029cdf-6fb4-4d82-ae53-527d61409aa9', @test, 'Assistant and examiner each give dog a treat in appropriately. Does dog safely accept treat from two people? Does the handler redirect the examiners to an appropriate way to feed their dog?', 1, @sectionId, 5, 0, @lastEditBy, @lastEditDate);

SET @sectionId = 'e38b7b93-381f-4c04-9da9-5223ade0fb4d';
INSERT INTO [dbo].[Questions] ([Id], [Test], [Text], [MustPass], [Section], [QuestionNumber], [HasYesNo], [LastEditedBy], [LastEditedDate]) VALUES
('9e01afc8-2bc9-42d7-94b0-8e7fe6454689', @test, 'Examiner Note: Has handler demonstrated safe and humane treatment of dog? If yes, mark P', 1, @sectionId, 1, 0, @lastEditBy, @lastEditDate),
('e6e3be99-5f52-42d5-805c-3211ad325e4d', @test, 'Examiner Note: Has handler has met standards for professional interactions and appearance? If yes, mark P.', 1, @sectionId, 2, 0, @lastEditBy, @lastEditDate),
('ad8104fb-6aa9-4d32-a851-b717e284ca32', @test, 'Describe how you have socialized your dog?', 1, @sectionId, 3, 0, @lastEditBy, @lastEditDate),
('aabf8624-6fe3-4ba7-8753-16cb3e0a368e', @test, 'Describe three signs of stress in dogs? What does your dog do when under stress?', 1, @sectionId, 4, 0, @lastEditBy, @lastEditDate),
('c54e3cef-2009-414e-9272-6c49708f6da7', @test, 'What is your dog''s breed or breed mix? What characteristics does this breed/mix possess that may assist or detract in a therapy visit situation?', 1, @sectionId, 5, 0, @lastEditBy, @lastEditDate),
('1b1cbd4c-1505-4813-8889-75f23f537bdb', @test, 'How do you ''correct'' your dog?', 1, @sectionId, 6, 0, @lastEditBy, @lastEditDate),
('4317cde9-955f-4944-a5e0-1fa5ad7977b1', @test, 'What is your dog''s living situation?', 1, @sectionId, 7, 0, @lastEditBy, @lastEditDate), ]
('80a3b281-bed7-411b-871d-187f95c4a3f1', @test, 'Describe what you do to groom your dog.', 1, @sectionId, 8, 0, @lastEditBy, @lastEditDate),
('477c4969-a76f-4bb9-9c27-ea34afdda4bf', @test, 'Who is your vet?', 1, @sectionId, 9, 0, @lastEditBy, @lastEditDate),
('7a13d8f9-d921-4240-9106-e8d96aa3d3f0', @test, 'When was your dog last vaccinated or titered? What is your schedule for vaccinating or titering? Handler has shown proof of current rabies vaccine.', 1, @sectionId, 10, 1, @lastEditBy, @lastEditDate),
('88de39aa-fbde-44bb-9370-327bcdcb0b58', @test, 'How do you treat for internal and external parasites? How frequently do you do this?Handler has shown proof of current, negative fecal exam.', 1, @sectionId, 11, 1, @lastEditBy, @lastEditDate),
('49434861-a18c-49bc-8873-5c95a10e665a', @test, 'Does your dog have any physical or medical issues that might be of concern when visiting? If yes, how do you manage that in order to keep both your dog and those you visit safe?', 1, @sectionId, 12, 0, @lastEditBy, @lastEditDate),
('fb31ea1b-106b-4a36-88e6-9ff603fce245', @test, 'For Senior Dogs: (Giant breed = 6yrs and over, medium to large = 8yrs and over, small breeds = 10yrs and over, are you noticing any age-related changes in your dog? If yes, how do you manage those? Have you made any modifications to your visits to accommodate your senior dog?', 1, @sectionId, 13, 0, @lastEditBy, @lastEditDate),
('32012588-fb7c-498c-bfa0-10a6a0d7983d', @test, 'How have you fulfilled your CCE requirement? (Examiner Note: This is for RECERTIFYING teams. If doing an exam with a new team, be sure to explain and reinforce this requirement here.)', 1, @sectionId, 14, 0, @lastEditBy, @lastEditDate),
('4ade18d8-9def-4382-83fa-96aa3a2bd15f', @test, 'What are the differences between therapy and service dogs?', 1, @sectionId, 15, 0, @lastEditBy, @lastEditDate),
('84a3fe8e-5c42-42a3-96c3-c343644066de', @test, 'If you visit in an environment where you and your dog might be exposed to infectious illnesses, what procedures do you follow to keep yourself and your dog safe from infection? (This question addresses handlerÕs ability to protect his/herself and dog.)', 1, @sectionId, 16, 0, @lastEditBy, @lastEditDate),
('9960be59-59d8-4eb0-8cc5-e2053d6409f6', @test, 'How do you address the need for health barriers with others while visiting? (This question addresses handlerÕs ability to protect others.)', 1, @sectionId, 17, 0, @lastEditBy, @lastEditDate),
('bcc9c224-9e17-4a40-87e3-17b02bc2b643', @test, 'What is HIPAA?', 1, @sectionId, 18, 0, @lastEditBy, @lastEditDate),
('2bc418bc-0251-44f6-a363-a8df6f282847', @test, 'Give three examples of times when you would not visit or would cancel a visit.', 1, @sectionId, 19, 0, @lastEditBy, @lastEditDate),
('e69943a7-e119-4db4-86df-7c52f76005dd', @test, 'List three items you should have with you on a visit?', 1, @sectionId, 20, 0, @lastEditBy, @lastEditDate),
('41aba644-5edd-4a47-936a-d3c6a6496fc4', @test, 'Why are you interested in obtaining this credential?', 1, @sectionId, 21, 0, @lastEditBy, @lastEditDate) 