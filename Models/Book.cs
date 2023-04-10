using System.ComponentModel.DataAnnotations;

namespace eBooks.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public double Price { get; set; }
        public DateTime Year_of_Edition { get; set; }
    }
}
