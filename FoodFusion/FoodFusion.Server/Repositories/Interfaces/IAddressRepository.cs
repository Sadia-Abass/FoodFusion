using FoodFusion.Server.DTOs;
using FoodFusion.Server.DTOs.AddressesDTOs;

namespace FoodFusion.Server.Repositories.Interfaces
{
    public interface IAddressRepository
    {
        Task<ApiResponse<AddressResponseDTO>> CreateAddressAsync(AddressCreateDTO addressCreateDTO);
        Task<ApiResponse<AddressResponseDTO>> GetAddressByIdAsync(long id);
        Task<ApiResponse<ConfirmationResponseDTO>> UpdateAddressAsync(AddressUpdateDTO addressUpdateDTO);
        Task<ApiResponse<ConfirmationResponseDTO>> DeleteAddressAsync(AddressDeleteDTO addressDeleteDTO);
        Task<ApiResponse<List<AddressResponseDTO>>> GetAddressesByCustomerAsync(long CustomerId);
    }
}
