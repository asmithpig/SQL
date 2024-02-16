-- 1. List all cities that have both Employees and Customers.
SELECT DISTINCT City
FROM Employees
WHERE City IN (
    SELECT DISTINCT City
    FROM Customers
)

-- 2. List all cities that have Customers but no Employee.
-- a. Use sub-query
SELECT DISTINCT City
FROM Customers
WHERE City NOT IN (
    SELECT DISTINCT City
    FROM Employees
)

-- b. Do not use sub-query
SELECT DISTINCT c.City
FROM Customers c LEFT JOIN Employees e ON c.City = e.City
WHERE e.EmployeeID IS NULL

-- 3. List all products and their total order quantities throughout all orders.
SELECT p.ProductName, (SELECT SUM(ISNULL(Quantity, 0)) FROM [Order Details] WHERE ProductID = p.ProductID) AS TotalOrderQuantity
FROM Products p
-- or
SELECT p.ProductName, ISNULL(tq.TotalOrderQuantity, 0) as TotalOrderQuantity
FROM Products p LEFT JOIN (
    SELECT ProductID, SUM(ISNULL(Quantity, 0)) as TotalOrderQuantity
    FROM [Order Details]
    GROUP BY ProductID
) tq ON p.ProductID = tq.ProductID

-- 4. List all Customer Cities and total products ordered by that city.
Select c.City, SUM(ISNULL(dt.Quantity, 0)) as TotalProducts
FROM Customers c LEFT JOIN (
    SELECT o.CustomerID, od.Quantity
    FROM Orders o LEFT JOIN [Order Details] od ON o.OrderID = od.OrderID
) dt ON c.CustomerID = dt.CustomerID
GROUP BY c.City

-- 5. List all Customer Cities that have at least two customers.
-- a. Use union
SELECT c1.City
FROM Customers c1, Customers c2
WHERE c1.City = c2.City AND c1.CustomerID < c2.CustomerID
UNION
SELECT c1.City
FROM Customers c1, Customers c2
WHERE c1.City = c2.City AND c1.CustomerID < c2.CustomerID

-- b. Use sub-query and no union
SELECT DISTINCT c1.City
FROM Customers c1 
WHERE c1.City IN (
    SELECT c2.City
    FROM Customers c2
    WHERE c1.City = c2.City AND c1.CustomerID < c2.CustomerID
)

-- 6. List all Customer Cities that have ordered at least two different kinds of products.
SELECT DISTINCT City
FROM Customers
WHERE CustomerID IN (
    SELECT o.CustomerID
    FROM Orders o LEFT JOIN [Order Details] od ON o.OrderID = od.OrderID
    GROUP BY o.CustomerID
    HAVING COUNT(DISTINCT od.ProductID) >= 2
)
-- or
SELECT dt.City
FROM (
    SELECT DISTINCT c.City, od.ProductID
    FROM Customers c LEFT JOIN Orders o ON c.CustomerID = o.CustomerID LEFT JOIN [Order Details] od ON o.OrderID = od.OrderID
) dt
GROUP BY dt.City
HAVING COUNT(dt.ProductID) >= 2

-- 7. List all Customers who have ordered products, but have the ‘ship city’ on the order different from their own customer cities.
SELECT DISTINCT c.ContactName
FROM Customers c
WHERE c.CustomerID IN (
    SELECT o.CustomerID
    FROM Orders o
    WHERE c.City != o.ShipCity
)

-- 8. List 5 most popular products, their average price, and the customer city that ordered most quantity of it.
WITH cte
AS (
    SELECT od.ProductID, od.UnitPrice, od.Quantity, c.City
    FROM [Order Details] od LEFT JOIN Orders o ON od.OrderID = o.OrderID LEFT JOIN Customers c ON o.CustomerID = c.CustomerID
)
SELECT TOP 5 ProductID, AVG(UnitPrice) AS AvgPrice, (SELECT TOP 1 City FROM cte c2 WHERE c1.ProductID = c2.ProductID GROUP BY City ORDER BY SUM(Quantity) DESC) AS CustomerCity
FROM cte c1
GROUP BY ProductID
ORDER BY SUM(Quantity) DESC

-- 9. List all cities that have never ordered something but we have employees there.
-- a. Use sub-query
SELECT DISTINCT City
FROM Employees
WHERE City NOT IN (
    SELECT c.City
    FROM Customers c RIGHT JOIN Orders o on c.CustomerID = o.CustomerID
)

-- b. Do not use sub-query
SELECT e.City
FROM Employees e LEFT JOIN Customers c ON e.City = c.City LEFT JOIN Orders o ON c.CustomerID = o.CustomerID
WHERE o.OrderID IS NULL


-- 10. List one city, if exists, that is the city from where the employee sold most orders (not the product quantity) is, and also the city of most total quantity of products ordered from. (tip: join  sub-query)
WITH cte
AS (
    SELECT c.City, COUNT(o.OrderID) AS NumOfOrders, COUNT(od.Quantity) AS NumOfProducts
    FROM Products p JOIN [Order Details] od ON p.ProductID = od.ProductID 
        JOIN Orders o ON od.OrderID = o.OrderID JOIN Customers c ON c.CustomerID = o.CustomerID 
    GROUP BY c.City 
)
SELECT DISTINCT c.City 
FROM orders o JOIN customers c ON o.CustomerID = c.CustomerID
WHERE c.City IN (
    SELECT TOP 1 c1.City  
    FROM cte c1
    ORDER BY c1.NumOfOrders DESC
)
AND
c.City IN (
    SELECT TOP 1 c2.City  
    FROM cte c2 
    ORDER BY c2.NumOfProducts DESC
)
-- or
SELECT DISTINCT c.City 
FROM orders o JOIN customers c ON o.CustomerID = c.CustomerID
WHERE c.City IN (
    SELECT TOP 1 City  
    FROM Products p1 JOIN [Order Details] od1 ON p1.ProductID = od1.ProductID 
        JOIN Orders o1 ON od1.OrderID = o1.OrderID JOIN Customers c1 ON c1.CustomerID = o1.CustomerID 
    GROUP BY c1.City 
    ORDER BY COUNT(o1.OrderID) DESC
)
AND
c.City IN (
    SELECT TOP 1 c2.City  
    FROM Products p2 JOIN [Order Details] od2 ON p2.ProductID = od2.ProductID 
        JOIN Orders o2 ON od2.OrderID = o2.OrderID JOIN Customers c2 ON o2.CustomerID = c2.CustomerID 
    GROUP BY c2.City 
    ORDER BY COUNT(od2.Quantity) DESC
)

-- 11. How do you remove the duplicates record of a table?
-- self join t1 join t2, and delete the the records has same value in all columns where t1.rowID < t2.rowID
-- eg. delete t1 from Table t1 join Table t2 on t1.column1 = t2.column1 and ... and t1.rowID < t2.rowID