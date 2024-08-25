# 使用指南

> 在使用`Mliybs.Minecraft.Fabric`前，请确保你安装了.NET8运行时

创建一个类库项目，可以使用任意工具

添加特定版本的`Mliybs.Minecraft.Fabric`的NuGet包引用，这里以`Mliybs.Minecraft.Fabric.V1_16_5`举例

新建一个类，写一个静态函数，例如：

```C#
[System.Runtime.InteropServices.UnmanagedCallersOnly(EntryPoint = "Initialize")]
public static void Load()
{
	// 你的逻辑
}
```