
CREATE TABLE Users (
    Id NVARCHAR(450) PRIMARY KEY,
    UserName NVARCHAR(256),
    Email NVARCHAR(256),
    FirstName NVARCHAR(100),
    LastName NVARCHAR(100),
    Discriminator NVARCHAR(100) -- 'Student' or 'Faculty'
);

-- Courses table
CREATE TABLE Courses (
    CourseId INT PRIMARY KEY IDENTITY,
    CourseName NVARCHAR(100) NOT NULL,
    CourseCode NVARCHAR(20) NOT NULL,
    FacultyId NVARCHAR(450) FOREIGN KEY REFERENCES Users(Id)
);

-- Enrollments
CREATE TABLE Enrollments (
    EnrollmentId INT PRIMARY KEY IDENTITY,
    StudentId NVARCHAR(450) FOREIGN KEY REFERENCES Users(Id),
    CourseId INT FOREIGN KEY REFERENCES Courses(CourseId),
    EnrollmentDate DATETIME NOT NULL DEFAULT GETDATE()
);

-- Assignments
CREATE TABLE Assignments (
    AssignmentId INT PRIMARY KEY IDENTITY,
    CourseId INT FOREIGN KEY REFERENCES Courses(CourseId),
    Title NVARCHAR(200) NOT NULL,
    Description NVARCHAR(MAX),
    DueDate DATETIME NOT NULL,
    FilePath NVARCHAR(255),
    CreatedDate DATETIME NOT NULL DEFAULT GETDATE()
);

-- Submissions
CREATE TABLE Submissions (
    SubmissionId INT PRIMARY KEY IDENTITY,
    AssignmentId INT FOREIGN KEY REFERENCES Assignments(AssignmentId),
    StudentId NVARCHAR(450) FOREIGN KEY REFERENCES Users(Id),
    FilePath NVARCHAR(255) NOT NULL,
    SubmissionDate DATETIME NOT NULL DEFAULT GETDATE(),
    LateSubmission BIT NOT NULL DEFAULT 0
);

-- Assessment Criteria
CREATE TABLE AssessmentCriteria (
    CriteriaId INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100) NOT NULL,
    Description NVARCHAR(255),
    MaxScore INT NOT NULL DEFAULT 10
);

-- Assessments
CREATE TABLE Assessments (
    AssessmentId INT PRIMARY KEY IDENTITY,
    SubmissionId INT FOREIGN KEY REFERENCES Submissions(SubmissionId),
    FacultyId NVARCHAR(450) FOREIGN KEY REFERENCES Users(Id),
    Feedback NVARCHAR(MAX),
    AssessmentDate DATETIME NOT NULL DEFAULT GETDATE()
);

-- Assessment Scores
CREATE TABLE AssessmentScores (
    ScoreId INT PRIMARY KEY IDENTITY,
    AssessmentId INT FOREIGN KEY REFERENCES Assessments(AssessmentId),
    CriteriaId INT FOREIGN KEY REFERENCES AssessmentCriteria(CriteriaId),
    Score INT NOT NULL,
    Remarks NVARCHAR(255)
);