using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using ServiceCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace ServiceCore
{
    public static class Helpers
    {
        public static object GetInfo(string url)
        {
            var controllers = Assembly.GetEntryAssembly()
                .GetTypes()
                .Where(x => x.Namespace.Contains("Controllers") && x.GetTypeInfo().IsClass && !x.Name.Equals("ServiceController"));

            //items.Add(items.Count);
            var services = new List<IServiceModel>();
            var actionType = typeof(IActionResult);
            foreach (var type in controllers)
            {
                var service = new ServiceModel();

                // Add Namespace as Service name
                var index = type.Namespace.IndexOf('.');
                if (index != -1)
                {
                    service.ServiceName = type.Namespace.Substring(0, index);
                }
                else
                {
                    service.ServiceName = type.Namespace;
                }

                // Action's name of service
                service.Name = type.Name;

                // Controller action that return datatype that implement IActionResult
                var methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly)
                    .Where(x => !x.IsConstructor && !x.IsAbstract && x.ReturnType.IsAssignableFrom(actionType));


                services.Add(service);
            }

            return services;
        }
    }
}
