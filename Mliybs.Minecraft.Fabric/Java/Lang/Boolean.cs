using System;
using System.Collections.Generic;

namespace Java.Lang
{
    [MapName("java.lang.Boolean", false), SuppressJavaClass]
    public partial class Boolean : Java.Lang.Object, IClassRef, IFromHandle<Boolean>
    {
        public Boolean(nint handle) : base(handle)
        {}

        [JavaConstructor]
        public Boolean(bool value) : base(Boolean_BoolInvoke(value))
        {}

        [Signature("booleanValue", false)]
        public partial bool BooleanValue();

        [Signature("valueOf", false)]
        public static partial Boolean ValueOf(bool value);

        public static Boolean From(nint handle)
        {
            return new(handle);
        }

        public static implicit operator bool(Boolean value)
        {
            if (value.IsNull) throw new NullReferenceException();
            return value.BooleanValue();
        }

        public static implicit operator Boolean(bool value)
        {
            return ValueOf(value);
        }
    }
}
