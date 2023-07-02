USE MyClass
GO

IF NOT EXISTS
(
SELECT name
FROM sys.tables
WHERE name=N'Teachers'
)
BEGIN
CREATE TABLE Teachers (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Email VARCHAR(100),
    Phone VARCHAR(20)
);
END
GO