﻿namespace WebVideoJuego.Controllers
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Web;
	using System.Web.Mvc;

	public class EstadoController : Controller
    {
        // GET: Estado
        public ActionResult Index()
        {
            return View("ViewEstado");
        }
    }
}