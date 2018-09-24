using Session7MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Session7MVC.Controllers
{
    public class JohnController : Controller
    {
        AnythingIWant database = new AnythingIWant();
        // GET: John
        public string Index(int Id)
        {
            return $"hello there - {Id}";
        }

        public string Add(string message)
        {
            Message newmessage = new Message();
            newmessage.Text = message;
            database.Messages.Add(newmessage);
            database.SaveChanges();
            return "ok!";
        }

        public ActionResult ShowAll()
        {
            return View(database.Messages.ToList());
        }
    }
}