
--- OR en la cláusula Join Predicate/WHERE en varias columnas

SELECT DISTINCT
  PRODUCT.ProductID,
  PRODUCT.Name
FROM Production.Product PRODUCT
INNER JOIN Sales.SalesOrderDetail DETAIL
ON PRODUCT.ProductID = DETAIL.ProductID
OR PRODUCT.rowguid = DETAIL.rowguid;


SELECT
  PRODUCT.ProductID,
  PRODUCT.Name
FROM Production.Product PRODUCT
INNER JOIN Sales.SalesOrderDetail DETAIL
ON PRODUCT.ProductID = DETAIL.ProductID
UNION
SELECT
  PRODUCT.ProductID,
  PRODUCT.Name
FROM Production.Product PRODUCT
INNER JOIN Sales.SalesOrderDetail DETAIL
ON PRODUCT.rowguid = DETAIL.rowguid


---Búsquedas de cadenas comodín

SELECT
  Person.BusinessEntityID,
  Person.FirstName,
  Person.LastName,
  Person.MiddleName
FROM Person.Person
WHERE Person.LastName LIKE '%For%';

--EVITAR EL Alto conteo de tablas

SELECT
  Product.ProductID,
  Product.Name AS ProductName,
  Product.ProductNumber,
  CostMeasure.UnitMeasureCode,
  CostMeasure.Name AS CostMeasureName,
  ProductVendor.AverageLeadTime,
  ProductVendor.StandardPrice,
  ProductReview.ReviewerName,
  ProductReview.Rating,
  ProductCategory.Name AS CategoryName,
  ProductSubCategory.Name AS SubCategoryName
FROM Production.Product
INNER JOIN Production.ProductSubCategory
ON ProductSubCategory.ProductSubcategoryID = Product.ProductSubcategoryID
INNER JOIN Production.ProductCategory
ON ProductCategory.ProductCategoryID = ProductSubCategory.ProductCategoryID
INNER JOIN Production.UnitMeasure SizeUnitMeasureCode
ON Product.SizeUnitMeasureCode = SizeUnitMeasureCode.UnitMeasureCode
INNER JOIN Production.UnitMeasure WeightUnitMeasureCode
ON Product.WeightUnitMeasureCode = WeightUnitMeasureCode.UnitMeasureCode
INNER JOIN Production.ProductModel
ON ProductModel.ProductModelID = Product.ProductModelID
LEFT JOIN Production.ProductModelIllustration
ON ProductModel.ProductModelID = ProductModelIllustration.ProductModelID
LEFT JOIN Production.ProductModelProductDescriptionCulture
ON ProductModelProductDescriptionCulture.ProductModelID = ProductModel.ProductModelID
LEFT JOIN Production.ProductDescription
ON ProductDescription.ProductDescriptionID = ProductModelProductDescriptionCulture.ProductDescriptionID
LEFT JOIN Production.ProductReview
ON ProductReview.ProductID = Product.ProductID
LEFT JOIN Purchasing.ProductVendor
ON ProductVendor.ProductID = Product.ProductID
LEFT JOIN Production.UnitMeasure CostMeasure
ON ProductVendor.UnitMeasureCode = CostMeasure.UnitMeasureCode
ORDER BY Product.ProductID DESC;

--- (2n-2)! / (n-1)! = (2*12-1)! / (12-1)! = 28,158,588,057,600 posibles planes de ejecución.


---Sugerencias de consulta (hints)
/*
NOLOCK
RECOMPILE
MERGE/HASH/LOOP
OPTIMIZE FOR
*/


SELECT 
  e.BusinessEntityID,
  p.Title,
  p.FirstName,
  p.LastName
FROM HumanResources.Employee e
INNER JOIN Person.Person p
ON p.BusinessEntityID = e.BusinessEntityID
WHERE FirstName LIKE 'E%'

SELECT 
  e.BusinessEntityID,
  p.Title,
  p.FirstName,
  p.LastName
FROM HumanResources.Employee e
INNER MERGE JOIN Person.Person p
ON p.BusinessEntityID = e.BusinessEntityID
WHERE FirstName LIKE 'E%'


SELECT 
  e.BusinessEntityID,
  p.Title,
  p.FirstName,
  p.LastName
FROM HumanResources.Employee e
INNER HASH JOIN Person.Person p
ON p.BusinessEntityID = e.BusinessEntityID
WHERE FirstName LIKE 'E%'