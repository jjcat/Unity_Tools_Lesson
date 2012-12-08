# Unity3D制作编辑器工具教程_1 —— Inspector#

## 简介 ##
Inspector面板可以用来对Componet和Asset进行快速编辑。如果您的Unity中没有看到Inspector面板，可以通过快捷键方式*Ctrl+3*打开。
<!Insert Image about Material Inspector>


##默认的Inspector样式##
新建一个C#文件，命名为MyPlayer.cs，输入下面的代码。这些代码定义了一个MyPlayer class，它继承自MonoBehaviour，是一个用户自定义的组件。	

	using UnityEngine;
	[System.Serializable]
	using System.Collections;
		public class MyPlayer : MonoBehaviour 
	{
    	public int armor = 75;
    	public int damage = 75;
    	public GameObject gun; 
	}

>  **注意：**是不是只有派生自MonoBehaviour的类才能够进行自定义化Editor? 不是，例如贴图，模型等不用加到GameObject上的资源文件，可以在Project面板下显示并选中，在Inspecotor面板中会列出这些资源的属性，并且可以进行修改。如果您也要自定义asset，需要继承自ScriptableObject class。自定义资源会在以后的课程中进行讲解。

<! Insert Image:01_texture_inspector.png>



让后我们在场景中新建一个GameObject，将上面的脚本添加到该GameObject上。
如果一个GameObject拥有该组件，那么在Inspector面板中会显示相关的一些信息。默认情况下，Unity会自动为我们生成一个组件编辑面板，他会把所有的public的变量显示在Inspector中。如下图：

<a href="http://imgur.com/piiO0"><img width = 600 src告诉="http://i.imgur.com/piiO0.png" title="Hosted by imgur.com" alt="" /></a>

Unity默认的Edtior面板可以随意对该变量进行修改。当MyPlayer类中的这些变量肯定是有其合法的数值范围，在自定义Editor中，我们就可以让对输入进行限制。如果这个MyPlayer最后是要给关卡设计师使用，他就不可能输入一些错误的数值。自定义后的Editor，对数值的输入做了限制，还增加了一个processing bar来增强显示效果。

<! Insert the image that comstomized inpsector of MyPlayer class>
>
>	!Insert Imgae!
>

##自定义Editor面板##
现在我们开始自定义Inspector面板的内容。自定义后的面板样式如下：
<!Insert Image about customized Inspector>

具体的步骤为：
创建一个新的C#文件，命名为MyPlayerEditor.cs，并将该文件放在Editor文件夹下。
>**注意**：为什么要放在Editor文件夹下？所有的Editor classes都必须放在Editor文件夹下，这时Unity的规定，Untiy编辑器运行Editor文件夹的Editor class，游戏中运行的代码不要放在Editor文件夹下。

下面的代码将会创建一个自定义的Editor，你将会在Inspector面板中看到最后的效果。
<!Insert code for write customize Inspector for MyPlayer class>

。。。

。。。

然后打开Unity编辑器，在一个GameObject上创建一个MyPlayer组件，你会看到默认的Inspector面板的选项被我们重写了。
##Editor class##
如果您想自定义如上的Inspector面板显示的内容，那么您必须像上面的例子那样，从Editor class中派生自己的类。

	[CustomEditor(typeof(MyPlayer))]
	public class MyPlayerInspector : Editor
	{
		// others...
	}

第一行代码告诉自定义Editor对应修改的类型，我们这里要对MyPlayer class进行自定义Editor。

	CustomEditor[typeof(MyPlayer)]
自定义Editor class必须从Editor class派生
	
	public class MyPlayerInspector: Editor
	{
		//others...
	}
##获取当前选择的对象##
Edtior class有三个成员变量可以让您访问当前选择的对象，这三个变量分别是

-  target
-  targets
-  serializedObject

	
