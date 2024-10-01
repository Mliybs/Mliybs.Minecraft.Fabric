using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.Minecraft.Util
{
    [MapName("net/minecraft/class_1269")]
    public sealed partial class ActionResult : JavaClass, IJavaEnum<ActionResult>, IClassRef, IFromHandle<ActionResult>
    {
        [Signature("field_21466")]
        public static ActionResult CONSUME { get; private set; }

        [Signature("field_5811")]
        public static ActionResult PASS { get; private set; }

        [Signature("field_5812")]
        public static ActionResult SUCCESS { get; private set; }

        [Signature("field_5814")]
        public static ActionResult FAIL { get; private set; }

        [Signature("method_23665")]
        public partial bool IsAccepted();

        [Signature("method_23666")]
        public partial bool ShouldSwingHand();

        [Signature("method_29236")]
        public static partial ActionResult Success(bool swingHand);

        [Signature("valueOf", false)]
        public static partial ActionResult ValueOf(string name);
    }
}
