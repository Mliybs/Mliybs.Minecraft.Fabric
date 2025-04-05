namespace Net.Minecraft.Nbt;

[MapName("net/minecraft/class_2487")]
public partial class NbtCompound : JavaObject, IClassRef<NbtCompound>, IFromHandle<NbtCompound>
{
    [JavaConstructor]
    public NbtCompound() : base(NbtCompound_Invoke())
    {}

    [Signature("method_10541")]
    public partial Java.Util.Set<JavaString> GetKeys();

    [Signature("method_10546")]
    public partial int GetSize();

    // [Signature("method_10566")]
    // public partial NbtElement? Put(string key, NbtElement element);

    [Signature("method_10567")]
    public partial void PutByte(string key, sbyte value);

    [Signature("method_10575")]
    public partial void PutShort(string key, short value);

    [Signature("method_10569")]
    public partial void PutInt(string key, int value);

    [Signature("method_10544")]
    public partial void PutLong(string key, long value);

    [Signature("method_25927")]
    public partial void PutUuid(string key, UUID value);

    [Signature("method_25926")]
    public partial UUID GetUuid(string key);

    [Signature("method_25928")]
    public partial bool ContainsUuid(string key);

    [Signature("method_10548")]
    public partial void PutFloat(string key, float value);

    [Signature("method_10549")]
    public partial void PutDouble(string key, double value);

    [Signature("method_10582")]
    public partial void PutString(string key, string value);

    // [Signature("method_10570")]
    // public partial void PutByteArray(string key, sbyte[] value);

    // [Signature("method_36110")]
    // public partial void PutByteArray(string key, List<Byte> value);

    // [Signature("method_10539")]
    // public partial void PutIntArray(string key, int[] value);

    // [Signature("method_10572")]
    // public partial void PutIntArray(string key, List<Integer> value);

    // [Signature("method_10564")]
    // public partial void PutLongArray(string key, long[] value);

    // [Signature("method_10538")]
    // public partial void PutLongArray(string key, List<Long> value);

    [Signature("method_10556")]
    public partial void PutBoolean(string key, bool value);

    [Signature("method_10580")]
    public partial NbtElement? Get(string key);

    [Signature("method_10540")]
    public partial sbyte GetType(string key);

    [Signature("method_10545")]
    public partial bool Contains(string key);

    [Signature("method_10573")]
    public partial bool Contains(string key, int type);

    [Signature("method_10571")]
    public partial sbyte GetByte(string key);

    [Signature("method_10568")]
    public partial short GetShort(string key);

    [Signature("method_10550")]
    public partial int GetInt(string key);

    [Signature("method_10537")]
    public partial long GetLong(string key);

    [Signature("method_10583")]
    public partial float GetFloat(string key);

    [Signature("method_10574")]
    public partial double GetDouble(string key);

    [Signature("method_10558")]
    public partial string GetString(string key);

    // [Signature("method_10547")]
    // public partial sbyte[] GetByteArray(string key);

    // [Signature("method_10561")]
    // public partial int[] GetIntArray(string key);

    // [Signature("method_10565")]
    // public partial long[] GetLongArray(string key);

    [Signature("method_10562")]
    public partial NbtCompound GetCompound(string key);

    [Signature("method_10554")]
    public partial NbtList GetList(string key, int type);

    [Signature("method_10577")]
    public partial bool GetBoolean(string key);

    [Signature("method_10551")]
    public partial void Remove(string key);

    [Signature("method_33133")]
    public partial bool IsEmpty();

    // [Signature("method_10559")]
    // private partial CrashReport CreateCrashReport(string key, NbtType<?> reader, ClassCastException exception);

    // [Signature("method_10553")]
    // public partial NbtCompound Copy();

    // [Signature("method_10555")]
    // private static partial void Write(string key, NbtElement element, DataOutput output)                   throws IOException;

    // [Signature("method_10581")]
    // static partial NbtElement Read(NbtType<?> reader, string key, DataInput input, NbtSizeTracker tracker);

    [Signature("method_10543")]
    public partial NbtCompound CopyFrom(NbtCompound source);

    // [Signature("method_29143")]
    // protected partial Map<JavaString, NbtElement> ToMap();
}
