using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using DBApp.Models;

namespace DBApp.Controllers
{
    public class GameController : Controller
    {
        private GameContext gameContext = new GameContext();
        
        public ActionResult Index()
        {
            return View(gameContext.Games.ToList());
        }

        public ActionResult AddGame()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Game phone)
        {
            gameContext.Games.Add(phone);
            gameContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var deleted = gameContext.Games.First(b => b.Id == id);
            gameContext.Games.Remove(deleted);
            gameContext.SaveChanges();
            return RedirectToAction("Index");
        }
        
    }
}