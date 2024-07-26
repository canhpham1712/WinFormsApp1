select * from Students

GO
CREATE PROCEDURE UpdateStudent
    @Name NVARCHAR(100),
    @DateOfBirth DATE,
    @Gender NVARCHAR(10),
    @Nation NVARCHAR(50) = NULL,
    @City NVARCHAR(50) = NULL,
    @District NVARCHAR(50) = NULL,
    @Commune NVARCHAR(50) = NULL,
    @Street NVARCHAR(255) = NULL
AS
BEGIN
    UPDATE Students
    SET Name = @Name,
        DateOfBirth = @DateOfBirth,
        Gender = @Gender,
        Nation = @Nation,
        City = @City,
        District = @District,
        Commune = @Commune,
        Street = @Street
    WHERE StudentID = @StudentID;
END

GO
