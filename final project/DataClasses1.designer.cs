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

namespace final_project
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="finalProject")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::final_project.Properties.Settings.Default.finalProjectConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<course> courses
		{
			get
			{
				return this.GetTable<course>();
			}
		}
		
		public System.Data.Linq.Table<score> scores
		{
			get
			{
				return this.GetTable<score>();
			}
		}
		
		public System.Data.Linq.Table<student> students
		{
			get
			{
				return this.GetTable<student>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.course")]
	public partial class course
	{
		
		private System.Nullable<int> _CourseID;
		
		private string _courseName;
		
		public course()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CourseID", DbType="Int")]
		public System.Nullable<int> CourseID
		{
			get
			{
				return this._CourseID;
			}
			set
			{
				if ((this._CourseID != value))
				{
					this._CourseID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_courseName", DbType="VarChar(20)")]
		public string courseName
		{
			get
			{
				return this._courseName;
			}
			set
			{
				if ((this._courseName != value))
				{
					this._courseName = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.score")]
	public partial class score
	{
		
		private System.Nullable<int> _ScoreId;
		
		private System.Nullable<int> _StudentId;
		
		private System.Nullable<int> _CourseID;
		
		private System.Nullable<int> _value;
		
		public score()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ScoreId", DbType="Int")]
		public System.Nullable<int> ScoreId
		{
			get
			{
				return this._ScoreId;
			}
			set
			{
				if ((this._ScoreId != value))
				{
					this._ScoreId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StudentId", DbType="Int")]
		public System.Nullable<int> StudentId
		{
			get
			{
				return this._StudentId;
			}
			set
			{
				if ((this._StudentId != value))
				{
					this._StudentId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CourseID", DbType="Int")]
		public System.Nullable<int> CourseID
		{
			get
			{
				return this._CourseID;
			}
			set
			{
				if ((this._CourseID != value))
				{
					this._CourseID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_value", DbType="Int")]
		public System.Nullable<int> value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((this._value != value))
				{
					this._value = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.student")]
	public partial class student
	{
		
		private System.Nullable<int> _StudentId;
		
		private string _name;
		
		private string _gender;
		
		public student()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StudentId", DbType="Int")]
		public System.Nullable<int> StudentId
		{
			get
			{
				return this._StudentId;
			}
			set
			{
				if ((this._StudentId != value))
				{
					this._StudentId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(50)")]
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
					this._name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gender", DbType="VarChar(20)")]
		public string gender
		{
			get
			{
				return this._gender;
			}
			set
			{
				if ((this._gender != value))
				{
					this._gender = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
