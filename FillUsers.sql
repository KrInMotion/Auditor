USE AuditorDD
GO
DELETE FROM [dbo].[Users]
GO
SET IDENTITY_INSERT [dbo].[Users] ON
GO
INSERT INTO [dbo].[Users] (Id, FirstName, LastName, MiddleName, FullName, ShortName) VALUES(1, N'Александр', N'Кожаринов', N'Святославович', N'Кожаринов Александр Святославович', N'Кожаринов А.С.')
GO
INSERT INTO [dbo].[Users] (Id, FirstName, LastName, MiddleName, FullName, ShortName) VALUES(1, N'Дмитрий', N'Слюсарев', N'Вячеславович', N'Слюсарев Дмитрий Вячеславович', N'Слюсарев Д.В.')
GO
SET IDENTITY_INSERT [dbo].[Users] OFF
GO