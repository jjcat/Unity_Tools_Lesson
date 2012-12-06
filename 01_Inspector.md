# Unity3D制作编辑器工具教程_1 —— Inspector#

## 简介 ##
Inspector面板可以用来对Componet和Asset进行快速编辑。如果您的Unity中没有看到Inspector面板，可以通过快捷键方式*Ctrl+3*打开。
<!Insert Image about Material Inspector>


##默认的Inspector样式##
如下的代码是一个自定义的MyPlayer类，它继承自MonoBehaviour，是一个用户自定义的组件。	

	using UnityEngine;
	using System.Collections;
	[System.Serializable]
		public class MyPlayer : MonoBehaviour {
    	public int armor = 75;
    	public int damage = 75;
    	public GameObject gun; 
	}
如果一个GameObject拥有该组件，那么在Inspector面板中会显示相关的一些信息。默认情况下，Unity会自动为我们生成一个组件编辑面板，他会把所有的public的变量显示在Inspector中。如下图：

<a href="http://imgur.com/piiO0"><img width = 600 src="http://i.imgur.com/piiO0.png" title="Hosted by imgur.com" alt="" /></a>

##自定义Inspector面板##
现在我们开始自定义Inspector面板的内容。自定义后的面板样式如下：
<!Insert Image about customized Inspector>

具体的步骤为：
创建一个新的C#文件，命名为MyPlayerEditor.cs，并将该文件放在Editor文件夹下。
####为什么要放在Editor文件夹下？####

下面的代码将会创建一个自定义的Editor，你将会在Inspector面板中看到最后的效果。
<!Insert code for write customize Inspector for MyPlayer class>

。。。

。。。

然后打开Unity编辑器，在一个GameObject上创建一个MyPlayer组件，你会看到默认的Inspector面板的选项被我们重写了。O
##Editor class##
如果您想自定义如上的Inspector面板显示的内容，那么您必须像上面的例子那样，从Editor class中派生自己的类。

	[CustomEditor(typeof(MyPlayer))]
	public class MyPlayerInspector : Editor
	{
		
	}
	