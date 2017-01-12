create procedure insKriteria
@nama_kriteria varchar(100), @jenis_kriteria varchar(10), @bobot_kriteria int
as
begin
declare @kode_kriteria varchar(13), @no varchar(4)
set @no = (SELECT count (SUBSTRING(KODE_KRITERIA,3,6))+1 from KRITERIA where SUBSTRING(KODE_KRITERIA,3,6) =  convert (varchar(2),right (year(getdate()),2))+ right('00' + convert (varchar(2),month(getdate())),2)+ right('00' + convert (varchar(2),day(getdate())),2))
set @kode_kriteria = 'K' + '.' + convert (varchar(2),right (year(getdate()),2))+ right('00' + convert (varchar(2),month(getdate())),2)+ right('00' + convert (varchar(2),day(getdate())),2)+ '.' + right('000' + convert(varchar(4),@no),4)
insert into KRITERIA values(@kode_kriteria, @nama_kriteria, @jenis_kriteria, @bobot_kriteria)
end