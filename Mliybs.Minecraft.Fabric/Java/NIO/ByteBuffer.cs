namespace Java.NIO;

[MapName("java.nio.ByteBuffer", false)]
public partial class ByteBuffer : Buffer, IClassRef<ByteBuffer>, IFromHandle<ByteBuffer>
{
    [Signature("get", false)]
    public partial sbyte Get();

    [Signature("get", false)]
    public partial ByteBuffer Get(JavaArrayByte dst);

    [Signature("get", false)]
    public partial ByteBuffer Get(JavaArrayByte dst, int offset, int length);

    [Signature("get", false)]
    public partial sbyte Get(int index);

    [Signature("get", false)]
    public partial ByteBuffer Get(int index, JavaArrayByte dst);

    [Signature("get", false)]
    public partial ByteBuffer Get(int index, JavaArrayByte dst, int offset, int length);
}