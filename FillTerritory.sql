USE AuditorDB
GO
DELETE FROM [dbo].[Territories]
GO
SET IDENTITY_INSERT [dbo].[Territories] ON
GO
INSERT INTO [dbo].[Territories] (Id, Region, Capital, DistrictId) VALUES(77, N'Москва', N'Москва', 1)
GO
INSERT INTO [dbo].[Territories] (Id, Region, Capital, DistrictId) VALUES(50, N'Московская область', null, 1)
GO
INSERT INTO [dbo].[Territories] (Id, Region, Capital, DistrictId) VALUES(71, N'Тульская область', N'Тула', 1)
GO
INSERT INTO [dbo].[Territories] (Id, Region, Capital, DistrictId) VALUES(40, N'Калужская область', N'Калуга', 1)
GO
SET IDENTITY_INSERT [dbo].[Territories] OFF
GO