CREATE PROCEDURE [dbo].[spInsertFaculty]
	@JsonData NVARCHAR(MAX)
AS
BEGIN

    INSERT INTO Faculty (FacultyGlobalIdentity, FacultyName)
    SELECT FacultyGlobalIdentity, FacultyName
    FROM OPENJSON(@JsonData)
    WITH (
        FacultyGlobalIdentity NVARCHAR(50),
        FacultyName NVARCHAR(50)
    )
END