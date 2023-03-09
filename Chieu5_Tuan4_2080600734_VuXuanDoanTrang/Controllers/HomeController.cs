using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Chieu5_Tuan4_2080600734_VuXuanDoanTrang.Models;
using Chieu5_Tuan4_2080600734_VuXuanDoanTrang.Controllers;
using PagedList;

namespace Chieu5_Tuan4_2080600734_VuXuanDoanTrang.Controllers
{
    public class HomeController : Controller
    {
        MyDataDataContext data = new MyDataDataContext();

        public ActionResult Index(int ? page)
        {
            if (page == null) page = 1;
            var all_book = from ss in data.Saches select ss;
            int pageSize = 3;
            int pageNum = page ?? 1;
            return View(all_book.ToPagedList(pageNum, pageSize));
        }

        public ActionResult ReadMore(int id)
        {
            var D_sach = data.Saches.Where(m => m.masach == id).First();
            return View(D_sach);
        }


    }
}