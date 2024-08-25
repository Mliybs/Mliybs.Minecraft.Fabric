# 中间名

尽管此库的各种类和方法是具名的，但是在映射到混淆代码时，我们使用的仍然是中间名intermediary，在`MapClassName`中使用中间名便可以获得映射名

传入`MapClassName`的中间名的规范与Java类相同，但嵌套类之间使用$

假设com.mlinetles.sample包中的类A包含嵌套类B，则`MapClassName`的参数应为`com.mlinetles.sample.A$B`

根据约定俗成，每一个映射类都具有`Names`静态只读字段，它包含四个字符串

## OriginName原名

`OriginName`为传入`MapClassName`的中间名本身

## OriginSignature原签名

`OriginSignature`为`OriginName`的变体，所有点`.`被替换为了斜杠`/`

## MapName映射名

`MapName`为映射后的实际Java类名

## MapSignature映射签名

`MapSignature`为`MapName`的变体，所有点`.`被替换为了斜杠`/`

# 映射操作

`Loader`类内有多个