using FoodFusion.Server.DTOs;
using FoodFusion.Server.DTOs.CustomerDTOs;
using FoodFusion.Server.Entities;

namespace FoodFusion.Server.Repositories.Interfaces
{
    public interface ICustomerRepository
    {
        Task<ApiResponse<CustomerResponseDTO>> GetCustomerById(long id);
        Task<ApiResponse<CustomerResponseDTO>> RegisterCustomerAsync(CustomerRegistrationDTO customerRegisterDto);
        Task<ApiResponse<ConfirmationResponseDTO>> UpdateCustomerAsync(CustomerUpdateDTO customerUpdateDto);
        Task<ApiResponse<ConfirmationResponseDTO>> DeleteCustomerAsync(long id);
    }
}
