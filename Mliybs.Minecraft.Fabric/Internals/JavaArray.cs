using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Mliybs.Minecraft.Fabric.Internals
{
    [SuppressJavaClass]
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

        public JavaArray(IEnumerable<T> objects) : base(nint.Zero)
        {
            var array = objects.ToArray();
            ObjectRef = NewObjectArray(array.Length, T.ClassRef.ObjectRef);
            length = array.Length;
            for (var i = 0; i < array.Length; i++)
                this[i] = array[i];
        }

        public JavaArray(T[] array) : base(nint.Zero)
        {
            ObjectRef = NewObjectArray(array.Length, T.ClassRef.ObjectRef);
            length = array.Length;
            for (var i = 0; i < array.Length; i++)
                this[i] = array[i];
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
}
