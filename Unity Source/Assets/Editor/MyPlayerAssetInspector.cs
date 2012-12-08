using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(MyPlayerAsset))]
public class MyPlayerAssetInspector : Editor
{
      
    [MenuItem("MyTest/Create Player Asset")]
    public static void CreateMyPlayerAsset()
    {
        MyPlayerAsset myPlayer = new MyPlayerAsset("Jiejiewang");
        AssetDatabase.CreateAsset(myPlayer, "assets/myplayer.asset");
    }


    public override void OnInspectorGUI()
    {
        GUILayout.Button("Test");
    }
}
