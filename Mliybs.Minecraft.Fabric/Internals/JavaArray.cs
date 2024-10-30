using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mliybs.Minecraft.Fabric.Internals
{
    [SuppressJavaClass]
    public partial class JavaArray<T> : Java.Lang.Object, IFromHandle<JavaArray<T>>, IEnumerable<T> where T : Java.Lang.Object, IClassRef, IFromHandle<T>
    {
        private readonly T[] _array;

        internal unsafe JavaArray(nint handle) : base(handle)
        {
            var length = GetArrayLength(handle); // 不知道为什么会报错

            _array = new T[length];

            for (int i = 0; i < length; i++)
                _array[i] = T.From(GetObjectArrayElement(handle, i));
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in _array) yield return item;
        }

        IEnumerator IEnumerable.GetEnumerator() => _array.GetEnumerator();

        public T this[int index]
        {
            get => _array[index];
            set
            {
                if (index < 0 || index >= _array.Length) throw new ArgumentOutOfRangeException(nameof(index));
                SetObjectArrayElement(ObjectRef, index, value.ObjectRef);
                _array[index] = value;
            }
        }

        public int Length => _array.Length;

        public static JavaArray<T> From(nint handle) => new(handle);
    }
}
