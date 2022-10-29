using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult SignUp_htmlhelp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp_htmlhelp(Member member)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Verify(FormCollection Formobj, string account, string password, LoginViewModel loginViewModel)
        {
            //寫法(一)
            //FormCollection Formobj 資料型態(Key,Value)，Key對應到前端input name
            //要注意的重點在於FormCollection使用form裡面元素的name屬性來繫結(不區分大小寫，意旨前端js是沒有區分大小)
            ViewBag.Account = Formobj["AcCount"];
            ViewBag.Password = Formobj["PaSsword"];

            //寫法(二)
            //也可以使用Verify(string 前端Input_name1,string 前端Input_name2,、、、)
            //Asp.net系統也可以幫你綁定到數值
            ViewBag.Account = account;
            ViewBag.Password = password;

            //寫法(三)表單欄位太多，我用改用Model物件去繫結資料，Model裡面的屬性也要對應到前端form input元素的name
            ViewBag.Account = loginViewModel.Account;
            ViewBag.Password = loginViewModel.Password;

            return View();
        }

     

    }
}