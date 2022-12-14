#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cine
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Cine")]
	public partial class ConexionDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void Insertpeliculas(peliculas instance);
    partial void Updatepeliculas(peliculas instance);
    partial void Deletepeliculas(peliculas instance);
    partial void Inserthorarios(horarios instance);
    partial void Updatehorarios(horarios instance);
    partial void Deletehorarios(horarios instance);
    partial void Insertsala(sala instance);
    partial void Updatesala(sala instance);
    partial void Deletesala(sala instance);
    #endregion
		
		public ConexionDataContext() : 
				base(global::Cine.Properties.Settings.Default.CineConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ConexionDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ConexionDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ConexionDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ConexionDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<peliculas> peliculas
		{
			get
			{
				return this.GetTable<peliculas>();
			}
		}
		
		public System.Data.Linq.Table<horarios> horarios
		{
			get
			{
				return this.GetTable<horarios>();
			}
		}
		
		public System.Data.Linq.Table<sala> sala
		{
			get
			{
				return this.GetTable<sala>();
			}
		}
		
		public System.Data.Linq.Table<cartelera> cartelera
		{
			get
			{
				return this.GetTable<cartelera>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_actualizar_horarios")]
		public int sp_actualizar_horarios([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> pid_horarios, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Time")] System.Nullable<System.TimeSpan> phora)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), pid_horarios, phora);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_actualizar_peliculas")]
		public int sp_actualizar_peliculas([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> pid_peliculas, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string ptitulo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(5)")] string pduracion, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(25)")] string pgenero, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(10)")] string pclasificacion)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), pid_peliculas, ptitulo, pduracion, pgenero, pclasificacion);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_actualizar_sala")]
		public int sp_actualizar_sala([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> pid_sala, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string pnombre, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string pdescripcion)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), pid_sala, pnombre, pdescripcion);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_eliminar_pelicula")]
		public int sp_eliminar_pelicula([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> pid_peliculas)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), pid_peliculas);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_insertar_cartelera")]
		public int sp_insertar_cartelera([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> pid_sala, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> pid_horarios, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> pid_peiculas)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), pid_sala, pid_horarios, pid_peiculas);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_insertar_horarios")]
		public int sp_insertar_horarios([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Time")] System.Nullable<System.TimeSpan> phora)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), phora);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_insertar_pelicula")]
		public int sp_insertar_pelicula([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string ptitulo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(5)")] string pduracion, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(25)")] string pgenero, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(10)")] string pclasificacion)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), ptitulo, pduracion, pgenero, pclasificacion);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_insertar_sala")]
		public int sp_insertar_sala([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string pnombre, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string pdescripcion)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), pnombre, pdescripcion);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_select_cartelera")]
		public ISingleResult<sp_select_carteleraResult> sp_select_cartelera()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<sp_select_carteleraResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_select_horarios")]
		public ISingleResult<sp_select_horariosResult> sp_select_horarios()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<sp_select_horariosResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_select_peliculas")]
		public ISingleResult<sp_select_peliculasResult> sp_select_peliculas()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<sp_select_peliculasResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_select_salas")]
		public ISingleResult<sp_select_salasResult> sp_select_salas()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<sp_select_salasResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.peliculas")]
	public partial class peliculas : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_peliculas;
		
		private string _titulo;
		
		private string _duracion;
		
		private string _genero;
		
		private string _clasificacion;
		
		private System.Nullable<bool> _estado;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_peliculasChanging(int value);
    partial void Onid_peliculasChanged();
    partial void OntituloChanging(string value);
    partial void OntituloChanged();
    partial void OnduracionChanging(string value);
    partial void OnduracionChanged();
    partial void OngeneroChanging(string value);
    partial void OngeneroChanged();
    partial void OnclasificacionChanging(string value);
    partial void OnclasificacionChanged();
    partial void OnestadoChanging(System.Nullable<bool> value);
    partial void OnestadoChanged();
    #endregion
		
		public peliculas()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_peliculas", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_peliculas
		{
			get
			{
				return this._id_peliculas;
			}
			set
			{
				if ((this._id_peliculas != value))
				{
					this.Onid_peliculasChanging(value);
					this.SendPropertyChanging();
					this._id_peliculas = value;
					this.SendPropertyChanged("id_peliculas");
					this.Onid_peliculasChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_titulo", DbType="VarChar(50)")]
		public string titulo
		{
			get
			{
				return this._titulo;
			}
			set
			{
				if ((this._titulo != value))
				{
					this.OntituloChanging(value);
					this.SendPropertyChanging();
					this._titulo = value;
					this.SendPropertyChanged("titulo");
					this.OntituloChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_duracion", DbType="VarChar(5)")]
		public string duracion
		{
			get
			{
				return this._duracion;
			}
			set
			{
				if ((this._duracion != value))
				{
					this.OnduracionChanging(value);
					this.SendPropertyChanging();
					this._duracion = value;
					this.SendPropertyChanged("duracion");
					this.OnduracionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_genero", DbType="VarChar(25)")]
		public string genero
		{
			get
			{
				return this._genero;
			}
			set
			{
				if ((this._genero != value))
				{
					this.OngeneroChanging(value);
					this.SendPropertyChanging();
					this._genero = value;
					this.SendPropertyChanged("genero");
					this.OngeneroChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_clasificacion", DbType="VarChar(10)")]
		public string clasificacion
		{
			get
			{
				return this._clasificacion;
			}
			set
			{
				if ((this._clasificacion != value))
				{
					this.OnclasificacionChanging(value);
					this.SendPropertyChanging();
					this._clasificacion = value;
					this.SendPropertyChanged("clasificacion");
					this.OnclasificacionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_estado", DbType="Bit")]
		public System.Nullable<bool> estado
		{
			get
			{
				return this._estado;
			}
			set
			{
				if ((this._estado != value))
				{
					this.OnestadoChanging(value);
					this.SendPropertyChanging();
					this._estado = value;
					this.SendPropertyChanged("estado");
					this.OnestadoChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.horarios")]
	public partial class horarios : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_horarios;
		
		private System.Nullable<System.TimeSpan> _hora;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_horariosChanging(int value);
    partial void Onid_horariosChanged();
    partial void OnhoraChanging(System.Nullable<System.TimeSpan> value);
    partial void OnhoraChanged();
    #endregion
		
		public horarios()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_horarios", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_horarios
		{
			get
			{
				return this._id_horarios;
			}
			set
			{
				if ((this._id_horarios != value))
				{
					this.Onid_horariosChanging(value);
					this.SendPropertyChanging();
					this._id_horarios = value;
					this.SendPropertyChanged("id_horarios");
					this.Onid_horariosChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hora", DbType="Time")]
		public System.Nullable<System.TimeSpan> hora
		{
			get
			{
				return this._hora;
			}
			set
			{
				if ((this._hora != value))
				{
					this.OnhoraChanging(value);
					this.SendPropertyChanging();
					this._hora = value;
					this.SendPropertyChanged("hora");
					this.OnhoraChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.sala")]
	public partial class sala : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_sala;
		
		private string _nombre;
		
		private string _descripcion;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_salaChanging(int value);
    partial void Onid_salaChanged();
    partial void OnnombreChanging(string value);
    partial void OnnombreChanged();
    partial void OndescripcionChanging(string value);
    partial void OndescripcionChanged();
    #endregion
		
		public sala()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_sala", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_sala
		{
			get
			{
				return this._id_sala;
			}
			set
			{
				if ((this._id_sala != value))
				{
					this.Onid_salaChanging(value);
					this.SendPropertyChanging();
					this._id_sala = value;
					this.SendPropertyChanged("id_sala");
					this.Onid_salaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre", DbType="VarChar(50)")]
		public string nombre
		{
			get
			{
				return this._nombre;
			}
			set
			{
				if ((this._nombre != value))
				{
					this.OnnombreChanging(value);
					this.SendPropertyChanging();
					this._nombre = value;
					this.SendPropertyChanged("nombre");
					this.OnnombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_descripcion", DbType="VarChar(50)")]
		public string descripcion
		{
			get
			{
				return this._descripcion;
			}
			set
			{
				if ((this._descripcion != value))
				{
					this.OndescripcionChanging(value);
					this.SendPropertyChanging();
					this._descripcion = value;
					this.SendPropertyChanged("descripcion");
					this.OndescripcionChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.cartelera")]
	public partial class cartelera
	{
		
		private int _id_cartelera;
		
		private System.Nullable<int> _id_sala;
		
		private System.Nullable<int> _id_horarios;
		
		private System.Nullable<int> _id_peliculas;
		
		public cartelera()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_cartelera", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int id_cartelera
		{
			get
			{
				return this._id_cartelera;
			}
			set
			{
				if ((this._id_cartelera != value))
				{
					this._id_cartelera = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_sala", DbType="Int")]
		public System.Nullable<int> id_sala
		{
			get
			{
				return this._id_sala;
			}
			set
			{
				if ((this._id_sala != value))
				{
					this._id_sala = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_horarios", DbType="Int")]
		public System.Nullable<int> id_horarios
		{
			get
			{
				return this._id_horarios;
			}
			set
			{
				if ((this._id_horarios != value))
				{
					this._id_horarios = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_peliculas", DbType="Int")]
		public System.Nullable<int> id_peliculas
		{
			get
			{
				return this._id_peliculas;
			}
			set
			{
				if ((this._id_peliculas != value))
				{
					this._id_peliculas = value;
				}
			}
		}
	}
	
	public partial class sp_select_carteleraResult
	{
		
		private int _id_cartelera;
		
		private System.Nullable<int> _id_sala;
		
		private System.Nullable<int> _id_horarios;
		
		private System.Nullable<int> _id_peliculas;
		
		public sp_select_carteleraResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_cartelera", DbType="Int NOT NULL")]
		public int id_cartelera
		{
			get
			{
				return this._id_cartelera;
			}
			set
			{
				if ((this._id_cartelera != value))
				{
					this._id_cartelera = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_sala", DbType="Int")]
		public System.Nullable<int> id_sala
		{
			get
			{
				return this._id_sala;
			}
			set
			{
				if ((this._id_sala != value))
				{
					this._id_sala = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_horarios", DbType="Int")]
		public System.Nullable<int> id_horarios
		{
			get
			{
				return this._id_horarios;
			}
			set
			{
				if ((this._id_horarios != value))
				{
					this._id_horarios = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_peliculas", DbType="Int")]
		public System.Nullable<int> id_peliculas
		{
			get
			{
				return this._id_peliculas;
			}
			set
			{
				if ((this._id_peliculas != value))
				{
					this._id_peliculas = value;
				}
			}
		}
	}
	
	public partial class sp_select_horariosResult
	{
		
		private int _id_horarios;
		
		private System.Nullable<System.TimeSpan> _hora;
		
		public sp_select_horariosResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_horarios", DbType="Int NOT NULL")]
		public int id_horarios
		{
			get
			{
				return this._id_horarios;
			}
			set
			{
				if ((this._id_horarios != value))
				{
					this._id_horarios = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hora", DbType="Time")]
		public System.Nullable<System.TimeSpan> hora
		{
			get
			{
				return this._hora;
			}
			set
			{
				if ((this._hora != value))
				{
					this._hora = value;
				}
			}
		}
	}
	
	public partial class sp_select_peliculasResult
	{
		
		private int _id_peliculas;
		
		private string _titulo;
		
		private string _duracion;
		
		private string _genero;
		
		private string _clasificacion;
		
		private System.Nullable<bool> _estado;
		
		public sp_select_peliculasResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_peliculas", DbType="Int NOT NULL")]
		public int id_peliculas
		{
			get
			{
				return this._id_peliculas;
			}
			set
			{
				if ((this._id_peliculas != value))
				{
					this._id_peliculas = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_titulo", DbType="VarChar(50)")]
		public string titulo
		{
			get
			{
				return this._titulo;
			}
			set
			{
				if ((this._titulo != value))
				{
					this._titulo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_duracion", DbType="VarChar(5)")]
		public string duracion
		{
			get
			{
				return this._duracion;
			}
			set
			{
				if ((this._duracion != value))
				{
					this._duracion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_genero", DbType="VarChar(25)")]
		public string genero
		{
			get
			{
				return this._genero;
			}
			set
			{
				if ((this._genero != value))
				{
					this._genero = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_clasificacion", DbType="VarChar(10)")]
		public string clasificacion
		{
			get
			{
				return this._clasificacion;
			}
			set
			{
				if ((this._clasificacion != value))
				{
					this._clasificacion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_estado", DbType="Bit")]
		public System.Nullable<bool> estado
		{
			get
			{
				return this._estado;
			}
			set
			{
				if ((this._estado != value))
				{
					this._estado = value;
				}
			}
		}
	}
	
	public partial class sp_select_salasResult
	{
		
		private int _id_sala;
		
		private string _nombre;
		
		private string _descripcion;
		
		public sp_select_salasResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_sala", DbType="Int NOT NULL")]
		public int id_sala
		{
			get
			{
				return this._id_sala;
			}
			set
			{
				if ((this._id_sala != value))
				{
					this._id_sala = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre", DbType="VarChar(50)")]
		public string nombre
		{
			get
			{
				return this._nombre;
			}
			set
			{
				if ((this._nombre != value))
				{
					this._nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_descripcion", DbType="VarChar(50)")]
		public string descripcion
		{
			get
			{
				return this._descripcion;
			}
			set
			{
				if ((this._descripcion != value))
				{
					this._descripcion = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
