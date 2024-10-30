using System;
using System.Collections.Generic;

namespace Java.Lang
{
    [MapName("java.lang.Byte", false)]
    public partial class Byte : Java.Lang.Object, IClassRef, IFromHandle<Byte>
    {
        [JavaConstructor]
        public Byte(sbyte value) : base(Byte_ByteInvoke(value))
        {}

        [Signature("byteValue", false)]
        public partial sbyte ByteValue();

        [Signature("valueOf", false)]
        public static partial Byte ValueOf(sbyte value);

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
