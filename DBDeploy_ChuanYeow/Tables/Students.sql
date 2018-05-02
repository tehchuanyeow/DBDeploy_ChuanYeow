CREATE TABLE [dbo].[Students]
(
	[StudentID] NVARCHAR(10) NOT NULL PRIMARY KEY,
	[FName] VARCHAR(20) NOT NULL,
	[LName] VARCHAR(20) NOT NULL,
	[Email] VARCHAR(50) NOT NULL,
	[Mobile] INT NOT NULL,
	[BorrowingCard] NVARCHAR(20) NOT NULL,
	[AuthorID] INT NOT NULL,
	CONSTRAINT [FK_BorrowingCard] FOREIGN KEY (BorrowingCard) REFERENCES BookTransaction(BorrowingCard),
	CONSTRAINT [FK_AuthorID] FOREIGN KEY (AuthorID) REFERENCES Author(AuthorID)
)
