using System.ComponentModel.DataAnnotations;

namespace NmcWbapi.model
{
    public class nmcStudent
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        public int age { get; set; }
        [Required]
        public string gmail { get; set; }
    }
}
