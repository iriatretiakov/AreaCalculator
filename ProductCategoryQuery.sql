SELECT p.ProductName + 
	CASE 
		WHEN c.CategoryName IS NOT NULL 
		THEN ' - ' +  c.CategoryName 
		ELSE '' 
	END ProductCategory 
FROM [ProductCategory].[dbo].[ProductCategories] pr
JOIN [ProductCategory].[dbo].[Products] p ON p.Id = pr.ProductID
LEFT JOIN [ProductCategory].[dbo].[Categories] c ON c.Id = pr.CategoryID