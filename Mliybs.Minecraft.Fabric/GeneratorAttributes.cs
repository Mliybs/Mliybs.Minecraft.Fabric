using System;

#nullable disable
namespace Mliybs.Minecraft.Fabric
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class SuppressJavaClassAttribute : Attribute
    {}

    [AttributeUsage(AttributeTargets.Constructor, AllowMultiple = false, Inherited = false)]
    public class JavaConstructorAttribute : Attribute
    {}

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
    public class JavaInterfaceAttribute : Attribute
    {
        public JavaInterfaceAttribute(Type type)
        {}
    }

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class JavaEnumAttribute : Attribute
    {
#nullable enable
        public string? Name { get; }

        public JavaEnumAttribute(string? name = null)
        {
            Name = name;
        }
#nullable disable
    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public sealed class MapNameAttribute : Attribute
    {
        public MapNameAttribute(string value, bool useMapping = true)
        {}
    }

    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public sealed class SignatureAttribute : Attribute
    {
        public string Value { get; }

        public bool UseMapping { get; }

        public SignatureAttribute(string value, bool useMapping = true)
        {
            Value = value;

            UseMapping = useMapping;
        }
    }

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    internal sealed class ReturnCheckAttribute : Attribute
    {
        public ReturnCheckAttribute(string paramName)
        {}
    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    internal sealed class StaticGenericAttribute : Attribute
    {
        public StaticGenericAttribute(Type type)
        {}
    }

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public sealed class FabricModAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public sealed class HandlerAttribute : Attribute
    {
        public HandlerAttribute(string name)
        {}
    }
}
