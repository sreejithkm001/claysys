use tutorial;
CREATE TABLE employees (
    id INT PRIMARY KEY,
    name VARCHAR(100),
    salary DECIMAL(10, 2)
);
INSERT INTO employees (id, name, salary)
VALUES
    (1, 'hari ', 60000),
    (2, ' ram', 75000),
    (3, ' John', 80000),
    (4, 'Emil', 72000),
    (5, 'rahul', 90000);



SELECT DISTINCT TOP 1 salary
FROM (
    SELECT DISTINCT TOP 2 salary
    FROM employees
    ORDER BY salary DESC
) AS SecondHighestSalaries
ORDER BY salary ASC; 