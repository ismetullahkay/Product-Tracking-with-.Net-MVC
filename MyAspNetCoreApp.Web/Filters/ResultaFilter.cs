﻿using Microsoft.AspNetCore.Mvc.Filters;

namespace MyAspNetCoreApp.Web.Filters
{
    public class ResultaFilter:ResultFilterAttribute
    {
        private readonly string _name;
        private readonly string _value;

        public ResultaFilter(string name, string value)
        {
            _name = name;
            _value = value;
        }

        public override void OnResultExecuting(ResultExecutingContext context)
        {
            context.HttpContext.Response.Headers.Add(_name, _value);
            base.OnResultExecuting(context);
        }
    }
}
