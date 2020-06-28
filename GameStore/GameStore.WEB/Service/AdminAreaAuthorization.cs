using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Mvc.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.WEB.Service
{
    public class AdminAreaAuthorization : IControllerModelConvention
    {
        private readonly string area;
        private readonly string policy;

        public AdminAreaAuthorization(string _area, string _policy)
        {
            area = _area;
            policy = _policy;
        }

        public void Apply(ControllerModel controller)
        {
            if( controller.Attributes.Any(x =>
                x is AreaAttribute 
                && (x as AreaAttribute).RouteValue.Equals(area, StringComparison.OrdinalIgnoreCase))
                || controller.RouteValues.Any(y => 
                y.Key.Equals("area", StringComparison.OrdinalIgnoreCase)
                && y.Value.Equals(area, StringComparison.OrdinalIgnoreCase)))
            {
                controller.Filters.Add(new AuthorizeFilter(policy)); 
            }
        }
    }
}
