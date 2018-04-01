using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Swashbuckle.AspNetCore.SwaggerGen.Test
{
    [ModelMetadataType(typeof(MetadataType))]
    public class MetadataAnnotatedType
    {
        public int PropertyWithRequiredAndNonNullDefault { get; set; }

        public string PropertyWithRequiredAndNullDefault { get; set; }

        public int PropertyWithRange { get; set; }

        public string PropertyWithRegularExpression { get; set; }
    }

    public class MetadataType
    {
        [Required]
        public int PropertyWithRequiredAndNonNullDefault { get; set; }

        [Required]
        public string PropertyWithRequiredAndNullDefault { get; set; }

        [Range(1, 12)]
        public int PropertyWithRange { get; set; }

        [RegularExpression("^[3-6]?\\d{12,15}$")]
        public string PropertyWithRegularExpression { get; set; }
    }
}