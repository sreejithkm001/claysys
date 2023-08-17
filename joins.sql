CREATE TABLE students (
    StudentID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Age INT,
    Gender VARCHAR(10)
);

INSERT INTO students (StudentID, FirstName, LastName, Age, Gender)
VALUES
    (1, 'John', 'Doe', 18, 'Male'),
    (2, 'Jane', 'Smith', 20, 'Female'),
    (3, 'Michael', 'Johnson', 19, 'Male'),
    (4, 'Emily', 'Williams', 21, 'Female');

	CREATE TABLE courses (
    CourseID INT PRIMARY KEY,
    CourseName VARCHAR(100)
);

INSERT INTO courses (CourseID, CourseName)
VALUES
    (101, 'Mathematics'),
    (102, 'History'),
    (103, 'Science'),
    (104, 'Literature');

	SELECT students.FirstName, students.LastName, courses.CourseName
FROM students
INNER JOIN courses ON students.StudentID = courses.CourseID;

SELECT students.FirstName, students.LastName, courses.CourseName
FROM students
LEFT JOIN courses ON students.StudentID = courses.CourseID;

SELECT students.FirstName, students.LastName, courses.CourseName
FROM students
RIGHT JOIN courses ON students.StudentID = courses.CourseID;

SELECT students.FirstName, students.LastName, courses.CourseName
FROM students
FULL JOIN courses ON students.StudentID = courses.CourseID;
