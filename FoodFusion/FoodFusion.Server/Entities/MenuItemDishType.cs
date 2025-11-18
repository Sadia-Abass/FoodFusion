using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodFusion.Server.Entities
{
    public class MenuItemDishType
    {
        [Key]
        public long Id { get; set; }

        public long DishTypeId { get; set; }
        [ForeignKey(nameof(DishTypeId))]
        public DishType? DishType { get; set; }

        public long MenuItemId { get; set; }
        [ForeignKey(nameof(MenuItemId))]
        public MenuItem? MenuItem {  set; get; }
    }
}
