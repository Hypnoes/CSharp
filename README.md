# CSharp

### C#作业

>  __Author__ := "Hypnoes"

<<<<<<< HEAD
<<<<<<< HEAD
>  __Mood__ := *★,°*:.☆(￣▽￣)/$:*.°★* 。
=======
>  __Mood__ := *★,°*:.☆(￣▽￣)/$:*.°★* 。
>>>>>>> dee9851a36075e2d0c2bb46f4134c82f097c26b6
=======
>  __Mood__ := *★,°*:.☆(￣▽￣)/$:*.°★* 。
>>>>>>> dee9851a36075e2d0c2bb46f4134c82f097c26b6

* * *

* ##### 第一次作业
    1. 依次提示用户输入两个整数（假设i1、i2）。如果i1、i2都是正数，则将i1的值递增一个数，然后打印i1+i2的值；如果i1、i2都是负数，则将i1的值递减10个数，然后打印i1\*i2的值；如果i1、i2中任一个为0，则提示数据有错误；否则计算i1\*i2的绝对值。
        * [<span style="color: green">√</span>] ans => ./ex1.1
    1. 不断要求用户输入一个数字（假定用户输入的都是正整数），当用户输入end的时候显示刚才输入的数字中的最大值。设一个变量int max，初始值为0，用户每输入一次就把用户输入的和max比较一下，如果输入的比max大，则让max等于用户输入。
        * [<span style="color: green">√</span>] ans => ./ex1.2 
    1. 编写聊天机器人，如果问“今天天气怎么样？”则回答天气，如果问……，如果说“88”，则“再见”。
        * [<span style="color: green">√</span>] ans => ./ex1.3 
    1. 将一个字符串数组的元素的顺序进行反转。{"3","a","8","haha"}{"haha","8","a","3"}。第i个和第length-i-1个进行交换。
        * [<span style="color: green">√</span>] ans => ./ex1.4

* ##### 第二次作业
    1. `Step1` 创建一个Person类库，以Person作为基类，创建子类Chinese和American，有同名的hi（）函数，分别输出中文的问好和英文的问好。<br />
	`Step2` 在类Helloworld中引用Person类，创建Chinese和American对象，调用问好。
        * [<span style="color: green">√</span>] ans => ./ex2.1
    1. `Step1` 设计汽车类Car，有特性（私有字段）：品牌、车型、颜色、门数，最大时速；构造函数有两个，一个构造函数参数仅品牌，另一个构造函数参数包括品牌、车型；属性有品牌、车型、颜色、门数、最大时速；有方法加速SpeedUp（）、SpeedUp（int i），减速SpeedDown（）、SpeedDown（int j）。<br />
	`Step2` 在主函数main中通过两个构造函数创建两辆车实例；显示车的品牌、车型、颜色、门数、最大时速信息；各自调用加速减速方法。
        * [<span style="color: green">√</span>] ans => ./ex2.2

* ##### 第三次作业
    1. 定义点类，从点类派生矩形类和园类，主程序实现用同一个方法显示矩形和园的面积。
        * [<span style="color: red">×</span>] ans => ~~./ex3.1~~
    1. 重做 _1_ 题，将点类定义为抽象类。
        * [<span style="color: green">√</span>] ans => ./ex3.2
    1. 重做 _1_ 题，改为接口实现，即将点类改为接口。
        * [<span style="color: green">√</span>] ans => ./ex3.3
    1. 编写一个控制台应用程序项目，假设图书馆的图书类Book包含书名和编号和作者属性，读者类Reader包含姓名和借书证属性，每位读者最多可借5本书，设计它们的公共基类BClass。要求列出所有读者的借书情况，类似下图。
        ![作业3_3](http://23.105.194.199/res/zuoye3_3.jpg)
        * [<span style="color: green">√</span>] ans => ./ex3.4

* ##### 第四次作业
    1. 添加一个继承自List<T>的类ListEX<T>，假设T类型不提供对象比较的方法，为该类添加方法CountAll()，输入参数为T类型对象，该方法用于计算指定参数出现在ListEX<T>中的次数；假设T类型实现了接口IComparable，提供了Compare()方法，可以对两个T类型的对象进行大小的比较，修改CountAll()方法，先将泛型中的数据元素排序，再计算指定参数出现在ListEX<T>中的次数。
        * [<span style="color: red">×</span>] ans => ~~./ex4.1~~
    1. 在主函数中创建该泛型类的实例，并为该类添加10个元素[1,2,2,3,3,3,4,4,4,4]；分别调用 _1_ 中的两个CountAll()方法计算1、2、3和4在集合中出现的次数，并输出。
        * [<span style="color: green">√</span>] ans => ./ex4.2
    1. 试着在 _2_ 中的两个CountAll()方法中添加计时功能，再次运行程序，体会排序是否提高了程序的时间效率。
        * [<span style="color: green">√</span>] ans => ./ex4.3

* ##### 第五次作业
    1. 实现拆分和合并文件的完整程序
        * [<span style="color: yellow">●</span>] ans => ./ex5.1

* ##### 第六次作业
    1. 设计一个访问数据库的类，主要功能包括：能获得满足查询条件的记录数、自动生成一些常见的SQL语句，将该类编译成dll。
        * [<span style="color: yellow">●</span>] ans => ./ex6.1
    1. 新建Windows应用程序，加载前面定义的组件（dll），在DataGridView中显示满足条件的数据。
        * [<span style="color: yellow">●</span>] ans => ./ex6.2

 * * *

## 总结
*
    * 所有作业来自于PPT后的Assignment.
    * 我不保证作业的正确性。
    * 编译用的是dotnet core，并不保证Visual Studio的兼容。
    * 我以为这门课叫C#网络编程，结果并没有提ASP.NET。反而中间讲了一些winForm。Σ(っ °Д °;)っ
    * 有问题联系caoxiang99@163.com.

        __祝大家生活愉快__
 >*★,°*:.☆(￣▽￣)/$:*.°★* 。
