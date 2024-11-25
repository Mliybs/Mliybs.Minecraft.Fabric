using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Mliybs.Minecraft.Fabric.Internals
{
    [SuppressJavaClass]
    public partial class JavaArray<T> : Java.Lang.Object, IFromHandle<JavaArray<T>>, IEnumerable<T> where T : Java.Lang.Object, IClassRef, IFromHandle<T>
    {
        private readonly int length;

        internal unsafe JavaArray(nint handle) : base(handle)
        {
            length = GetArrayLength(handle);
        }

        public unsafe JavaArray(int length) : base(NewObjectArray(length, T.ClassRef.ObjectRef))
        {
            this.length = length;
        }

        public unsafe JavaArray(int length, T initObject) : base(NewObjectArray(length, T.ClassRef.ObjectRef, initObject.ObjectRef))
        {
            this.length = length;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (var i = 0; i < length; i++) yield return T.From(GetObjectArrayElement(ObjectRef, i));
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public T this[int index]
        {
            get => T.From(GetObjectArrayElement(ObjectRef, index));
            set => SetObjectArrayElement(ObjectRef, index, value.ObjectRef);
        }

        public int Length => length;

        public static JavaArray<T> From(nint handle) => new(handle);
    }
}
