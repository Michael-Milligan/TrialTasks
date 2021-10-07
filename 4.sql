use trial;
declare @table table(accountId uniqueidentifier, number int);
insert into @table select accountid, count(*) as number from orders group by accountid;
select * from @table where number > 2
