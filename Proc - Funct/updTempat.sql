create procedure updTempat
@kode_tempat varchar(13), @nama_tempat varchar(100)
as
begin
update tempat set nama_tempat=@nama_tempat where kode_tempat = @kode_tempat
end