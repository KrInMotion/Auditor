USE AuditorDB
GO
DELETE FROM [dbo].[TaskResults]
GO
SET IDENTITY_INSERT [dbo].[TaskResults] ON
GO
INSERT INTO [dbo].[TaskResults] (Id, ResultName, NeedReAction) VALUES(1, N'Агент не в сети', 1)
GO
INSERT INTO [dbo].[TaskResults] (Id, ResultName, NeedReAction) VALUES(2, N'В HTML-коде - запрещенный сайт, на скриншоте - заглушка', 1)
GO
INSERT INTO [dbo].[TaskResults] (Id, ResultName, NeedReAction) VALUES(3, N'Есть нарушения', 0)
GO
INSERT INTO [dbo].[TaskResults] (Id, ResultName, NeedReAction) VALUES(4, N'Есть нарушения, но среди скриншотов есть заглушки, отсутствующие в результатах задачи', 1)
GO
INSERT INTO [dbo].[TaskResults] (Id, ResultName, NeedReAction) VALUES(5, N'Есть нарушения, скриншотов нет', 1)
GO
INSERT INTO [dbo].[TaskResults] (Id, ResultName, NeedReAction) VALUES(6, N'Есть нарушения, среди прочих - неинформативные скриншоты', 0)
GO
INSERT INTO [dbo].[TaskResults] (Id, ResultName, NeedReAction) VALUES(7, N'Есть нарушения, только неинформативные скриншоты', 0)
GO
INSERT INTO [dbo].[TaskResults] (Id, ResultName, NeedReAction) VALUES(8, N'Нарушений нет', 0)
GO
INSERT INTO [dbo].[TaskResults] (Id, ResultName, NeedReAction) VALUES(9, N'Не найдено нарушений для включения в протокол мониторинга', 0)
GO
INSERT INTO [dbo].[TaskResults] (Id, ResultName, NeedReAction) VALUES(10, N'Ошибка: failed to fetch checklist', 1)
GO
INSERT INTO [dbo].[TaskResults] (Id, ResultName, NeedReAction) VALUES(11, N'Ошибка: whiteitems check failed: not available', 1)
GO
INSERT INTO [dbo].[TaskResults] (Id, ResultName, NeedReAction) VALUES(12, N'Ошибка: whiteitems check failed: unknown ip address', 1)
GO
SET IDENTITY_INSERT [dbo].[Territories] OFF
GO