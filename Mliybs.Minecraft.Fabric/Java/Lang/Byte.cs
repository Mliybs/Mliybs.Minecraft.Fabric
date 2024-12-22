using System;
using System.Collections.Generic;

namespace Java.Lang
{
    [MapName("java.lang.Byte", false), SuppressJavaClass]
    public partial class Byte : JavaObject, IClassRef<Byte>, IFromHandle<Byte>
    {
        internal Byte(nint handle) : base(handle)
        {}

        [JavaConstructor]
        public Byte(sbyte value) : base(Byte_ByteInvoke(value))
        {}

        [Signature("byteValue", false)]
        public partial sbyte ByteValue();

        [Signature("valueOf", false)]
        public static partial Byte ValueOf(sbyte value);

        public static Byte From(nint handle)
        {
            return new(handle);
        }

        public static implicit operator sbyte(Byte value)
        {
            if (value.IsNull) throw new NullReferenceException();
            return value.ByteValue();
        }

        public static implicit operator Byte(sbyte value)
        {
            return ValueOf(value);
        }
    }
}
