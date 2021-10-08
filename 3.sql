use trial;
declare @pastYear datetime = dateadd(day, -365, getdate());
select sum(amount) from orders where orderDate > @pastYear;