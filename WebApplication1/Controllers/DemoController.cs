using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        //Controller中ActionResult修飾詞請用public 否則路由URL會導引錯誤

        public ActionResult Index()
        {
            ViewData["name"] = "吳宗泰";
            ViewBag.Name = "吳宗泰";
            TempData["name"] = "吳宗泰";
            //使用RedirectToAction導至ActtionResult
            //TempData所傳遞的資料，可以保留，而ViewData、ViewBag將會消失
            return RedirectToAction("ShowAction");
        }

        public ActionResult ShowAction()
        {
            
            return View();
        }

        public ActionResult ShowMember()
        {
            var memberA = new Member() { Id = 1, Name = "Simon", Age = 27 };
            var memberB = new Member() { Id = 2, Name = "Alex", Age = 27 };
            var memberC = new Member() { Id = 3, Name = "Joe", Age = 27 };
            var memberList = new List<Member>() { memberA, memberB, memberC };
            ViewData["Members"] = memberList;
            ViewBag.Members = memberList;
            var carA = new Car() { Id = 1,Name = "Honda",Color = "red"};
            var carB = new Car() { Id = 2, Name = "TOYOTA", Color = "yellow" };
            var carList = new List<Car>() { carA, carB };
            //除了使用ViewData、ViewBag、TempData以外，也能直接丟入View();
            return View(memberList);
            //如果有很多Model物件的話，直接在新增總類別，在將各自類別賦予到總類別

        }

        public ActionResult ShowShoppingList()
        {
            var memberA = new Member() { Id = 1, Name = "Simon", Age = 27 };
            var memberB = new Member() { Id = 2, Name = "Alex", Age = 27 };
            var memberC = new Member() { Id = 3, Name = "Joe", Age = 27 };
            var memberList = new List<Member>() { memberA, memberB, memberC };
            var carA = new Car() { Id = 1, Name = "Honda", Color = "red" };
            var carB = new Car() { Id = 2, Name = "TOYOTA", Color = "yellow" };
            var carList = new List<Car>() { carA, carB };
            MemberInfoViewModel memberInfoViewModel = new MemberInfoViewModel();
            memberInfoViewModel.Member = memberA;
            memberInfoViewModel.Cars = carList;
            //除了使用ViewData、ViewBag、TempData以外，也能直接丟入View();
            return View(memberInfoViewModel);
            //如果有很多Model物件的話，直接在新增總類別，在將各自類別賦予到總類別

        }

        //動作的回傳預設都是Get請求
        [HttpGet] //因此可以HttpGet省略
        public string ShowHelloWorld() 
        {
            return "Hello World";
        }

        public string ShowPrice(string product, int price) 
        {
            return $"商品是:{product}，價格是:{price}";
        }
    }
}