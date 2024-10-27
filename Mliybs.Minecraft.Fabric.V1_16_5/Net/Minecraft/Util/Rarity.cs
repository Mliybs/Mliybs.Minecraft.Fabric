using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.Minecraft.Util
{
    [MapName("net/minecraft/class_1814")]
    public sealed partial class Rarity : JavaClass, IJavaEnum<Rarity>, IClassRef, IFromHandle<Rarity>
    {
        [JavaEnum]
        public static Rarity COMMON { get; private set; }

        [JavaEnum]
        public static Rarity EPIC { get; private set; }

        [JavaEnum]
        public static Rarity RARE { get; private set; }

        [JavaEnum]
        public static Rarity UNCOMMON { get; private set; }

        [Signature("valueOf", false)]
        public static partial Rarity ValueOf(string name);
    }
}
