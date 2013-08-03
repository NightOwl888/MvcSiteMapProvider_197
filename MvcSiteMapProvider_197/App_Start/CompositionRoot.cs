using System;
using System.Web.Mvc;
using StructureMap;
using MvcSiteMapProvider_197.DI;
using MvcSiteMapProvider_197.DI.StructureMap;
using MvcSiteMapProvider_197.DI.StructureMap.Registries;

internal class CompositionRoot
{
    public static IDependencyInjectionContainer Compose()
    {
// Create the DI container
        var container = new Container();

// Setup configuration of DI
        container.Configure(r => r.AddRegistry<MvcSiteMapProviderRegistry>());

// Return our DI container wrapper instance
        return new StructureMapDependencyInjectionContainer(container);
    }
}
