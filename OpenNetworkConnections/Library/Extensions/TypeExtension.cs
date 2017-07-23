﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace de.efsdev.wsapm.OpenNetworkConnections.Library.Extensions
{
    public static class TypeExtension
    {
        public static bool IsSameOrSubclassOf(this Type potentialDescendant, Type potentialBase)
        {
            return potentialDescendant == potentialBase || potentialDescendant.IsSubclassOf(potentialBase);
        }

        public static bool HasProperty(this Type type, string name)
        {
            return type.GetProperty(name, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance) != null;
        }

        public static bool HasField(this Type type, string name)
        {
            return type.GetField(name, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance) != null;
        }
    }
}
