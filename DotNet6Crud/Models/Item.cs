using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DotNet6Crud.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Borrower Name")]
        public string Borrower { get; set; }
        [DisplayName("Borrower Item Name")]
        public string BorrowedItem { get; set; }
        [DisplayName("Days Item Borrowed")]
        public int DaysBorrowed { get; set; }
        [DisplayName("Date Borrowed")]
        public DateTime BorrowedDate { get; set; }
        [DisplayName("Return Date")]
        public DateTime ItemReturnDate { get ; set; }

    }
}
