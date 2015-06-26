using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContentManagement.Models;

namespace ContentManagement.Controllers
{
    public class PhotosController : Controller
    {
        //
        // GET: /Photos/

        public ActionResult Index()
        {
            PhotosModel model = new PhotosModel();
            return View(model.PhotosByParentId().ToList());
        }

    }
}
