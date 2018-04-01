using System.ComponentModel.DataAnnotations;

namespace Swashbuckle.AspNetCore.SwaggerGen.Test
{
    public class DataAnnotatedType
    {
        public int PropertyWithNoAttributes { get; set; }

        [Required]
        public int PropertyWithRequiredAndNonNullDefault { get; set; }

        [Required]
        public string PropertyWithRequiredAndNullDefault { get; set; }

        [Range(1, 12)]
        public int PropertyWithRange { get; set; }

        [RegularExpression("^[3-6]?\\d{12,15}$")]
        public string PropertyWithRegularExpression { get; set; }

        [StringLength(10, MinimumLength = 5)]
        public string PropertyWithStringLength { get; set; }

        [MinLength(1), MaxLength(3)]
        public string PropertyWithMinMaxLength { get; set; }
    }
}