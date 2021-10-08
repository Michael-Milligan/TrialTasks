use trial;
declare @rawTable table(name nvarchar(500), inn nvarchar(100), kpp nvarchar(100));
declare @resultTable table(name nvarchar(500), inn nvarchar(100), kpp nvarchar(100));
insert into @rawTable select name, inn, kpp from accounts;
insert into @resultTable select * from @rawTable where inn in ( select inn from accounts group by inn having count(*) > 1);
select * from @resultTable where kpp in ( select kpp from accounts group by kpp having count(*) > 1);