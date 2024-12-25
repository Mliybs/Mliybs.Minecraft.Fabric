# 开发范式

`Mliybs.Minecraft.Fabric`是一个Java绑定库，因此会大量与指针，非托管代码打交道，它尽力提供与编写正常C#代码相同的感受，<del>但该绑定库内部具有一部分的约定俗成内容，这是Java绑定的限制所致，因此才有了这份开发范式来帮助开发者进行开发，</del>目前，几乎所有的约定俗成内容都被**源生成器**所代替，你可以使用源生成器提供的一系列特性来帮助源生成器自动生成代码

> 值得注意的是，**该开发范式是帮助编写此Java绑定库的，而不是该库的使用指南**

## 内置接口与抽象类

`Mliybs.Minecraft.Fabric`内置了数个接口与抽象类，分别代表不同的含义

需要注意的是，这些接口与抽象类大多只表示某些意义，几乎不会将它们作为参数类型 _（因为它们大多是用来包含静态抽象成员的）_

由于抽象类不支持静态抽象成员，所以一个类有的时候必须分别继承抽象类和接口，这一点需要注意

### IClassRef接口

`IClassRef`指示一个类具有相对应的Java类绑定，但它**不一定是可作为Java对象的，也不一定具有Java构造函数**

如果一个`IClassRef`的实现类对应的是**混淆代码**，则**应**具有静态`Names`只读字段，该字段负责提供中间名与运行时Java类名的映射结果

### IConstructor接口

<del>现身说法：这个接口目前没什么卵用了，将来准备删除（</del>

`IConstructor`指示一个类在具有Java类绑定的基础上，还具有Java构造函数，可作为Java对象，它继承自`IClassRef`，**实现该接口的C#类可以通过实例化C#对象来实例化相对应的Java对象**

虽然此时它与`JavaClass`没有继承关系，但子类应该同时继承它们两个

### JavaClass抽象类

`JavaClass`指示一个类可作为Java对象，它不一定具有Java构造函数，但它自己具有传入指针的C#构造函数，即**可以将Java方传递过来的对象指针作为C#对象表示**

`JavaClass`还具有自主全局引用管理，会将每一个Java对象的局部引用更改为全局引用存储在自身的`ObjectRef`属性下，并使用**终结器**_（析构函数）_ 释放，这样做能保证**C#对象的生命周期不会长于相对应的Java对象，在C#对象还没有被释放的时候是一定能访问到相对应的Java对象的**

在继承的时候应同时与`IClassRef`或`IConstructor`进行继承，如果对应的Java类具有可用的公共构造函数则应使用后者，否则使用前者

> 话是这么说，但你其实应该继承`Java.Lang.Object`，只有部分特殊类需要继承`JavaClass`

### IWrapper接口

IWrapper指示一个类可以被正常继承，它继承自`IConstructor`

由于此库不具有动态生成`Java`类的能力，因此我们退而求其次，利用Java包装类只为部分类提供了继承功能（如`Item`类），这意味着，**只有实现该接口的C#类可被正常继承进行诸如覆写基类方法的操作，继承未实现该接口的C#类是没有任何意义的**

### IFromHandle&lt;T&gt;接口

所有实现了`IClassRef`接口的类都应该实现`IFromHandle<T>`接口，这个接口提供一个返回值为`T`的`From(nint handle)`静态方法，由源生成器给每个继承自`JavaClass`的类自动生成（主要内容就是调用类的构造函数并返回），这个接口主要用于泛型方法的返回值中，给作为返回值类型的泛型参数添加`IFromHandle<T>`约束后，就可以通过调用`T.From(nint handle)`获取到对应的对象

> 如果直接给`IClassRef`添加`From`静态方法的话，对于有多个泛型参数且互相有继承关系的泛型方法来说，可能会造成调用二义性错误

> 目前来说，将引用转换为C#对象的过程都应使用From方法而不是构造函数，因为From方法为除了`Java.Lang.Object`以外的类都提供了子类查找，在自己是子类对象的时候会调用子类的From方法，直到无法找到派生程度更高的子类