ALTER TABLE [DACITASXPSQL].[dbo].[Datos de los colores en citas] ADD NombreColor nvarchar(20)

GO

UPDATE [DACITASXPSQL].[dbo].[Datos de los colores en citas] SET NombreColor = 'Green' WHERE CodColor = '001'
UPDATE [DACITASXPSQL].[dbo].[Datos de los colores en citas] SET NombreColor = 'Blue' WHERE CodColor = '002'
UPDATE [DACITASXPSQL].[dbo].[Datos de los colores en citas] SET NombreColor = 'Coral' WHERE CodColor = '003'
UPDATE [DACITASXPSQL].[dbo].[Datos de los colores en citas] SET NombreColor = 'Red' WHERE CodColor = '004'
UPDATE [DACITASXPSQL].[dbo].[Datos de los colores en citas] SET NombreColor = 'White' WHERE CodColor = '005'
UPDATE [DACITASXPSQL].[dbo].[Datos de los colores en citas] SET NombreColor = 'Yellow' WHERE CodColor = '006'
UPDATE [DACITASXPSQL].[dbo].[Datos de los colores en citas] SET NombreColor = 'DeepSkyBlue' WHERE CodColor = '007'


