use tutorial;
CREATE TABLE employees (
    id INT PRIMARY KEY,
    name VARCHAR(100),
    salary DECIMAL(10, 2)
);
INSERT INTO employees (id, name, salary)
VALUES
    (1, 'John Doe', 60000),
    (2, 'Jane Smith', 75000),
    (3, 'Michael Johnson', 80000),
    (4, 'Emily Brown', 72000),
    (5, 'William Lee', 90000);

SELECT DISTINCT salary
FROM employees
ORDER BY salary DESC;

SELECT DISTINCT TOP 1 salary
FROM (
    SELECT DISTINCT TOP 2 salary
    FROM employees
    ORDER BY salary DESC
) AS SecondHighestSalaries
ORDER BY salary ASC; 