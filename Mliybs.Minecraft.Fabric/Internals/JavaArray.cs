using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Mliybs.Minecraft.Fabric.Internals
{
    [SuppressJavaClass, CollectionBuilder(typeof(JavaArrayBuilder), nameof(JavaArrayBuilder.Create))]
    public partial class JavaArray<T> : JavaObject, IFromHandle<JavaArray<T>>, IEnumerable<T> where T : JavaObject, IClassRef<T>, IFromHandle<T>
    {
        private readonly int length;

        internal JavaArray(nint handle) : base(handle)
        {
            // 基类构造函数先于子类构造函数调用，此时的handle已经被删除引用无法使用了
            length = GetArrayLength(ObjectRef);
        }

        public JavaArray(int length) : base(NewObjectArray(length, T.ClassRef.ObjectRef))
        {
            this.length = length;
        }

        public JavaArray(int length, T initObject) : base(NewObjectArray(length, T.ClassRef.ObjectRef, initObject.ObjectRef))
        {
            this.length = length;
        }

        public JavaArray(ReadOnlySpan<T> span) : base(nint.Zero)
        {
            ObjectRef = NewObjectArray(span.Length, T.ClassRef.ObjectRef);
            length = span.Length;
            for (var i = 0; i < span.Length; i++)
                this[i] = span[i];
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

        public static implicit operator JavaArray<T>(T[] array) => new(array);
    }

    public static class JavaArrayBuilder
    {
        public static JavaArray<T> Create<T>(ReadOnlySpan<T> values) where T : JavaObject, IClassRef<T>, IFromHandle<T> => new(values);
    }
}
