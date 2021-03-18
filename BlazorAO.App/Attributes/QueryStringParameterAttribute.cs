﻿using System;

namespace BlazorAO.App.Attributes
{
    /// <summary>
    /// from https://www.meziantou.net/bind-parameters-from-the-query-string-in-blazor.htm
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public sealed class QueryStringParameterAttribute : Attribute
    {
        public QueryStringParameterAttribute()
        {
        }

        public QueryStringParameterAttribute(string name)
        {
            Name = name;
        }

        /// <summary>Name of the query string parameter. It uses the property name by default.</summary>
        public string Name { get; }
    }
}
