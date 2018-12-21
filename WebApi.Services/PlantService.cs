using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Models;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace WebApi.Services
{
    public class PlantService : IPlantService
    {
        private readonly VendorConnectEntities _repository;
        public PlantService(VendorConnectEntities repository)
        {
            _repository = repository;
        }

        public async Task<IList<M_PLANT>> GetAllPlants()
        {
            return await _repository.M_PLANT.ToListAsync();
        }
        public async Task<M_PLANT> GetPlantById(string Id)
        {
            return await _repository.M_PLANT.FindAsync(Id);
        }
        public async void InsertPlant(M_PLANT plant)
        {
            _repository.M_PLANT.Add(plant);
            try
            {
                await _repository.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                throw;
            }
        }
        public async void UpdatePlant(M_PLANT plant)
        {
            _repository.Entry(plant).State = EntityState.Modified;
            try
            {
                await _repository.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }
        public async Task<M_PLANT> DeletePlant(string Id)
        {
            M_PLANT m_PLANT = await GetPlantById(Id);
            
            _repository.M_PLANT.Remove(m_PLANT);
            
            try
            {
                await _repository.SaveChangesAsync();
                return m_PLANT;
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }
        public async void InsertPlants(IList<M_PLANT> plants)
        {
            _repository.Configuration.AutoDetectChangesEnabled = false;
            foreach (var plant in plants)
                _repository.M_PLANT.Add(plant);
            try
            {
                await _repository.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                throw;
            }
            finally
            {
                _repository.Configuration.AutoDetectChangesEnabled = true;
            }
        }
        public async void UpdatePlants(IList<M_PLANT> plants)
        {
            _repository.Configuration.AutoDetectChangesEnabled = false;
            foreach (var plant in plants)
                _repository.Entry(plant).State = EntityState.Modified;
            try
            {
                await _repository.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                throw;
            }
            finally
            {
                _repository.Configuration.AutoDetectChangesEnabled = true;
            }
        }
        public async void DeletePlants(IList<M_PLANT> plants)
        {
            _repository.Configuration.AutoDetectChangesEnabled = false;
            foreach (var plant in plants)
                _repository.M_PLANT.Remove(plant);
            try
            {
                await _repository.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                throw;
            }
            finally
            {
                _repository.Configuration.AutoDetectChangesEnabled = true;
            }
        }

        public bool M_PLANTExists(string Id)
        {
            return _repository.M_PLANT.Count(e => e.PLANT == Id) > 0;
        }
    }
}
