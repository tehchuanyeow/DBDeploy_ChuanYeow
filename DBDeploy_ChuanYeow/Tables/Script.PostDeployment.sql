/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

IF '$(LoadTestData)' = 'true'

BEGIN

DELETE FROM Book;
DELETE FROM BookTransaction;
DELETE FROM Students;
DELETE FROM Author;

INSERT INTO BookTransaction (BorrowingCard) VALUES
('borrowed');

INSERT INTO Book (ISBN, Title, YearPublished) VALUES
(978-3-16-148410-0, 'Relationships with Databases, the ins and outs', 1970),
(978-3-16-148410-1, 'Normalisation, how to make a database geek fit in.', 1973),
(978-3-16-148410-2, 'TCP/IP, the protocol for the masses.', 1983),
(978-3-16-148410-3, 'The Man, the Bombe, and the Enigma', 1940);

INSERT INTO Author (AuthorID, AuthorFirstName, AuthorLastName, AuthorTFN, ISBN) VALUES
(32567, 'Edgar', 'Codd', 150111222, 978-3-16-148410-0),
(76543, 'Vinton', 'Cerf', 150222333, 978-3-16-148410-2),
(12345, 'Alan', 'Turing', 150222444, 978-3-16-148410-3);

INSERT INTO Students (StudentID, FName, LName, Email, Mobile, BorrowingCard, AuthorID) VALUES
('S12345678', 'Fred', 'Flintstone', '12345678@student.swin.edu.au', 0400555111, 'borrowed', 32567),
('S23456789', 'Barney', 'Rubble', '23456789@student.swin.edu.au', 0400555222, 'borrowed', 76543),
('S34567890', 'Bam-Bam', 'Rubble', '34567890@student.swin.edu.au', 0400555333, 'borrowed', 12345);

END;