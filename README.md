# 什么是Mliybs.Minecraft.Fabric

`Mliybs.Minecraft.Fabric`是一个依赖于Fabric Mod [NativeLoader](https://github.com/Mliybs/NativeLoader)的C#绑定库，它通过NativeAOT和JNI来与JVM交互，并提供Java类的C#代理包装，以此来尽力提供与Java相同的Fabric Mod编程体验

想使用它，你需要.NET8运行时，同时在发布的时候启用PublishAot编译选项以确保自己使用的是NativeAOT

> 因为这个库是使用NativeAOT的，所以会有反射限制，使用的时候请多加小心

本仓库还有[使用指南](tutorial/README.md)和[贡献须知](develop/README.md)，详情请点进链接查看

# 为什么需要Mliybs.Minecraft.Fabric

<del>我都写C#了还要我多说吗</del>