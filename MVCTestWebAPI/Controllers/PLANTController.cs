using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCTestWebAPI.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;
using System.Text;

namespace MVCTestWebAPI.Controllers
{
    public class PLANTController : Controller
    {
        private IRPLUploadTestEntities db = new IRPLUploadTestEntities();
        // GET: PLANT

        public async Task<ActionResult> Index2()
        {
            IEnumerable<M_PLANT> plantList = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:8080");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //error message here
                HttpResponseMessage response = await client.GetAsync("api/PLANT");
                if (response.IsSuccessStatusCode)
                {
                    plantList = await response.Content.ReadAsAsync<IEnumerable<M_PLANT>>();
                }
            }
            return View(plantList);
        }
        public async Task<ActionResult> Index()
        {
            //IEnumerable<M_PLANT> plantList;
            //HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("PLANT").Result;
            //plantList = response.Content.ReadAsAsync<IEnumerable<M_PLANT>>().Result;

            IEnumerable<M_PLANT> plantList;
            
            

            HttpResponseMessage response = await GlobalVariables.WebApiClient.GetAsync("PLANT");
            
            plantList = await response.Content.ReadAsAsync<IEnumerable<M_PLANT>>();

            return View(plantList);
        }

        // GET: PLANT/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            M_PLANT m_PLANT = await db.M_PLANT.FindAsync(id);
            if (m_PLANT == null)
            {
                return HttpNotFound();
            }
            return View(m_PLANT);
        }

        // GET: PLANT/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PLANT/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "PLANT,PLANT_NAME,GSTNumber,RegionName,RegionCode,ScheduleYN")] M_PLANT m_PLANT)
        {
            if (ModelState.IsValid)
            {
                HttpResponseMessage response = await GlobalVariables.WebApiClient.PostAsJsonAsync("InsertPlant", m_PLANT);
                if (response.IsSuccessStatusCode)
                {
                    TempData["Message"] = "Successfully Inserted";
                    return RedirectToAction("Index");
                }
                return View(m_PLANT);
            }

            return View(m_PLANT);
        }

        // GET: PLANT/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
         //   M_PLANT m_PLANT = await db.M_PLANT.FindAsync(id);

            HttpResponseMessage response = await GlobalVariables.WebApiClient.GetAsync("PLANT/"+ id);
            if (response.IsSuccessStatusCode)
            {
                return View(response.Content.ReadAsAsync<M_PLANT>().Result);
            }
            else
            {
                TempData["Message"] = response.RequestMessage.ToString();
                return RedirectToAction("Index");
            }
        }

        // POST: PLANT/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "PLANT,PLANT_NAME,GSTNumber,RegionName,RegionCode,ScheduleYN")] M_PLANT m_PLANT)
        {
            if (ModelState.IsValid)
            {
                HttpResponseMessage response = await GlobalVariables.WebApiClient.PutAsJsonAsync("PLANT/"+m_PLANT.PLANT, m_PLANT);
                if (response.IsSuccessStatusCode)
                {
                    TempData["Message"] = "Successfully Updated";
                    return RedirectToAction("Index");
                }
                return View(m_PLANT);
            }
            return View(m_PLANT);
        }

        // GET: PLANT/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
             
            HttpResponseMessage response = await GlobalVariables.WebApiClient.DeleteAsync("PLANT/" + id);
            if (response.IsSuccessStatusCode)
            {
                TempData["Message"] = "Successfully Deleted";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["Message"] = response.RequestMessage.ToString();
                return RedirectToAction("Index");
            }
        }

        // POST: PLANT/Delete/5
       
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
