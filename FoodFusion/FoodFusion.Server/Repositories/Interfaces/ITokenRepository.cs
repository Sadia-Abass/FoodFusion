using FoodFusion.Server.Entities;

namespace FoodFusion.Server.Repositories.Interfaces
{
    public interface ITokenRepository
    {
        Task<string> CreateToken(ApplicationUser applicationUser);
    }
}
