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

namespace Prototype_TNT_Der1
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ProtoDB")]
	public partial class ProtoTypeDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertUSER(USER instance);
    partial void UpdateUSER(USER instance);
    partial void DeleteUSER(USER instance);
    partial void InsertGuestDetail(GuestDetail instance);
    partial void UpdateGuestDetail(GuestDetail instance);
    partial void DeleteGuestDetail(GuestDetail instance);
    partial void InsertEventImage(EventImage instance);
    partial void UpdateEventImage(EventImage instance);
    partial void DeleteEventImage(EventImage instance);
    partial void InsertEvent(Event instance);
    partial void UpdateEvent(Event instance);
    partial void DeleteEvent(Event instance);
    #endregion
		
		public ProtoTypeDBDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["ProtoDBConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ProtoTypeDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProtoTypeDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProtoTypeDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProtoTypeDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<USER> USERs
		{
			get
			{
				return this.GetTable<USER>();
			}
		}
		
		public System.Data.Linq.Table<Temp_GuestForm> Temp_GuestForms
		{
			get
			{
				return this.GetTable<Temp_GuestForm>();
			}
		}
		
		public System.Data.Linq.Table<GuestDetail> GuestDetails
		{
			get
			{
				return this.GetTable<GuestDetail>();
			}
		}
		
		public System.Data.Linq.Table<EventImage> EventImages
		{
			get
			{
				return this.GetTable<EventImage>();
			}
		}
		
		public System.Data.Linq.Table<Event> Events
		{
			get
			{
				return this.GetTable<Event>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[USER]")]
	public partial class USER : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Email;
		
		private string _Password;
		
		private string _Name;
		
		private string _Surname;
		
		private string _Company_Name;
		
		private string _Bank_Name;
		
		private string _Account_Number;
		
		private EntitySet<Event> _Events;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnSurnameChanging(string value);
    partial void OnSurnameChanged();
    partial void OnCompany_NameChanging(string value);
    partial void OnCompany_NameChanged();
    partial void OnBank_NameChanging(string value);
    partial void OnBank_NameChanged();
    partial void OnAccount_NumberChanging(string value);
    partial void OnAccount_NumberChanged();
    #endregion
		
		public USER()
		{
			this._Events = new EntitySet<Event>(new Action<Event>(this.attach_Events), new Action<Event>(this.detach_Events));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(MAX)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Surname", DbType="VarChar(50)")]
		public string Surname
		{
			get
			{
				return this._Surname;
			}
			set
			{
				if ((this._Surname != value))
				{
					this.OnSurnameChanging(value);
					this.SendPropertyChanging();
					this._Surname = value;
					this.SendPropertyChanged("Surname");
					this.OnSurnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Company_Name", DbType="VarChar(MAX)")]
		public string Company_Name
		{
			get
			{
				return this._Company_Name;
			}
			set
			{
				if ((this._Company_Name != value))
				{
					this.OnCompany_NameChanging(value);
					this.SendPropertyChanging();
					this._Company_Name = value;
					this.SendPropertyChanged("Company_Name");
					this.OnCompany_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Bank_Name", DbType="VarChar(MAX)")]
		public string Bank_Name
		{
			get
			{
				return this._Bank_Name;
			}
			set
			{
				if ((this._Bank_Name != value))
				{
					this.OnBank_NameChanging(value);
					this.SendPropertyChanging();
					this._Bank_Name = value;
					this.SendPropertyChanged("Bank_Name");
					this.OnBank_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Account_Number", DbType="VarChar(MAX)")]
		public string Account_Number
		{
			get
			{
				return this._Account_Number;
			}
			set
			{
				if ((this._Account_Number != value))
				{
					this.OnAccount_NumberChanging(value);
					this.SendPropertyChanging();
					this._Account_Number = value;
					this.SendPropertyChanged("Account_Number");
					this.OnAccount_NumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="USER_Event", Storage="_Events", ThisKey="Id", OtherKey="Id")]
		public EntitySet<Event> Events
		{
			get
			{
				return this._Events;
			}
			set
			{
				this._Events.Assign(value);
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
		
		private void attach_Events(Event entity)
		{
			this.SendPropertyChanging();
			entity.USER = this;
		}
		
		private void detach_Events(Event entity)
		{
			this.SendPropertyChanging();
			entity.USER = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Temp_GuestForm")]
	public partial class Temp_GuestForm
	{
		
		private string _Name;
		
		private string _Surname;
		
		private string _Email;
		
		private System.Nullable<int> _PhoneNumber;
		
		private string _Status;
		
		private System.Nullable<decimal> _Credit;
		
		public Temp_GuestForm()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Surname", DbType="VarChar(50)")]
		public string Surname
		{
			get
			{
				return this._Surname;
			}
			set
			{
				if ((this._Surname != value))
				{
					this._Surname = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(MAX)")]
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
					this._Email = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNumber", DbType="Int")]
		public System.Nullable<int> PhoneNumber
		{
			get
			{
				return this._PhoneNumber;
			}
			set
			{
				if ((this._PhoneNumber != value))
				{
					this._PhoneNumber = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="VarChar(MAX)")]
		public string Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this._Status = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Credit", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> Credit
		{
			get
			{
				return this._Credit;
			}
			set
			{
				if ((this._Credit != value))
				{
					this._Credit = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.GuestDetail")]
	public partial class GuestDetail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _GuestID;
		
		private string _Name;
		
		private string _Surname;
		
		private string _Email;
		
		private System.Nullable<int> _PhoneNumber;
		
		private string _Status;
		
		private System.Nullable<decimal> _Credit;
		
		private string _Passowrd;
		
		private System.Nullable<int> _EventID;
		
		private EntityRef<Event> _Event;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnGuestIDChanging(int value);
    partial void OnGuestIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnSurnameChanging(string value);
    partial void OnSurnameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPhoneNumberChanging(System.Nullable<int> value);
    partial void OnPhoneNumberChanged();
    partial void OnStatusChanging(string value);
    partial void OnStatusChanged();
    partial void OnCreditChanging(System.Nullable<decimal> value);
    partial void OnCreditChanged();
    partial void OnPassowrdChanging(string value);
    partial void OnPassowrdChanged();
    partial void OnEventIDChanging(System.Nullable<int> value);
    partial void OnEventIDChanged();
    #endregion
		
		public GuestDetail()
		{
			this._Event = default(EntityRef<Event>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GuestID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int GuestID
		{
			get
			{
				return this._GuestID;
			}
			set
			{
				if ((this._GuestID != value))
				{
					this.OnGuestIDChanging(value);
					this.SendPropertyChanging();
					this._GuestID = value;
					this.SendPropertyChanged("GuestID");
					this.OnGuestIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Surname", DbType="VarChar(50)")]
		public string Surname
		{
			get
			{
				return this._Surname;
			}
			set
			{
				if ((this._Surname != value))
				{
					this.OnSurnameChanging(value);
					this.SendPropertyChanging();
					this._Surname = value;
					this.SendPropertyChanged("Surname");
					this.OnSurnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(MAX)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNumber", DbType="Int")]
		public System.Nullable<int> PhoneNumber
		{
			get
			{
				return this._PhoneNumber;
			}
			set
			{
				if ((this._PhoneNumber != value))
				{
					this.OnPhoneNumberChanging(value);
					this.SendPropertyChanging();
					this._PhoneNumber = value;
					this.SendPropertyChanged("PhoneNumber");
					this.OnPhoneNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="VarChar(MAX)")]
		public string Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Credit", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> Credit
		{
			get
			{
				return this._Credit;
			}
			set
			{
				if ((this._Credit != value))
				{
					this.OnCreditChanging(value);
					this.SendPropertyChanging();
					this._Credit = value;
					this.SendPropertyChanged("Credit");
					this.OnCreditChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Passowrd", DbType="VarChar(MAX)")]
		public string Passowrd
		{
			get
			{
				return this._Passowrd;
			}
			set
			{
				if ((this._Passowrd != value))
				{
					this.OnPassowrdChanging(value);
					this.SendPropertyChanging();
					this._Passowrd = value;
					this.SendPropertyChanged("Passowrd");
					this.OnPassowrdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EventID", DbType="Int")]
		public System.Nullable<int> EventID
		{
			get
			{
				return this._EventID;
			}
			set
			{
				if ((this._EventID != value))
				{
					if (this._Event.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnEventIDChanging(value);
					this.SendPropertyChanging();
					this._EventID = value;
					this.SendPropertyChanged("EventID");
					this.OnEventIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Event_GuestDetail", Storage="_Event", ThisKey="EventID", OtherKey="EventID", IsForeignKey=true)]
		public Event Event
		{
			get
			{
				return this._Event.Entity;
			}
			set
			{
				Event previousValue = this._Event.Entity;
				if (((previousValue != value) 
							|| (this._Event.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Event.Entity = null;
						previousValue.GuestDetails.Remove(this);
					}
					this._Event.Entity = value;
					if ((value != null))
					{
						value.GuestDetails.Add(this);
						this._EventID = value.EventID;
					}
					else
					{
						this._EventID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Event");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EventImage")]
	public partial class EventImage : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Image_Id;
		
		private string _Name;
		
		private string _ContentType;
		
		private System.Data.Linq.Binary _Data;
		
		private System.Nullable<int> _EventID;
		
		private EntityRef<Event> _Event;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnImage_IdChanging(int value);
    partial void OnImage_IdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnContentTypeChanging(string value);
    partial void OnContentTypeChanged();
    partial void OnDataChanging(System.Data.Linq.Binary value);
    partial void OnDataChanged();
    partial void OnEventIDChanging(System.Nullable<int> value);
    partial void OnEventIDChanged();
    #endregion
		
		public EventImage()
		{
			this._Event = default(EntityRef<Event>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Image_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Image_Id
		{
			get
			{
				return this._Image_Id;
			}
			set
			{
				if ((this._Image_Id != value))
				{
					this.OnImage_IdChanging(value);
					this.SendPropertyChanging();
					this._Image_Id = value;
					this.SendPropertyChanged("Image_Id");
					this.OnImage_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(MAX)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContentType", DbType="VarChar(MAX)")]
		public string ContentType
		{
			get
			{
				return this._ContentType;
			}
			set
			{
				if ((this._ContentType != value))
				{
					this.OnContentTypeChanging(value);
					this.SendPropertyChanging();
					this._ContentType = value;
					this.SendPropertyChanged("ContentType");
					this.OnContentTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Data", DbType="Binary(50)", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Data
		{
			get
			{
				return this._Data;
			}
			set
			{
				if ((this._Data != value))
				{
					this.OnDataChanging(value);
					this.SendPropertyChanging();
					this._Data = value;
					this.SendPropertyChanged("Data");
					this.OnDataChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EventID", DbType="Int")]
		public System.Nullable<int> EventID
		{
			get
			{
				return this._EventID;
			}
			set
			{
				if ((this._EventID != value))
				{
					if (this._Event.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnEventIDChanging(value);
					this.SendPropertyChanging();
					this._EventID = value;
					this.SendPropertyChanged("EventID");
					this.OnEventIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Event_EventImage", Storage="_Event", ThisKey="EventID", OtherKey="EventID", IsForeignKey=true)]
		public Event Event
		{
			get
			{
				return this._Event.Entity;
			}
			set
			{
				Event previousValue = this._Event.Entity;
				if (((previousValue != value) 
							|| (this._Event.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Event.Entity = null;
						previousValue.EventImages.Remove(this);
					}
					this._Event.Entity = value;
					if ((value != null))
					{
						value.EventImages.Add(this);
						this._EventID = value.EventID;
					}
					else
					{
						this._EventID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Event");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Event")]
	public partial class Event : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _EventID;
		
		private string _EventName;
		
		private string _EventDes;
		
		private int _Id;
		
		private string _Venue;
		
		private System.Nullable<System.DateTime> _Date;
		
		private System.Nullable<int> _NUMGuest;
		
		private string _Event_Type;
		
		private string _Venue_Name;
		
		private string _Venue_Address;
		
		private System.Data.Linq.Binary _Venue_Layout;
		
		private EntitySet<GuestDetail> _GuestDetails;
		
		private EntitySet<EventImage> _EventImages;
		
		private EntityRef<USER> _USER;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEventIDChanging(int value);
    partial void OnEventIDChanged();
    partial void OnEventNameChanging(string value);
    partial void OnEventNameChanged();
    partial void OnEventDesChanging(string value);
    partial void OnEventDesChanged();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnVenueChanging(string value);
    partial void OnVenueChanged();
    partial void OnDateChanging(System.Nullable<System.DateTime> value);
    partial void OnDateChanged();
    partial void OnNUMGuestChanging(System.Nullable<int> value);
    partial void OnNUMGuestChanged();
    partial void OnEvent_TypeChanging(string value);
    partial void OnEvent_TypeChanged();
    partial void OnVenue_NameChanging(string value);
    partial void OnVenue_NameChanged();
    partial void OnVenue_AddressChanging(string value);
    partial void OnVenue_AddressChanged();
    partial void OnVenue_LayoutChanging(System.Data.Linq.Binary value);
    partial void OnVenue_LayoutChanged();
    #endregion
		
		public Event()
		{
			this._GuestDetails = new EntitySet<GuestDetail>(new Action<GuestDetail>(this.attach_GuestDetails), new Action<GuestDetail>(this.detach_GuestDetails));
			this._EventImages = new EntitySet<EventImage>(new Action<EventImage>(this.attach_EventImages), new Action<EventImage>(this.detach_EventImages));
			this._USER = default(EntityRef<USER>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EventID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int EventID
		{
			get
			{
				return this._EventID;
			}
			set
			{
				if ((this._EventID != value))
				{
					this.OnEventIDChanging(value);
					this.SendPropertyChanging();
					this._EventID = value;
					this.SendPropertyChanged("EventID");
					this.OnEventIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EventName", DbType="VarChar(50)")]
		public string EventName
		{
			get
			{
				return this._EventName;
			}
			set
			{
				if ((this._EventName != value))
				{
					this.OnEventNameChanging(value);
					this.SendPropertyChanging();
					this._EventName = value;
					this.SendPropertyChanged("EventName");
					this.OnEventNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EventDes", DbType="VarChar(MAX)")]
		public string EventDes
		{
			get
			{
				return this._EventDes;
			}
			set
			{
				if ((this._EventDes != value))
				{
					this.OnEventDesChanging(value);
					this.SendPropertyChanging();
					this._EventDes = value;
					this.SendPropertyChanged("EventDes");
					this.OnEventDesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL")]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					if (this._USER.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Venue", DbType="VarChar(MAX)")]
		public string Venue
		{
			get
			{
				return this._Venue;
			}
			set
			{
				if ((this._Venue != value))
				{
					this.OnVenueChanging(value);
					this.SendPropertyChanging();
					this._Venue = value;
					this.SendPropertyChanged("Venue");
					this.OnVenueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="DateTime")]
		public System.Nullable<System.DateTime> Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NUMGuest", DbType="Int")]
		public System.Nullable<int> NUMGuest
		{
			get
			{
				return this._NUMGuest;
			}
			set
			{
				if ((this._NUMGuest != value))
				{
					this.OnNUMGuestChanging(value);
					this.SendPropertyChanging();
					this._NUMGuest = value;
					this.SendPropertyChanged("NUMGuest");
					this.OnNUMGuestChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Event_Type", DbType="VarChar(MAX)")]
		public string Event_Type
		{
			get
			{
				return this._Event_Type;
			}
			set
			{
				if ((this._Event_Type != value))
				{
					this.OnEvent_TypeChanging(value);
					this.SendPropertyChanging();
					this._Event_Type = value;
					this.SendPropertyChanged("Event_Type");
					this.OnEvent_TypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Venue_Name", DbType="VarChar(MAX)")]
		public string Venue_Name
		{
			get
			{
				return this._Venue_Name;
			}
			set
			{
				if ((this._Venue_Name != value))
				{
					this.OnVenue_NameChanging(value);
					this.SendPropertyChanging();
					this._Venue_Name = value;
					this.SendPropertyChanged("Venue_Name");
					this.OnVenue_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Venue_Address", DbType="VarChar(MAX)")]
		public string Venue_Address
		{
			get
			{
				return this._Venue_Address;
			}
			set
			{
				if ((this._Venue_Address != value))
				{
					this.OnVenue_AddressChanging(value);
					this.SendPropertyChanging();
					this._Venue_Address = value;
					this.SendPropertyChanged("Venue_Address");
					this.OnVenue_AddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Venue_Layout", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Venue_Layout
		{
			get
			{
				return this._Venue_Layout;
			}
			set
			{
				if ((this._Venue_Layout != value))
				{
					this.OnVenue_LayoutChanging(value);
					this.SendPropertyChanging();
					this._Venue_Layout = value;
					this.SendPropertyChanged("Venue_Layout");
					this.OnVenue_LayoutChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Event_GuestDetail", Storage="_GuestDetails", ThisKey="EventID", OtherKey="EventID")]
		public EntitySet<GuestDetail> GuestDetails
		{
			get
			{
				return this._GuestDetails;
			}
			set
			{
				this._GuestDetails.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Event_EventImage", Storage="_EventImages", ThisKey="EventID", OtherKey="EventID")]
		public EntitySet<EventImage> EventImages
		{
			get
			{
				return this._EventImages;
			}
			set
			{
				this._EventImages.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="USER_Event", Storage="_USER", ThisKey="Id", OtherKey="Id", IsForeignKey=true)]
		public USER USER
		{
			get
			{
				return this._USER.Entity;
			}
			set
			{
				USER previousValue = this._USER.Entity;
				if (((previousValue != value) 
							|| (this._USER.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._USER.Entity = null;
						previousValue.Events.Remove(this);
					}
					this._USER.Entity = value;
					if ((value != null))
					{
						value.Events.Add(this);
						this._Id = value.Id;
					}
					else
					{
						this._Id = default(int);
					}
					this.SendPropertyChanged("USER");
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
		
		private void attach_GuestDetails(GuestDetail entity)
		{
			this.SendPropertyChanging();
			entity.Event = this;
		}
		
		private void detach_GuestDetails(GuestDetail entity)
		{
			this.SendPropertyChanging();
			entity.Event = null;
		}
		
		private void attach_EventImages(EventImage entity)
		{
			this.SendPropertyChanging();
			entity.Event = this;
		}
		
		private void detach_EventImages(EventImage entity)
		{
			this.SendPropertyChanging();
			entity.Event = null;
		}
	}
}
#pragma warning restore 1591
