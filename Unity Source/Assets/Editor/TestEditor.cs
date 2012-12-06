using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(MyPlayer))]
public class TestEditor : Editor
{
    public override void OnInspectorGUI()
    {
        GUILayout.Button("Test");
        base.OnInspectorGUI();
    }
}
