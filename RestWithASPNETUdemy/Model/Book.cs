using RestWithASPNETUdemy.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASPNETUdemy.Model
{
    [Table("Book")]
    public class Book : BaseEntity
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public DateTime LaunchDate { get; set; }
        public double Price { get; set; }

        public Book(int id, string author, string title, DateTime launchDate, double price)
        {
            Id = id;
            Author = author;
            Title = title;
            LaunchDate = launchDate;
            Price = price;
        }
    }
}
