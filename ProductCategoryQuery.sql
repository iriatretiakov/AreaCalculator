SELECT p.ProductName,
       c.CategoryName
FROM [ProductCategory] pr
JOIN [Product] p ON p.ProductID = pr.ProductID
LEFT JOIN [Category] c ON c.CategoryID = pr.CategoryID