﻿CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Wins] INT NOT NULL DEFAULT 0, 
    [Losses] INT NOT NULL DEFAULT 0, 
    [Draws] INT NOT NULL DEFAULT 0
)
