using comicbook.Data;
using comicbook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace comicbook.Controllers
{
    public class ComicbooksController : Controller
    {
        private comicbookRepository _comicbookRepository = new comicbookRepository();
        
        public ActionResult Detail(int? id)
        {
            if (id == null)
                return HttpNotFound();

            var selectedcomicbook = _comicbookRepository.getcomicbook((int)id);

            return View(selectedcomicbook);
        }
        public ActionResult Index()
        {
            var Allcomicbook = _comicbookRepository.getAllcomicbook();

            return View(Allcomicbook);
        }
    }
}
