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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="AMPS")]
public partial class DbtoLinqDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  #endregion
	
	public DbtoLinqDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["AMPSConnectionString1"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public DbtoLinqDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DbtoLinqDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DbtoLinqDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DbtoLinqDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<WeightDemoTable> WeightDemoTables
	{
		get
		{
			return this.GetTable<WeightDemoTable>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.WeightDemoTable")]
public partial class WeightDemoTable
{
	
	private int _Agent_ID;
	
	private string _Agent_Name;
	
	private System.Nullable<double> _milk_Kg;
	
	private string _Centre_ID;
	
	private System.Nullable<System.DateTime> _WDate;
	
	private string _Session;
	
	private System.Nullable<int> _No_Of_Cans;
	
	private System.Nullable<double> _milk_Ltr;
	
	private System.Nullable<double> _fat;
	
	private System.Nullable<double> _snf;
	
	private System.Nullable<decimal> _rate;
	
	private System.Nullable<decimal> _amount;
	
	private string _sample_No;
	
	private System.Nullable<double> _fat_Kg;
	
	private System.Nullable<double> _snf_Kg;
	
	private System.Nullable<double> _clr;
	
	private System.Nullable<decimal> _net_amount;
	
	private System.Nullable<decimal> _net_rate;
	
	private string _milk_Nature;
	
	private string _rate_chart;
	
	private System.Nullable<decimal> _com_Amnt;
	
	private System.Nullable<decimal> _bon_Amnt;
	
	public WeightDemoTable()
	{
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Agent_ID", DbType="Int NOT NULL")]
	public int Agent_ID
	{
		get
		{
			return this._Agent_ID;
		}
		set
		{
			if ((this._Agent_ID != value))
			{
				this._Agent_ID = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Agent_Name", DbType="NVarChar(50)")]
	public string Agent_Name
	{
		get
		{
			return this._Agent_Name;
		}
		set
		{
			if ((this._Agent_Name != value))
			{
				this._Agent_Name = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_milk_Kg", DbType="Float")]
	public System.Nullable<double> milk_Kg
	{
		get
		{
			return this._milk_Kg;
		}
		set
		{
			if ((this._milk_Kg != value))
			{
				this._milk_Kg = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Centre_ID", DbType="NVarChar(50)")]
	public string Centre_ID
	{
		get
		{
			return this._Centre_ID;
		}
		set
		{
			if ((this._Centre_ID != value))
			{
				this._Centre_ID = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WDate", DbType="DateTime")]
	public System.Nullable<System.DateTime> WDate
	{
		get
		{
			return this._WDate;
		}
		set
		{
			if ((this._WDate != value))
			{
				this._WDate = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Session", DbType="NChar(10)")]
	public string Session
	{
		get
		{
			return this._Session;
		}
		set
		{
			if ((this._Session != value))
			{
				this._Session = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_No_Of_Cans", DbType="Int")]
	public System.Nullable<int> No_Of_Cans
	{
		get
		{
			return this._No_Of_Cans;
		}
		set
		{
			if ((this._No_Of_Cans != value))
			{
				this._No_Of_Cans = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_milk_Ltr", DbType="Float")]
	public System.Nullable<double> milk_Ltr
	{
		get
		{
			return this._milk_Ltr;
		}
		set
		{
			if ((this._milk_Ltr != value))
			{
				this._milk_Ltr = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fat", DbType="Float")]
	public System.Nullable<double> fat
	{
		get
		{
			return this._fat;
		}
		set
		{
			if ((this._fat != value))
			{
				this._fat = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_snf", DbType="Float")]
	public System.Nullable<double> snf
	{
		get
		{
			return this._snf;
		}
		set
		{
			if ((this._snf != value))
			{
				this._snf = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_rate", DbType="Money")]
	public System.Nullable<decimal> rate
	{
		get
		{
			return this._rate;
		}
		set
		{
			if ((this._rate != value))
			{
				this._rate = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_amount", DbType="Money")]
	public System.Nullable<decimal> amount
	{
		get
		{
			return this._amount;
		}
		set
		{
			if ((this._amount != value))
			{
				this._amount = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sample_No", DbType="NVarChar(15)")]
	public string sample_No
	{
		get
		{
			return this._sample_No;
		}
		set
		{
			if ((this._sample_No != value))
			{
				this._sample_No = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fat_Kg", DbType="Float")]
	public System.Nullable<double> fat_Kg
	{
		get
		{
			return this._fat_Kg;
		}
		set
		{
			if ((this._fat_Kg != value))
			{
				this._fat_Kg = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_snf_Kg", DbType="Float")]
	public System.Nullable<double> snf_Kg
	{
		get
		{
			return this._snf_Kg;
		}
		set
		{
			if ((this._snf_Kg != value))
			{
				this._snf_Kg = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_clr", DbType="Float")]
	public System.Nullable<double> clr
	{
		get
		{
			return this._clr;
		}
		set
		{
			if ((this._clr != value))
			{
				this._clr = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_net_amount", DbType="Money")]
	public System.Nullable<decimal> net_amount
	{
		get
		{
			return this._net_amount;
		}
		set
		{
			if ((this._net_amount != value))
			{
				this._net_amount = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_net_rate", DbType="Money")]
	public System.Nullable<decimal> net_rate
	{
		get
		{
			return this._net_rate;
		}
		set
		{
			if ((this._net_rate != value))
			{
				this._net_rate = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_milk_Nature", DbType="NVarChar(50)")]
	public string milk_Nature
	{
		get
		{
			return this._milk_Nature;
		}
		set
		{
			if ((this._milk_Nature != value))
			{
				this._milk_Nature = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_rate_chart", DbType="NVarChar(25)")]
	public string rate_chart
	{
		get
		{
			return this._rate_chart;
		}
		set
		{
			if ((this._rate_chart != value))
			{
				this._rate_chart = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_com_Amnt", DbType="Money")]
	public System.Nullable<decimal> com_Amnt
	{
		get
		{
			return this._com_Amnt;
		}
		set
		{
			if ((this._com_Amnt != value))
			{
				this._com_Amnt = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bon_Amnt", DbType="Money")]
	public System.Nullable<decimal> bon_Amnt
	{
		get
		{
			return this._bon_Amnt;
		}
		set
		{
			if ((this._bon_Amnt != value))
			{
				this._bon_Amnt = value;
			}
		}
	}
}
#pragma warning restore 1591
