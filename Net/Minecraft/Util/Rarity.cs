using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.Minecraft.Util
{
    [MapName("net/minecraft/class_1814")]
    public sealed partial class Rarity : Java.Lang.Object, IJavaEnum<Rarity>, IClassRef, IFromHandle<Rarity>
    {
        [Signature("field_8906")]
        public static Rarity COMMON { get; private set; }

        [Signature("field_8904")]
        public static Rarity EPIC { get; private set; }

        [Signature("field_8903")]
        public static Rarity RARE { get; private set; }

        [Signature("field_8907")]
        public static Rarity UNCOMMON { get; private set; }

        [Signature("valueOf", false)]
        public static partial Rarity ValueOf(string name);
    }
}
