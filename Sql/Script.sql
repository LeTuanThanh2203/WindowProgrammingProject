-- ============================================================
-- DATABASE: DataUser
-- PURPOSE : Student Course Registration System
-- PLATFORM: SQL Server
-- VERSION : Fixed — all review issues addressed
-- ============================================================

-- ============================================================
-- SECTION 1: CREATE DATABASE
-- ============================================================

IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'DataUser')
BEGIN
    CREATE DATABASE DataUser;
END
GO

USE DataUser;
GO

-- ============================================================
-- SECTION 2: DROP ALL FOREIGN KEYS FIRST
-- ============================================================

DECLARE @sql NVARCHAR(MAX) = N'';
SELECT @sql += N'ALTER TABLE ' + QUOTENAME(OBJECT_SCHEMA_NAME(parent_object_id))
             + N'.' + QUOTENAME(OBJECT_NAME(parent_object_id))
             + N' DROP CONSTRAINT ' + QUOTENAME(name) + N';' + CHAR(13)
FROM sys.foreign_keys;
IF LEN(@sql) > 0 EXEC sp_executesql @sql;
GO

-- ============================================================
-- SECTION 3: DROP TRIGGERS
-- ============================================================

IF OBJECT_ID('TR_Score_Update',             'TR') IS NOT NULL DROP TRIGGER TR_Score_Update;
IF OBJECT_ID('TR_CheckDuplicate',           'TR') IS NOT NULL DROP TRIGGER TR_CheckDuplicate;
IF OBJECT_ID('TR_CheckCapacity',            'TR') IS NOT NULL DROP TRIGGER TR_CheckCapacity;
IF OBJECT_ID('TR_DKMH_Delete',              'TR') IS NOT NULL DROP TRIGGER TR_DKMH_Delete;
IF OBJECT_ID('TR_DKMH_Insert',              'TR') IS NOT NULL DROP TRIGGER TR_DKMH_Insert;
IF OBJECT_ID('TR_Course_CheckPeriods',      'TR') IS NOT NULL DROP TRIGGER TR_Course_CheckPeriods;
IF OBJECT_ID('TR_Course_CheckPrerequisite', 'TR') IS NOT NULL DROP TRIGGER TR_Course_CheckPrerequisite;
GO

-- ============================================================
-- SECTION 4: DROP VIEWS
-- ============================================================

IF OBJECT_ID('vw_StudentTranscript',   'V') IS NOT NULL DROP VIEW vw_StudentTranscript;
IF OBJECT_ID('vw_ClassList',           'V') IS NOT NULL DROP VIEW vw_ClassList;
IF OBJECT_ID('vw_TeacherAssignment',   'V') IS NOT NULL DROP VIEW vw_TeacherAssignment;
IF OBJECT_ID('vw_StudentRegistration', 'V') IS NOT NULL DROP VIEW vw_StudentRegistration;
IF OBJECT_ID('vw_Course',              'V') IS NOT NULL DROP VIEW vw_Course;
IF OBJECT_ID('vw_CourseDetail',        'V') IS NOT NULL DROP VIEW vw_CourseDetail;
IF OBJECT_ID('vw_ScoreDetail',         'V') IS NOT NULL DROP VIEW vw_ScoreDetail;
IF OBJECT_ID('vw_HRClass',             'V') IS NOT NULL DROP VIEW vw_HRClass;
GO

-- ============================================================
-- SECTION 5: DROP FUNCTIONS
-- ============================================================

IF OBJECT_ID('fn_GetGPA',                 'FN') IS NOT NULL DROP FUNCTION fn_GetGPA;
IF OBJECT_ID('fn_CountRegisteredCourses', 'FN') IS NOT NULL DROP FUNCTION fn_CountRegisteredCourses;
IF OBJECT_ID('fn_GetTotalCredits',        'FN') IS NOT NULL DROP FUNCTION fn_GetTotalCredits;
GO

-- ============================================================
-- SECTION 6: DROP STORED PROCEDURES
-- ============================================================

IF OBJECT_ID('sp_Student_Insert',        'P') IS NOT NULL DROP PROCEDURE sp_Student_Insert;
IF OBJECT_ID('sp_Student_Update',        'P') IS NOT NULL DROP PROCEDURE sp_Student_Update;
IF OBJECT_ID('sp_Student_Delete',        'P') IS NOT NULL DROP PROCEDURE sp_Student_Delete;
IF OBJECT_ID('sp_Student_GetAll',        'P') IS NOT NULL DROP PROCEDURE sp_Student_GetAll;
IF OBJECT_ID('sp_Student_Search',        'P') IS NOT NULL DROP PROCEDURE sp_Student_Search;
IF OBJECT_ID('sp_Course_Insert',         'P') IS NOT NULL DROP PROCEDURE sp_Course_Insert;
IF OBJECT_ID('sp_Course_Update',         'P') IS NOT NULL DROP PROCEDURE sp_Course_Update;
IF OBJECT_ID('sp_Course_Delete',         'P') IS NOT NULL DROP PROCEDURE sp_Course_Delete;
IF OBJECT_ID('sp_Course_GetAll',         'P') IS NOT NULL DROP PROCEDURE sp_Course_GetAll;
IF OBJECT_ID('sp_Class_Insert',          'P') IS NOT NULL DROP PROCEDURE sp_Class_Insert;
IF OBJECT_ID('sp_Class_Update',          'P') IS NOT NULL DROP PROCEDURE sp_Class_Update;
IF OBJECT_ID('sp_Class_Delete',          'P') IS NOT NULL DROP PROCEDURE sp_Class_Delete;
IF OBJECT_ID('sp_Class_GetAll',          'P') IS NOT NULL DROP PROCEDURE sp_Class_GetAll;
IF OBJECT_ID('sp_HR_Insert',             'P') IS NOT NULL DROP PROCEDURE sp_HR_Insert;
IF OBJECT_ID('sp_HR_Update',             'P') IS NOT NULL DROP PROCEDURE sp_HR_Update;
IF OBJECT_ID('sp_HR_Delete',             'P') IS NOT NULL DROP PROCEDURE sp_HR_Delete;
IF OBJECT_ID('sp_HR_GetAll',             'P') IS NOT NULL DROP PROCEDURE sp_HR_GetAll;
IF OBJECT_ID('sp_Groups_Insert',         'P') IS NOT NULL DROP PROCEDURE sp_Groups_Insert;
IF OBJECT_ID('sp_Groups_Update',         'P') IS NOT NULL DROP PROCEDURE sp_Groups_Update;
IF OBJECT_ID('sp_Groups_Delete',         'P') IS NOT NULL DROP PROCEDURE sp_Groups_Delete;
IF OBJECT_ID('sp_Groups_GetAll',         'P') IS NOT NULL DROP PROCEDURE sp_Groups_GetAll;
IF OBJECT_ID('sp_Assign_Teacher',        'P') IS NOT NULL DROP PROCEDURE sp_Assign_Teacher;
IF OBJECT_ID('sp_Assign_Delete',         'P') IS NOT NULL DROP PROCEDURE sp_Assign_Delete;
IF OBJECT_ID('sp_Assign_GetAll',         'P') IS NOT NULL DROP PROCEDURE sp_Assign_GetAll;
IF OBJECT_ID('sp_Registration_Register', 'P') IS NOT NULL DROP PROCEDURE sp_Registration_Register;
IF OBJECT_ID('sp_Registration_Cancel',   'P') IS NOT NULL DROP PROCEDURE sp_Registration_Cancel;
IF OBJECT_ID('sp_Score_Update',          'P') IS NOT NULL DROP PROCEDURE sp_Score_Update;
IF OBJECT_ID('sp_Score_GetTranscript',   'P') IS NOT NULL DROP PROCEDURE sp_Score_GetTranscript;
GO

-- ============================================================
-- SECTION 7: DROP TABLES (children before parents)
-- ============================================================

IF OBJECT_ID('Score',    'U') IS NOT NULL DROP TABLE Score;
IF OBJECT_ID('DKMH',     'U') IS NOT NULL DROP TABLE DKMH;
IF OBJECT_ID('Assign',   'U') IS NOT NULL DROP TABLE Assign;
IF OBJECT_ID('Class',    'U') IS NOT NULL DROP TABLE Class;
IF OBJECT_ID('Course',   'U') IS NOT NULL DROP TABLE Course;
IF OBJECT_ID('Student',  'U') IS NOT NULL DROP TABLE Student;
IF OBJECT_ID('HR',       'U') IS NOT NULL DROP TABLE HR;
IF OBJECT_ID('[Groups]', 'U') IS NOT NULL DROP TABLE [Groups];
GO

-- ============================================================
-- SECTION 8: CREATE TABLES
-- ============================================================

-- ----------------------------------------------------------
-- Table: Student
-- ----------------------------------------------------------
CREATE TABLE dbo.Student
(
    ID          VARCHAR(20)    NOT NULL  CONSTRAINT PK_Student PRIMARY KEY,
    FirstName   NVARCHAR(100)  NOT NULL,
    LastName    NVARCHAR(50)   NOT NULL,
    Dob         DATE           NULL,
    Gender      NVARCHAR(10)   NOT NULL,
    Phone       VARCHAR(20)    NULL,
    Email       VARCHAR(100)   NULL,
    Address     NVARCHAR(255)  NULL,
    Picture     VARBINARY(MAX) NULL
);
GO

-- ----------------------------------------------------------
-- Table: Course
-- ----------------------------------------------------------
CREATE TABLE dbo.Course
(
    CourseID         VARCHAR(20)    NOT NULL  CONSTRAINT PK_Course PRIMARY KEY,
    CourseName       NVARCHAR(200)  NOT NULL,
    Credits          INT            NOT NULL,
    TotalPeriods     INT            NOT NULL,
    TheoryPeriods    INT            NOT NULL,
    PracticePeriods  INT            NOT NULL,
    PrerequisiteID   VARCHAR(20)    NULL,
    IsRequired       BIT            NOT NULL  CONSTRAINT DF_Course_IsRequired DEFAULT 1,
    Description      NVARCHAR(500)  NULL
);
GO

-- ----------------------------------------------------------
-- Table: Class
-- ----------------------------------------------------------
CREATE TABLE dbo.Class
(
    ClassID         VARCHAR(20)    NOT NULL  CONSTRAINT PK_Class PRIMARY KEY,
    CourseID        VARCHAR(20)    NOT NULL,
    Semester        NVARCHAR(20)   NOT NULL,
    AcademicYear    VARCHAR(20)    NOT NULL,
    Capacity        INT            NOT NULL,
    CurrentStudents INT            NOT NULL  CONSTRAINT DF_Class_CurrentStudents DEFAULT 0,
    Room            NVARCHAR(50)   NULL,
    Schedule        NVARCHAR(200)  NULL
);
GO

-- ----------------------------------------------------------
-- Table: HR
-- ----------------------------------------------------------
CREATE TABLE dbo.HR
(
    ID          VARCHAR(20)    NOT NULL  CONSTRAINT PK_HR PRIMARY KEY,
    FirstName   NVARCHAR(100)  NOT NULL,
    LastName    NVARCHAR(50)   NOT NULL,
    Dob         DATE           NULL,
    Gender      NVARCHAR(10)   NOT NULL,
    Phone       VARCHAR(20)    NULL,
    Email       VARCHAR(100)   NULL,
    Address     NVARCHAR(255)  NULL,
    Picture     VARBINARY(MAX) NULL
);
GO

-- ----------------------------------------------------------
-- Table: Groups
-- ----------------------------------------------------------
CREATE TABLE dbo.[Groups]
(
    GroupID     VARCHAR(20)    NOT NULL  CONSTRAINT PK_Groups PRIMARY KEY,
    GroupName   NVARCHAR(100)  NOT NULL,
    Description NVARCHAR(MAX)  NULL
);
GO

-- ----------------------------------------------------------
-- Table: Assign
-- FIX: PK expanded to (ID, GroupID, ClassID) to allow
--      one HR to teach the same class from different groups
-- ----------------------------------------------------------
CREATE TABLE dbo.Assign
(
    ID         VARCHAR(20)  NOT NULL,
    GroupID    VARCHAR(20)  NOT NULL,
    ClassID    VARCHAR(20)  NOT NULL,
    AssignDate DATE         NOT NULL  CONSTRAINT DF_Assign_AssignDate DEFAULT (CAST(GETDATE() AS DATE)),
    CONSTRAINT PK_Assign PRIMARY KEY (ID, GroupID, ClassID)
);
GO

-- ----------------------------------------------------------
-- Table: DKMH (Course Registration)
-- ----------------------------------------------------------
CREATE TABLE dbo.DKMH
(
    ID           VARCHAR(20)  NOT NULL,
    ClassID      VARCHAR(20)  NOT NULL,
    RegisterDate DATE         NOT NULL  CONSTRAINT DF_DKMH_RegisterDate DEFAULT (CAST(GETDATE() AS DATE)),
    CONSTRAINT PK_DKMH PRIMARY KEY (ID, ClassID)
);
GO

-- ----------------------------------------------------------
-- Table: Score
-- FIX: LetterGrade now has explicit NULL + CHECK constraint
-- ----------------------------------------------------------
CREATE TABLE dbo.Score
(
    ID           VARCHAR(20)   NOT NULL,
    ClassID      VARCHAR(20)   NOT NULL,
    MidtermScore DECIMAL(4,2)  NULL,
    FinalScore   DECIMAL(4,2)  NULL,
    TotalScore   AS (CAST(
                     CASE
                         WHEN MidtermScore IS NULL OR FinalScore IS NULL THEN NULL
                         ELSE MidtermScore * 0.4 + FinalScore * 0.6
                     END AS DECIMAL(4,2))),
    LetterGrade  NVARCHAR(2)   NULL,
    Overview     NVARCHAR(20)  NULL,
    CONSTRAINT PK_Score PRIMARY KEY (ID, ClassID)
);
GO

-- ============================================================
-- SECTION 9: FOREIGN KEYS
-- ============================================================

ALTER TABLE dbo.Course  ADD CONSTRAINT FK_Course_Prerequisite FOREIGN KEY (PrerequisiteID) REFERENCES dbo.Course(CourseID);
ALTER TABLE dbo.Class   ADD CONSTRAINT FK_Class_Course        FOREIGN KEY (CourseID)        REFERENCES dbo.Course(CourseID);
ALTER TABLE dbo.Assign  ADD CONSTRAINT FK_Assign_HR           FOREIGN KEY (ID)              REFERENCES dbo.HR(ID);
ALTER TABLE dbo.Assign  ADD CONSTRAINT FK_Assign_Groups       FOREIGN KEY (GroupID)         REFERENCES dbo.[Groups](GroupID);
ALTER TABLE dbo.Assign  ADD CONSTRAINT FK_Assign_Class        FOREIGN KEY (ClassID)         REFERENCES dbo.Class(ClassID);
ALTER TABLE dbo.DKMH    ADD CONSTRAINT FK_DKMH_Student        FOREIGN KEY (ID)              REFERENCES dbo.Student(ID);
ALTER TABLE dbo.DKMH    ADD CONSTRAINT FK_DKMH_Class          FOREIGN KEY (ClassID)         REFERENCES dbo.Class(ClassID);
ALTER TABLE dbo.Score   ADD CONSTRAINT FK_Score_DKMH          FOREIGN KEY (ID, ClassID)     REFERENCES dbo.DKMH(ID, ClassID);
GO

-- ============================================================
-- SECTION 10: CHECK CONSTRAINTS
-- ============================================================

ALTER TABLE dbo.Student ADD CONSTRAINT CHK_Student_Gender  CHECK (Gender IN (N'Male', N'Female'));
ALTER TABLE dbo.Student ADD CONSTRAINT CHK_Student_Email   CHECK (Email  LIKE '%_@_%.__%');
ALTER TABLE dbo.HR      ADD CONSTRAINT CHK_HR_Gender       CHECK (Gender IN (N'Male', N'Female'));
ALTER TABLE dbo.HR      ADD CONSTRAINT CHK_HR_Email        CHECK (Email  LIKE '%_@_%.__%');
ALTER TABLE dbo.Course  ADD CONSTRAINT CHK_Course_Credits        CHECK (Credits > 0);
ALTER TABLE dbo.Course  ADD CONSTRAINT CHK_Course_TotalPeriods   CHECK (TotalPeriods > 0);
ALTER TABLE dbo.Course  ADD CONSTRAINT CHK_Course_TheoryPeriods  CHECK (TheoryPeriods >= 0);
ALTER TABLE dbo.Course  ADD CONSTRAINT CHK_Course_PracticePeriods CHECK (PracticePeriods >= 0);
ALTER TABLE dbo.Class   ADD CONSTRAINT CHK_Class_Capacity        CHECK (Capacity > 0);
ALTER TABLE dbo.Class   ADD CONSTRAINT CHK_Class_CurrentStudents CHECK (CurrentStudents >= 0);
ALTER TABLE dbo.Score   ADD CONSTRAINT CHK_Score_Midterm     CHECK (MidtermScore IS NULL OR (MidtermScore >= 0 AND MidtermScore <= 10));
ALTER TABLE dbo.Score   ADD CONSTRAINT CHK_Score_Final       CHECK (FinalScore   IS NULL OR (FinalScore   >= 0 AND FinalScore   <= 10));
-- FIX: LetterGrade CHECK constraint added
ALTER TABLE dbo.Score   ADD CONSTRAINT CHK_Score_LetterGrade CHECK (LetterGrade IS NULL OR LetterGrade IN ('A','B+','B','C+','C','D','F'));
ALTER TABLE dbo.Score   ADD CONSTRAINT CHK_Score_Overview    CHECK (Overview IS NULL OR Overview IN (N'Excellent', N'Good', N'Pass', N'Fail'));
GO

-- ============================================================
-- SECTION 11: UNIQUE CONSTRAINTS + NON-CLUSTERED INDEXES
-- ============================================================

ALTER TABLE dbo.Student ADD CONSTRAINT UQ_Student_Email UNIQUE (Email);
ALTER TABLE dbo.HR      ADD CONSTRAINT UQ_HR_Email      UNIQUE (Email);

CREATE NONCLUSTERED INDEX IX_Student_LastName  ON dbo.Student (LastName);
CREATE NONCLUSTERED INDEX IX_Student_Email     ON dbo.Student (Email);
CREATE NONCLUSTERED INDEX IX_Course_CourseName ON dbo.Course  (CourseName);
CREATE NONCLUSTERED INDEX IX_Class_CourseID    ON dbo.Class   (CourseID);
CREATE NONCLUSTERED INDEX IX_DKMH_ID           ON dbo.DKMH    (ID);
CREATE NONCLUSTERED INDEX IX_Score_ID          ON dbo.Score   (ID);
CREATE NONCLUSTERED INDEX IX_Assign_ID         ON dbo.Assign  (ID);
GO

-- ============================================================
-- SECTION 12: TRIGGERS
-- ============================================================

-- ----------------------------------------------------------
-- TR_CheckDuplicate
-- INSTEAD OF INSERT: blocks duplicate and over-capacity
-- ----------------------------------------------------------
CREATE TRIGGER TR_CheckDuplicate
ON dbo.DKMH
INSTEAD OF INSERT
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (
        SELECT 1 FROM inserted i
        INNER JOIN dbo.DKMH d ON d.ID = i.ID AND d.ClassID = i.ClassID
    )
    BEGIN
        RAISERROR(N'Duplicate registration: student is already enrolled in this class.', 16, 1);
        RETURN;
    END

    IF EXISTS (
        SELECT 1 FROM inserted i
        INNER JOIN dbo.Class c ON c.ClassID = i.ClassID
        WHERE c.CurrentStudents >= c.Capacity
    )
    BEGIN
        RAISERROR(N'Class is full: registration rejected because capacity has been reached.', 16, 1);
        RETURN;
    END

    INSERT INTO dbo.DKMH (ID, ClassID, RegisterDate)
    SELECT ID, ClassID, RegisterDate FROM inserted;
END
GO

-- ----------------------------------------------------------
-- TR_DKMH_Insert
-- AFTER INSERT: creates blank Score row + increments seat count
-- ----------------------------------------------------------
CREATE TRIGGER TR_DKMH_Insert
ON dbo.DKMH
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO dbo.Score (ID, ClassID, MidtermScore, FinalScore, LetterGrade, Overview)
    SELECT i.ID, i.ClassID, NULL, NULL, NULL, NULL
    FROM inserted i
    WHERE NOT EXISTS (
        SELECT 1 FROM dbo.Score s
        WHERE s.ID = i.ID AND s.ClassID = i.ClassID
    );

    UPDATE c
    SET c.CurrentStudents = c.CurrentStudents + t.TotalInserted
    FROM dbo.Class c
    JOIN (
        SELECT ClassID, COUNT(*) AS TotalInserted
        FROM inserted
        GROUP BY ClassID
    ) t ON c.ClassID = t.ClassID;
END
GO

-- ----------------------------------------------------------
-- TR_CheckCapacity
-- AFTER INSERT: secondary capacity guard (runs LAST)
-- ----------------------------------------------------------
CREATE TRIGGER TR_CheckCapacity
ON dbo.DKMH
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (
        SELECT 1 FROM inserted i
        INNER JOIN dbo.Class c ON c.ClassID = i.ClassID
        WHERE (SELECT COUNT(*) FROM dbo.DKMH d WHERE d.ClassID = c.ClassID) > c.Capacity
    )
    BEGIN
        ROLLBACK TRANSACTION;
        RAISERROR(N'Class capacity exceeded. Registration rolled back.', 16, 1);
        RETURN;
    END
END
GO

-- Ensure TR_CheckCapacity runs AFTER TR_DKMH_Insert
EXEC sp_settriggerorder
    @triggername = 'TR_CheckCapacity',
    @order       = 'Last',
    @stmttype    = 'INSERT';
GO

-- ----------------------------------------------------------
-- TR_DKMH_Delete
-- FIX: uses COUNT(*) GROUP BY to handle batch deletes correctly
-- ----------------------------------------------------------
CREATE TRIGGER TR_DKMH_Delete
ON dbo.DKMH
AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DELETE s
    FROM   dbo.Score s
    INNER JOIN deleted d ON d.ID = s.ID AND d.ClassID = s.ClassID;

    UPDATE c
    SET c.CurrentStudents = c.CurrentStudents - t.TotalDeleted
    FROM dbo.Class c
    JOIN (
        SELECT ClassID, COUNT(*) AS TotalDeleted
        FROM deleted
        GROUP BY ClassID
    ) t ON c.ClassID = t.ClassID;
END
GO

-- ----------------------------------------------------------
-- TR_Course_CheckPeriods
-- FIX: ROLLBACK before RAISERROR (consistent with best practice)
-- ----------------------------------------------------------
CREATE TRIGGER TR_Course_CheckPeriods
ON dbo.Course
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (
        SELECT 1 FROM inserted
        WHERE TheoryPeriods + PracticePeriods <> TotalPeriods
    )
    BEGIN
        ROLLBACK TRANSACTION;
        RAISERROR(N'Tổng số tiết phải bằng Tiết lý thuyết + Tiết thực hành.', 16, 1);
        RETURN;
    END
END
GO

-- ----------------------------------------------------------
-- TR_Course_CheckPrerequisite
-- FIX: ROLLBACK before RAISERROR in both branches
-- ----------------------------------------------------------
CREATE TRIGGER TR_Course_CheckPrerequisite
ON dbo.Course
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (
        SELECT 1 FROM inserted
        WHERE CourseID = PrerequisiteID
          AND PrerequisiteID IS NOT NULL
    )
    BEGIN
        ROLLBACK TRANSACTION;
        RAISERROR(N'Một môn không thể là tiên quyết của chính nó.', 16, 1);
        RETURN;
    END

    IF EXISTS (
        SELECT 1 FROM inserted i
        JOIN dbo.Course c ON i.PrerequisiteID = c.CourseID
        WHERE c.PrerequisiteID = i.CourseID
          AND i.PrerequisiteID IS NOT NULL
    )
    BEGIN
        ROLLBACK TRANSACTION;
        RAISERROR(N'Không được tạo vòng lặp môn tiên quyết.', 16, 1);
        RETURN;
    END
END
GO

-- ----------------------------------------------------------
-- TR_Score_Update
-- FIX: reads TotalScore from computed column instead of
--      re-computing the formula — single source of truth
-- ----------------------------------------------------------
CREATE TRIGGER TR_Score_Update
ON dbo.Score
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;
 
    IF NOT (UPDATE(MidtermScore) OR UPDATE(FinalScore))
        RETURN;
 
    UPDATE s
    SET
        -- Thang LetterGrade (A/B+/B/C+/C/D/F)
        LetterGrade =
            CASE
                WHEN s.TotalScore >= 8.5 THEN 'A'
                WHEN s.TotalScore >= 8.0 THEN 'B+'
                WHEN s.TotalScore >= 7.0 THEN 'B'
                WHEN s.TotalScore >= 6.5 THEN 'C+'
                WHEN s.TotalScore >= 5.5 THEN 'C'
                WHEN s.TotalScore >= 5.0 THEN 'D'
                ELSE                          'F'
            END,
 
        -- Overview: phải khớp CHK_Score_Overview
        -- 'Excellent' | 'Good' | 'Pass' | 'Fail'
        Overview =
            CASE
                WHEN s.TotalScore >= 8.5 THEN N'Excellent'   -- A
                WHEN s.TotalScore >= 7.0 THEN N'Good'        -- B+, B
                WHEN s.TotalScore >= 5.0 THEN N'Pass'        -- C+, C, D
                ELSE                          N'Fail'        -- F
            END
 
    FROM dbo.Score s
    JOIN inserted i ON s.ID = i.ID AND s.ClassID = i.ClassID
    WHERE s.TotalScore IS NOT NULL;
END
GO
 
-- ============================================================
-- SECTION 13: FUNCTIONS
-- ============================================================

-- ----------------------------------------------------------
-- fn_GetGPA
-- FIX: credit-weighted average instead of plain AVG
-- ----------------------------------------------------------
CREATE FUNCTION dbo.fn_GetGPA (@StudentID VARCHAR(20))
RETURNS DECIMAL(4,2)
AS
BEGIN
    DECLARE @GPA DECIMAL(4,2);

    SELECT @GPA = SUM(s.TotalScore * co.Credits) / NULLIF(SUM(co.Credits), 0)
    FROM dbo.Score s
    JOIN dbo.DKMH    d  ON d.ID = s.ID AND d.ClassID = s.ClassID
    JOIN dbo.Class   cl ON cl.ClassID  = s.ClassID
    JOIN dbo.Course  co ON co.CourseID = cl.CourseID
    WHERE s.ID = @StudentID AND s.TotalScore IS NOT NULL;

    RETURN ISNULL(@GPA, 0);
END
GO

-- ----------------------------------------------------------
-- fn_CountRegisteredCourses
-- ----------------------------------------------------------
CREATE FUNCTION dbo.fn_CountRegisteredCourses (@StudentID VARCHAR(20))
RETURNS INT
AS
BEGIN
    DECLARE @Count INT;
    SELECT @Count = COUNT(*) FROM dbo.DKMH WHERE ID = @StudentID;
    RETURN ISNULL(@Count, 0);
END
GO

-- ----------------------------------------------------------
-- fn_GetTotalCredits
-- ----------------------------------------------------------
CREATE FUNCTION dbo.fn_GetTotalCredits (@StudentID VARCHAR(20))
RETURNS INT
AS
BEGIN
    DECLARE @Total INT;
    SELECT @Total = SUM(co.Credits)
    FROM dbo.DKMH    d
    INNER JOIN dbo.Class   cl ON cl.ClassID  = d.ClassID
    INNER JOIN dbo.Course  co ON co.CourseID = cl.CourseID
    WHERE d.ID = @StudentID;
    RETURN ISNULL(@Total, 0);
END
GO

-- ============================================================
-- SECTION 14: STORED PROCEDURES
-- ============================================================

-- ── Student ───────────────────────────────────────────────

CREATE PROCEDURE dbo.sp_Student_Insert
    @ID        VARCHAR(20),
    @FirstName NVARCHAR(100),
    @LastName  NVARCHAR(50),
    @Dob       DATE           = NULL,
    @Gender    NVARCHAR(10),
    @Phone     VARCHAR(20)    = NULL,
    @Email     VARCHAR(100)   = NULL,
    @Address   NVARCHAR(255)  = NULL,
    @Picture   VARBINARY(MAX) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO dbo.Student (ID, FirstName, LastName, Dob, Gender, Phone, Email, Address, Picture)
    VALUES (@ID, @FirstName, @LastName, @Dob, @Gender, @Phone, @Email, @Address, @Picture);
END
GO

CREATE PROCEDURE dbo.sp_Student_Update
    @ID        VARCHAR(20),
    @FirstName NVARCHAR(100),
    @LastName  NVARCHAR(50),
    @Dob       DATE           = NULL,
    @Gender    NVARCHAR(10),
    @Phone     VARCHAR(20)    = NULL,
    @Email     VARCHAR(100)   = NULL,
    @Address   NVARCHAR(255)  = NULL,
    @Picture   VARBINARY(MAX) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE dbo.Student
    SET FirstName = @FirstName, LastName = @LastName, Dob = @Dob,
        Gender = @Gender, Phone = @Phone, Email = @Email,
        Address = @Address, Picture = @Picture
    WHERE ID = @ID;
END
GO

CREATE PROCEDURE dbo.sp_Student_Delete
    @ID VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM dbo.Student WHERE ID = @ID;
END
GO

CREATE PROCEDURE dbo.sp_Student_GetAll
AS
BEGIN
    SET NOCOUNT ON;
    SELECT ID, FirstName, LastName, Dob, Gender, Phone, Email, Address
    FROM dbo.Student
    ORDER BY ID;
END
GO

CREATE PROCEDURE dbo.sp_Student_Search
    @Keyword NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT ID, FirstName, LastName, Dob, Gender, Phone, Email, Address
    FROM dbo.Student
    WHERE ID        LIKE '%' + @Keyword + '%'
       OR FirstName LIKE '%' + @Keyword + '%'
       OR LastName  LIKE '%' + @Keyword + '%'
       OR Phone     LIKE '%' + @Keyword + '%'
       OR Email     LIKE '%' + @Keyword + '%'
       OR Address   LIKE '%' + @Keyword + '%'
    ORDER BY ID;
END
GO

-- ── Course ────────────────────────────────────────────────

CREATE PROCEDURE dbo.sp_Course_Insert
    @CourseID        VARCHAR(20),
    @CourseName      NVARCHAR(200),
    @Credits         INT,
    @TotalPeriods    INT,
    @TheoryPeriods   INT,
    @PracticePeriods INT,
    @PrerequisiteID  VARCHAR(20)   = NULL,
    @IsRequired      BIT           = 1,
    @Description     NVARCHAR(500) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO dbo.Course (CourseID, CourseName, Credits, TotalPeriods, TheoryPeriods,
                            PracticePeriods, PrerequisiteID, IsRequired, Description)
    VALUES (@CourseID, @CourseName, @Credits, @TotalPeriods, @TheoryPeriods,
            @PracticePeriods, @PrerequisiteID, @IsRequired, @Description);
END
GO

CREATE PROCEDURE dbo.sp_Course_Update
    @CourseID        VARCHAR(20),
    @CourseName      NVARCHAR(200),
    @Credits         INT,
    @TotalPeriods    INT,
    @TheoryPeriods   INT,
    @PracticePeriods INT,
    @PrerequisiteID  VARCHAR(20)   = NULL,
    @IsRequired      BIT           = 1,
    @Description     NVARCHAR(500) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE dbo.Course
    SET CourseName      = @CourseName,
        Credits         = @Credits,
        TotalPeriods    = @TotalPeriods,
        TheoryPeriods   = @TheoryPeriods,
        PracticePeriods = @PracticePeriods,
        PrerequisiteID  = @PrerequisiteID,
        IsRequired      = @IsRequired,
        Description     = @Description
    WHERE CourseID = @CourseID;
END
GO

CREATE PROCEDURE dbo.sp_Course_Delete
    @CourseID VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM dbo.Course WHERE CourseID = @CourseID;
END
GO

CREATE PROCEDURE dbo.sp_Course_GetAll
AS
BEGIN
    SET NOCOUNT ON;
    SELECT CourseID, CourseName, Credits, TotalPeriods, TheoryPeriods,
           PracticePeriods, PrerequisiteID, IsRequired, Description
    FROM dbo.Course
    ORDER BY CourseID;
END
GO

-- ── Class ────────────────────────────────────────────────

CREATE PROCEDURE dbo.sp_Class_Insert
    @ClassID        VARCHAR(20),
    @CourseID       VARCHAR(20),
    @Semester       NVARCHAR(20),
    @AcademicYear   VARCHAR(20),
    @Capacity       INT,
    @CurrentStudents INT          = 0,
    @Room           NVARCHAR(50)  = NULL,
    @Schedule       NVARCHAR(200) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO dbo.Class (ClassID, CourseID, Semester, AcademicYear,
                           Capacity, CurrentStudents, Room, Schedule)
    VALUES (@ClassID, @CourseID, @Semester, @AcademicYear,
            @Capacity, @CurrentStudents, @Room, @Schedule);
END
GO

CREATE PROCEDURE dbo.sp_Class_Update
    @ClassID      VARCHAR(20),
    @CourseID     VARCHAR(20),
    @Semester     NVARCHAR(20),
    @AcademicYear VARCHAR(20),
    @Capacity     INT,
    @Room         NVARCHAR(50)  = NULL,
    @Schedule     NVARCHAR(200) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE dbo.Class
    SET CourseID     = @CourseID,
        Semester     = @Semester,
        AcademicYear = @AcademicYear,
        Capacity     = @Capacity,
        Room         = @Room,
        Schedule     = @Schedule
    WHERE ClassID = @ClassID;
END
GO

CREATE PROCEDURE dbo.sp_Class_Delete
    @ClassID VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM dbo.Class WHERE ClassID = @ClassID;
END
GO

CREATE PROCEDURE dbo.sp_Class_GetAll
AS
BEGIN
    SET NOCOUNT ON;
    SELECT cl.ClassID, cl.CourseID, co.CourseName, co.Credits,
           cl.Semester, cl.AcademicYear, cl.Capacity, cl.CurrentStudents,
           cl.Room, cl.Schedule
    FROM dbo.Class   cl
    INNER JOIN dbo.Course co ON co.CourseID = cl.CourseID
    ORDER BY cl.ClassID;
END
GO

-- ── HR ───────────────────────────────────────────────────

CREATE PROCEDURE dbo.sp_HR_Insert
    @ID        VARCHAR(20),
    @FirstName NVARCHAR(100),
    @LastName  NVARCHAR(50),
    @Dob       DATE           = NULL,
    @Gender    NVARCHAR(10),
    @Phone     VARCHAR(20)    = NULL,
    @Email     VARCHAR(100)   = NULL,
    @Address   NVARCHAR(255)  = NULL,
    @Picture   VARBINARY(MAX) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO dbo.HR (ID, FirstName, LastName, Dob, Gender, Phone, Email, Address, Picture)
    VALUES (@ID, @FirstName, @LastName, @Dob, @Gender, @Phone, @Email, @Address, @Picture);
END
GO

CREATE PROCEDURE dbo.sp_HR_Update
    @ID        VARCHAR(20),
    @FirstName NVARCHAR(100),
    @LastName  NVARCHAR(50),
    @Dob       DATE           = NULL,
    @Gender    NVARCHAR(10),
    @Phone     VARCHAR(20)    = NULL,
    @Email     VARCHAR(100)   = NULL,
    @Address   NVARCHAR(255)  = NULL,
    @Picture   VARBINARY(MAX) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE dbo.HR
    SET FirstName = @FirstName, LastName = @LastName, Dob = @Dob,
        Gender = @Gender, Phone = @Phone, Email = @Email,
        Address = @Address, Picture = @Picture
    WHERE ID = @ID;
END
GO

CREATE PROCEDURE dbo.sp_HR_Delete
    @ID VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM dbo.HR WHERE ID = @ID;
END
GO

CREATE PROCEDURE dbo.sp_HR_GetAll
AS
BEGIN
    SET NOCOUNT ON;
    SELECT ID, FirstName, LastName, Dob, Gender, Phone, Email, Address
    FROM dbo.HR
    ORDER BY ID;
END
GO

-- ── Groups ───────────────────────────────────────────────

CREATE PROCEDURE dbo.sp_Groups_Insert
    @GroupID     VARCHAR(20),
    @GroupName   NVARCHAR(100),
    @Description NVARCHAR(MAX) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO dbo.[Groups] (GroupID, GroupName, Description)
    VALUES (@GroupID, @GroupName, @Description);
END
GO

CREATE PROCEDURE dbo.sp_Groups_Update
    @GroupID     VARCHAR(20),
    @GroupName   NVARCHAR(100),
    @Description NVARCHAR(MAX) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE dbo.[Groups]
    SET GroupName = @GroupName, Description = @Description
    WHERE GroupID = @GroupID;
END
GO

CREATE PROCEDURE dbo.sp_Groups_Delete
    @GroupID VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM dbo.[Groups] WHERE GroupID = @GroupID;
END
GO

CREATE PROCEDURE dbo.sp_Groups_GetAll
AS
BEGIN
    SET NOCOUNT ON;
    SELECT GroupID, GroupName, Description
    FROM dbo.[Groups]
    ORDER BY GroupID;
END
GO

-- ── Assign ───────────────────────────────────────────────

CREATE PROCEDURE dbo.sp_Assign_Teacher
    @ID         VARCHAR(20),
    @GroupID    VARCHAR(20),
    @ClassID    VARCHAR(20),
    @AssignDate DATE = NULL
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO dbo.Assign (ID, GroupID, ClassID, AssignDate)
    VALUES (@ID, @GroupID, @ClassID, ISNULL(@AssignDate, CAST(GETDATE() AS DATE)));
END
GO

CREATE PROCEDURE dbo.sp_Assign_Delete
    @ID      VARCHAR(20),
    @ClassID VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM dbo.Assign WHERE ID = @ID AND ClassID = @ClassID;
END
GO

CREATE PROCEDURE dbo.sp_Assign_GetAll
AS
BEGIN
    SET NOCOUNT ON;
    SELECT a.ID,
           h.FirstName + N' ' + h.LastName AS HRName,
           g.GroupName,
           a.ClassID,
           co.CourseName,
           cl.Semester,
           cl.AcademicYear,
           a.AssignDate
    FROM dbo.Assign   a
    INNER JOIN dbo.HR       h  ON h.ID       = a.ID
    INNER JOIN dbo.[Groups] g  ON g.GroupID  = a.GroupID
    INNER JOIN dbo.Class    cl ON cl.ClassID = a.ClassID
    INNER JOIN dbo.Course   co ON co.CourseID= cl.CourseID
    ORDER BY a.ID;
END
GO

-- ── Registration ─────────────────────────────────────────

CREATE PROCEDURE dbo.sp_Registration_Register
    @StudentID    VARCHAR(20),
    @ClassID      VARCHAR(20),
    @RegisterDate DATE = NULL
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO dbo.DKMH (ID, ClassID, RegisterDate)
    VALUES (@StudentID, @ClassID, ISNULL(@RegisterDate, CAST(GETDATE() AS DATE)));
END
GO

CREATE PROCEDURE dbo.sp_Registration_Cancel
    @StudentID VARCHAR(20),
    @ClassID   VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM dbo.DKMH WHERE ID = @StudentID AND ClassID = @ClassID;
END
GO

-- ── Score ────────────────────────────────────────────────

CREATE PROCEDURE dbo.sp_Score_Update
    @StudentID    VARCHAR(20),
    @ClassID      VARCHAR(20),
    @MidtermScore DECIMAL(4,2) = NULL,
    @FinalScore   DECIMAL(4,2) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE dbo.Score
    SET MidtermScore = @MidtermScore,
        FinalScore   = @FinalScore
    WHERE ID = @StudentID AND ClassID = @ClassID;
END
GO

CREATE PROCEDURE dbo.sp_Score_GetTranscript
    @StudentID VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT s.ID,
           st.FirstName + N' ' + st.LastName AS StudentName,
           co.CourseID,
           co.CourseName,
           co.Credits,
           cl.Semester,
           cl.AcademicYear,
           s.MidtermScore,
           s.FinalScore,
           s.TotalScore,
           s.LetterGrade,
           s.Overview
    FROM dbo.Score   s
    INNER JOIN dbo.DKMH    d  ON d.ID = s.ID AND d.ClassID = s.ClassID
    INNER JOIN dbo.Student st ON st.ID      = s.ID
    INNER JOIN dbo.Class   cl ON cl.ClassID = s.ClassID
    INNER JOIN dbo.Course  co ON co.CourseID= cl.CourseID
    WHERE s.ID = @StudentID
    ORDER BY co.CourseID;
END
GO

-- ============================================================
-- SECTION 15: VIEWS
-- ============================================================

-- ----------------------------------------------------------
-- vw_StudentTranscript
-- ----------------------------------------------------------
CREATE VIEW dbo.vw_StudentTranscript
AS
    SELECT st.ID                              AS StudentID,
           st.FirstName + N' ' + st.LastName AS StudentName,
           co.CourseID,
           co.CourseName,
           co.Credits,
           cl.ClassID,
           cl.Semester,
           cl.AcademicYear,
           s.MidtermScore,
           s.FinalScore,
           s.TotalScore,
           s.LetterGrade,
           s.Overview
    FROM dbo.Score   s
    INNER JOIN dbo.DKMH    d  ON d.ID = s.ID AND d.ClassID = s.ClassID
    INNER JOIN dbo.Student st ON st.ID      = s.ID
    INNER JOIN dbo.Class   cl ON cl.ClassID = s.ClassID
    INNER JOIN dbo.Course  co ON co.CourseID= cl.CourseID;
GO

-- ----------------------------------------------------------
-- vw_ClassList
-- ----------------------------------------------------------
CREATE VIEW dbo.vw_ClassList
AS
    SELECT cl.ClassID,
           co.CourseID,
           co.CourseName,
           co.Credits,
           cl.Semester,
           cl.AcademicYear,
           cl.Capacity,
           cl.CurrentStudents,
           cl.Room,
           cl.Schedule
    FROM dbo.Class  cl
    INNER JOIN dbo.Course co ON co.CourseID = cl.CourseID;
GO

-- ----------------------------------------------------------
-- vw_TeacherAssignment
-- ----------------------------------------------------------
CREATE VIEW dbo.vw_TeacherAssignment
AS
    SELECT h.ID                               AS HRID,
           h.FirstName + N' ' + h.LastName   AS HRName,
           g.GroupID,
           g.GroupName,
           cl.ClassID,
           co.CourseName,
           cl.Semester,
           cl.AcademicYear,
           cl.Room,
           a.AssignDate
    FROM dbo.Assign   a
    INNER JOIN dbo.HR       h  ON h.ID       = a.ID
    INNER JOIN dbo.[Groups] g  ON g.GroupID  = a.GroupID
    INNER JOIN dbo.Class    cl ON cl.ClassID = a.ClassID
    INNER JOIN dbo.Course   co ON co.CourseID= cl.CourseID;
GO

-- ----------------------------------------------------------
-- vw_StudentRegistration
-- ----------------------------------------------------------
CREATE VIEW dbo.vw_StudentRegistration
AS
    SELECT st.ID                              AS StudentID,
           st.FirstName + N' ' + st.LastName AS StudentName,
           d.ClassID,
           co.CourseName,
           cl.Semester,
           cl.AcademicYear,
           cl.Room,
           cl.Schedule,
           d.RegisterDate
    FROM dbo.DKMH    d
    INNER JOIN dbo.Student st ON st.ID      = d.ID
    INNER JOIN dbo.Class   cl ON cl.ClassID = d.ClassID
    INNER JOIN dbo.Course  co ON co.CourseID= cl.CourseID;
GO

-- ----------------------------------------------------------
-- vw_CourseDetail (merged from vw_Course + vw_CourseDetail)
-- FIX: duplicate view removed; [Groups] bracket fix applied
-- ----------------------------------------------------------
CREATE VIEW dbo.vw_CourseDetail
AS
    SELECT c.CourseID,
           c.CourseName,
           c.Credits,
           c.TotalPeriods,
           c.TheoryPeriods,
           c.PracticePeriods,
           p.CourseName AS Prerequisite,
           c.IsRequired,
           c.Description
    FROM dbo.Course c
    LEFT JOIN dbo.Course p ON c.PrerequisiteID = p.CourseID;
GO

-- ----------------------------------------------------------
-- vw_ScoreDetail
-- FIX: no bracket issue here, kept as-is with dbo prefix
-- ----------------------------------------------------------
CREATE VIEW dbo.vw_ScoreDetail
AS
    SELECT st.ID,
           st.FirstName + N' ' + st.LastName AS StudentName,
           c.CourseName,
           cl.ClassID,
           sc.MidtermScore,
           sc.FinalScore,
           sc.TotalScore,
           sc.LetterGrade,
           sc.Overview
    FROM dbo.Score   sc
    JOIN dbo.Student st ON sc.ID      = st.ID
    JOIN dbo.Class   cl ON sc.ClassID = cl.ClassID
    JOIN dbo.Course  c  ON cl.CourseID= c.CourseID;
GO

-- ----------------------------------------------------------
-- vw_HRClass
-- FIX: [Groups] bracket added (was missing in original)
-- ----------------------------------------------------------
CREATE VIEW dbo.vw_HRClass
AS
    SELECT h.ID,
           h.FirstName + N' ' + h.LastName AS Lecturer,
           g.GroupName,
           cl.ClassID,
           c.CourseName,
           cl.Semester,
           cl.AcademicYear
    FROM dbo.Assign   a
    JOIN dbo.HR       h  ON a.ID      = h.ID
    JOIN dbo.[Groups] g  ON a.GroupID = g.GroupID
    JOIN dbo.Class    cl ON a.ClassID = cl.ClassID
    JOIN dbo.Course   c  ON cl.CourseID= c.CourseID;
GO