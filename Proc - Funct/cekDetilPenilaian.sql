create function cekDetilPenilaian
(@nama_kriteria varchar(100),  @nama_tempat varchar(100))
returns varchar(9)
as
begin
	declare @xkode_kriteria varchar(13), @xkode_tempat varchar(13), @kode_kriteria varchar(13),  @kode_tempat varchar(13), @hasil varchar(9)
	set @hasil = 'tidak ada'
	declare cek cursor for select kode_kriteria, kode_tempat from detil_penilaian
	open cek
	fetch next from cek into @xkode_kriteria, @xkode_tempat
	while @@FETCH_STATUS=0
	begin
	set @kode_kriteria = (select KODE_KRITERIA from KRITERIA where NAMA_KRITERIA = @nama_kriteria)
	set @kode_tempat = (select kode_tempat from tempat where nama_tempat = @nama_tempat)
		if (@xkode_kriteria = @kode_kriteria and @xkode_tempat = @kode_tempat)
			set @hasil = 'ada'
	fetch next from cek into @xkode_kriteria, @xkode_tempat
	end
	close cek
	deallocate cek
	return @hasil
end