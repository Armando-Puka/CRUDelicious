#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace CRUDelicious.Models;   
public class Dish
{
    [Key]
    public int DishId { get; set; }
    
    [Required(ErrorMessage = "The Chef's Name field is required.")]
    public string DishChef { get; set; }

    [Required(ErrorMessage = "The Name of Dish field is required.")]
    public string DishName { get; set; } 

    [Required(ErrorMessage = "The # of Calories field is required.")]
    [Range(1, int.MaxValue, ErrorMessage = "Calories must be greater than 0.")]
    public int DishCalories { get; set; }

    [Required(ErrorMessage = "You must rate the dish tastiness from 1 to 5.")]
    public int DishTastiness { get; set; }

    [Required(ErrorMessage = "The Description field is required.")]
    public string DishDescription { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}