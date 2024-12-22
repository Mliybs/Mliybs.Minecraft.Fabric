using System;

namespace Java.Lang;

[MapName("java/lang/String", false)]
public partial class String : JavaObject, IClassRef<JavaString>, IFromHandle<JavaString>
{
    public static implicit operator JavaString(string @string) => new(NewString(@string));

    public static implicit operator string(JavaString @string) => GetString(@string.ObjectRef);
}
