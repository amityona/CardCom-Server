using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudPersonsWebService.Models
{
    [Table("Peoples")]
    public class Person
    {
        //No Need Unique

        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [EmailAddress]
        public string Mail { get; set; }

        [Required]
        public DateTime BirthDay { get; set; }

        [EnumDataType(typeof(Gender))]
        public Gender Gender { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }
    }

}
