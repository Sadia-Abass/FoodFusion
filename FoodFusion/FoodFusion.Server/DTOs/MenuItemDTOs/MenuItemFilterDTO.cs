namespace FoodFusion.Server.DTOs.MenuItemDTOs
{
    public class MenuItemFilterDTO
    {
        public long CuisineId { get; set; }
        public long MealTypeId { get; set; }
        public long MealCourse {  get; set; }
        public List<long>? DishTypeId { get; set; }
        public bool IsAvailable { get; set; }
        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }
        public string SearchTerm { get; set; } = string.Empty;
        public int PageSize { get; set; } = 10;
    }
}
