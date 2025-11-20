using FoodFusion.Server.DTOs;
using FoodFusion.Server.DTOs.MealCourseDTOs;
using FoodFusion.Server.Repositories.implementations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodFusion.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MealCourseController : ControllerBase
    {
        private readonly MealCourseRepository _mealCourseRepository;

        public MealCourseController(MealCourseRepository mealCourseRepository)
        {
            _mealCourseRepository = mealCourseRepository ?? throw new ArgumentNullException(nameof(mealCourseRepository));
        }

        [HttpGet("GetAllMealCourse")]
        public async Task<ActionResult<List<ApiResponse<MealCourseResponseDTO>>>> GetAllMealCourse()
        {
            var response = await _mealCourseRepository.GetAllMealCourseAsync();
            if(response.StatusCode != 200)
            {
                return StatusCode(response.StatusCode, response);
            }

            return Ok(response);
        }

        [HttpGet("GetMealCourseById/{id}")]
        public async Task<ActionResult<ApiResponse<MealCourseResponseDTO>>> GetMealCourseById(long id)
        {
            var response = await _mealCourseRepository.GetMealCourseByIdAsync(id);
            if (response.StatusCode != 200) 
            {
                return StatusCode(response.StatusCode, response);
            }

            return Ok(response);
        }

        [HttpPost("CreateMealCourse")]
        public async Task<ActionResult<ApiResponse<MealCourseResponseDTO>>> CreateMealCourse([FromBody] CreateMealCourseDTO createMealCourseDTO)
        {
            var response = await _mealCourseRepository.CreateMealCourseAsync(createMealCourseDTO);
            if (response.StatusCode != 200)
            {
                return StatusCode(response.StatusCode, response);
            }

            return Ok(response);
        }

        [HttpPut("UpdateMealCourse")]
        public async Task<ActionResult<ApiResponse<ConfirmationResponseDTO>>> UpdateMealCourse([FromBody] UpdateMealCourseDTO updateMealCourseDTO)
        {
            var response = await _mealCourseRepository.UpdateMealCourseAsync(updateMealCourseDTO);
            if (response.StatusCode != 200)
            {
                return StatusCode(response.StatusCode, response);
            }
            return Ok(response);
        }

        [HttpDelete("DeleteMealCourse/{id}")]
        public async Task<ActionResult<ApiResponse<ConfirmationResponseDTO>>> DeleteMealCourse(long id)
        {
            var response = await _mealCourseRepository.DeleteMealCourseAsync(id);
            if (response.StatusCode != 200) 
            {
                return StatusCode(response.StatusCode, response);
            }

            return Ok(response);
        }
    }
}
