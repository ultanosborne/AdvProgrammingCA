CREATE TABLE [dbo].[Table]
(
	StudentNumber INT NOT NULL PRIMARY KEY,
	FirstName VARCHAR(20),
	LastName VARCHAR(20),
	Email VARCHAR(50),
	Phone VARCHAR(10),
	AddressLine1 VARCHAR(50),
	AddressLine2 VARCHAR(50),
	City VARCHAR(20),
	Country VARCHAR(50),
	GradLevel BIT,
	Course VARCHAR(20)


)
