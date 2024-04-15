using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BT2._1.Controllers
{
    public class ListSongController : Controller
    {
        // GET: ListSong
        
        public ActionResult ShowSong()
        {
            return View();
        }
        
    }
}