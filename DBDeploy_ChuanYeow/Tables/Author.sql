﻿CREATE TABLE [dbo].[Author]
(
	[AuthorID] INT PRIMARY KEY,
	[AuthorFirstName] VARCHAR(20) NOT NULL,
	[AuthorLastName] VARCHAR(20) NOT NULL,
	[AuthorTFN] INT NOT NULL,
	[ISBN] VARCHAR(30) NOT NULL,
)
