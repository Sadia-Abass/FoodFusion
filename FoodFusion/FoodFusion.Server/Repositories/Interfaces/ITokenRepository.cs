using FoodFusion.Server.Entities;

namespace FoodFusion.Server.Repositories.Interfaces
{
    public interface ITokenRepository
    {
        //string GetToken();
        Task<string> CreateToken(ApplicationUser applicationUser);
    }
}
