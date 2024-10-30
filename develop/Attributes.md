# 特性Attribute

`Mliybs.Minecraft.Fabric`中有大量的特性，这些特性大多都是用于给源生成器识别并生成代码的

## MapName特性

`MapNameAttribute`用于给类自动生成Names和ClassRef静态只读属性，参数为类的名称，同时支持用点来分割包名和用斜杠分割

如果你给混淆类添加`MapName`特性，请填入类的完整中间名

如果你给具名类添加`MapName`特性，请填入类的完整限定名，并添加一个`false`参数（指示不使用映射）

## Signature特性

`SignatureAttribute`用于给方法或属性自动生成相关的MethodID或FieldID属性和调用内容

该特性有两个参数，第二个参数可选，默认为true，表示是否进行中间名映射

如果进行映射，第一个参数为中间名，如果不映射，第一个参数为方法名或字段名

> 所有的Java方法即使是get set开头的方法都应使用C#方法进行对应
> 所有的Java字段都应使用C#属性（一般情况下Java暴露出的字段都是静态只读的）
> 如果方法标记为partial，源生成器会自动生成调用内容并返回结果

## JavaConstructor

`JavaConstructorAttribute`用于构造函数，由于无法给构造函数标记为partial，所以在`SignatureAttribute`的基础上自动生成了以Invoke结尾的辅助函数，直接调用即可

> 你也可以给某些private构造函数添加该特性，在其它构造函数中调用生成出来的辅助函数，这通常用于解决签名冲突问题

> 对于只用于生成辅助函数的构造函数，你应该在构造函数内部抛出`NotSupportedException`