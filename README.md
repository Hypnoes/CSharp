# CSharp

### C#作业

>  __Author__ := "Hypnoes"

>  __Mode__ := *★,°*:.☆(￣▽￣)/$:*.°★* 。

* * *

* ##### 第一次作业
    1. 依次提示用户输入两个整数（假设i1、i2）。如果i1、i2都是正数，则将i1的值递增一个数，然后打印i1+i2的值；如果i1、i2都是负数，则将i1的值递减10个数，然后打印i1\*i2的值；如果i1、i2中任一个为0，则提示数据有错误；否则计算i1\*i2的绝对值。
        * [<font color = "green">√</font>] ans => ./作业1_1
    1. 不断要求用户输入一个数字（假定用户输入的都是正整数），当用户输入end的时候显示刚才输入的数字中的最大值。设一个变量int max，初始值为0，用户每输入一次就把用户输入的和max比较一下，如果输入的比max大，则让max等于用户输入。
        * [<font color = "green">√</font>] ans => ./作业1_2 
    1. 编写聊天机器人，如果问“今天天气怎么样？”则回答天气，如果问……，如果说“88”，则“再见”。
        * [<font color = "green">√</font>] ans => ./作业1_3  
    1. 将一个字符串数组的元素的顺序进行反转。{"3","a","8","haha"}{"haha","8","a","3"}。第i个和第length-i-1个进行交换。
        * [<font color = "green">√</font>] ans => ./作业1_4


* ##### 第二次作业
    1. `Step1` 创建一个Person类库，以Person作为基类，创建子类Chinese和American，有同名的hi（）函数，分别输出中文的问好和英文的问好。
	
		`Step2` 在类Helloworld中引用Person类，创建Chinese和American对象，调用问好。
        * [<font color = "green">√</font>] ans => ./作业2_1

    1. `Step1` 设计汽车类Car，有特性（私有字段）：品牌、车型、颜色、门数，最大时速；构造函数有两个，一个构造函数参数仅品牌，另一个构造函数参数包括品牌、车型；属性有品牌、车型、颜色、门数、最大时速；有方法加速SpeedUp（）、SpeedUp（int i），减速SpeedDown（）、SpeedDown（int j）。
	
		`Step2` 在主函数main中通过两个构造函数创建两辆车实例；显示车的品牌、车型、颜色、门数、最大时速信息；各自调用加速减速方法。
        * [<font color = "green">√</font>] ans => ./作业2_2

* ##### 第三次作业
    1. 定义点类，从点类派生矩形类和园类，主程序实现用同一个方法显示矩形和园的面积。
        * [<font color = "red">×</font>] ans => ~~./作业3_1~~
    1. 重做 _1_ 题，将点类定义为抽象类。
        * [<font color = "green">√</font>] ans => ./作业3_1
    1. 重做 _1_ 题，改为接口实现，即将点类改为接口。
        * [<font color = "green">√</font>] ans => ./作业3_2
    1. 编写一个控制台应用程序项目，假设图书馆的图书类Book包含书名和编号和作者属性，读者类Reader包含姓名和借书证属性，每位读者最多可借5本书，设计它们的公共基类BClass。要求列出所有读者的借书情况，类似下图。
        ![作业3_3](http://23.105.194.199/res/zuoye3_3.jpg) 
        * [<font color = "orange">●</font>] ans => ./作业3_3
        
