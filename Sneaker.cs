using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Sneaker
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Название модели обязательно")]
        public string ModelName { get; set; }

        [Required(ErrorMessage = "Укажите бренд")]
        public string Brand { get; set; }

        [Range(30, 50, ErrorMessage = "Размер должен быть от 30 до 50")]
        public int Size { get; set; }

        [Range(1, 100000, ErrorMessage = "Цена должна быть от 1 до 100 000")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
}
