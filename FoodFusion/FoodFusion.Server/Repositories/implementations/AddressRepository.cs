using FoodFusion.Server.Data;
using FoodFusion.Server.DTOs;
using FoodFusion.Server.DTOs.AddressesDTOs;
using FoodFusion.Server.Entities;
using FoodFusion.Server.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FoodFusion.Server.Repositories.implementations
{
    public class AddressRepository : IAddressRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public AddressRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<ApiResponse<AddressResponseDTO>> CreateAddressAsync(AddressCreateDTO addressCreateDTO)
        {
            try
            {
                // Check if customer exists
                var customer = await _dbContext.Customer.FindAsync(addressCreateDTO.CustomerID);
                if (customer == null) 
                {
                    return new ApiResponse<AddressResponseDTO>(404, "Customer not found");
                }

                // Manually mapping DTO to entity model
                var address = new Address
                {
                    CustomerID = addressCreateDTO.CustomerID,
                    AddressLineOne = addressCreateDTO.AddressLineOne,
                    AddressLineTwo = addressCreateDTO.AddressLineTwo,
                    City = addressCreateDTO.City,
                    County = addressCreateDTO.County,
                    PostCode = addressCreateDTO.PostCode
                };

                // Add address to the database
                _dbContext.Address.Add(address);
                await _dbContext.SaveChangesAsync();

                // Map response to AddressResponseDTO
                var addressResponse = new AddressResponseDTO
                {
                    Id = address.AddressID,
                    CustomerID = address.CustomerID,
                    AddressLineOne = address.AddressLineOne,
                    AddressLineTwo = address.AddressLineTwo,
                    City = address.City,
                    County = address.County,
                    PostCode = address.PostCode
                };

                return new ApiResponse<AddressResponseDTO>(200, addressResponse);
            }
            catch (Exception ex) 
            { 
                // Log the exception 
                return new ApiResponse<AddressResponseDTO>(500, $"An unexpected error occurred while processing your request, Error: {ex.Message}");
            }
        }

        public async Task<ApiResponse<ConfirmationResponseDTO>> DeleteAddressAsync(AddressDeleteDTO addressDeleteDTO)
        {
            try
            {
                var address = await _dbContext.Address.FirstOrDefaultAsync(add => add.AddressID == addressDeleteDTO.AddressID && add.CustomerID == addressDeleteDTO.CustomerID);
                if (address == null) 
                {
                    return new ApiResponse<ConfirmationResponseDTO>(404, "Address not found.");
                }

                _dbContext.Address.Remove(address);
                await _dbContext.SaveChangesAsync();

                // Prepare confirmation
                var confirmationMessage = new ConfirmationResponseDTO
                {
                    Message = $"Address with Id {addressDeleteDTO.AddressID} deleted successfully."
                };

                return new ApiResponse<ConfirmationResponseDTO>(200, confirmationMessage);
            }
            catch (Exception ex) 
            {
                return new ApiResponse<ConfirmationResponseDTO>(500, $"An unexpected error occurred while processing your request, Error: {ex.Message}");
            }
        }

        public async Task<ApiResponse<AddressResponseDTO>> GetAddressByIdAsync(long id)
        {
            try
            {
                var address = await _dbContext.Address.AsNoTracking().FirstOrDefaultAsync(add => add.AddressID == id);
                if (address == null) 
                {
                    return new ApiResponse<AddressResponseDTO>(404, "Address not found.");
                }

                // Map response to AddressResponseDTO 
                var addressResponse = new AddressResponseDTO
                {
                    Id = address.AddressID,
                    CustomerID = address.CustomerID,
                    AddressLineOne = address.AddressLineOne,
                    AddressLineTwo = address.AddressLineTwo,
                    City = address.City,
                    County = address.County,
                    PostCode = address.PostCode
                };

                return new ApiResponse<AddressResponseDTO>(200, addressResponse);
            }
            catch (Exception ex)
            {
                {
                    // Log the exception
                    return new ApiResponse<AddressResponseDTO>(500, $"An unexpected error occurred while processing your request, Error: {ex.Message}");
                }
            }
        }

        public async Task<ApiResponse<List<AddressResponseDTO>>> GetAddressesByCustomerAsync(long CustomerId)
        {
            try
            {
                var customer = await _dbContext.Customer.AsNoTracking().Include(c => c.Addresses).FirstOrDefaultAsync(c => c.CustomerID == CustomerId);
                if (customer == null)
                {
                    return new ApiResponse<List<AddressResponseDTO>>(404, "Customer not found.");
                }

                var addresses =  customer.Addresses.Select(a => new AddressResponseDTO 
                { 
                    Id = a.AddressID,
                    CustomerID = a.CustomerID,
                    AddressLineOne = a.AddressLineOne,
                    AddressLineTwo = a.AddressLineTwo,
                    City = a.City,
                    County = a.County,
                    PostCode = a.PostCode
                }).ToList();

                return new ApiResponse<List<AddressResponseDTO>>(200, addresses);
            }
            catch (Exception ex) 
            {
                return new ApiResponse<List<AddressResponseDTO>>(500, $"An unexpected error occurred while processing your request, Error: {ex.Message}");
            }
        }

        public async Task<ApiResponse<ConfirmationResponseDTO>> UpdateAddressAsync(AddressUpdateDTO addressUpdateDTO)
        {
            try
            {
                var address = await _dbContext.Address.FirstOrDefaultAsync(add => add.AddressID == addressUpdateDTO.AddressID && add.CustomerID == add.CustomerID);
                if (address == null)
                {
                    return new ApiResponse<ConfirmationResponseDTO>(404, "Address not found");
                }

                // Update address property 
                address.AddressLineOne = addressUpdateDTO.AddressLineOne;
                address.AddressLineTwo = addressUpdateDTO.AddressLineTwo;
                address.City = addressUpdateDTO.City;
                address.County = addressUpdateDTO.County;
                address.PostCode = addressUpdateDTO.PostCode;
                await _dbContext.SaveChangesAsync();

                // Prepare the confirmation message
                var confirmationMessage = new ConfirmationResponseDTO
                {
                    Message = $"Address with Id {addressUpdateDTO.AddressID} updated successfully."
                };

                return new ApiResponse<ConfirmationResponseDTO>(200, confirmationMessage);
            }
            catch (Exception ex)
            {
                return new ApiResponse<ConfirmationResponseDTO>(500, $"An unexpected error occurred while processing your request, Error: {ex.Message}");
            }
        }
    }
}
