using System;
using StructureMap;
using StructureMap.Configuration.DSL;
using StructureMap.Graph;

namespace MvcSiteMapProvider_197.DI.StructureMap.Conventions
{
    public class TransientConvention
        : IRegistrationConvention
    {
        public void Process(Type type, Registry registry)
        {
            registry.For(type).LifecycleIs(InstanceScope.Transient);
        }
    }
}
