﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServisRacunara
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Servis")]
	public partial class ServisRacunaraDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDosije(Dosije instance);
    partial void UpdateDosije(Dosije instance);
    partial void DeleteDosije(Dosije instance);
    partial void InsertRacunVlasnika(RacunVlasnika instance);
    partial void UpdateRacunVlasnika(RacunVlasnika instance);
    partial void DeleteRacunVlasnika(RacunVlasnika instance);
    partial void InsertRadNalog(RadNalog instance);
    partial void UpdateRadNalog(RadNalog instance);
    partial void DeleteRadNalog(RadNalog instance);
    partial void InsertRezervniDeo(RezervniDeo instance);
    partial void UpdateRezervniDeo(RezervniDeo instance);
    partial void DeleteRezervniDeo(RezervniDeo instance);
    partial void InsertZahtevServ(ZahtevServ instance);
    partial void UpdateZahtevServ(ZahtevServ instance);
    partial void DeleteZahtevServ(ZahtevServ instance);
    #endregion
		
		public ServisRacunaraDataContext() : 
				base(global::ServisRacunara.Properties.Settings.Default.ServisConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ServisRacunaraDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ServisRacunaraDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ServisRacunaraDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ServisRacunaraDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Dosije> Dosijes
		{
			get
			{
				return this.GetTable<Dosije>();
			}
		}
		
		public System.Data.Linq.Table<RacunVlasnika> RacunVlasnikas
		{
			get
			{
				return this.GetTable<RacunVlasnika>();
			}
		}
		
		public System.Data.Linq.Table<RadNalog> RadNalogs
		{
			get
			{
				return this.GetTable<RadNalog>();
			}
		}
		
		public System.Data.Linq.Table<RezervniDeo> RezervniDeos
		{
			get
			{
				return this.GetTable<RezervniDeo>();
			}
		}
		
		public System.Data.Linq.Table<ZahtevServ> ZahtevServs
		{
			get
			{
				return this.GetTable<ZahtevServ>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Dosije")]
	public partial class Dosije : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ime;
		
		private string _prezime;
		
		private string _korisnickoIme;
		
		private string _sifra;
		
		private string _osoba;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnimeChanging(string value);
    partial void OnimeChanged();
    partial void OnprezimeChanging(string value);
    partial void OnprezimeChanged();
    partial void OnkorisnickoImeChanging(string value);
    partial void OnkorisnickoImeChanged();
    partial void OnsifraChanging(string value);
    partial void OnsifraChanged();
    partial void OnosobaChanging(string value);
    partial void OnosobaChanged();
    #endregion
		
		public Dosije()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ime", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string ime
		{
			get
			{
				return this._ime;
			}
			set
			{
				if ((this._ime != value))
				{
					this.OnimeChanging(value);
					this.SendPropertyChanging();
					this._ime = value;
					this.SendPropertyChanged("ime");
					this.OnimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_prezime", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string prezime
		{
			get
			{
				return this._prezime;
			}
			set
			{
				if ((this._prezime != value))
				{
					this.OnprezimeChanging(value);
					this.SendPropertyChanging();
					this._prezime = value;
					this.SendPropertyChanged("prezime");
					this.OnprezimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_korisnickoIme", DbType="NVarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string korisnickoIme
		{
			get
			{
				return this._korisnickoIme;
			}
			set
			{
				if ((this._korisnickoIme != value))
				{
					this.OnkorisnickoImeChanging(value);
					this.SendPropertyChanging();
					this._korisnickoIme = value;
					this.SendPropertyChanged("korisnickoIme");
					this.OnkorisnickoImeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sifra", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string sifra
		{
			get
			{
				return this._sifra;
			}
			set
			{
				if ((this._sifra != value))
				{
					this.OnsifraChanging(value);
					this.SendPropertyChanging();
					this._sifra = value;
					this.SendPropertyChanged("sifra");
					this.OnsifraChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_osoba", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string osoba
		{
			get
			{
				return this._osoba;
			}
			set
			{
				if ((this._osoba != value))
				{
					this.OnosobaChanging(value);
					this.SendPropertyChanging();
					this._osoba = value;
					this.SendPropertyChanged("osoba");
					this.OnosobaChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.RacunVlasnika")]
	public partial class RacunVlasnika : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _sifraRacuna;
		
		private int _sifraNaloga;
		
		private string _radnik;
		
		private string _vreme;
		
		private string _imePrezime;
		
		private System.Nullable<int> _brLicne;
		
		private string _mail;
		
		private string _telefon;
		
		private string _sifraRac;
		
		private string _opisKva;
		
		private string _spisPoslova;
		
		private string _rezDel;
		
		private string _cenaUsluga;
		
		private string _cenaDelova;
		
		private string _cenaUkupna;
		
		private EntityRef<RadNalog> _RadNalog;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnsifraRacunaChanging(int value);
    partial void OnsifraRacunaChanged();
    partial void OnsifraNalogaChanging(int value);
    partial void OnsifraNalogaChanged();
    partial void OnradnikChanging(string value);
    partial void OnradnikChanged();
    partial void OnvremeChanging(string value);
    partial void OnvremeChanged();
    partial void OnimePrezimeChanging(string value);
    partial void OnimePrezimeChanged();
    partial void OnbrLicneChanging(System.Nullable<int> value);
    partial void OnbrLicneChanged();
    partial void OnmailChanging(string value);
    partial void OnmailChanged();
    partial void OntelefonChanging(string value);
    partial void OntelefonChanged();
    partial void OnsifraRacChanging(string value);
    partial void OnsifraRacChanged();
    partial void OnopisKvaChanging(string value);
    partial void OnopisKvaChanged();
    partial void OnspisPoslovaChanging(string value);
    partial void OnspisPoslovaChanged();
    partial void OnrezDelChanging(string value);
    partial void OnrezDelChanged();
    partial void OncenaUslugaChanging(string value);
    partial void OncenaUslugaChanged();
    partial void OncenaDelovaChanging(string value);
    partial void OncenaDelovaChanged();
    partial void OncenaUkupnaChanging(string value);
    partial void OncenaUkupnaChanged();
    #endregion
		
		public RacunVlasnika()
		{
			this._RadNalog = default(EntityRef<RadNalog>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sifraRacuna", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int sifraRacuna
		{
			get
			{
				return this._sifraRacuna;
			}
			set
			{
				if ((this._sifraRacuna != value))
				{
					this.OnsifraRacunaChanging(value);
					this.SendPropertyChanging();
					this._sifraRacuna = value;
					this.SendPropertyChanged("sifraRacuna");
					this.OnsifraRacunaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sifraNaloga", DbType="Int NOT NULL")]
		public int sifraNaloga
		{
			get
			{
				return this._sifraNaloga;
			}
			set
			{
				if ((this._sifraNaloga != value))
				{
					if (this._RadNalog.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnsifraNalogaChanging(value);
					this.SendPropertyChanging();
					this._sifraNaloga = value;
					this.SendPropertyChanged("sifraNaloga");
					this.OnsifraNalogaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_radnik", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string radnik
		{
			get
			{
				return this._radnik;
			}
			set
			{
				if ((this._radnik != value))
				{
					this.OnradnikChanging(value);
					this.SendPropertyChanging();
					this._radnik = value;
					this.SendPropertyChanged("radnik");
					this.OnradnikChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vreme", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string vreme
		{
			get
			{
				return this._vreme;
			}
			set
			{
				if ((this._vreme != value))
				{
					this.OnvremeChanging(value);
					this.SendPropertyChanging();
					this._vreme = value;
					this.SendPropertyChanged("vreme");
					this.OnvremeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_imePrezime", DbType="NVarChar(50)")]
		public string imePrezime
		{
			get
			{
				return this._imePrezime;
			}
			set
			{
				if ((this._imePrezime != value))
				{
					this.OnimePrezimeChanging(value);
					this.SendPropertyChanging();
					this._imePrezime = value;
					this.SendPropertyChanged("imePrezime");
					this.OnimePrezimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_brLicne", DbType="Int")]
		public System.Nullable<int> brLicne
		{
			get
			{
				return this._brLicne;
			}
			set
			{
				if ((this._brLicne != value))
				{
					this.OnbrLicneChanging(value);
					this.SendPropertyChanging();
					this._brLicne = value;
					this.SendPropertyChanged("brLicne");
					this.OnbrLicneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mail", DbType="NVarChar(50)")]
		public string mail
		{
			get
			{
				return this._mail;
			}
			set
			{
				if ((this._mail != value))
				{
					this.OnmailChanging(value);
					this.SendPropertyChanging();
					this._mail = value;
					this.SendPropertyChanged("mail");
					this.OnmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_telefon", DbType="NVarChar(50)")]
		public string telefon
		{
			get
			{
				return this._telefon;
			}
			set
			{
				if ((this._telefon != value))
				{
					this.OntelefonChanging(value);
					this.SendPropertyChanging();
					this._telefon = value;
					this.SendPropertyChanged("telefon");
					this.OntelefonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sifraRac", DbType="NVarChar(4)")]
		public string sifraRac
		{
			get
			{
				return this._sifraRac;
			}
			set
			{
				if ((this._sifraRac != value))
				{
					this.OnsifraRacChanging(value);
					this.SendPropertyChanging();
					this._sifraRac = value;
					this.SendPropertyChanged("sifraRac");
					this.OnsifraRacChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_opisKva", DbType="NVarChar(100)")]
		public string opisKva
		{
			get
			{
				return this._opisKva;
			}
			set
			{
				if ((this._opisKva != value))
				{
					this.OnopisKvaChanging(value);
					this.SendPropertyChanging();
					this._opisKva = value;
					this.SendPropertyChanged("opisKva");
					this.OnopisKvaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_spisPoslova", DbType="NVarChar(100)")]
		public string spisPoslova
		{
			get
			{
				return this._spisPoslova;
			}
			set
			{
				if ((this._spisPoslova != value))
				{
					this.OnspisPoslovaChanging(value);
					this.SendPropertyChanging();
					this._spisPoslova = value;
					this.SendPropertyChanged("spisPoslova");
					this.OnspisPoslovaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_rezDel", DbType="NVarChar(100)")]
		public string rezDel
		{
			get
			{
				return this._rezDel;
			}
			set
			{
				if ((this._rezDel != value))
				{
					this.OnrezDelChanging(value);
					this.SendPropertyChanging();
					this._rezDel = value;
					this.SendPropertyChanged("rezDel");
					this.OnrezDelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cenaUsluga", DbType="NVarChar(50)")]
		public string cenaUsluga
		{
			get
			{
				return this._cenaUsluga;
			}
			set
			{
				if ((this._cenaUsluga != value))
				{
					this.OncenaUslugaChanging(value);
					this.SendPropertyChanging();
					this._cenaUsluga = value;
					this.SendPropertyChanged("cenaUsluga");
					this.OncenaUslugaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cenaDelova", DbType="NVarChar(50)")]
		public string cenaDelova
		{
			get
			{
				return this._cenaDelova;
			}
			set
			{
				if ((this._cenaDelova != value))
				{
					this.OncenaDelovaChanging(value);
					this.SendPropertyChanging();
					this._cenaDelova = value;
					this.SendPropertyChanged("cenaDelova");
					this.OncenaDelovaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cenaUkupna", DbType="NVarChar(50)")]
		public string cenaUkupna
		{
			get
			{
				return this._cenaUkupna;
			}
			set
			{
				if ((this._cenaUkupna != value))
				{
					this.OncenaUkupnaChanging(value);
					this.SendPropertyChanging();
					this._cenaUkupna = value;
					this.SendPropertyChanged("cenaUkupna");
					this.OncenaUkupnaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="RadNalog_RacunVlasnika", Storage="_RadNalog", ThisKey="sifraNaloga", OtherKey="sifraNaloga", IsForeignKey=true)]
		public RadNalog RadNalog
		{
			get
			{
				return this._RadNalog.Entity;
			}
			set
			{
				RadNalog previousValue = this._RadNalog.Entity;
				if (((previousValue != value) 
							|| (this._RadNalog.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._RadNalog.Entity = null;
						previousValue.RacunVlasnikas.Remove(this);
					}
					this._RadNalog.Entity = value;
					if ((value != null))
					{
						value.RacunVlasnikas.Add(this);
						this._sifraNaloga = value.sifraNaloga;
					}
					else
					{
						this._sifraNaloga = default(int);
					}
					this.SendPropertyChanged("RadNalog");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.RadNalog")]
	public partial class RadNalog : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _sifraNaloga;
		
		private string _radnik;
		
		private string _vreme;
		
		private string _status;
		
		private string _imePrezime;
		
		private int _brLicne;
		
		private string _telefon;
		
		private string _adresa;
		
		private string _mail;
		
		private string _sifraRac;
		
		private string _opisPro;
		
		private string _opisKva;
		
		private string _spisPoslova;
		
		private string _rezDel;
		
		private EntitySet<RacunVlasnika> _RacunVlasnikas;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnsifraNalogaChanging(int value);
    partial void OnsifraNalogaChanged();
    partial void OnradnikChanging(string value);
    partial void OnradnikChanged();
    partial void OnvremeChanging(string value);
    partial void OnvremeChanged();
    partial void OnstatusChanging(string value);
    partial void OnstatusChanged();
    partial void OnimePrezimeChanging(string value);
    partial void OnimePrezimeChanged();
    partial void OnbrLicneChanging(int value);
    partial void OnbrLicneChanged();
    partial void OntelefonChanging(string value);
    partial void OntelefonChanged();
    partial void OnadresaChanging(string value);
    partial void OnadresaChanged();
    partial void OnmailChanging(string value);
    partial void OnmailChanged();
    partial void OnsifraRacChanging(string value);
    partial void OnsifraRacChanged();
    partial void OnopisProChanging(string value);
    partial void OnopisProChanged();
    partial void OnopisKvaChanging(string value);
    partial void OnopisKvaChanged();
    partial void OnspisPoslovaChanging(string value);
    partial void OnspisPoslovaChanged();
    partial void OnrezDelChanging(string value);
    partial void OnrezDelChanged();
    #endregion
		
		public RadNalog()
		{
			this._RacunVlasnikas = new EntitySet<RacunVlasnika>(new Action<RacunVlasnika>(this.attach_RacunVlasnikas), new Action<RacunVlasnika>(this.detach_RacunVlasnikas));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sifraNaloga", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int sifraNaloga
		{
			get
			{
				return this._sifraNaloga;
			}
			set
			{
				if ((this._sifraNaloga != value))
				{
					this.OnsifraNalogaChanging(value);
					this.SendPropertyChanging();
					this._sifraNaloga = value;
					this.SendPropertyChanged("sifraNaloga");
					this.OnsifraNalogaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_radnik", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string radnik
		{
			get
			{
				return this._radnik;
			}
			set
			{
				if ((this._radnik != value))
				{
					this.OnradnikChanging(value);
					this.SendPropertyChanging();
					this._radnik = value;
					this.SendPropertyChanged("radnik");
					this.OnradnikChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vreme", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string vreme
		{
			get
			{
				return this._vreme;
			}
			set
			{
				if ((this._vreme != value))
				{
					this.OnvremeChanging(value);
					this.SendPropertyChanging();
					this._vreme = value;
					this.SendPropertyChanged("vreme");
					this.OnvremeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_imePrezime", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string imePrezime
		{
			get
			{
				return this._imePrezime;
			}
			set
			{
				if ((this._imePrezime != value))
				{
					this.OnimePrezimeChanging(value);
					this.SendPropertyChanging();
					this._imePrezime = value;
					this.SendPropertyChanged("imePrezime");
					this.OnimePrezimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_brLicne", DbType="Int NOT NULL")]
		public int brLicne
		{
			get
			{
				return this._brLicne;
			}
			set
			{
				if ((this._brLicne != value))
				{
					this.OnbrLicneChanging(value);
					this.SendPropertyChanging();
					this._brLicne = value;
					this.SendPropertyChanged("brLicne");
					this.OnbrLicneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_telefon", DbType="NVarChar(50)")]
		public string telefon
		{
			get
			{
				return this._telefon;
			}
			set
			{
				if ((this._telefon != value))
				{
					this.OntelefonChanging(value);
					this.SendPropertyChanging();
					this._telefon = value;
					this.SendPropertyChanged("telefon");
					this.OntelefonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_adresa", DbType="NVarChar(50)")]
		public string adresa
		{
			get
			{
				return this._adresa;
			}
			set
			{
				if ((this._adresa != value))
				{
					this.OnadresaChanging(value);
					this.SendPropertyChanging();
					this._adresa = value;
					this.SendPropertyChanged("adresa");
					this.OnadresaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mail", DbType="NVarChar(50)")]
		public string mail
		{
			get
			{
				return this._mail;
			}
			set
			{
				if ((this._mail != value))
				{
					this.OnmailChanging(value);
					this.SendPropertyChanging();
					this._mail = value;
					this.SendPropertyChanged("mail");
					this.OnmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sifraRac", DbType="NVarChar(4)")]
		public string sifraRac
		{
			get
			{
				return this._sifraRac;
			}
			set
			{
				if ((this._sifraRac != value))
				{
					this.OnsifraRacChanging(value);
					this.SendPropertyChanging();
					this._sifraRac = value;
					this.SendPropertyChanged("sifraRac");
					this.OnsifraRacChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_opisPro", DbType="NVarChar(100)")]
		public string opisPro
		{
			get
			{
				return this._opisPro;
			}
			set
			{
				if ((this._opisPro != value))
				{
					this.OnopisProChanging(value);
					this.SendPropertyChanging();
					this._opisPro = value;
					this.SendPropertyChanged("opisPro");
					this.OnopisProChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_opisKva", DbType="NVarChar(100)")]
		public string opisKva
		{
			get
			{
				return this._opisKva;
			}
			set
			{
				if ((this._opisKva != value))
				{
					this.OnopisKvaChanging(value);
					this.SendPropertyChanging();
					this._opisKva = value;
					this.SendPropertyChanged("opisKva");
					this.OnopisKvaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_spisPoslova", DbType="NVarChar(100)")]
		public string spisPoslova
		{
			get
			{
				return this._spisPoslova;
			}
			set
			{
				if ((this._spisPoslova != value))
				{
					this.OnspisPoslovaChanging(value);
					this.SendPropertyChanging();
					this._spisPoslova = value;
					this.SendPropertyChanged("spisPoslova");
					this.OnspisPoslovaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_rezDel", DbType="NVarChar(100)")]
		public string rezDel
		{
			get
			{
				return this._rezDel;
			}
			set
			{
				if ((this._rezDel != value))
				{
					this.OnrezDelChanging(value);
					this.SendPropertyChanging();
					this._rezDel = value;
					this.SendPropertyChanged("rezDel");
					this.OnrezDelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="RadNalog_RacunVlasnika", Storage="_RacunVlasnikas", ThisKey="sifraNaloga", OtherKey="sifraNaloga")]
		public EntitySet<RacunVlasnika> RacunVlasnikas
		{
			get
			{
				return this._RacunVlasnikas;
			}
			set
			{
				this._RacunVlasnikas.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_RacunVlasnikas(RacunVlasnika entity)
		{
			this.SendPropertyChanging();
			entity.RadNalog = this;
		}
		
		private void detach_RacunVlasnikas(RacunVlasnika entity)
		{
			this.SendPropertyChanging();
			entity.RadNalog = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.RezervniDeo")]
	public partial class RezervniDeo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _barkod;
		
		private string _marka;
		
		private string _vrsta;
		
		private string _model;
		
		private System.Nullable<int> _kolicina;
		
		private System.Nullable<int> _cena;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnbarkodChanging(int value);
    partial void OnbarkodChanged();
    partial void OnmarkaChanging(string value);
    partial void OnmarkaChanged();
    partial void OnvrstaChanging(string value);
    partial void OnvrstaChanged();
    partial void OnmodelChanging(string value);
    partial void OnmodelChanged();
    partial void OnkolicinaChanging(System.Nullable<int> value);
    partial void OnkolicinaChanged();
    partial void OncenaChanging(System.Nullable<int> value);
    partial void OncenaChanged();
    #endregion
		
		public RezervniDeo()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_barkod", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int barkod
		{
			get
			{
				return this._barkod;
			}
			set
			{
				if ((this._barkod != value))
				{
					this.OnbarkodChanging(value);
					this.SendPropertyChanging();
					this._barkod = value;
					this.SendPropertyChanged("barkod");
					this.OnbarkodChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_marka", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string marka
		{
			get
			{
				return this._marka;
			}
			set
			{
				if ((this._marka != value))
				{
					this.OnmarkaChanging(value);
					this.SendPropertyChanging();
					this._marka = value;
					this.SendPropertyChanged("marka");
					this.OnmarkaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vrsta", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string vrsta
		{
			get
			{
				return this._vrsta;
			}
			set
			{
				if ((this._vrsta != value))
				{
					this.OnvrstaChanging(value);
					this.SendPropertyChanging();
					this._vrsta = value;
					this.SendPropertyChanged("vrsta");
					this.OnvrstaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_model", DbType="NVarChar(20)")]
		public string model
		{
			get
			{
				return this._model;
			}
			set
			{
				if ((this._model != value))
				{
					this.OnmodelChanging(value);
					this.SendPropertyChanging();
					this._model = value;
					this.SendPropertyChanged("model");
					this.OnmodelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kolicina", DbType="Int")]
		public System.Nullable<int> kolicina
		{
			get
			{
				return this._kolicina;
			}
			set
			{
				if ((this._kolicina != value))
				{
					this.OnkolicinaChanging(value);
					this.SendPropertyChanging();
					this._kolicina = value;
					this.SendPropertyChanged("kolicina");
					this.OnkolicinaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cena", DbType="Int")]
		public System.Nullable<int> cena
		{
			get
			{
				return this._cena;
			}
			set
			{
				if ((this._cena != value))
				{
					this.OncenaChanging(value);
					this.SendPropertyChanging();
					this._cena = value;
					this.SendPropertyChanged("cena");
					this.OncenaChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ZahtevServ")]
	public partial class ZahtevServ : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _brZahteva;
		
		private string _serviser;
		
		private string _datum;
		
		private string _tekst;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnbrZahtevaChanging(int value);
    partial void OnbrZahtevaChanged();
    partial void OnserviserChanging(string value);
    partial void OnserviserChanged();
    partial void OndatumChanging(string value);
    partial void OndatumChanged();
    partial void OntekstChanging(string value);
    partial void OntekstChanged();
    #endregion
		
		public ZahtevServ()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_brZahteva", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int brZahteva
		{
			get
			{
				return this._brZahteva;
			}
			set
			{
				if ((this._brZahteva != value))
				{
					this.OnbrZahtevaChanging(value);
					this.SendPropertyChanging();
					this._brZahteva = value;
					this.SendPropertyChanged("brZahteva");
					this.OnbrZahtevaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_serviser", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string serviser
		{
			get
			{
				return this._serviser;
			}
			set
			{
				if ((this._serviser != value))
				{
					this.OnserviserChanging(value);
					this.SendPropertyChanging();
					this._serviser = value;
					this.SendPropertyChanged("serviser");
					this.OnserviserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_datum", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string datum
		{
			get
			{
				return this._datum;
			}
			set
			{
				if ((this._datum != value))
				{
					this.OndatumChanging(value);
					this.SendPropertyChanging();
					this._datum = value;
					this.SendPropertyChanged("datum");
					this.OndatumChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tekst", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string tekst
		{
			get
			{
				return this._tekst;
			}
			set
			{
				if ((this._tekst != value))
				{
					this.OntekstChanging(value);
					this.SendPropertyChanging();
					this._tekst = value;
					this.SendPropertyChanged("tekst");
					this.OntekstChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591