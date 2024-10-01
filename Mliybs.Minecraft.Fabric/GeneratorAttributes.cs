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

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class JavaInterfaceAttribute : Attribute
    {}

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
        public string Value { get; }

        public MapNameAttribute(string value)
        {
            Value = value;
        }
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
}
