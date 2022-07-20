using System.ComponentModel.DataAnnotations;

namespace DotNet6Crud.Models
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? CreatedDate { get; set; }
        public string Comment { get; set; }
    }
}
