using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication2.Interface;
using MvcApplication2.Service;
using MvcApplication2.Factory;
using MvcApplication2.Models;

namespace MvcApplication2.Controllers
{
    public class HomeController : Controller
    {
        #region Private Methods
        private HomeService _home;
        private Person objPerson;
        #endregion

        #region Constructor
        public HomeController()
        {
            _home = new HomeService();
        }
        #endregion

        #region Action Methods
        //
        // GET: /Home/

        public ActionResult Index()
        {            
            objPerson = new Person();
            objPerson.fillGenderList();
            return View("index", objPerson);
        }

        [HttpPost]
        [ActionName("Calculate")]
        public ActionResult CalculatePremium(int gender, int age)
        {
            try
            {
                var premium = _home.CalculatePremimun(gender,age);
                return Json(new { ErrorMessage = "Success", Primium = premium }, JsonRequestBehavior.AllowGet);
               
                
            }
            catch (Exception)
            {
               //do not throw exception here..
               //pass the custom error message in json to view
                return Json(new { ErrorMessage = "An error occurred while processing this request" },JsonRequestBehavior.AllowGet );
            }          
         }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        //private string ValidateInput()
        //{
        //    //return 
        //    return string.Empty;
        //}

    }
}
