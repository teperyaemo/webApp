using LR7.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LR7.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private int _counter = 0;

        public IActionResult TaskFirst()
        {
            return View();
        }
        public IActionResult TaskSecond()
        {
            return View();
        }
        public IActionResult TaskThird()
        {
            return View();
        }
        [HttpPost]
        public IActionResult TaskFirst(int FirstNumber, int SecondNumber, int ThirdNumber)
        {
            if (FirstNumber > 0 && SecondNumber > 0 && ThirdNumber > 0)
            {
                ViewBag.H = (FirstNumber + SecondNumber + ThirdNumber) / 3;
            }
            else ViewBag.H = FirstNumber * SecondNumber * ThirdNumber;
            return View();
        }

        [HttpPost]
        public IActionResult TaskSecond(int Pos1_x, int Pos1_y, int Pos2_x, int Pos2_y, int Pos3_x, int Pos3_y)
        {
            Triangle tr = new Triangle(Pos1_x, Pos1_y, Pos2_x, Pos2_y, Pos3_x, Pos3_y);
            ViewBag.perimeter = tr.Perimeter;
            ViewBag.sqare = tr.Square;
            ViewBag.center = tr.Center;
            return View();
        }

        [HttpPost]

       /* public IActionResult TaskThird(int multi_A, int multi_B, int Num1_1, int Num1_2, int Num1_3, int Num2_1, int Num2_2, int Num2_3, int Num3_1, int Num3_2, int Num3_3)
        {
            Matrix mat = new Matrix(multi_A, multi_B, Num1_1, Num1_2, Num1_3, Num2_1, Num2_2, Num2_3, Num3_1, Num3_2, Num3_3);
            ViewBag.c1_1 = mat.array[1, 1];
            ViewBag.c1_2 = mat.array[1, 2];
            ViewBag.c1_3 = mat.array[1, 3];
            ViewBag.c2_1 = mat.array[2, 1];
            ViewBag.c2_2 = mat.array[2, 2];
            ViewBag.c2_3 = mat.array[2, 3];
            ViewBag.c3_1 = mat.array[3, 1];
            ViewBag.c3_2 = mat.array[3, 2];
            ViewBag.c3_3 = mat.array[3, 3];
            return View();
        } */

        public IActionResult TaskThird(int multi_A, int multi_B, int Num1_1, int Num1_2, int Num1_3, int Num2_1, int Num2_2, int Num2_3, int Num3_1, int Num3_2, int Num3_3, int B_Num1_1, int B_Num1_2, int B_Num1_3, int B_Num2_1, int B_Num2_2, int B_Num2_3, int B_Num3_1, int B_Num3_2, int B_Num3_3)
        {
            Matrix mat = new Matrix(multi_A, multi_B, Num1_1, Num1_2, Num1_3, Num2_1, Num2_2, Num2_3, Num3_1, Num3_2, Num3_3, B_Num1_1, B_Num1_2, B_Num1_3, B_Num2_1, B_Num2_2, B_Num2_3, B_Num3_1, B_Num3_2, B_Num3_3);
            int[,] carray = new int[3, 3];
            carray = mat.umn();
            ViewBag.c1_1 = carray[0, 1];
            ViewBag.c1_2 = carray[0, 1];
            ViewBag.c1_3 = carray[0, 2];
            ViewBag.c2_1 = carray[1, 0];
            ViewBag.c2_2 = carray[1, 1];
            ViewBag.c2_3 = carray[1, 2];
            ViewBag.c3_1 = carray[2, 0];
            ViewBag.c3_2 = carray[2, 1];
            ViewBag.c3_3 = carray[2, 2];
            return View();
        }

    }
}
