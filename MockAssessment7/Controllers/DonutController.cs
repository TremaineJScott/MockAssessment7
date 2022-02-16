using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MockAssessment7.Models;
using Flurl.Http;

namespace MockAssessment7.Controllers
{

    public class DonutController : Controller
    {
        private List<Donut> _donuts;
        private readonly string _apiBase = "https://grandcircusco.github.io/demo-apis";

        public DonutController()
        {
            _donuts = new List<Donut>();
        }

        public ActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Search(int id)
        {
            string apiUri = $"{_apiBase}/donuts/{id}.json";
            var apiTask = apiUri.GetJsonAsync<Donut>();
            apiTask.Wait();

            Donut donut = apiTask.Result;

            return View("Details",donut);
        }
        // GET: DonutController
        public ActionResult Index()        
        {           
            return View(_donuts);
        }

        // GET: DonutController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DonutController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DonutController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DonutController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DonutController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DonutController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DonutController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
