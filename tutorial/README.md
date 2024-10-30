# 使用指南

> 在使用`Mliybs.Minecraft.Fabric`前，请确保你安装了.NET8运行时

创建一个类库项目，可以使用任意工具

在创建的项目的.csproj文件内，在`<PropertyGroup>`一栏中加入一行`<PublishAot>true</PublishAot>`

此时该项目便启用了NativeAOT，可以进行下一步操作

> 如果你使用Visual Studio，请安装C++桌面开发工作负载

添加特定版本的`Mliybs.Minecraft.Fabric`的NuGet包引用，这里以`Mliybs.Minecraft.Fabric.V1_16_5`举例

新建一个类，写一个静态方法，并给其添加`FabricMod`特性，例如：

```C#
using Mliybs.Minecraft.Fabric;

namespace Test
{
	public class Program
	{
		[FabricMod]
		public static void Load()
		{
			// 类和函数都必须是public的
		}
	}
}
```

> 如果你的IDE支持引用查找的话，大概率会发现方法的引用数从0变成了1

此时，该方法就成为了这个程序的入口点，所有的初始化动作都在这个方法内部执行