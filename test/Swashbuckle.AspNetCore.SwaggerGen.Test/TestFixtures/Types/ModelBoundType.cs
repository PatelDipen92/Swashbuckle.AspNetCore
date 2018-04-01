using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Swashbuckle.AspNetCore.SwaggerGen.Test
{
    public class ModelBoundType
    {
        public int PropertyWithNoAttributes { get; set; }

        [BindRequired]
        public int PropertyWithBindRequired { get; set; }

        [BindNever]
        public int PropertyWithBindNever { get; set; }
    }
}
