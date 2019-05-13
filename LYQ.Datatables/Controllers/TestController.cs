using LYQ.Datatables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LYQ.Datatables.Controllers
{
    public class TestController : Controller
    {
        [HttpGet]        
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PageList(string userName = "", int pageIndex = 1, int pageSize = 10)
        {
            var userList = new List<User>();

            var random = new Random();

            for (int i = 1; i <= 100; i++)
            {
                var user = new User()
                {
                    Name = "Tim" + i,
                    Gender = i % 2 == 0 ? "Femal" : "Male",
                    ID = i.ToString(),
                    Age = random.Next(18, 30),
                    Grade = "AP3",
                    Position = "IT"
                };

                userList.Add(user);
            }

            userList = (from item in userList
                        where item.Name.Contains(userName)
                        select item).ToList();

            return Json(new TableInfo
            {
                draw = int.Parse(Request.Form["draw"]),
                recordsTotal = userList.Count(),
                recordsFiltered = userList.Count(),
                data = userList.Skip(pageSize * (pageIndex - 1)).Take(pageSize)
            });
        }

    }
}