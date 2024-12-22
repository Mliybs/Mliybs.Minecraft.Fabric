using System;
using System.Collections.Generic;

namespace Java.Lang
{
    [MapName("java.lang.Integer", false), SuppressJavaClass]
    public partial class Integer : JavaObject, IClassRef<Integer>, IFromHandle<Integer>
    {
        internal Integer(nint handle) : base(handle)
        {}

        [JavaConstructor]
        public Integer(int value) : base(Integer_IntInvoke(value))
        {}

        [Signature("intValue", false)]
        public partial int IntValue();

        [Signature("valueOf", false)]
        public static partial Integer ValueOf(int value);

        public static Integer From(nint handle)
        {
            return new(handle);
        }

        public static implicit operator int(Integer value)
        {
            if (value.IsNull) throw new NullReferenceException();
            return value.IntValue();
        }

        public static implicit operator Integer(int value)
        {
            return ValueOf(value);
        }
    }
}
