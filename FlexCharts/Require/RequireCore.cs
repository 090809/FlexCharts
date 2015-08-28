﻿using System;
using JetBrains.Annotations;

namespace FlexCharts.Require
{
	public static class RequireExtensions
	{
    public static T RequireType<T>(this object @object)
    {
			if (!(@object is T))
		    throw new Exception("RequireType<T>");
      return (T) @object;
    }

    public static object RequireType(this object @object, Type expectedType)
    {
	    if (!expectedType.IsInstanceOfType(@object))
		    throw new Exception("RequireType");
	    return @object;
    }

    public static T RequireImplement<T>(this object @object)
    {
      if (!@object.GetType().IsInstanceOfType(typeof(T)))
		    throw new Exception("RequireImplement");
	    return (T)@object;
    }
		[ContractAnnotation("notnull => halt")]
		public static void RequireNull(this object @object)
		{
			if (@object != null)
				throw new Exception("RequireNull");
		}
		[ContractAnnotation("null => halt")]
		public static object RequireNotNull(this object @object)
    {
      if (@object == null)
		    throw new Exception("RequireNotNull");
	    return @object;
    }
		[ContractAnnotation("null => halt")]
		public static T RequireNotNull<T>(this T @object)
    {
      if (@object == null)
		    throw new Exception("RequireNotNull");
	    return @object;
    }
	}
}