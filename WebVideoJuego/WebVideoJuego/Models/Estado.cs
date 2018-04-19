﻿namespace WebVideoJuego.Models
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Web;

	public class Estado
	{
		#region "Atributos"
			private string nombre;
			private string color;
			private string descripcion;
		#endregion

		#region "Constructores"
			public Estado() { }

			public Estado(string nombre, string color, string descripcion)
			{
				this.nombre = nombre;
				this.color = color;
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

			public string GetColor()
			{
				return color;
			}

			public void SetColor(string color)
			{
				this.color = color;
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