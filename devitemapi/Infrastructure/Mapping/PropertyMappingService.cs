using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devitemapi.Infrastructure.Mapping
{
    public class PropertyMappingService : IPropertyMappingService
    {
        public Dictionary<string, PropertyMappingValue> GetPropertyMapping<TSource, TDestination>()
        {
            throw new NotImplementedException();
        }

        public bool ValidMappingExistsFor<TSource, TDestination>(string fields)
        {
            throw new NotImplementedException();
        }
    }
}
