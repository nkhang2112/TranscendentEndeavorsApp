using System.ComponentModel.DataAnnotations;

namespace NumberApp.Models
{
    public class NumberEntry
    {
        public int Id { get; set; }

        [Required]
        public int InputNumber { get; set; }
        public int MultipliedNumber { get; set; }
        public int MultipliedSquaredNumber { get; set; }
    }
}
