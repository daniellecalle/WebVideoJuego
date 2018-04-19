namespace WebVideoJuego.Models
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Web;

	public class EstadoTarea
	{
		#region "Atributos"
			private int codTarea;
			private int codEstado;
			private DateTime fecha;
		#endregion

		#region "Constructores"
			public EstadoTarea() { }

			public EstadoTarea(int codTarea, int codEstado, DateTime fecha)
			{
				this.codTarea = codTarea;
				this.codEstado = codEstado;
				this.fecha = fecha;
			}
		#endregion

		#region "Metodos Publicos"
			public int GetCodTarea()
			{
				return codTarea;
			}

			public void SetCodTarea(int codTarea)
			{
				this.codTarea = codTarea;
			}

			public int GetCodEstado()
			{
				return codEstado;
			}

			public void SetCodEstado(int codEstado)
			{
				this.codEstado = codEstado;
			}

			public DateTime GetFecha()
			{
				return fecha;
			}

			public void SetFecha(DateTime fecha)
			{
				this.fecha = fecha;
			}

		#endregion
	}
}