CREATE SEQUENCE SQ_CategoryId
AS BIGINT
START WITH 1 INCREMENT BY 1

SELECT NEXT VALUE FOR SQ_CategoryId

SELECT * FROM Categories

CREATE SEQUENCE SQ_ProductId
AS BIGINT
START WITH 100 INCREMENT BY 1

SELECT NEXT VALUE FOR SQ_ProductId

SELECT * FROM Products

CREATE SEQUENCE SQ_ProductDetailsId
AS BIGINT
START WITH 1 INCREMENT BY 1


CREATE VIEW [VW_Products] AS 
Select P.Name as 'Product Name', P.SKU, C.Name as 'Category Name', PD.Quantity, pd.TotalPrice
From ProductDetails as PD
inner join Products as P
on PD.CategoryId = P.Id 
inner join Categories as C
on PD.CategoryId = C.Id 

select Name From Products AS P Where p.CategoryId = 18

Select * FROM Products

Create View Vw_ProductDetails AS
Select Pd.Id, c.Name 'Category Name', p.Name as 'Product Name', pd.Quantity, pd.TotalPrice, pd.CostPrice, pd.SalePrice
from ProductDetails as Pd
inner join Products as P
on pd.ProductId = p.Id
inner join Categories as c
on pd.CategoryId = c.Id

select * From Vw_ProductDetails