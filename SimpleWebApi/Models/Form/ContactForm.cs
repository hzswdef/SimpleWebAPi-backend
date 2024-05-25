using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleWebApi.Models.Form;

public class ContactForm
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id", TypeName = "int(11)")]
    public int Id { get; set; }

    [Required]
    [Column("email", TypeName = "varchar(64)")]
    public string Email { get; set; }
    
    [Required]
    [Column("subject", TypeName = "varchar(64)")]
    public string Subject { get; set; }
    
    [Required]
    [Column("message", TypeName = "varchar(2048)")]
    public string Message { get; set; }
    
    [Required]
    [Column("created_on", TypeName = "int(11)")]
    public long CreatedOn { get; set; }
}