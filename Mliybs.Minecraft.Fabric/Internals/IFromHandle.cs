using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mliybs.Minecraft.Fabric.Internals
{
    public interface IFromHandle<T> where T : IFromHandle<T>
    {
        static abstract T From(nint handle);
    }
}
