use trial;
declare @table table(accountId uniqueidentifier, amountSum int);
insert into @table select accountid, sum(amount) as amountSum from orders group by accountid order by amountSum desc;
select top 1 accountId from @table  order by amountSum desc;