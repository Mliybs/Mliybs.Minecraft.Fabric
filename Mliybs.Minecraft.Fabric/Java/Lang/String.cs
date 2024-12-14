using System;

namespace Java.Lang;

[MapName("java/lang/String", false)]
public partial class String : Java.Lang.Object, IClassRef<String>, IFromHandle<String>
{
    public static implicit operator String(string @string) => new(NewString(@string));

    public static implicit operator string(String @string) => GetString(@string.ObjectRef);
}
