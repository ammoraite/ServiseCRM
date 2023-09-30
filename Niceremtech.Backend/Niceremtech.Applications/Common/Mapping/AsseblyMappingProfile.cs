
using System.Reflection;

using AutoMapper;

namespace Niceremtech.Applications.Common.Mapping
{
    public class AsseblyMappingProfile:Profile
    {
        public AsseblyMappingProfile(Assembly assembly)=>
            ApplyMappingFromAssemly(assembly);

        private void ApplyMappingFromAssemly ( Assembly assembly )
        {
            var types = assembly.GetExportedTypes ( )
                .Where (type => type
                    .GetInterfaces ( )
                    .Any (
                            i => i.IsGenericType&&i.GetGenericTypeDefinition ( )==typeof (IMapWith<>)
                        )
                      ).ToList();
            foreach (var type in types)
            {
                var instance = Activator.CreateInstance (type);
                var methodInfo = type.GetMethod ("Mapping");
                methodInfo?.Invoke (instance, new object[] { this });
            }
        }
    }
}
