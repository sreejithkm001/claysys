using MVC.Models;
using MVC.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;

namespace MVC.Controllers
{
    public class UserController : Controller
    {
        UserDAL UserDAL=new UserDAL();
        // GET: User
        public ActionResult List()
        {
           var data=UserDAL.GetUsers();
            return View(data);
        }
        public ActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Create(UserModel user)
        {
            if(UserDAL.InsertUser(user))
            {
                TempData["InsertMsg"] = "<script>alert('User saved successfully')</script>";
                return RedirectToAction("List");
            }
            else 
            {
                TempData["InsertErrorMsg"] = "< script > alert('Data not saved') </ script > ";
            }
            return View();
        }

        public ActionResult Details(int id)
        {
            var data = UserDAL.GetUsers().Find(a => a.ID == id);

            return View(data);
        }
        public ActionResult Edit(int id)
        {
            var data=UserDAL.GetUsers().Find(a => a.ID == id);

            return View();
        }
        [HttpPost]
        public ActionResult Edit(UserModel user)
        {
            if (UserDAL.UpdateUser(user))
            {
                TempData["UpdateMsg"] = "<script>alert('User updated successfully')</script>";
                return RedirectToAction("List");
            }
            else
            {
                TempData["UpdateErrorMsg"] = "< script > alert('Data not updated') </ script > ";
            }
                return View();
        }
        //[HttpPost]
        public ActionResult Delete(int id)
        {
            int r = UserDAL.DeleteUser(id);
            if (r>0)
            {
                TempData["DeleteMsg"] = "<script>alert('User deleted successfully')</script>";
                return RedirectToAction("List");
            }
            else
            {
                TempData["DeleteErrorMsg"] = "< script > alert('Data not deleted') </ script > ";
            }
            return View();
        }
    }
}