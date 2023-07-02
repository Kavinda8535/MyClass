USE MyClass
GO

IF NOT EXISTS
(
SELECT name
FROM sys.tables
WHERE name=N'ClassAvailabilityChecks'
)

BEGIN
CREATE TABLE ClassAvailabilityChecks (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    CourseId INT,
    TeacherId INT,
    ClassDateTime DATETIME,
    CONSTRAINT FK_ClassAvailabilityCheck_Course FOREIGN KEY (CourseId) REFERENCES Courses(Id),
    CONSTRAINT FK_ClassAvailabilityCheck_Teacher FOREIGN KEY (TeacherId) REFERENCES Teachers(Id)
);
END
GO