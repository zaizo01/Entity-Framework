using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntityF.Models;
using EntityF.Models.ViewModels;


namespace EntityF.Controllers
{
    public class TablaController : Controller
    {

        // GET: Tabla
        public ActionResult Index()
        {
            List<ListTablaViewModel> lst;
            using (CrudEntities db = new CrudEntities())
            {
                lst = (from d in db.tabla
                           select new ListTablaViewModel
                           {
                               id = d.id,
                               nombre = d.nombre,
                               correo = d.correo
                           }).ToList();
            }

            return View(lst);
        }
    }
}