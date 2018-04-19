namespace WebVideoJuego.Models
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Web;

	public class Cliente: Persona
	{
		#region "Atributos"
			private string nit;
			private string tipoCliente;
		#endregion

		#region "Contructores"
			public Cliente() { }

			public Cliente(string nit, string tipoCliente)
			{
				this.nit = nit;
				this.tipoCliente = tipoCliente;
			}
		#endregion

		#region "Metodos Publicos"
			public string GetNit()
			{
				return nit;
			}

			public void SetNit(string nit)
			{
				this.nit = nit;
			}

			public string GetTipoCliente()
			{
				return tipoCliente;
			}

			public void SetTipoCliente(string tipoCliente)
			{
				this.tipoCliente = tipoCliente;
			}
		#endregion

	}
}