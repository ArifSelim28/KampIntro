-- Select (sql server case insensitive)
select * from Customers

select ContactName, CompanyName, City from Customers

select ContactName Adi, CompanyName SirketAdi, City SehirAdi from Customers

select * from Customers where city = 'London'  -- tek tırnak metinsel ifade

select * from Products

select * from Products where categoryId = 1

select * from Products where categoryId = 1 or categoryId = 3

select * from Products where categoryId = 1 and UnitPrice >= 10 -- <> farklı olan demek

select * from Products order by ProductName -- butun urunleri sec, urun adına gore sırala

select * from Products order by CategoryId, ProductName -- her kategoriyi alfabetik sıralama

select * from Products order by UnitPrice asc -- urunleri artan fiyata gore sıralar (ascending default)

select * from Products order by UnitPrice desc -- urunleri azalan fiyata gore sırala (descending)

select * from Products where categoryID = 1 order by UnitPrice desc -- category id si 1 olanları azalan fiyata gore

select count (*) Adet from Products

select categoryID,count(*) from products where UnitPrice>20 group by CategoryID having count(*)<10

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10

--DTO Data Transformation object

select * from Products P inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID

select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID 
where o.CustomerID is null



