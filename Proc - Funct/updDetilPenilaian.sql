create procedure updDetilPenilaian
@nama_kriteria varchar(100),  @nama_tempat varchar(100), @dp_nilai decimal(18,2)
as
begin
declare @kode_kriteria varchar(13),  @kode_tempat varchar(13), @jenis_kriteria varchar(10), @xkode_kriteria varchar(13), @xkode_tempat varchar(13), @xdp_nilai decimal(18,2), @max_dp_nilai decimal(18,2), @min_dp_nilai decimal(18,2), @dp_normalisasi decimal(18,2), @bobot_kriteria int, @nilai_akhir decimal(18,2), @xdp_normalisasi decimal(18,2)
set @kode_kriteria = (select KODE_KRITERIA from KRITERIA where NAMA_KRITERIA = @nama_kriteria)
set @kode_tempat = (select KODE_TEMPAT from TEMPAT where NAMA_TEMPAT = @nama_tempat)
update DETIL_PENILAIAN set DP_NILAI = @dp_nilai where KODE_KRITERIA = @kode_kriteria and KODE_TEMPAT = @kode_tempat

--update nilai dp_normalisasi
declare cek cursor for select distinct kode_kriteria from detil_penilaian
	open cek
	fetch next from cek into @xkode_kriteria
	while @@FETCH_STATUS=0
	begin
	
declare cek1 cursor for select kode_tempat, dp_nilai from detil_penilaian where kode_kriteria = @xkode_kriteria
	open cek1
	fetch next from cek1 into @xkode_tempat, @xdp_nilai
	while @@FETCH_STATUS=0
	begin
		set @jenis_kriteria = (select JENIS_KRITERIA from KRITERIA where KODE_KRITERIA = @xkode_kriteria)
		if (@jenis_kriteria = 'max')
		begin
			set @max_dp_nilai = (select max(dp_nilai) from DETIL_PENILAIAN where KODE_KRITERIA = @xkode_kriteria)
			set @dp_normalisasi = (@xdp_nilai/@max_dp_nilai)
			update DETIL_PENILAIAN set DP_NORMALISASI = @dp_normalisasi where KODE_KRITERIA = @xkode_kriteria and KODE_TEMPAT = @xkode_tempat
		end
		else
		begin
			set @min_dp_nilai = (select min(dp_nilai) from DETIL_PENILAIAN where KODE_KRITERIA = @xkode_kriteria)
			set @dp_normalisasi = (@min_dp_nilai/@xdp_nilai)
			update DETIL_PENILAIAN set DP_NORMALISASI = @dp_normalisasi where KODE_KRITERIA = @xkode_kriteria and KODE_TEMPAT = @xkode_tempat
		end
		
	fetch next from cek1 into @xkode_tempat, @xdp_nilai
	end
	close cek1
	deallocate cek1
	
	fetch next from cek into @xkode_kriteria
	end
	close cek
	deallocate cek
-------------------------------------------------------------------------------------------------------------------

--update nilai_akhir
declare cek cursor for select distinct kode_tempat from detil_penilaian
	open cek
	fetch next from cek into @xkode_tempat
	while @@FETCH_STATUS=0
	begin
	set @nilai_akhir = 0
	
declare cek1 cursor for select kode_kriteria, dp_normalisasi from detil_penilaian where kode_tempat = @xkode_tempat
	open cek1
	fetch next from cek1 into @xkode_kriteria, @xdp_normalisasi
	while @@FETCH_STATUS=0
	begin
		set @bobot_kriteria = (select bobot_kriteria from KRITERIA where KODE_KRITERIA = @xkode_kriteria)
		set @nilai_akhir = (@nilai_akhir+@bobot_kriteria*@xdp_normalisasi)
		
	fetch next from cek1 into @xkode_kriteria, @xdp_normalisasi
	end
	close cek1
	deallocate cek1
	update TEMPAT set NILAI_AKHIR = @nilai_akhir where KODE_TEMPAT = @xkode_tempat
	
	fetch next from cek into @xkode_tempat
	end
	close cek
	deallocate cek
end