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
        public string ItemBorrowed { get; set; }
        [DisplayName("Item Borrowed Price")]
        public int ItemBorrowedPrice { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DisplayName("Date Borrowed")]
        public DateTime? BorrowedDate { get; set; }

        [DisplayName("Return Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? ItemReturnDate { get ; set; }

    }
}
