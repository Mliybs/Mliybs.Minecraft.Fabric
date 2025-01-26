#if false
// using Com.Google.Gson;
// using Io.Netty.Buffer;
// using Io.Netty.Handler.Codec;
// using Io.Netty.Util;
// using It.Unimi.Dsi.Fastutil.Ints;
// using Java.Io;
// using Java.Nio.Channels;
// using Java.Nio.Charset;
// using Java.Nio;
// using Java.Security;
// using Java.Time;
using Java.Util.Function;
using Java.Util;
using Net.Minecraft.Item;
using Net.Minecraft.Nbt;
using Net.Minecraft.Network.Encoding;
using Net.Minecraft.Registry.Entry;
using Net.Minecraft.Registry;
using Net.Minecraft.Text;
using Net.Minecraft.Util.Collection;
using Net.Minecraft.Util.Hit;
using Net.Minecraft.Util.Math;
using Net.Minecraft.Util;

namespace Net.Minecraft.Network;

[MapName("net/minecraft/class_2540")]
public partial class PacketByteBuf : JavaObject, IClassRef<PacketByteBuf>, IFromHandle<PacketByteBuf>
{
//     [Signature("method_52954")]
//     @Deprecated
// public <T> T Decode(com.mojang.serialization.DynamicOps<NbtElement> ops, com.mojang.serialization.Codec<T> codec);

//     [Signature("method_29171")]
//     @Deprecated
// public <T> T Decode(com.mojang.serialization.DynamicOps<NbtElement> ops, com.mojang.serialization.Codec<T> codec, NbtSizeTracker sizeTracker);

//     [Signature("method_29172")]
//     @Deprecated
// public <T> PacketByteBuf Encode(com.mojang.serialization.DynamicOps<NbtElement> ops, com.mojang.serialization.Codec<T> codec, T value);

//     [Signature("method_49394")]
//     public partial <T> T DecodeAsJson(com.mojang.serialization.Codec<T> codec);

//     [Signature("method_49395")]
//     public partial <T> void EncodeAsJson(com.mojang.serialization.Codec<T> codec, T value);

//     [Signature("method_42065")]
//     public partial <T> void WriteRegistryValue(IndexedIterable<T> registry, T value);

//     [Signature("method_47989")]
//     public partial <T> void WriteRegistryEntry(IndexedIterable<RegistryEntry<T>> registryEntries, RegistryEntry<T> entry, PacketByteBuf.PacketWriter<T> writer);

//     [Signature("method_42064")]
//     @Nullable
// public <T> T ReadRegistryValue(IndexedIterable<T> registry);

//     [Signature("method_47990")]
//     public partial <T> RegistryEntry<T> ReadRegistryEntry(IndexedIterable<RegistryEntry<T>> registryEntries, PacketByteBuf.PacketReader<T> reader);

//     [Signature("method_37453")]
//     public static partial <T> IntFunction<T> GetMaxValidator(IntFunction<T> applier, int max);

//     [Signature("method_34068")]
//     public partial <T,C extends Collection<T>> C ReadCollection(IntFunction<C> collectionFactory, PacketByteBuf.PacketReader<T> reader);

//     [Signature("method_34062")]
//     public partial <T> void WriteCollection(Collection<T> collection, PacketByteBuf.PacketWriter<T> writer);

    // [Signature("method_34066")]
    // public partial <T> List<T> ReadList(PacketByteBuf.PacketReader<T> reader);

    // [Signature("method_34059")]
    // public partial IntList ReadIntList();

    // [Signature("method_34060")]
    // public partial void WriteIntList(IntList list);

    // [Signature("method_34069")]
    // public partial <K,V,M extends Map<K,V>> M ReadMap(IntFunction<M> mapFactory, PacketByteBuf.PacketReader<K> keyReader, PacketByteBuf.PacketReader<V> valueReader);

    // [Signature("method_34067")]
    // public partial <K,V> Map<K,V> ReadMap(PacketByteBuf.PacketReader<K> keyReader, PacketByteBuf.PacketReader<V> valueReader);

    // [Signature("method_34063")]
    // public partial <K,V> void WriteMap(Map<K,V> map, PacketByteBuf.PacketWriter<K> keyWriter, PacketByteBuf.PacketWriter<V> valueWriter);

    [Signature("method_34065")]
    public partial void ForEachInCollection(Consumer<PacketByteBuf> consumer);

    // [Signature("method_46253")]
    // public partial <E extends Enum<E>> void WriteEnumSet(EnumSet<E> enumSet, Class<E> type);

    // [Signature("method_46251")]
    // public partial <E extends Enum<E>> EnumSet<E> ReadEnumSet(Class<E> type);

    // [Signature("method_37435")]
    // public partial <T> void WriteOptional(Optional<T> value, PacketByteBuf.PacketWriter<T> writer);

    // [Signature("method_37436")]
    // public partial <T> Optional<T> ReadOptional(PacketByteBuf.PacketReader<T> reader);

//     [Signature("method_43827")]
//     @Nullable
// public <T> T ReadNullable(PacketByteBuf.PacketReader<T> reader);

    [Signature("method_43826")]
    public partial <T> void WriteNullable(@Nullable T value, PacketByteBuf.PacketWriter<T> writer);

//     [Signature("method_43619")]
//     public partial <L,R> void WriteEither(com.mojang.datafixers.util.Either<L,R> either, PacketByteBuf.PacketWriter<L> leftWriter, PacketByteBuf.PacketWriter<R> rightWriter);

//     [Signature("method_43622")]
//     public partial <L,R>
// com.mojang.datafixers.util.Either<L,R> ReadEither(PacketByteBuf.PacketReader<L> leftReader, PacketByteBuf.PacketReader<R> rightReader);

    [Signature("method_10795")]
    public partial sbyte[] ReadByteArray();

    [Signature("method_10813")]
    public partial PacketByteBuf WriteByteArray(sbyte[] array);

    [Signature("method_10803")]
    public partial sbyte[] ReadByteArray(int maxSize);

    [Signature("method_10806")]
    public partial PacketByteBuf WriteIntArray(int[] array);

    [Signature("method_10787")]
    public partial int[] ReadIntArray();

    [Signature("method_10799")]
    public partial int[] ReadIntArray(int maxSize);

    [Signature("method_10789")]
    public partial PacketByteBuf WriteLongArray(long[] array);

    [Signature("method_33134")]
    public partial long[] ReadLongArray();

    // [Signature("method_10801")]
    // public partial long[] ReadLongArray(@Nullable @org.jetbrains.annotations.Nullable long[] toArray);

    // [Signature("method_10809")]
    // public partial long[] ReadLongArray(@Nullable @org.jetbrains.annotations.Nullable long[] toArray, int maxSize);

    [Signature("method_10811")]
    public partial BlockPos ReadBlockPos();

    [Signature("method_10807")]
    public partial PacketByteBuf WriteBlockPos(BlockPos pos);

    [Signature("method_36133")]
    public partial ChunkPos ReadChunkPos();

    [Signature("method_36130")]
    public partial PacketByteBuf WriteChunkPos(ChunkPos pos);

    [Signature("method_19456")]
    public partial ChunkSectionPos ReadChunkSectionPos();

    [Signature("method_36131")]
    public partial PacketByteBuf WriteChunkSectionPos(ChunkSectionPos pos);

    [Signature("method_44117")]
    public partial GlobalPos ReadGlobalPos();

    [Signature("method_44113")]
    public partial void WriteGlobalPos(GlobalPos pos);

    // [Signature("method_49069")]
    // public partial Vector3f ReadVector3f();

    // [Signature("method_49068")]
    // public partial void WriteVector3f(Vector3f vector3f);

    [Signature("method_49070")]
    public partial Quaternionf ReadQuaternionf();

    [Signature("method_49067")]
    public partial void WriteQuaternionf(Quaternionf quaternionf);

    [Signature("method_52996")]
    public partial Vec3d ReadVec3d();

    [Signature("method_52955")]
    public partial void WriteVec3d(Vec3d vec);

    [Signature("method_10808")]
    public partial Text.Text ReadText();

    [Signature("method_54148")]
    public partial Text.Text ReadUnlimitedText();

    [Signature("method_10805")]
    public partial PacketByteBuf WriteText(IText text);

    // [Signature("method_10818")]
    // public partial <T extends Enum<T>> T ReadEnumConstant(Class<T> enumClass);

    [Signature("method_10817")]
    public partial PacketByteBuf WriteEnumConstant(Enum<?> instance);

    // [Signature("method_52962")]
    // public partial <T> T Decode(IntFunction<T> idToValue);

    // [Signature("method_52963")]
    // public partial <T> PacketByteBuf Encode(ToIntFunction<T> valueToId, T value);

    [Signature("method_10816")]
    public partial int ReadVarInt();

    [Signature("method_10792")]
    public partial long ReadVarLong();

    [Signature("method_10797")]
    public partial PacketByteBuf WriteUuid(UUID uuid);

    [Signature("method_10790")]
    public partial UUID ReadUuid();

    [Signature("method_10804")]
    public partial PacketByteBuf WriteVarInt(int value);

    [Signature("method_10791")]
    public partial PacketByteBuf WriteVarLong(long value);

    [Signature("method_10794")]
    public partial PacketByteBuf WriteNbt( NbtElement? nbt);

    [Signature("method_10798")]
    public partial NbtCompound? ReadNbt();

    [Signature("method_30616")]
    public partial NbtElement? ReadNbt(NbtSizeTracker sizeTracker);

    [Signature("method_10793")]
    public partial PacketByteBuf WriteItemStack(ItemStack stack);

    [Signature("method_10819")]
    public partial ItemStack ReadItemStack();

    [Signature("method_19772")]
    public partial String ReadString();

    [Signature("method_10800")]
    public partial String ReadString(int maxLength);

    [Signature("method_10814")]
    public partial PacketByteBuf WriteString(String string);

    [Signature("method_10788")]
    public partial PacketByteBuf WriteString(String string, int maxLength);

    [Signature("method_10810")]
    public partial Identifier ReadIdentifier();

    [Signature("method_10812")]
    public partial PacketByteBuf WriteIdentifier(Identifier id);

    // [Signature("method_44112")]
    // public partial <T> RegistryKey<T> ReadRegistryKey(RegistryKey<? extends Registry<T>> registryRef);

    // [Signature("method_44116")]
    // public partial void WriteRegistryKey(RegistryKey<?> key);

    // [Signature("method_53006")]
    // public partial <T> RegistryKey<? extends Registry<T>> ReadRegistryRefKey();

    [Signature("method_10802")]
    public partial Date ReadDate();

    [Signature("method_10796")]
    public partial PacketByteBuf WriteDate(Date date);

    [Signature("method_44118")]
    public partial Instant ReadInstant();

    [Signature("method_44115")]
    public partial void WriteInstant(Instant instant);

    [Signature("method_44119")]
    public partial PublicKey ReadPublicKey();

    [Signature("method_44114")]
    public partial PacketByteBuf WritePublicKey(PublicKey publicKey);

    [Signature("method_17814")]
    public partial BlockHitResult ReadBlockHitResult();

    [Signature("method_17813")]
    public partial void WriteBlockHitResult(BlockHitResult hitResult);

    [Signature("method_33558")]
    public partial BitSet ReadBitSet();

    [Signature("method_33557")]
    public partial void WriteBitSet(BitSet bitSet);

    [Signature("method_46254")]
    public partial BitSet ReadBitSet(int size);

    [Signature("method_46252")]
    public partial void WriteBitSet(BitSet bitSet, int size);

    // [Signature("method_43623")]
    // public partial com.mojang.authlib.GameProfile ReadGameProfile();

    // [Signature("method_43616")]
    // public partial void WriteGameProfile(com.mojang.authlib.GameProfile gameProfile);

    // [Signature("method_46255")]
    // public partial com.mojang.authlib.properties.PropertyMap ReadPropertyMap();

    // [Signature("method_46249")]
    // public partial void WritePropertyMap(com.mojang.authlib.properties.PropertyMap propertyMap);

    // [Signature("method_43624")]
    // public partial com.mojang.authlib.properties.Property ReadProperty();

    // [Signature("method_43617")]
    // public partial void WriteProperty(com.mojang.authlib.properties.Property property);

    [Signature("method_52986")]
    public partial PacketByteBuf Capacity(int int2);

    [Signature("method_52988")]
    public partial PacketByteBuf ReaderIndex(int int2);

    [Signature("method_52990")]
    public partial PacketByteBuf WriterIndex(int int2);

    [Signature("method_52944")]
    public partial PacketByteBuf SetIndex(int int2, int int3);

    [Signature("method_52931")]
    public partial PacketByteBuf Clear();

    [Signature("method_52932")]
    public partial PacketByteBuf MarkReaderIndex();

    [Signature("method_52933")]
    public partial PacketByteBuf ResetReaderIndex();

    [Signature("method_52934")]
    public partial PacketByteBuf MarkWriterIndex();

    [Signature("method_52935")]
    public partial PacketByteBuf ResetWriterIndex();

    [Signature("method_52936")]
    public partial PacketByteBuf DiscardReadBytes();

    [Signature("method_52937")]
    public partial PacketByteBuf DiscardSomeReadBytes();

    [Signature("method_52992")]
    public partial PacketByteBuf EnsureWritable(int int2);

    [Signature("method_52946")]
    public partial PacketByteBuf GetBytes(int int2, ByteBuf sbyteBuf);

    [Signature("method_52947")]
    public partial PacketByteBuf GetBytes(int int2, ByteBuf sbyteBuf, int int3);

    [Signature("method_52948")]
    public partial PacketByteBuf GetBytes(int int2, ByteBuf sbyteBuf, int int3, int int4);

    [Signature("method_52952")]
    public partial PacketByteBuf GetBytes(int int2, sbyte[] sbyte2);

    [Signature("method_52953")]
    public partial PacketByteBuf GetBytes(int int2, sbyte[] sbyte2, int int3, int int4);

    [Signature("method_52950")]
    public partial PacketByteBuf GetBytes(int int2, ByteBuffer sbyteBuffer);

    [Signature("method_52949")]
    public partial PacketByteBuf GetBytes(int int2, OutputStream outputStream, int int3)                       throws IOException;

    [Signature("method_52951")]
    public partial PacketByteBuf SetBoolean(int int2, bool bool);

    [Signature("method_52966")]
    public partial PacketByteBuf SetByte(int int2, int int3);

    [Signature("method_52981")]
    public partial PacketByteBuf SetShort(int int2, int int3);

    [Signature("method_52984")]
    public partial PacketByteBuf SetShortLE(int int2, int int3);

    [Signature("method_52985")]
    public partial PacketByteBuf SetMedium(int int2, int int3);

    [Signature("method_52987")]
    public partial PacketByteBuf SetMediumLE(int int2, int int3);

    [Signature("method_52989")]
    public partial PacketByteBuf SetInt(int int2, int int3);

    [Signature("method_52991")]
    public partial PacketByteBuf SetIntLE(int int2, int int3);

    [Signature("method_52945")]
    public partial PacketByteBuf SetLong(int int2, long long2);

    [Signature("method_52967")]
    public partial PacketByteBuf SetLongLE(int int2, long long2);

    [Signature("method_52993")]
    public partial PacketByteBuf SetChar(int int2, int int3);

    [Signature("method_52943")]
    public partial PacketByteBuf SetFloat(int int2, float float2);

    [Signature("method_52942")]
    public partial PacketByteBuf SetDouble(int int2, double double2);

    [Signature("method_52968")]
    public partial PacketByteBuf SetBytes(int int2, ByteBuf sbyteBuf);

    [Signature("method_52969")]
    public partial PacketByteBuf SetBytes(int int2, ByteBuf sbyteBuf, int int3);

    [Signature("method_52970")]
    public partial PacketByteBuf SetBytes(int int2, ByteBuf sbyteBuf, int int3, int int4);

    [Signature("method_52972")]
    public partial PacketByteBuf SetBytes(int int2, sbyte[] sbyte2);

    [Signature("method_52973")]
    public partial PacketByteBuf SetBytes(int int2, sbyte[] sbyte2, int int3, int int4);

    [Signature("method_52971")]
    public partial PacketByteBuf SetBytes(int int2, ByteBuffer sbyteBuffer);

    [Signature("method_52995")]
    public partial PacketByteBuf SetZero(int int2, int int3);

    [Signature("method_52956")]
    public partial PacketByteBuf ReadBytes(ByteBuf sbyteBuf);

    [Signature("method_52957")]
    public partial PacketByteBuf ReadBytes(ByteBuf sbyteBuf, int int2);

    [Signature("method_52958")]
    public partial PacketByteBuf ReadBytes(ByteBuf sbyteBuf, int int2, int int3);

    [Signature("method_52979")]
    public partial PacketByteBuf ReadBytes(sbyte[] sbyte2);

    [Signature("method_52965")]
    public partial PacketByteBuf ReadBytes(sbyte[] sbyte2, int int2, int int3);

    [Signature("method_52961")]
    public partial PacketByteBuf ReadBytes(ByteBuffer sbyteBuffer);

    [Signature("method_52959")]
    public partial PacketByteBuf ReadBytes(OutputStream outputStream, int int2)                        throws IOException;

    [Signature("method_52994")]
    public partial PacketByteBuf SkipBytes(int int2);

    [Signature("method_52964")]
    public partial PacketByteBuf WriteBoolean(bool bool);

    [Signature("method_52997")]
    public partial PacketByteBuf WriteByte(int int2);

    [Signature("method_52998")]
    public partial PacketByteBuf WriteShort(int int2);

    [Signature("method_52999")]
    public partial PacketByteBuf WriteShortLE(int int2);

    [Signature("method_53000")]
    public partial PacketByteBuf WriteMedium(int int2);

    [Signature("method_53001")]
    public partial PacketByteBuf WriteMediumLE(int int2);

    [Signature("method_53002")]
    public partial PacketByteBuf WriteInt(int int2);

    [Signature("method_53003")]
    public partial PacketByteBuf WriteIntLE(int int2);

    [Signature("method_52974")]
    public partial PacketByteBuf WriteLong(long long2);

    [Signature("method_52982")]
    public partial PacketByteBuf WriteLongLE(long long2);

    [Signature("method_53004")]
    public partial PacketByteBuf WriteChar(int int2);

    [Signature("method_52941")]
    public partial PacketByteBuf WriteFloat(float float2);

    [Signature("method_52940")]
    public partial PacketByteBuf WriteDouble(double double2);

    [Signature("method_52975")]
    public partial PacketByteBuf WriteBytes(ByteBuf sbyteBuf);

    [Signature("method_52976")]
    public partial PacketByteBuf WriteBytes(ByteBuf sbyteBuf, int int2);

    [Signature("method_52977")]
    public partial PacketByteBuf WriteBytes(ByteBuf sbyteBuf, int int2, int int3);

    [Signature("method_52983")]
    public partial PacketByteBuf WriteBytes(sbyte[] sbyte2);

    [Signature("method_52980")]
    public partial PacketByteBuf WriteBytes(sbyte[] sbyte2, int int2, int int3);

    [Signature("method_52978")]
    public partial PacketByteBuf WriteBytes(ByteBuffer sbyteBuffer);

    [Signature("method_53005")]
    public partial PacketByteBuf WriteZero(int int2);

    [Signature("method_53007")]
    public partial PacketByteBuf Retain(int int2);

    [Signature("method_52938")]
    public partial PacketByteBuf Retain();

    [Signature("method_52939")]
    public partial PacketByteBuf Touch();

    [Signature("method_52960")]
    public partial PacketByteBuf Touch(JavaObject @object);
}
#endif