using NZWalks.API.Models.Domain;

namespace NZWalks.API.Repositories
{
    // Repositorio paterno para Region, actua como capa intermedia entre controller y dbase
    public interface IRegionRepository
    {
        //Tenemos que tener 5 definiciones de acuerdo a los 5 metodos en el controlador
        Task<List<Region>> GetAllAsync();

        Task<Region?> GetByIdAsync(Guid id); // ? nullable

        Task<Region> CreateAsync(Region region);

        Task<Region?> UpdateAsync(Guid id, Region region);

        Task<Region?> DeleteAsync(Guid id);
    }
}
