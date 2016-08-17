USE AuditorDB
GO
DELETE FROM [dbo].[Users]
GO
SET IDENTITY_INSERT [dbo].[Users] ON
GO
INSERT INTO [dbo].[Users] (Id, FirstName, LastName, MiddleName, FullName, ShortName) VALUES(1, N'Александр', N'Кожаринов', N'Святославович', N'Кожаринов Александр Святославович', N'Кожаринов А.С.')
GO
INSERT INTO [dbo].[Users] (Id, FirstName, LastName, MiddleName, FullName, ShortName) VALUES(2, N'Дмитрий', N'Слюсарев', N'Вячеславович', N'Слюсарев Дмитрий Вячеславович', N'Слюсарев Д.В.')
GO
INSERT INTO [dbo].[Users] (Id, FirstName, LastName, MiddleName, FullName, ShortName) VALUES(3, N'Роман', N'Клопов', N'Владимирович', N'Клопов Роман Владимирович', N'Клопов Р.В.')
GO
INSERT INTO [dbo].[Users] (Id, FirstName, LastName, MiddleName, FullName, ShortName) VALUES(4, N'Михаил', N'Шурупов', N'Геннадиевич', N'Шурупов Михаил Геннадиевич', N'Шурупов М.Г.')
GO
INSERT INTO [dbo].[Users] (Id, FirstName, LastName, MiddleName, FullName, ShortName) VALUES(5, N'Максим', N'Еланцев', N'Александрович', N'Еланцев Максим Александрович', N'Еланцев М.А.')
GO
SET IDENTITY_INSERT [dbo].[Users] OFF
GO