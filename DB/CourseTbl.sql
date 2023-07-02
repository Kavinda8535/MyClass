USE MyClass
GO

IF NOT EXISTS
(
SELECT name
FROM sys.tables
WHERE name=N'Courses'
)

BEGIN
CREATE TABLE Courses (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    CourseName VARCHAR(100) NOT NULL,
    CourseDescription VARCHAR(255),
    TeacherId INT,
    CONSTRAINT FK_Course_Teacher FOREIGN KEY (TeacherId) REFERENCES Teachers(Id)
);
END
GO