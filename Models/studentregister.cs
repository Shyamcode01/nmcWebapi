using System.ComponentModel.DataAnnotations;

namespace nmvUiproject.Models
{
    public class studentregister
    {

        [Required]
            public int id { get; set; }
        [Required]
            public string name { get; set; }
        [Required]
            public int age { get; set; }
        [Required]
            public string gmail { get; set; }
        

    }
}
