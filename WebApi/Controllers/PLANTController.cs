using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using WebApi.App_Start;
using WebApi.Models;
using WebApi.Services;

namespace WebApi.Controllers
{
    [BasicAuthentication]
    public class PLANTController : ApiController
    {
        private readonly IPlantService _plantService;
        public PLANTController(IPlantService plantService)
        {
            _plantService = plantService;
        }
        [HttpGet]
        [Route("api/Plant")]
        public async Task<IList<M_PLANT>> GetM_PLANT()
        {
            return await _plantService.GetAllPlants();
        }

        // GET: api/PLANT/5
        [ResponseType(typeof(M_PLANT))]
        public async Task<IHttpActionResult> GetM_PLANT(string id)
        {
            M_PLANT m_PLANT = await _plantService.GetPlantById(id);
            if (m_PLANT == null)
            {
                return NotFound();
            }

            return Ok(m_PLANT);
        }

        // PUT: api/PLANT/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutM_PLANT(string id, M_PLANT m_PLANT)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != m_PLANT.PLANT)
            {
                return BadRequest();
            }
            try
            {
                await Task.Run(() => _plantService.UpdatePlant(m_PLANT));
            }
            catch (DbUpdateConcurrencyException)
            {
                    throw;
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/PLANT
        [ResponseType(typeof(M_PLANT))]
        [Route("api/InsertPlant")]
        public async Task<IHttpActionResult> PostM_PLANT(M_PLANT m_PLANT)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                 await Task.Run(() => _plantService.InsertPlant(m_PLANT));
                 return StatusCode(HttpStatusCode.NoContent);
            }
            catch (DbUpdateException)
            {
                    throw;
            }

        }

        // DELETE: api/PLANT/5
        [ResponseType(typeof(M_PLANT))]
        public async Task<IHttpActionResult> DeleteM_PLANT(string id)
        {
            var plant = await Task.Run(() => _plantService.DeletePlant(id));
            return Ok(plant);
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool M_PLANTExists(string id)
        //{
        //    return db.M_PLANT.Count(e => e.PLANT == id) > 0;
        //}
    }
}