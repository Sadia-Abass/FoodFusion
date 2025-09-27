using FoodFusion.Server.Data;
using FoodFusion.Server.DTOs;
using FoodFusion.Server.DTOs.AddressesDTOs;
using FoodFusion.Server.DTOs.CustomerDTOs;
using FoodFusion.Server.DTOs.FeedbackDTOs;
using FoodFusion.Server.DTOs.OrdersDTOs;
using FoodFusion.Server.DTOs.ReservationResponseDTOs;
using FoodFusion.Server.Entities;
using FoodFusion.Server.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FoodFusion.Server.Repositories.implementations
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CustomerRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<ApiResponse<ConfirmationResponseDTO>> DeleteCustomerAsync(long id)
        {
            try
            {
                var customer = await _dbContext.Customer.FirstOrDefaultAsync(c => c.CustomerID == id);
                if (customer == null) 
                {
                    return new ApiResponse<ConfirmationResponseDTO>(404, "Customer not found.");
                }

                customer.IsActive = false;
                await _dbContext.SaveChangesAsync();

                // Prepare confirmation message
                var confirmationMessage = new ConfirmationResponseDTO
                {
                    Message = $"Customer with Id {id} deleted successfully."
                };

                return new ApiResponse<ConfirmationResponseDTO>(200, confirmationMessage);
            }
            catch (Exception ex) 
            {
                return new ApiResponse<ConfirmationResponseDTO>(500, $"An unexpected error occurred while processing your request, Error: {ex.Message}");
            }
        }

        public async Task<ApiResponse<CustomerResponseDTO>> GetCustomerById(long id)
        {
            try
            {
               var customer = await _dbContext.Customer.AsNoTracking().FirstOrDefaultAsync(c => c.CustomerID == id && c.IsActive == true);
                if (customer == null) 
                { 
                    return new ApiResponse<CustomerResponseDTO>(404, "Customer not found.");
                }

                // Map Customer Response DTO to Entity Model
                var customerResponse = new CustomerResponseDTO
                {
                    CustomerID = customer.CustomerID,
                    Name = customer.Name,
                    Surname = customer.Surname,
                    Email = customer.Email,
                    PhoneNumber = customer.PhoneNumber,
                    DateOfBirth = customer.DateOfBirth,
                    ApplicationUserId = customer.ApplicationUserId,
                    Addresses = new List<AddressResponseDTO>(),
                    Orders = new List<OrderResponseDTO>(),
                    Feedbacks = new List<FeedbackResponseDTO>(),
                    Reservation = new List<ReservationResponseDTO>()
                }; 

                return new ApiResponse<CustomerResponseDTO>(200, customerResponse);
            }
            catch (Exception ex) 
            {
                return new ApiResponse<CustomerResponseDTO>(500, $"An unexpected error occurred while processing your request, Error: {ex.Message}");
            }
        }

        public async Task<ApiResponse<CustomerResponseDTO>> RegisterCustomerAsync(CustomerRegistrationDTO customerRegisterDto)
        {
            try
            {
                // Check if email already exists
                var existingCustomer = await _dbContext.Customer.AnyAsync(c => c.Email == customerRegisterDto.Email);
                if (existingCustomer) 
                {
                    return new ApiResponse<CustomerResponseDTO>(400, "Email is already in use.");
                }

                // Manual mapping from DTO to Entity Model
                var customer = new Customer
                {
                    ApplicationUserId = customerRegisterDto.ApplicationUserId,
                    Email = customerRegisterDto.Email,
                    Name = customerRegisterDto.Name,
                    Surname = customerRegisterDto.Surname,
                    PhoneNumber = customerRegisterDto.PhoneNumber,
                    DateOfBirth = customerRegisterDto.DateOfBirth,
                    DateJoined = DateTime.Now,
                    IsActive = true
                };

                // Add customer to the database
                _dbContext.Customer.Add(customer);
                await _dbContext.SaveChangesAsync();

                // Prepare response data
                var customerResponse = new CustomerResponseDTO
                {
                    CustomerID = customerRegisterDto.CustomerID,
                    ApplicationUserId = customerRegisterDto.ApplicationUserId,
                    Name = customerRegisterDto.Name,
                    Surname = customerRegisterDto.Surname,
                    Email = customerRegisterDto.Email,
                    PhoneNumber= customerRegisterDto.PhoneNumber,
                    DateOfBirth = customerRegisterDto.DateOfBirth,
                    
                };

                return new ApiResponse<CustomerResponseDTO>(200, customerResponse);
            }
            catch (Exception ex) 
            {
                // Log the exception
                return new ApiResponse<CustomerResponseDTO>(500, $"An unexpected error occurred while processing your request, Error: {ex.Message}");
            }
        }

        public async Task<ApiResponse<ConfirmationResponseDTO>> UpdateCustomerAsync(CustomerUpdateDTO customerUpdateDto)
        {
            try
            {
                var customer = await _dbContext.Customer.FindAsync(customerUpdateDto.CustomerID);
                if (customer == null) 
                {
                    return new ApiResponse<ConfirmationResponseDTO>(404, "Customer not found.");
                }

                // Check if email is being updated to an existing one
                if (customer.Email != customerUpdateDto.Email && await _dbContext.Customer.AnyAsync(c => c.Email == customerUpdateDto.Email)) 
                {
                    return new ApiResponse<ConfirmationResponseDTO>(400, "Email is already in use.");
                }

                // Update customer properties manually
                customer.Name = customerUpdateDto.Name;
                customer.Surname = customerUpdateDto.Surname;
                customer.Email = customerUpdateDto.Email;
                customer.PhoneNumber = customerUpdateDto.PhoneNumber;
                customer.DateOfBirth = customerUpdateDto.DateOfBirth;
                customer.DateLastModified = DateTime.Now;
                await _dbContext.SaveChangesAsync();

                // Prepare confirmation message
                var confirmationMessage = new ConfirmationResponseDTO
                {
                    Message = $"Customer with Id {customerUpdateDto.CustomerID} updated successfully."
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
