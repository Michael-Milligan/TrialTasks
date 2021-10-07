use Trial;
declare @rawTable table(AccountId uniqueidentifier, number int);
insert into @rawTable select AccountId, count(*) as number from orders group by Orders.AccountId;
select top 1 AccountId from @rawTable  order by number desc
