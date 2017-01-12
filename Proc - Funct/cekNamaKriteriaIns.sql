create function cekNamaKriteriaIns
(@nama_kriteria varchar(100))
returns varchar(11)
as
begin
	declare @hasil varchar(11), @xnama_kriteria varchar(100)
	set @hasil = 'boleh'
	declare cek cursor for select nama_kriteria from kriteria
	open cek
	fetch next from cek into @xnama_kriteria
	while @@FETCH_STATUS=0
	begin
		if (@xnama_kriteria = @nama_kriteria)
			set @hasil = 'tidak boleh'
	fetch next from cek into @xnama_kriteria
	end
	close cek
	deallocate cek
	return @hasil
end