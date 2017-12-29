using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace ConstraintsAdding.Constraints
{
    public class NotEqual : IRouteConstraint
    {
        string _valueToBeChecked;

        public NotEqual(string valueToBeChecked)
        {
            _valueToBeChecked = valueToBeChecked;
        }

        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            bool result;

            result = String.Compare(values[parameterName].ToString(), _valueToBeChecked) != 0;

            return result;
        }
    }
}