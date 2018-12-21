using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Services
{
    public interface IPlantService
    {
        Task<IList<M_PLANT>> GetAllPlants();
        Task<M_PLANT> GetPlantById(string Id);
        bool M_PLANTExists(string Id);
        void InsertPlant(M_PLANT plant);
        void UpdatePlant(M_PLANT plant);
        Task<M_PLANT> DeletePlant(string Id);

        void InsertPlants(IList<M_PLANT> plants);
        void UpdatePlants(IList<M_PLANT> plants);
        void DeletePlants(IList<M_PLANT> plants);
        

    }
}
