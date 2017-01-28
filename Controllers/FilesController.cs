using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab3_Stuff.Controllers
{
    public class FilesController : Controller
    {
        // GET: Files
        public ActionResult Index()
        {
            string[] files = Directory.GetFiles(Server.MapPath("~/TextFiles"));
            ViewBag.myFiles = files;

            for(int i = 0; i < files.Length; i++)
            {
                files[i] = files[i].Remove(files[i].Length - 4, 4);
                files[i] = files[i].Remove(0, files[i].Length - 5);
            }

            return View();
        }

        public ActionResult FileContent(string filename)
        {
            string contents = System.IO.File.ReadAllText(Server.MapPath("~/TextFiles/" + filename + ".txt"));
            ViewBag.file = contents;
            return View();
        }
    }
}
