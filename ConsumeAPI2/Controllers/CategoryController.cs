using ConsumeAPI2.Models.Entities;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ConsumeAPI2.Controllers
{
    public class CategoryController : Controller
    {
        [HttpGet]
        public ActionResult Index() 
        { 
        List<Category> categories = new List<Category>();

            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("https://localhost:44361/api/");
            HttpResponseMessage responce = client.GetAsync("category").Result;
            if (responce.IsSuccessStatusCode)
            {
                dynamic result = responce.Content.ReadAsStringAsync().Result;
                categories = JsonConvert.DeserializeObject<List<Category>>(result);
            }
            else
            {
                ViewBag.Data = "Bhava Empty Data AAhe Punha Try kr nahiter tu zopi ja te pn Pangrun gheun ...)";
            }
            return View(categories);
        }
       


        [HttpGet]
        public ActionResult Details(int? id)
        {
            Category category = GetElementById(id);
            return View(category);

        }

        [NonAction]
        public Category GetElementById(int? id)
        {
            Category category = new Category();

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44361/api/");
            HttpResponseMessage responce = client.GetAsync($"category/{id}").Result;
            if (responce.IsSuccessStatusCode)
            {
                string jsonResult = responce.Content.ReadAsStringAsync().Result;
                category = JsonConvert.DeserializeObject<Category>(jsonResult);
            }
            return category;
        }
        [HttpGet]

        public ActionResult Create ()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category category)
        {
            HttpClient client = new HttpClient();
            try
            {
                client.BaseAddress = new Uri("https://localhost:44361/api/");
                string request = JsonConvert.SerializeObject(category);
                /*StringContent requestBody = new StringContent(request,
                        Encoding.UTF8, "application/json");*/

                StringContent content = new StringContent(request, Encoding.UTF8, "application/json");
                /*HttpResponseMessage response =
                        client.PostAsync("category", requestBody).Result;*/
                HttpResponseMessage response = client.PostAsync("category", content).Result;

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }

                ViewBag.message = "Create API failed";
                return View(category);
            }
            catch (Exception ex)
            {
                ViewBag.message = ex.Message;
                return View();
            }

            finally
            {
              client?.Dispose();
            }

        }

        [HttpGet]
        public ActionResult Update (int? id)
        {
            Category category = GetElementById(id);
            return View(category);
        }

      
        public ActionResult Update(Category category)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44361/api/");
            string request= JsonConvert.SerializeObject(category);
            StringContent content = new StringContent(request, Encoding.UTF8, "application/json");
            HttpResponseMessage response= client.PutAsync($"category/{category.Id}", content).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            ViewBag.message = "Api creation failed";
           return View();
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Category category = GetElementById(id);
            return View(category);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteResult(int id)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44361/api/");

            HttpResponseMessage response = client.DeleteAsync($"category/{id}").Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            ViewBag.message = "api call failed";
            return RedirectToAction("Index");
        }
    }
}