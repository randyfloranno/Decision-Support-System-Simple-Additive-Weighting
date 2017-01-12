create procedure insTempat
@nama_tempat varchar(100)
as
begin
declare @kode_tempat varchar(13), @no varchar(4)
set @no = (SELECT count (SUBSTRING(kode_tempat,3,6))+1 from TEMPAT where SUBSTRING(kode_tempat,3,6) =  convert (varchar(2),right (year(getdate()),2))+ right('00' + convert (varchar(2),month(getdate())),2)+ right('00' + convert (varchar(2),day(getdate())),2))
set @kode_tempat = 'T' + '.' + convert (varchar(2),right (year(getdate()),2))+ right('00' + convert (varchar(2),month(getdate())),2)+ right('00' + convert (varchar(2),day(getdate())),2)+ '.' + right('000' + convert(varchar(4),@no),4)
insert into tempat values(@kode_tempat, @nama_tempat, 0)
end