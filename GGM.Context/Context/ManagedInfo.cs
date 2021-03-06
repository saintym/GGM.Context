﻿using GGM.Context.Attribute;
using System;

namespace GGM.Context
{
    public class ManagedInfo
    {
        public ManagedInfo(Type type, ManagedAttribute managedAttribute, Func<object> generator)
        {
            Type = type;
            ManagedAttribute = managedAttribute;
            mGenerator = generator;
        }

        public Type Type { get; }
        public ManagedAttribute ManagedAttribute { get; }
        Func<object> mGenerator { get; }
        public object Object => mGenerator();

        public ManagedType ManagedType => ManagedAttribute.ManagedType;
    }
}
