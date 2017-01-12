create procedure updKriteria
@kode_kriteria varchar(13), @nama_kriteria varchar(100), @jenis_kriteria varchar(10), @bobot_kriteria int
as
begin
update KRITERIA set nama_kriteria=@nama_kriteria, JENIS_KRITERIA = @jenis_kriteria, BOBOT_KRITERIA = @bobot_kriteria where kode_kriteria = @kode_kriteria
end