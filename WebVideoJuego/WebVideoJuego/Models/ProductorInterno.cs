namespace WebVideoJuego.Models
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Web;

	public class ProductorInterno:Persona
	{
		#region "Atributos"
			public string cargo;
		#endregion

		#region "Constructores"
			public ProductorInterno() { }

			public ProductorInterno(string cargo)
			{
				this.cargo = cargo;
			}
		#endregion

		#region "Propiedades"
			public string Cargo { get; set; }
		#endregion
	}
}