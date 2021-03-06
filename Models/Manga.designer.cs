#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MangaWorld.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Manga")]
	public partial class MangaDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCHAP(CHAP instance);
    partial void UpdateCHAP(CHAP instance);
    partial void DeleteCHAP(CHAP instance);
    partial void InsertHINHANH(HINHANH instance);
    partial void UpdateHINHANH(HINHANH instance);
    partial void DeleteHINHANH(HINHANH instance);
    partial void InsertTHELOAI(THELOAI instance);
    partial void UpdateTHELOAI(THELOAI instance);
    partial void DeleteTHELOAI(THELOAI instance);
    partial void InsertTINHTRANG(TINHTRANG instance);
    partial void UpdateTINHTRANG(TINHTRANG instance);
    partial void DeleteTINHTRANG(TINHTRANG instance);
    partial void InsertUSER(USER instance);
    partial void UpdateUSER(USER instance);
    partial void DeleteUSER(USER instance);
    partial void InsertTRUYEN(TRUYEN instance);
    partial void UpdateTRUYEN(TRUYEN instance);
    partial void DeleteTRUYEN(TRUYEN instance);
    #endregion
		
		public MangaDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["MangaConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MangaDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MangaDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MangaDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MangaDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<CHAP> CHAPs
		{
			get
			{
				return this.GetTable<CHAP>();
			}
		}
		
		public System.Data.Linq.Table<HINHANH> HINHANHs
		{
			get
			{
				return this.GetTable<HINHANH>();
			}
		}
		
		public System.Data.Linq.Table<THELOAI> THELOAIs
		{
			get
			{
				return this.GetTable<THELOAI>();
			}
		}
		
		public System.Data.Linq.Table<TINHTRANG> TINHTRANGs
		{
			get
			{
				return this.GetTable<TINHTRANG>();
			}
		}
		
		public System.Data.Linq.Table<USER> USERs
		{
			get
			{
				return this.GetTable<USER>();
			}
		}
		
		public System.Data.Linq.Table<HuyAdmin> HuyAdmins
		{
			get
			{
				return this.GetTable<HuyAdmin>();
			}
		}
		
		public System.Data.Linq.Table<MaMANGA> MaMANGAs
		{
			get
			{
				return this.GetTable<MaMANGA>();
			}
		}
		
		public System.Data.Linq.Table<TRUYEN> TRUYENs
		{
			get
			{
				return this.GetTable<TRUYEN>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CHAP")]
	public partial class CHAP : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaChap;
		
		private System.Nullable<int> _ChuongSo;
		
		private string _TenTruyen;
		
		private System.Nullable<int> _MaTruyen;
		
		private string _Anhbia;
		
		private EntitySet<HINHANH> _HINHANHs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaChapChanging(int value);
    partial void OnMaChapChanged();
    partial void OnChuongSoChanging(System.Nullable<int> value);
    partial void OnChuongSoChanged();
    partial void OnTenTruyenChanging(string value);
    partial void OnTenTruyenChanged();
    partial void OnMaTruyenChanging(System.Nullable<int> value);
    partial void OnMaTruyenChanged();
    partial void OnAnhbiaChanging(string value);
    partial void OnAnhbiaChanged();
    #endregion
		
		public CHAP()
		{
			this._HINHANHs = new EntitySet<HINHANH>(new Action<HINHANH>(this.attach_HINHANHs), new Action<HINHANH>(this.detach_HINHANHs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaChap", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaChap
		{
			get
			{
				return this._MaChap;
			}
			set
			{
				if ((this._MaChap != value))
				{
					this.OnMaChapChanging(value);
					this.SendPropertyChanging();
					this._MaChap = value;
					this.SendPropertyChanged("MaChap");
					this.OnMaChapChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChuongSo", DbType="Int")]
		public System.Nullable<int> ChuongSo
		{
			get
			{
				return this._ChuongSo;
			}
			set
			{
				if ((this._ChuongSo != value))
				{
					this.OnChuongSoChanging(value);
					this.SendPropertyChanging();
					this._ChuongSo = value;
					this.SendPropertyChanged("ChuongSo");
					this.OnChuongSoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenTruyen", DbType="NVarChar(50)")]
		public string TenTruyen
		{
			get
			{
				return this._TenTruyen;
			}
			set
			{
				if ((this._TenTruyen != value))
				{
					this.OnTenTruyenChanging(value);
					this.SendPropertyChanging();
					this._TenTruyen = value;
					this.SendPropertyChanged("TenTruyen");
					this.OnTenTruyenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaTruyen", DbType="Int")]
		public System.Nullable<int> MaTruyen
		{
			get
			{
				return this._MaTruyen;
			}
			set
			{
				if ((this._MaTruyen != value))
				{
					this.OnMaTruyenChanging(value);
					this.SendPropertyChanging();
					this._MaTruyen = value;
					this.SendPropertyChanged("MaTruyen");
					this.OnMaTruyenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Anhbia", DbType="VarChar(50)")]
		public string Anhbia
		{
			get
			{
				return this._Anhbia;
			}
			set
			{
				if ((this._Anhbia != value))
				{
					this.OnAnhbiaChanging(value);
					this.SendPropertyChanging();
					this._Anhbia = value;
					this.SendPropertyChanged("Anhbia");
					this.OnAnhbiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CHAP_HINHANH", Storage="_HINHANHs", ThisKey="MaChap", OtherKey="MaChap")]
		public EntitySet<HINHANH> HINHANHs
		{
			get
			{
				return this._HINHANHs;
			}
			set
			{
				this._HINHANHs.Assign(value);
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
		
		private void attach_HINHANHs(HINHANH entity)
		{
			this.SendPropertyChanging();
			entity.CHAP = this;
		}
		
		private void detach_HINHANHs(HINHANH entity)
		{
			this.SendPropertyChanging();
			entity.CHAP = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HINHANH")]
	public partial class HINHANH : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaHinhAnh;
		
		private System.Nullable<int> _MaChap;
		
		private string _ChuongSo;
		
		private string _TenTruyen;
		
		private string _MaTruyen;
		
		private EntityRef<CHAP> _CHAP;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHinhAnhChanging(int value);
    partial void OnMaHinhAnhChanged();
    partial void OnMaChapChanging(System.Nullable<int> value);
    partial void OnMaChapChanged();
    partial void OnChuongSoChanging(string value);
    partial void OnChuongSoChanged();
    partial void OnTenTruyenChanging(string value);
    partial void OnTenTruyenChanged();
    partial void OnMaTruyenChanging(string value);
    partial void OnMaTruyenChanged();
    #endregion
		
		public HINHANH()
		{
			this._CHAP = default(EntityRef<CHAP>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHinhAnh", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaHinhAnh
		{
			get
			{
				return this._MaHinhAnh;
			}
			set
			{
				if ((this._MaHinhAnh != value))
				{
					this.OnMaHinhAnhChanging(value);
					this.SendPropertyChanging();
					this._MaHinhAnh = value;
					this.SendPropertyChanged("MaHinhAnh");
					this.OnMaHinhAnhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaChap", DbType="Int")]
		public System.Nullable<int> MaChap
		{
			get
			{
				return this._MaChap;
			}
			set
			{
				if ((this._MaChap != value))
				{
					if (this._CHAP.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaChapChanging(value);
					this.SendPropertyChanging();
					this._MaChap = value;
					this.SendPropertyChanged("MaChap");
					this.OnMaChapChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChuongSo", DbType="NVarChar(50)")]
		public string ChuongSo
		{
			get
			{
				return this._ChuongSo;
			}
			set
			{
				if ((this._ChuongSo != value))
				{
					this.OnChuongSoChanging(value);
					this.SendPropertyChanging();
					this._ChuongSo = value;
					this.SendPropertyChanged("ChuongSo");
					this.OnChuongSoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenTruyen", DbType="NChar(10)")]
		public string TenTruyen
		{
			get
			{
				return this._TenTruyen;
			}
			set
			{
				if ((this._TenTruyen != value))
				{
					this.OnTenTruyenChanging(value);
					this.SendPropertyChanging();
					this._TenTruyen = value;
					this.SendPropertyChanged("TenTruyen");
					this.OnTenTruyenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaTruyen", DbType="NVarChar(100)")]
		public string MaTruyen
		{
			get
			{
				return this._MaTruyen;
			}
			set
			{
				if ((this._MaTruyen != value))
				{
					this.OnMaTruyenChanging(value);
					this.SendPropertyChanging();
					this._MaTruyen = value;
					this.SendPropertyChanged("MaTruyen");
					this.OnMaTruyenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CHAP_HINHANH", Storage="_CHAP", ThisKey="MaChap", OtherKey="MaChap", IsForeignKey=true)]
		public CHAP CHAP
		{
			get
			{
				return this._CHAP.Entity;
			}
			set
			{
				CHAP previousValue = this._CHAP.Entity;
				if (((previousValue != value) 
							|| (this._CHAP.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._CHAP.Entity = null;
						previousValue.HINHANHs.Remove(this);
					}
					this._CHAP.Entity = value;
					if ((value != null))
					{
						value.HINHANHs.Add(this);
						this._MaChap = value.MaChap;
					}
					else
					{
						this._MaChap = default(Nullable<int>);
					}
					this.SendPropertyChanged("CHAP");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.THELOAI")]
	public partial class THELOAI : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaTL;
		
		private string _TenTL;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaTLChanging(int value);
    partial void OnMaTLChanged();
    partial void OnTenTLChanging(string value);
    partial void OnTenTLChanged();
    #endregion
		
		public THELOAI()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaTL", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaTL
		{
			get
			{
				return this._MaTL;
			}
			set
			{
				if ((this._MaTL != value))
				{
					this.OnMaTLChanging(value);
					this.SendPropertyChanging();
					this._MaTL = value;
					this.SendPropertyChanged("MaTL");
					this.OnMaTLChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenTL", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenTL
		{
			get
			{
				return this._TenTL;
			}
			set
			{
				if ((this._TenTL != value))
				{
					this.OnTenTLChanging(value);
					this.SendPropertyChanging();
					this._TenTL = value;
					this.SendPropertyChanged("TenTL");
					this.OnTenTLChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TINHTRANG")]
	public partial class TINHTRANG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaTinhTrang;
		
		private string _TenTinhTrang;
		
		private EntitySet<TRUYEN> _TRUYENs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaTinhTrangChanging(int value);
    partial void OnMaTinhTrangChanged();
    partial void OnTenTinhTrangChanging(string value);
    partial void OnTenTinhTrangChanged();
    #endregion
		
		public TINHTRANG()
		{
			this._TRUYENs = new EntitySet<TRUYEN>(new Action<TRUYEN>(this.attach_TRUYENs), new Action<TRUYEN>(this.detach_TRUYENs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaTinhTrang", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaTinhTrang
		{
			get
			{
				return this._MaTinhTrang;
			}
			set
			{
				if ((this._MaTinhTrang != value))
				{
					this.OnMaTinhTrangChanging(value);
					this.SendPropertyChanging();
					this._MaTinhTrang = value;
					this.SendPropertyChanged("MaTinhTrang");
					this.OnMaTinhTrangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenTinhTrang", DbType="NVarChar(50)")]
		public string TenTinhTrang
		{
			get
			{
				return this._TenTinhTrang;
			}
			set
			{
				if ((this._TenTinhTrang != value))
				{
					this.OnTenTinhTrangChanging(value);
					this.SendPropertyChanging();
					this._TenTinhTrang = value;
					this.SendPropertyChanged("TenTinhTrang");
					this.OnTenTinhTrangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TINHTRANG_TRUYEN", Storage="_TRUYENs", ThisKey="MaTinhTrang", OtherKey="MaTinhTrang")]
		public EntitySet<TRUYEN> TRUYENs
		{
			get
			{
				return this._TRUYENs;
			}
			set
			{
				this._TRUYENs.Assign(value);
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
		
		private void attach_TRUYENs(TRUYEN entity)
		{
			this.SendPropertyChanging();
			entity.TINHTRANG = this;
		}
		
		private void detach_TRUYENs(TRUYEN entity)
		{
			this.SendPropertyChanging();
			entity.TINHTRANG = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[USER]")]
	public partial class USER : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdUser;
		
		private string _Taikhoan;
		
		private string _Matkhau;
		
		private string _Email;
		
		private string _DienThoai;
		
		private System.Nullable<System.DateTime> _Ngaysinh;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdUserChanging(int value);
    partial void OnIdUserChanged();
    partial void OnTaikhoanChanging(string value);
    partial void OnTaikhoanChanged();
    partial void OnMatkhauChanging(string value);
    partial void OnMatkhauChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnDienThoaiChanging(string value);
    partial void OnDienThoaiChanged();
    partial void OnNgaysinhChanging(System.Nullable<System.DateTime> value);
    partial void OnNgaysinhChanged();
    #endregion
		
		public USER()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdUser", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int IdUser
		{
			get
			{
				return this._IdUser;
			}
			set
			{
				if ((this._IdUser != value))
				{
					this.OnIdUserChanging(value);
					this.SendPropertyChanging();
					this._IdUser = value;
					this.SendPropertyChanged("IdUser");
					this.OnIdUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Taikhoan", DbType="VarChar(50)")]
		public string Taikhoan
		{
			get
			{
				return this._Taikhoan;
			}
			set
			{
				if ((this._Taikhoan != value))
				{
					this.OnTaikhoanChanging(value);
					this.SendPropertyChanging();
					this._Taikhoan = value;
					this.SendPropertyChanged("Taikhoan");
					this.OnTaikhoanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Matkhau", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Matkhau
		{
			get
			{
				return this._Matkhau;
			}
			set
			{
				if ((this._Matkhau != value))
				{
					this.OnMatkhauChanging(value);
					this.SendPropertyChanging();
					this._Matkhau = value;
					this.SendPropertyChanged("Matkhau");
					this.OnMatkhauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(100)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DienThoai", DbType="VarChar(50)")]
		public string DienThoai
		{
			get
			{
				return this._DienThoai;
			}
			set
			{
				if ((this._DienThoai != value))
				{
					this.OnDienThoaiChanging(value);
					this.SendPropertyChanging();
					this._DienThoai = value;
					this.SendPropertyChanged("DienThoai");
					this.OnDienThoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ngaysinh", DbType="DateTime")]
		public System.Nullable<System.DateTime> Ngaysinh
		{
			get
			{
				return this._Ngaysinh;
			}
			set
			{
				if ((this._Ngaysinh != value))
				{
					this.OnNgaysinhChanging(value);
					this.SendPropertyChanging();
					this._Ngaysinh = value;
					this.SendPropertyChanged("Ngaysinh");
					this.OnNgaysinhChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HuyAdmin")]
	public partial class HuyAdmin
	{
		
		private string _UserAdmin;
		
		private string _PassAdmin;
		
		private string _Hoten;
		
		public HuyAdmin()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserAdmin", DbType="NVarChar(50)")]
		public string UserAdmin
		{
			get
			{
				return this._UserAdmin;
			}
			set
			{
				if ((this._UserAdmin != value))
				{
					this._UserAdmin = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PassAdmin", DbType="NVarChar(50)")]
		public string PassAdmin
		{
			get
			{
				return this._PassAdmin;
			}
			set
			{
				if ((this._PassAdmin != value))
				{
					this._PassAdmin = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hoten", DbType="NVarChar(50)")]
		public string Hoten
		{
			get
			{
				return this._Hoten;
			}
			set
			{
				if ((this._Hoten != value))
				{
					this._Hoten = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MaMANGA")]
	public partial class MaMANGA
	{
		
		private int _MaTruyen;
		
		private int _MaTL;
		
		public MaMANGA()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaTruyen", DbType="Int NOT NULL")]
		public int MaTruyen
		{
			get
			{
				return this._MaTruyen;
			}
			set
			{
				if ((this._MaTruyen != value))
				{
					this._MaTruyen = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaTL", DbType="Int NOT NULL")]
		public int MaTL
		{
			get
			{
				return this._MaTL;
			}
			set
			{
				if ((this._MaTL != value))
				{
					this._MaTL = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TRUYEN")]
	public partial class TRUYEN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaTruyen;
		
		private string _TenTruyen;
		
		private string _Mota;
		
		private string _Anhbia;
		
		private System.Nullable<System.DateTime> _NgayCapNhat;
		
		private System.Nullable<int> _MaTinhTrang;
		
		private EntityRef<TINHTRANG> _TINHTRANG;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaTruyenChanging(int value);
    partial void OnMaTruyenChanged();
    partial void OnTenTruyenChanging(string value);
    partial void OnTenTruyenChanged();
    partial void OnMotaChanging(string value);
    partial void OnMotaChanged();
    partial void OnAnhbiaChanging(string value);
    partial void OnAnhbiaChanged();
    partial void OnNgayCapNhatChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayCapNhatChanged();
    partial void OnMaTinhTrangChanging(System.Nullable<int> value);
    partial void OnMaTinhTrangChanged();
    #endregion
		
		public TRUYEN()
		{
			this._TINHTRANG = default(EntityRef<TINHTRANG>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaTruyen", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaTruyen
		{
			get
			{
				return this._MaTruyen;
			}
			set
			{
				if ((this._MaTruyen != value))
				{
					this.OnMaTruyenChanging(value);
					this.SendPropertyChanging();
					this._MaTruyen = value;
					this.SendPropertyChanged("MaTruyen");
					this.OnMaTruyenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenTruyen", DbType="NVarChar(50)")]
		public string TenTruyen
		{
			get
			{
				return this._TenTruyen;
			}
			set
			{
				if ((this._TenTruyen != value))
				{
					this.OnTenTruyenChanging(value);
					this.SendPropertyChanging();
					this._TenTruyen = value;
					this.SendPropertyChanged("TenTruyen");
					this.OnTenTruyenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mota", DbType="NVarChar(MAX)")]
		public string Mota
		{
			get
			{
				return this._Mota;
			}
			set
			{
				if ((this._Mota != value))
				{
					this.OnMotaChanging(value);
					this.SendPropertyChanging();
					this._Mota = value;
					this.SendPropertyChanged("Mota");
					this.OnMotaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Anhbia", DbType="NVarChar(50)")]
		public string Anhbia
		{
			get
			{
				return this._Anhbia;
			}
			set
			{
				if ((this._Anhbia != value))
				{
					this.OnAnhbiaChanging(value);
					this.SendPropertyChanging();
					this._Anhbia = value;
					this.SendPropertyChanged("Anhbia");
					this.OnAnhbiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayCapNhat", DbType="DateTime")]
		public System.Nullable<System.DateTime> NgayCapNhat
		{
			get
			{
				return this._NgayCapNhat;
			}
			set
			{
				if ((this._NgayCapNhat != value))
				{
					this.OnNgayCapNhatChanging(value);
					this.SendPropertyChanging();
					this._NgayCapNhat = value;
					this.SendPropertyChanged("NgayCapNhat");
					this.OnNgayCapNhatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaTinhTrang", DbType="Int")]
		public System.Nullable<int> MaTinhTrang
		{
			get
			{
				return this._MaTinhTrang;
			}
			set
			{
				if ((this._MaTinhTrang != value))
				{
					if (this._TINHTRANG.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaTinhTrangChanging(value);
					this.SendPropertyChanging();
					this._MaTinhTrang = value;
					this.SendPropertyChanged("MaTinhTrang");
					this.OnMaTinhTrangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TINHTRANG_TRUYEN", Storage="_TINHTRANG", ThisKey="MaTinhTrang", OtherKey="MaTinhTrang", IsForeignKey=true)]
		public TINHTRANG TINHTRANG
		{
			get
			{
				return this._TINHTRANG.Entity;
			}
			set
			{
				TINHTRANG previousValue = this._TINHTRANG.Entity;
				if (((previousValue != value) 
							|| (this._TINHTRANG.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TINHTRANG.Entity = null;
						previousValue.TRUYENs.Remove(this);
					}
					this._TINHTRANG.Entity = value;
					if ((value != null))
					{
						value.TRUYENs.Add(this);
						this._MaTinhTrang = value.MaTinhTrang;
					}
					else
					{
						this._MaTinhTrang = default(Nullable<int>);
					}
					this.SendPropertyChanged("TINHTRANG");
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
