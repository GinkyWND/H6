using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Cat
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Кличка котика обязательна")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Длина имени должна быть от 2 до 20 символов")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Укажите породу")]
        public string Breed { get; set; }

        [Range(0, 30, ErrorMessage = "Возраст должен быть в диапазоне от 0 до 30 лет")]
        public int Age { get; set; }

        [Range(0.1, 20.0, ErrorMessage = "Вес должен быть от 0.1 до 20 кг")]
        public double Weight { get; set; }

        [Required(ErrorMessage = "Выберите цвет")]
        public string Color { get; set; }
    }
}
