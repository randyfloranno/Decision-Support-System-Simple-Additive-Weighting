/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     7/18/2014 11:40:47 PM                        */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DETIL_PENILAIAN') and o.name = 'FK_DETIL_PE_DETIL_PEN_KRITERIA')
alter table DETIL_PENILAIAN
   drop constraint FK_DETIL_PE_DETIL_PEN_KRITERIA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DETIL_PENILAIAN') and o.name = 'FK_DETIL_PE_DETIL_PEN_TEMPAT')
alter table DETIL_PENILAIAN
   drop constraint FK_DETIL_PE_DETIL_PEN_TEMPAT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DETIL_PENILAIAN')
            and   name  = 'DETIL_PENILAIAN2_FK'
            and   indid > 0
            and   indid < 255)
   drop index DETIL_PENILAIAN.DETIL_PENILAIAN2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DETIL_PENILAIAN')
            and   name  = 'DETIL_PENILAIAN_FK'
            and   indid > 0
            and   indid < 255)
   drop index DETIL_PENILAIAN.DETIL_PENILAIAN_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DETIL_PENILAIAN')
            and   type = 'U')
   drop table DETIL_PENILAIAN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('KRITERIA')
            and   type = 'U')
   drop table KRITERIA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TEMPAT')
            and   type = 'U')
   drop table TEMPAT
go

/*==============================================================*/
/* Table: DETIL_PENILAIAN                                       */
/*==============================================================*/
create table DETIL_PENILAIAN (
   KODE_KRITERIA        varchar(13)          not null,
   KODE_TEMPAT          varchar(13)          not null,
   DP_NILAI             decimal(18,2)        null,
   DP_NORMALISASI       decimal(18,2)        null,
   constraint PK_DETIL_PENILAIAN primary key (KODE_KRITERIA, KODE_TEMPAT)
)
go

/*==============================================================*/
/* Index: DETIL_PENILAIAN_FK                                    */
/*==============================================================*/
create index DETIL_PENILAIAN_FK on DETIL_PENILAIAN (
KODE_KRITERIA ASC
)
go

/*==============================================================*/
/* Index: DETIL_PENILAIAN2_FK                                   */
/*==============================================================*/
create index DETIL_PENILAIAN2_FK on DETIL_PENILAIAN (
KODE_TEMPAT ASC
)
go

/*==============================================================*/
/* Table: KRITERIA                                              */
/*==============================================================*/
create table KRITERIA (
   KODE_KRITERIA        varchar(13)          not null,
   NAMA_KRITERIA        varchar(100)         null,
   JENIS_KRITERIA       varchar(10)          null,
   BOBOT_KRITERIA       int                  null,
   constraint PK_KRITERIA primary key nonclustered (KODE_KRITERIA)
)
go

/*==============================================================*/
/* Table: TEMPAT                                                */
/*==============================================================*/
create table TEMPAT (
   KODE_TEMPAT          varchar(13)          not null,
   NAMA_TEMPAT          varchar(100)         null,
   NILAI_AKHIR          decimal(18,2)        null,
   constraint PK_TEMPAT primary key nonclustered (KODE_TEMPAT)
)
go

alter table DETIL_PENILAIAN
   add constraint FK_DETIL_PE_DETIL_PEN_KRITERIA foreign key (KODE_KRITERIA)
      references KRITERIA (KODE_KRITERIA)
go

alter table DETIL_PENILAIAN
   add constraint FK_DETIL_PE_DETIL_PEN_TEMPAT foreign key (KODE_TEMPAT)
      references TEMPAT (KODE_TEMPAT)
go

