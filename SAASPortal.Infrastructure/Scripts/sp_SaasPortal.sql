-- Get students by faculty
CREATE PROCEDURE sp_GetStudentsByFaculty
    @FacultyId NVARCHAR(450)
AS
BEGIN
    SELECT u.Id, u.FirstName, u.LastName, u.Email, c.CourseName
    FROM Users u
    JOIN Enrollments e ON u.Id = e.StudentId
    JOIN Courses c ON e.CourseId = c.CourseId
    WHERE c.FacultyId = @FacultyId
    AND u.Discriminator = 'Student'
END

-- Create assignment
CREATE PROCEDURE sp_CreateAssignment
    @CourseId INT,
    @Title NVARCHAR(200),
    @Description NVARCHAR(MAX),
    @DueDate DATETIME,
    @FilePath NVARCHAR(255)
AS
BEGIN
    INSERT INTO Assignments (CourseId, Title, Description, DueDate, FilePath)
    VALUES (@CourseId, @Title, @Description, @DueDate, @FilePath)
    
    SELECT SCOPE_IDENTITY() AS AssignmentId
END

-- Submit assignment
CREATE PROCEDURE sp_SubmitAssignment
    @AssignmentId INT,
    @StudentId NVARCHAR(450),
    @FilePath NVARCHAR(255)
AS
BEGIN
    DECLARE @DueDate DATETIME
    SELECT @DueDate = DueDate FROM Assignments WHERE AssignmentId = @AssignmentId
    
    INSERT INTO Submissions (AssignmentId, StudentId, FilePath, LateSubmission)
    VALUES (@AssignmentId, @StudentId, @FilePath, 
           CASE WHEN GETDATE() > @DueDate THEN 1 ELSE 0 END)
    
    SELECT SCOPE_IDENTITY() AS SubmissionId
END