namespace WebVideoJuego.Models
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Web;

	public class Tarea
	{
		#region "Atributos"
			private string nombre;
			private string descripcion;
		#endregion

		#region "Contructores"
			public Tarea() { }

			public Tarea(string nombre, string descripcion)
			{
				this.nombre = nombre;
				this.descripcion = descripcion;
			}
		#endregion

		#region "Metodos Publicos"
			public string GetNombre()
			{
				return nombre;
			}

			public void SetNombre(string nombre)
			{
				this.nombre = nombre;
			}

			public string GetDescripcion()
			{
				return descripcion;
			}

			public void SetDescripcion(string descripcion)
			{
				this.descripcion = descripcion;
			}
		#endregion
	}
}