create function cekNamaTempatUpd
(@kode_tempat varchar(13), @nama_tempat varchar(100))
returns varchar(11)
as
begin
	declare @hasil varchar(11), @xnama_tempat varchar(100)
	set @hasil = 'boleh'
	declare cek cursor for select nama_tempat from tempat where kode_tempat != @kode_tempat
	open cek
	fetch next from cek into @xnama_tempat
	while @@FETCH_STATUS=0
	begin
		if (@xnama_tempat = @nama_tempat)
			set @hasil = 'tidak boleh'
	fetch next from cek into @xnama_tempat
	end
	close cek
	deallocate cek
	return @hasil
end