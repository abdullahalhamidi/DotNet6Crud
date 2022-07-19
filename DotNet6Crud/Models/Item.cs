using System.ComponentModel.DataAnnotations;

namespace DotNet6Crud.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string Borrower { get; set; }
        public string BorrowedItem { get; set; }
        public int DaysBorrowed { get; set; }
        public DateTime BorrowedDate { get; set; }
        public DateTime ItemReturnDate { get; set; }

    }
}
