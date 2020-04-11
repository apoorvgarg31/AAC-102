using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAPI_Employee.Models;
using System.Net.Http;

namespace WebAPI_Employee.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        // GET: CRUD
        public ActionResult Index()
        {
            IEnumerable<dbo__vUsers> empobj = null;
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("https://localhost:44368/api/UserAPI");
            var comsumeapi = hc.GetAsync("UserAPI");
            comsumeapi.Wait();

            var readdata = comsumeapi.Result;
            if ( readdata.IsSuccessStatusCode)
            {
                var displaydata = readdata.Content.ReadAsAsync<IList<dbo__vUsers>>();
                displaydata.Wait();
                empobj = displaydata.Result;
            }
            
            return View(empobj);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(dbo__vUsers insertemp)
        {

            if (ModelState.IsValid)
            {
                HttpClient hc = new HttpClient();
                hc.BaseAddress = new Uri("https://localhost:44368/api/UserAPI");
                var insertrecord = hc.PostAsJsonAsync<dbo__vUsers>("UserAPI", insertemp);
                insertrecord.Wait();

                var savedate = insertrecord.Result;
                if (savedate.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }

                return View("Create");
            }
            return View("Create");

        }

        public ActionResult  Details(int id)
        {
            EmpClass empobj = null;
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("https://localhost:44368/api/UserAPI");

            var consumeapi = hc.GetAsync("UserAPI?id=" + id.ToString());
            consumeapi.Wait();

            var readdata = consumeapi.Result;
            if (readdata.IsSuccessStatusCode)
            {
                var displaydata = readdata.Content.ReadAsAsync<EmpClass>();
                displaydata.Wait();
                empobj = displaydata.Result;
            }
            return View(empobj);
        }

       
        public ActionResult Edit(int id)
        {
            EmpClass empobj = null;
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("https://localhost:44368/api/UserAPI");

            var consumeapi = hc.GetAsync("UserAPI?id=" + id.ToString());
            consumeapi.Wait();

            var readdata = consumeapi.Result;
            if (readdata.IsSuccessStatusCode)
            {
                var displaydata = readdata.Content.ReadAsAsync<EmpClass>();
                displaydata.Wait();
                empobj = displaydata.Result;
            }
            return View(empobj);
        }
        [HttpPost]
        public ActionResult Edit(EmpClass ec)
        {
            
  
            if (ModelState.IsValid)
            {
                HttpClient hc = new HttpClient();
                hc.BaseAddress = new Uri("https://localhost:44368/api/UserAPI");
                var insertrecord = hc.PutAsJsonAsync<EmpClass>("UserAPI", ec);

                insertrecord.Wait();

                var savedate = insertrecord.Result;

                if (savedate.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.message = "Employee Recordnot updated";
                }
                
            }
            return View("Edit");




        }
        public ActionResult Delete(int id)
        {
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("https://localhost:44368/api/UserAPI");
            var delrecord = hc.DeleteAsync("UserAPI/" + id.ToString());
            delrecord.Wait();
            var displaydata = delrecord.Result;
            if ( displaydata.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View("Index");

        }



    }



}