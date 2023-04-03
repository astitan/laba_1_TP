using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Controllers
{
    public class HomeController1 : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {

            ViewBag.chis = ' ';
            return View(new Class());
        }


        [HttpPost]
        public ViewResult Index(Class cl, string click)
        {

            double chis = 17.00;
            ViewBag.chis = chis;
            if (!ModelState.IsValid)
            {
                return View(cl);
            }
            if (click == "calculate")
            {
                switch (cl.act)
                {
                    case '+':
                        cl.result = cl.first_oper + cl.second_oper;
                        break;
                    case '-':
                        cl.result = cl.first_oper - cl.second_oper;
                        break;
                    case '*':
                        cl.result = cl.first_oper * cl.second_oper;
                        break;
                    case '/':
                        if (cl.second_oper != 0)
                        {
                            cl.result = cl.first_oper / cl.second_oper;
                        }
                        break;

                }

            }
            else
            {
                if (click == "clear")
                {
                    cl.first_oper = 0;
                    cl.second_oper = 0;
                    cl.result = 0;
                }
            }
            
            return View(cl);

        }

        public ViewResult Urav()
        {
            string result;
            result = Request.Query["fir_op"].ToString() + Request.Query["op"].ToString() + Request.Query["sec_op"].ToString() + " = " + Request.Query["res"].ToString();
            int index = result.LastIndexOf('=');
            string resultInfo = result.Remove(index, result.Length - index) + " равно " + result.Substring(index + 1);
            ViewBag.equation = resultInfo;
            return View();

        }
    }
}
