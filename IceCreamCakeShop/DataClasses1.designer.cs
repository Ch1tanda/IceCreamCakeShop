﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace IceCreamCakeShop
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="IceCream Cake Shop")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 可扩展性方法定义
    partial void OnCreated();
    partial void InsertCakeinfo(Cakeinfo instance);
    partial void UpdateCakeinfo(Cakeinfo instance);
    partial void DeleteCakeinfo(Cakeinfo instance);
    partial void InsertGoods(Goods instance);
    partial void UpdateGoods(Goods instance);
    partial void DeleteGoods(Goods instance);
    partial void InsertStaffinfo(Staffinfo instance);
    partial void UpdateStaffinfo(Staffinfo instance);
    partial void DeleteStaffinfo(Staffinfo instance);
    partial void InsertStock(Stock instance);
    partial void UpdateStock(Stock instance);
    partial void DeleteStock(Stock instance);
    partial void InsertSupplierinfo(Supplierinfo instance);
    partial void UpdateSupplierinfo(Supplierinfo instance);
    partial void DeleteSupplierinfo(Supplierinfo instance);
    partial void InsertSupplierorder(Supplierorder instance);
    partial void UpdateSupplierorder(Supplierorder instance);
    partial void DeleteSupplierorder(Supplierorder instance);
    partial void InsertUserinfo(Userinfo instance);
    partial void UpdateUserinfo(Userinfo instance);
    partial void DeleteUserinfo(Userinfo instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["IceCream_Cake_ShopConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Cakeinfo> Cakeinfo
		{
			get
			{
				return this.GetTable<Cakeinfo>();
			}
		}
		
		public System.Data.Linq.Table<Goods> Goods
		{
			get
			{
				return this.GetTable<Goods>();
			}
		}
		
		public System.Data.Linq.Table<Staffinfo> Staffinfo
		{
			get
			{
				return this.GetTable<Staffinfo>();
			}
		}
		
		public System.Data.Linq.Table<Stock> Stock
		{
			get
			{
				return this.GetTable<Stock>();
			}
		}
		
		public System.Data.Linq.Table<Supplierinfo> Supplierinfo
		{
			get
			{
				return this.GetTable<Supplierinfo>();
			}
		}
		
		public System.Data.Linq.Table<Supplierorder> Supplierorder
		{
			get
			{
				return this.GetTable<Supplierorder>();
			}
		}
		
		public System.Data.Linq.Table<Userinfo> Userinfo
		{
			get
			{
				return this.GetTable<Userinfo>();
			}
		}
		
		public System.Data.Linq.Table<Userorder> Userorder
		{
			get
			{
				return this.GetTable<Userorder>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Cakeinfo")]
	public partial class Cakeinfo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _id;
		
		private string _name;
		
		private decimal _price;
		
		private string _recipe;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(string value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnpriceChanging(decimal value);
    partial void OnpriceChanged();
    partial void OnrecipeChanging(string value);
    partial void OnrecipeChanged();
    #endregion
		
		public Cakeinfo()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Decimal(10,2) NOT NULL")]
		public decimal price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this.OnpriceChanging(value);
					this.SendPropertyChanging();
					this._price = value;
					this.SendPropertyChanged("price");
					this.OnpriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_recipe", DbType="VarChar(50)")]
		public string recipe
		{
			get
			{
				return this._recipe;
			}
			set
			{
				if ((this._recipe != value))
				{
					this.OnrecipeChanging(value);
					this.SendPropertyChanging();
					this._recipe = value;
					this.SendPropertyChanged("recipe");
					this.OnrecipeChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Goods")]
	public partial class Goods : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _sid;
		
		private string _mid;
		
		private decimal _price;
		
		private EntityRef<Supplierinfo> _Supplierinfo;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnsidChanging(string value);
    partial void OnsidChanged();
    partial void OnmidChanging(string value);
    partial void OnmidChanged();
    partial void OnpriceChanging(decimal value);
    partial void OnpriceChanged();
    #endregion
		
		public Goods()
		{
			this._Supplierinfo = default(EntityRef<Supplierinfo>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sid", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string sid
		{
			get
			{
				return this._sid;
			}
			set
			{
				if ((this._sid != value))
				{
					if (this._Supplierinfo.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnsidChanging(value);
					this.SendPropertyChanging();
					this._sid = value;
					this.SendPropertyChanged("sid");
					this.OnsidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mid", DbType="VarChar(5) NOT NULL", CanBeNull=false)]
		public string mid
		{
			get
			{
				return this._mid;
			}
			set
			{
				if ((this._mid != value))
				{
					this.OnmidChanging(value);
					this.SendPropertyChanging();
					this._mid = value;
					this.SendPropertyChanged("mid");
					this.OnmidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Decimal(10,2) NOT NULL")]
		public decimal price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this.OnpriceChanging(value);
					this.SendPropertyChanging();
					this._price = value;
					this.SendPropertyChanged("price");
					this.OnpriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Supplierinfo_Goods", Storage="_Supplierinfo", ThisKey="sid", OtherKey="id", IsForeignKey=true)]
		public Supplierinfo Supplierinfo
		{
			get
			{
				return this._Supplierinfo.Entity;
			}
			set
			{
				Supplierinfo previousValue = this._Supplierinfo.Entity;
				if (((previousValue != value) 
							|| (this._Supplierinfo.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Supplierinfo.Entity = null;
						previousValue.Goods = null;
					}
					this._Supplierinfo.Entity = value;
					if ((value != null))
					{
						value.Goods = this;
						this._sid = value.id;
					}
					else
					{
						this._sid = default(string);
					}
					this.SendPropertyChanged("Supplierinfo");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Staffinfo")]
	public partial class Staffinfo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _id;
		
		private string _password;
		
		private string _name;
		
		private string _sex;
		
		private string _age;
		
		private string _phonenumber;
		
		private string _position;
		
		private string _salary;
		
		private EntitySet<Supplierorder> _Supplierorder;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(string value);
    partial void OnidChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnsexChanging(string value);
    partial void OnsexChanged();
    partial void OnageChanging(string value);
    partial void OnageChanged();
    partial void OnphonenumberChanging(string value);
    partial void OnphonenumberChanged();
    partial void OnpositionChanging(string value);
    partial void OnpositionChanged();
    partial void OnsalaryChanging(string value);
    partial void OnsalaryChanged();
    #endregion
		
		public Staffinfo()
		{
			this._Supplierorder = new EntitySet<Supplierorder>(new Action<Supplierorder>(this.attach_Supplierorder), new Action<Supplierorder>(this.detach_Supplierorder));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="VarChar(4) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(16) NOT NULL", CanBeNull=false)]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(24) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sex", DbType="VarChar(6) NOT NULL", CanBeNull=false)]
		public string sex
		{
			get
			{
				return this._sex;
			}
			set
			{
				if ((this._sex != value))
				{
					this.OnsexChanging(value);
					this.SendPropertyChanging();
					this._sex = value;
					this.SendPropertyChanged("sex");
					this.OnsexChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_age", DbType="VarChar(3) NOT NULL", CanBeNull=false)]
		public string age
		{
			get
			{
				return this._age;
			}
			set
			{
				if ((this._age != value))
				{
					this.OnageChanging(value);
					this.SendPropertyChanging();
					this._age = value;
					this.SendPropertyChanged("age");
					this.OnageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phonenumber", DbType="VarChar(32) NOT NULL", CanBeNull=false)]
		public string phonenumber
		{
			get
			{
				return this._phonenumber;
			}
			set
			{
				if ((this._phonenumber != value))
				{
					this.OnphonenumberChanging(value);
					this.SendPropertyChanging();
					this._phonenumber = value;
					this.SendPropertyChanged("phonenumber");
					this.OnphonenumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_position", DbType="VarChar(16) NOT NULL", CanBeNull=false)]
		public string position
		{
			get
			{
				return this._position;
			}
			set
			{
				if ((this._position != value))
				{
					this.OnpositionChanging(value);
					this.SendPropertyChanging();
					this._position = value;
					this.SendPropertyChanged("position");
					this.OnpositionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_salary", DbType="VarChar(16) NOT NULL", CanBeNull=false)]
		public string salary
		{
			get
			{
				return this._salary;
			}
			set
			{
				if ((this._salary != value))
				{
					this.OnsalaryChanging(value);
					this.SendPropertyChanging();
					this._salary = value;
					this.SendPropertyChanged("salary");
					this.OnsalaryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Staffinfo_Supplierorder", Storage="_Supplierorder", ThisKey="id", OtherKey="staffid")]
		public EntitySet<Supplierorder> Supplierorder
		{
			get
			{
				return this._Supplierorder;
			}
			set
			{
				this._Supplierorder.Assign(value);
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
		
		private void attach_Supplierorder(Supplierorder entity)
		{
			this.SendPropertyChanging();
			entity.Staffinfo = this;
		}
		
		private void detach_Supplierorder(Supplierorder entity)
		{
			this.SendPropertyChanging();
			entity.Staffinfo = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Stock")]
	public partial class Stock : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _mid;
		
		private string _name;
		
		private int _stock1;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmidChanging(string value);
    partial void OnmidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void Onstock1Changing(int value);
    partial void Onstock1Changed();
    #endregion
		
		public Stock()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mid", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string mid
		{
			get
			{
				return this._mid;
			}
			set
			{
				if ((this._mid != value))
				{
					this.OnmidChanging(value);
					this.SendPropertyChanging();
					this._mid = value;
					this.SendPropertyChanged("mid");
					this.OnmidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="stock", Storage="_stock1", DbType="Int NOT NULL")]
		public int stock1
		{
			get
			{
				return this._stock1;
			}
			set
			{
				if ((this._stock1 != value))
				{
					this.Onstock1Changing(value);
					this.SendPropertyChanging();
					this._stock1 = value;
					this.SendPropertyChanged("stock1");
					this.Onstock1Changed();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Supplierinfo")]
	public partial class Supplierinfo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _id;
		
		private string _name;
		
		private string _tel;
		
		private EntityRef<Goods> _Goods;
		
		private EntitySet<Supplierorder> _Supplierorder;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(string value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OntelChanging(string value);
    partial void OntelChanged();
    #endregion
		
		public Supplierinfo()
		{
			this._Goods = default(EntityRef<Goods>);
			this._Supplierorder = new EntitySet<Supplierorder>(new Action<Supplierorder>(this.attach_Supplierorder), new Action<Supplierorder>(this.detach_Supplierorder));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(40) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tel", DbType="VarChar(11) NOT NULL", CanBeNull=false)]
		public string tel
		{
			get
			{
				return this._tel;
			}
			set
			{
				if ((this._tel != value))
				{
					this.OntelChanging(value);
					this.SendPropertyChanging();
					this._tel = value;
					this.SendPropertyChanged("tel");
					this.OntelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Supplierinfo_Goods", Storage="_Goods", ThisKey="id", OtherKey="sid", IsUnique=true, IsForeignKey=false)]
		public Goods Goods
		{
			get
			{
				return this._Goods.Entity;
			}
			set
			{
				Goods previousValue = this._Goods.Entity;
				if (((previousValue != value) 
							|| (this._Goods.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Goods.Entity = null;
						previousValue.Supplierinfo = null;
					}
					this._Goods.Entity = value;
					if ((value != null))
					{
						value.Supplierinfo = this;
					}
					this.SendPropertyChanged("Goods");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Supplierinfo_Supplierorder", Storage="_Supplierorder", ThisKey="id", OtherKey="supplierid")]
		public EntitySet<Supplierorder> Supplierorder
		{
			get
			{
				return this._Supplierorder;
			}
			set
			{
				this._Supplierorder.Assign(value);
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
		
		private void attach_Supplierorder(Supplierorder entity)
		{
			this.SendPropertyChanging();
			entity.Supplierinfo = this;
		}
		
		private void detach_Supplierorder(Supplierorder entity)
		{
			this.SendPropertyChanging();
			entity.Supplierinfo = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Supplierorder")]
	public partial class Supplierorder : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _id;
		
		private string _supplierid;
		
		private string _materialid;
		
		private int _number;
		
		private decimal _price;
		
		private string _staffid;
		
		private System.DateTime _time;
		
		private EntityRef<Staffinfo> _Staffinfo;
		
		private EntityRef<Supplierinfo> _Supplierinfo;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(string value);
    partial void OnidChanged();
    partial void OnsupplieridChanging(string value);
    partial void OnsupplieridChanged();
    partial void OnmaterialidChanging(string value);
    partial void OnmaterialidChanged();
    partial void OnnumberChanging(int value);
    partial void OnnumberChanged();
    partial void OnpriceChanging(decimal value);
    partial void OnpriceChanged();
    partial void OnstaffidChanging(string value);
    partial void OnstaffidChanged();
    partial void OntimeChanging(System.DateTime value);
    partial void OntimeChanged();
    #endregion
		
		public Supplierorder()
		{
			this._Staffinfo = default(EntityRef<Staffinfo>);
			this._Supplierinfo = default(EntityRef<Supplierinfo>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_supplierid", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string supplierid
		{
			get
			{
				return this._supplierid;
			}
			set
			{
				if ((this._supplierid != value))
				{
					if (this._Supplierinfo.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnsupplieridChanging(value);
					this.SendPropertyChanging();
					this._supplierid = value;
					this.SendPropertyChanged("supplierid");
					this.OnsupplieridChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_materialid", DbType="VarChar(5) NOT NULL", CanBeNull=false)]
		public string materialid
		{
			get
			{
				return this._materialid;
			}
			set
			{
				if ((this._materialid != value))
				{
					this.OnmaterialidChanging(value);
					this.SendPropertyChanging();
					this._materialid = value;
					this.SendPropertyChanged("materialid");
					this.OnmaterialidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_number", DbType="Int NOT NULL")]
		public int number
		{
			get
			{
				return this._number;
			}
			set
			{
				if ((this._number != value))
				{
					this.OnnumberChanging(value);
					this.SendPropertyChanging();
					this._number = value;
					this.SendPropertyChanged("number");
					this.OnnumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Decimal(10,2) NOT NULL")]
		public decimal price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this.OnpriceChanging(value);
					this.SendPropertyChanging();
					this._price = value;
					this.SendPropertyChanged("price");
					this.OnpriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_staffid", DbType="VarChar(4) NOT NULL", CanBeNull=false)]
		public string staffid
		{
			get
			{
				return this._staffid;
			}
			set
			{
				if ((this._staffid != value))
				{
					if (this._Staffinfo.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnstaffidChanging(value);
					this.SendPropertyChanging();
					this._staffid = value;
					this.SendPropertyChanged("staffid");
					this.OnstaffidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_time", DbType="DateTime NOT NULL")]
		public System.DateTime time
		{
			get
			{
				return this._time;
			}
			set
			{
				if ((this._time != value))
				{
					this.OntimeChanging(value);
					this.SendPropertyChanging();
					this._time = value;
					this.SendPropertyChanged("time");
					this.OntimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Staffinfo_Supplierorder", Storage="_Staffinfo", ThisKey="staffid", OtherKey="id", IsForeignKey=true)]
		public Staffinfo Staffinfo
		{
			get
			{
				return this._Staffinfo.Entity;
			}
			set
			{
				Staffinfo previousValue = this._Staffinfo.Entity;
				if (((previousValue != value) 
							|| (this._Staffinfo.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Staffinfo.Entity = null;
						previousValue.Supplierorder.Remove(this);
					}
					this._Staffinfo.Entity = value;
					if ((value != null))
					{
						value.Supplierorder.Add(this);
						this._staffid = value.id;
					}
					else
					{
						this._staffid = default(string);
					}
					this.SendPropertyChanged("Staffinfo");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Supplierinfo_Supplierorder", Storage="_Supplierinfo", ThisKey="supplierid", OtherKey="id", IsForeignKey=true)]
		public Supplierinfo Supplierinfo
		{
			get
			{
				return this._Supplierinfo.Entity;
			}
			set
			{
				Supplierinfo previousValue = this._Supplierinfo.Entity;
				if (((previousValue != value) 
							|| (this._Supplierinfo.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Supplierinfo.Entity = null;
						previousValue.Supplierorder.Remove(this);
					}
					this._Supplierinfo.Entity = value;
					if ((value != null))
					{
						value.Supplierorder.Add(this);
						this._supplierid = value.id;
					}
					else
					{
						this._supplierid = default(string);
					}
					this.SendPropertyChanged("Supplierinfo");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Userinfo")]
	public partial class Userinfo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _id;
		
		private string _password;
		
		private string _username;
		
		private string _phonenumber;
		
		private string _address;
		
		private string _birthday;
		
		private string _viptype;
		
		private decimal _gmv;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(string value);
    partial void OnidChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnphonenumberChanging(string value);
    partial void OnphonenumberChanged();
    partial void OnaddressChanging(string value);
    partial void OnaddressChanged();
    partial void OnbirthdayChanging(string value);
    partial void OnbirthdayChanged();
    partial void OnviptypeChanging(string value);
    partial void OnviptypeChanged();
    partial void OngmvChanging(decimal value);
    partial void OngmvChanged();
    #endregion
		
		public Userinfo()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(16) NOT NULL", CanBeNull=false)]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="VarChar(24) NOT NULL", CanBeNull=false)]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phonenumber", DbType="VarChar(32) NOT NULL", CanBeNull=false)]
		public string phonenumber
		{
			get
			{
				return this._phonenumber;
			}
			set
			{
				if ((this._phonenumber != value))
				{
					this.OnphonenumberChanging(value);
					this.SendPropertyChanging();
					this._phonenumber = value;
					this.SendPropertyChanged("phonenumber");
					this.OnphonenumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_address", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string address
		{
			get
			{
				return this._address;
			}
			set
			{
				if ((this._address != value))
				{
					this.OnaddressChanging(value);
					this.SendPropertyChanging();
					this._address = value;
					this.SendPropertyChanged("address");
					this.OnaddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_birthday", DbType="VarChar(8) NOT NULL", CanBeNull=false)]
		public string birthday
		{
			get
			{
				return this._birthday;
			}
			set
			{
				if ((this._birthday != value))
				{
					this.OnbirthdayChanging(value);
					this.SendPropertyChanging();
					this._birthday = value;
					this.SendPropertyChanged("birthday");
					this.OnbirthdayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_viptype", DbType="VarChar(16) NOT NULL", CanBeNull=false)]
		public string viptype
		{
			get
			{
				return this._viptype;
			}
			set
			{
				if ((this._viptype != value))
				{
					this.OnviptypeChanging(value);
					this.SendPropertyChanging();
					this._viptype = value;
					this.SendPropertyChanged("viptype");
					this.OnviptypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gmv", DbType="Decimal(10,2) NOT NULL")]
		public decimal gmv
		{
			get
			{
				return this._gmv;
			}
			set
			{
				if ((this._gmv != value))
				{
					this.OngmvChanging(value);
					this.SendPropertyChanging();
					this._gmv = value;
					this.SendPropertyChanged("gmv");
					this.OngmvChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Userorder")]
	public partial class Userorder
	{
		
		private string _id;
		
		private string _userid;
		
		private string _staffid;
		
		private string _cdid;
		
		private int _number;
		
		private decimal _price;
		
		private System.DateTime _time;
		
		public Userorder()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this._id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userid", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string userid
		{
			get
			{
				return this._userid;
			}
			set
			{
				if ((this._userid != value))
				{
					this._userid = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_staffid", DbType="VarChar(4) NOT NULL", CanBeNull=false)]
		public string staffid
		{
			get
			{
				return this._staffid;
			}
			set
			{
				if ((this._staffid != value))
				{
					this._staffid = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cdid", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string cdid
		{
			get
			{
				return this._cdid;
			}
			set
			{
				if ((this._cdid != value))
				{
					this._cdid = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_number", DbType="Int NOT NULL")]
		public int number
		{
			get
			{
				return this._number;
			}
			set
			{
				if ((this._number != value))
				{
					this._number = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Decimal(10,2) NOT NULL")]
		public decimal price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this._price = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_time", DbType="DateTime NOT NULL")]
		public System.DateTime time
		{
			get
			{
				return this._time;
			}
			set
			{
				if ((this._time != value))
				{
					this._time = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
