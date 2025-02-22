using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerWebAPI.Models
{
    [Table("Customer", Schema ="dbo")]
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CustomerId")]
        public int CustomerId { get; set; }

        [Column("CustomerName")]
        public string CustomerName { get; set; }

        [Column("MobileNumber")]
        public string MobileNumber { get; set; }

        [Column("Email")]
        public string Email { get; set; }

    }
}
