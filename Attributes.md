# 特性Attribute

`Mliybs.Minecraft.Fabric`中有大量的特性，这些特性大多都是用于给源生成器识别并生成代码的

## MapName特性

`MapNameAttribute`用于给类自动生成Names和ClassRef静态只读属性，参数为类的中间名，没有混淆的类应该手动编写ClassRef属性

## Signature特性

`SignatureAttribute`用于给方法或属性自动生成相关的MethodID或FieldID属性和调用内容

该特性有两个参数，第二个参数可选，默认为true，表示是否进行中间名映射

如果进行映射，第一个参数为中间名，如果不映射，第一个参数为方法名或字段名

> 所有的Java方法即使是get set开头的方法都应使用C#方法进行对应
> 所有的Java字段都应使用C#属性（一般情况下Java暴露出的字段都是静态只读的）
> 如果方法标记为partial，源生成器会自动生成调用内容并返回结果

## JavaConstructor

`JavaConstructorAttribute`用于构造函数，由于无法给构造函数标记为partial，所以在`SignatureAttribute`的基础上自动生成了以Invoke结尾的辅助函数，直接调用即可
