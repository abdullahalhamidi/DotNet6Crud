using System.ComponentModel.DataAnnotations;

namespace DotNet6Crud.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string Borrower { get; set; }

    }
}
