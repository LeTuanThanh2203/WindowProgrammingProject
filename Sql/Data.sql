/*==================================================
    DELETE SAMPLE DATA
==================================================*/

DELETE FROM Score;
DELETE FROM DKMH;
DELETE FROM Assign;
DELETE FROM Student;
DELETE FROM Class;
DELETE FROM Course;
DELETE FROM HR;
DELETE FROM [Groups];

-- ============================================================
-- SECTION 18: SAMPLE DATA (UPDATED)
-- Semester values: 'Semester 1' | 'Semester 2' | 'Summer'
-- ============================================================

-- ── Groups (4 records) ──────────────────────────────────────
INSERT INTO [Groups] (GroupID, GroupName, Description) VALUES
('G001', N'CNTT',        N'Computer Science and Information Technology faculty'),
('G002', N'Mathematics', N'Department of Mathematics and Statistics'),
('G003', N'English',     N'Department of English Language and Literature'),
('G004', N'Business',    N'Faculty of Business Administration and Economics');

-- ── HR (6 records) ──────────────────────────────────────────
INSERT INTO HR (ID, FirstName, LastName, Dob, Gender, Phone, Email, Address) VALUES
('HR001', N'Minh',  N'Nguyen', '1980-03-15', N'Male',   '0901111001', 'minh.nguyen@school.edu.vn', N'123 Le Loi, HCMC'),
('HR002', N'Lan',   N'Tran',   '1975-07-22', N'Female', '0901111002', 'lan.tran@school.edu.vn',    N'45 Tran Hung Dao, HCMC'),
('HR003', N'Hung',  N'Le',     '1982-11-10', N'Male',   '0901111003', 'hung.le@school.edu.vn',     N'78 Nguyen Hue, HCMC'),
('HR004', N'Hoa',   N'Pham',   '1979-05-28', N'Female', '0901111004', 'hoa.pham@school.edu.vn',    N'12 Vo Thi Sau, HCMC'),
('HR005', N'Tuan',  N'Vo',     '1985-09-03', N'Male',   '0901111005', 'tuan.vo@school.edu.vn',     N'99 CMT8, HCMC'),
('HR006', N'Mai',   N'Bui',    '1990-12-17', N'Female', '0901111006', 'mai.bui@school.edu.vn',     N'55 Dien Bien Phu, HCMC');

-- ── Course (8 records) ──────────────────────────────────────
INSERT INTO Course
(
    CourseID, CourseName, Credits, TotalPeriods, TheoryPeriods,
    PracticePeriods, PrerequisiteID, IsRequired, Description
)
VALUES
('CS101', N'Introduction to Programming',    3, 45, 30, 15, NULL,    1, N'Fundamentals of programming using C#'),
('CS201', N'Data Structures and Algorithms', 3, 45, 30, 15, 'CS101', 1, N'Data structures'),
('CS301', N'Database Systems',               3, 45, 30, 15, 'CS201', 1, N'Relational databases'),
('CS401', N'Software Engineering',           3, 45, 30, 15, 'CS301', 1, N'SDLC'),
('MA101', N'Calculus I',                     3, 45, 45,  0, NULL,    1, N'Calculus'),
('MA201', N'Linear Algebra',                 3, 45, 30, 15, 'MA101', 1, N'Linear Algebra'),
('EN101', N'Academic English',               2, 30, 20, 10, NULL,    0, N'English'),
('BA101', N'Principles of Management',       3, 45, 30, 15, NULL,    0, N'Business');

-- ── Class (13 records) ──────────────────────────────────────
-- Semester 1 classes (originally HK1)
INSERT INTO Class (ClassID, CourseID, Semester, AcademicYear, Capacity, Room, Schedule) VALUES
('CL001', 'CS101', N'Semester 1', '2024-2025', 40, N'A101', N'Mon/Wed 07:30-09:00'),
('CL002', 'CS101', N'Semester 1', '2024-2025', 35, N'A102', N'Tue/Thu 09:15-10:45'),
('CL003', 'CS201', N'Semester 1', '2024-2025', 40, N'B201', N'Mon/Wed 10:00-11:30'),
('CL004', 'CS301', N'Semester 1', '2024-2025', 45, N'B301', N'Tue/Thu 13:00-14:30'),
('CL006', 'MA101', N'Semester 1', '2024-2025', 50, N'C201', N'Mon/Wed/Fri 07:30-08:30'),
('CL008', 'EN101', N'Semester 1', '2024-2025', 40, N'D101', N'Fri 09:15-11:15'),
('CL009', 'BA101', N'Semester 1', '2024-2025', 50, N'D201', N'Tue/Thu 15:00-16:30');

-- Semester 2 classes (originally HK2)
INSERT INTO Class (ClassID, CourseID, Semester, AcademicYear, Capacity, Room, Schedule) VALUES
('CL005', 'CS401', N'Semester 2', '2024-2025', 40, N'C101', N'Mon/Wed 13:00-14:30'),
('CL007', 'MA201', N'Semester 2', '2024-2025', 45, N'C202', N'Tue/Thu 07:30-09:00'),
('CL010', 'CS301', N'Semester 2', '2024-2025', 40, N'B302', N'Mon/Wed 15:00-16:30');

-- Summer classes (NEW)
INSERT INTO Class (ClassID, CourseID, Semester, AcademicYear, Capacity, Room, Schedule) VALUES
('CL011', 'CS101', N'Summer', '2024-2025', 30, N'A103', N'Mon/Tue/Wed/Thu 07:30-09:00'),
('CL012', 'EN101', N'Summer', '2024-2025', 35, N'D102', N'Mon/Wed/Fri 09:15-11:15'),
('CL013', 'BA101', N'Summer', '2024-2025', 30, N'D202', N'Tue/Thu 13:00-15:00');

-- ── Assign (9 records) ──────────────────────────────────────
-- Original assignments (Semester 1 & 2)
INSERT INTO Assign (ID, GroupID, ClassID, AssignDate) VALUES
('HR001', 'G001', 'CL001', '2024-08-15'),
('HR001', 'G001', 'CL002', '2024-08-15'),
('HR002', 'G002', 'CL006', '2024-08-15'),
('HR003', 'G001', 'CL003', '2024-08-16'),
('HR004', 'G003', 'CL008', '2024-08-16'),
('HR005', 'G001', 'CL004', '2024-08-17');

-- Summer assignments (NEW) — assigned before Summer term starts
INSERT INTO Assign (ID, GroupID, ClassID, AssignDate) VALUES
('HR001', 'G001', 'CL011', '2025-05-01'),   -- Minh Nguyen teaches CS101 Summer
('HR004', 'G003', 'CL012', '2025-05-01'),   -- Hoa Pham teaches EN101 Summer
('HR006', 'G004', 'CL013', '2025-05-02');   -- Mai Bui teaches BA101 Summer

-- ── Student (10 records) ────────────────────────────────────
INSERT INTO Student (ID, FirstName, LastName, Dob, Gender, Phone, Email, Address) VALUES
('20240001', N'An',     N'Nguyen', '2004-01-15', N'Male',   '0909001001', 'an.nguyen@student.edu.vn',     N'10 Nguyen Trai'),
('20240002', N'Bich',   N'Tran',   '2004-03-22', N'Female', '0909001002', 'bich.tran@student.edu.vn',     N'22 Hai Ba Trung'),
('20240003', N'Cuong',  N'Le',     '2003-07-10', N'Male',   '0909001003', 'cuong.le@student.edu.vn',      N'33 Le Van Sy'),
('20240004', N'Dung',   N'Pham',   '2004-11-05', N'Female', '0909001004', 'dung.pham@student.edu.vn',     N'44 Pasteur'),
('20240005', N'Em',     N'Hoang',  '2003-09-18', N'Male',   '0909001005', 'em.hoang@student.edu.vn',      N'55 Dien Bien Phu'),
('20240006', N'Phuong', N'Vu',     '2004-05-30', N'Female', '0909001006', 'phuong.vu@student.edu.vn',     N'66 CMT8'),
('20240007', N'Giang',  N'Do',     '2003-12-12', N'Male',   '0909001007', 'giang.do@student.edu.vn',      N'77 NKKN'),
('20240008', N'Huy',    N'Nguyen', '2004-02-28', N'Male',   '0909001008', 'huy.nguyen@student.edu.vn',    N'88 Nguyen Van Cu'),
('20240009', N'Khanh',  N'Ly',     '2003-08-14', N'Female', '0909001009', 'khanh.ly@student.edu.vn',      N'99 Vo Van Tan'),
('20240010', N'Long',   N'Mai',    '2004-06-25', N'Male',   '0909001010', 'long.mai@student.edu.vn',      N'101 Tran Quoc Toan');

-- ── DKMH (Semester 1 & 2 — 15 records) ─────────────────────
-- TR_DKMH_Insert fires automatically → creates Score rows + increments CurrentStudents
INSERT INTO DKMH (ID, ClassID, RegisterDate) VALUES
('20240001', 'CL001', '2024-09-01'),
('20240001', 'CL003', '2024-09-01'),
('20240001', 'CL006', '2024-09-01'),
('20240002', 'CL001', '2024-09-02'),
('20240002', 'CL004', '2024-09-02'),
('20240003', 'CL002', '2024-09-02'),
('20240003', 'CL003', '2024-09-02'),
('20240004', 'CL004', '2024-09-03'),
('20240004', 'CL006', '2024-09-03'),
('20240005', 'CL001', '2024-09-03'),
('20240005', 'CL008', '2024-09-03'),
('20240006', 'CL002', '2024-09-04'),
('20240006', 'CL009', '2024-09-04'),
('20240007', 'CL003', '2024-09-04'),
('20240008', 'CL004', '2024-09-05');

-- ── DKMH (Summer — 9 records NEW) ──────────────────────────
-- Students re-take or take new courses in Summer term
INSERT INTO DKMH (ID, ClassID, RegisterDate) VALUES
('20240002', 'CL011', '2025-05-10'),   -- Bich re-takes CS101 (failed Semester 1)
('20240004', 'CL011', '2025-05-10'),   -- Dung re-takes CS101
('20240006', 'CL011', '2025-05-10'),   -- Phuong takes CS101 Summer
('20240003', 'CL012', '2025-05-11'),   -- Cuong takes EN101 Summer
('20240005', 'CL012', '2025-05-11'),   -- Em takes EN101 Summer
('20240007', 'CL012', '2025-05-11'),   -- Giang takes EN101 Summer
('20240008', 'CL013', '2025-05-12'),   -- Huy takes BA101 Summer
('20240009', 'CL013', '2025-05-12'),   -- Khanh takes BA101 Summer
('20240010', 'CL013', '2025-05-12');   -- Long takes BA101 Summer

-- ============================================================
-- UPDATE SCORES — Semester 1 & 2
-- TR_Score_Update fires automatically → sets LetterGrade & Overview
-- ============================================================
UPDATE Score SET MidtermScore = 7.5, FinalScore = 8.5 WHERE ID='20240001' AND ClassID='CL001';
UPDATE Score SET MidtermScore = 6.0, FinalScore = 7.0 WHERE ID='20240001' AND ClassID='CL003';
UPDATE Score SET MidtermScore = 8.0, FinalScore = 9.0 WHERE ID='20240001' AND ClassID='CL006';
UPDATE Score SET MidtermScore = 5.5, FinalScore = 6.0 WHERE ID='20240002' AND ClassID='CL001';
UPDATE Score SET MidtermScore = 4.0, FinalScore = 4.5 WHERE ID='20240002' AND ClassID='CL004';
UPDATE Score SET MidtermScore = 7.0, FinalScore = 8.0 WHERE ID='20240003' AND ClassID='CL002';
UPDATE Score SET MidtermScore = 6.5, FinalScore = 7.5 WHERE ID='20240003' AND ClassID='CL003';
UPDATE Score SET MidtermScore = 9.0, FinalScore = 9.5 WHERE ID='20240004' AND ClassID='CL004';
UPDATE Score SET MidtermScore = 3.5, FinalScore = 4.0 WHERE ID='20240004' AND ClassID='CL006';
UPDATE Score SET MidtermScore = 7.0, FinalScore = 7.5 WHERE ID='20240005' AND ClassID='CL001';
UPDATE Score SET MidtermScore = 8.5, FinalScore = 9.0 WHERE ID='20240005' AND ClassID='CL008';
UPDATE Score SET MidtermScore = 5.0, FinalScore = 5.5 WHERE ID='20240006' AND ClassID='CL002';
UPDATE Score SET MidtermScore = 6.0, FinalScore = 6.5 WHERE ID='20240006' AND ClassID='CL009';
UPDATE Score SET MidtermScore = 7.5, FinalScore = 8.0 WHERE ID='20240007' AND ClassID='CL003';
UPDATE Score SET MidtermScore = 4.5, FinalScore = 5.0 WHERE ID='20240008' AND ClassID='CL004';

-- ── UPDATE SCORES — Summer (NEW) ────────────────────────────
-- CL011: CS101 Summer
UPDATE Score SET MidtermScore = 6.5, FinalScore = 7.0 WHERE ID='20240002' AND ClassID='CL011';  -- Bich  → TotalScore=6.8  → C+
UPDATE Score SET MidtermScore = 7.0, FinalScore = 8.0 WHERE ID='20240004' AND ClassID='CL011';  -- Dung  → TotalScore=7.6  → B
UPDATE Score SET MidtermScore = 8.0, FinalScore = 8.5 WHERE ID='20240006' AND ClassID='CL011';  -- Phuong→ TotalScore=8.3  → B+

-- CL012: EN101 Summer
UPDATE Score SET MidtermScore = 7.5, FinalScore = 8.0 WHERE ID='20240003' AND ClassID='CL012';  -- Cuong → TotalScore=7.8  → B
UPDATE Score SET MidtermScore = 9.0, FinalScore = 9.5 WHERE ID='20240005' AND ClassID='CL012';  -- Em    → TotalScore=9.3  → A
UPDATE Score SET MidtermScore = 5.5, FinalScore = 6.0 WHERE ID='20240007' AND ClassID='CL012';  -- Giang → TotalScore=5.8  → C

-- CL013: BA101 Summer
UPDATE Score SET MidtermScore = 6.0, FinalScore = 7.5 WHERE ID='20240008' AND ClassID='CL013';  -- Huy   → TotalScore=6.9  → C+
UPDATE Score SET MidtermScore = 8.5, FinalScore = 9.0 WHERE ID='20240009' AND ClassID='CL013';  -- Khanh → TotalScore=8.8  → A
UPDATE Score SET MidtermScore = 4.0, FinalScore = 5.0 WHERE ID='20240010' AND ClassID='CL013';  -- Long  → TotalScore=4.6  → F

-- ============================================================
-- END OF SCRIPT
-- ============================================================