namespace WebVideoJuego.Controllers
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Web;
	using System.Web.Mvc;
	using WebVideoJuego.Models;
	using System.Data.SqlClient;

	public class TareaController : Controller
    {
		Conexion con = new Conexion();
		SqlConnection a;
		Tarea objT;

		// GET: Tarea
		public ActionResult Index()
        {
            return View("NuevaTarea");
        }

		[HttpPost]
		public ActionResult Created()
		{
			string nombre = Request["txtNombre"];
			string descripcion = Request["txtDescripcion"];
			objT = new Tarea(nombre, descripcion);

			if (!objT.Validar())
			{
				return View();
			}
			else
			{
				try
				{
					a = con.Conectar();
				}
				catch (Exception)
				{
					throw;
				}

				string sql = "INSERT INTO TBLTAREA VALUES ('" + objT.GetNombre() 
					+ "', '" +objT.GetDescripcion()+"')";
				int n = con.operaracion(sql, a);

				if (n != 0)
				{
					return View("ShowTareas");
				}
				else
				{
					return View("MessageError");
				}
			}
		}

	
		public void LimpiarCampos()
		{
			
		}

	}
}