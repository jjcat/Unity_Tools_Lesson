using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(MyPlayer))]
public class MyPlayerInspector : Editor
{
    public SerializedProperty damageProp;
    public SerializedProperty armorProp;
    public SerializedProperty gunProp;

    void OnEnable()
    {
        Debug.Log("Call Enable");
        damageProp = serializedObject.FindProperty("damage");
        armorProp = serializedObject.FindProperty("armor");
        gunProp = serializedObject.FindProperty("gun");

    }

    void OnDisable()
    {
        Debug.Log("Call Disable");
    }

    void OnDestory()
    {
        Debug.Log("Call Destory");
    }

    public override void OnInspectorGUI()
    {
 	     serializedObject.Update();

         EditorGUILayout.IntSlider(damageProp, 0, 100, new GUIContent("Damage"));
         // Only show the damage progress bar if all the objects have the same damage value:
         if (!damageProp.hasMultipleDifferentValues)
             ProgressBar(damageProp.intValue / 100.0f, "Damage");

         EditorGUILayout.IntSlider(armorProp, 0, 100, new GUIContent("Armor"));
         // Only show the armor progress bar if all the objects have the same armor value:
         if (!armorProp.hasMultipleDifferentValues)
             ProgressBar(armorProp.intValue / 100.0f, "Armor");

         EditorGUILayout.PropertyField(gunProp, new GUIContent("Gun Object"));

         // Apply changes to the serializedProperty - always do this in the end of OnInspectorGUI.
         serializedObject.ApplyModifiedProperties();
    }

        // Custom GUILayout progress bar.
     private void ProgressBar (float value , string label)
     {
        Rect rect = GUILayoutUtility.GetRect (18, 18, "TextField");
        EditorGUI.ProgressBar (rect, value, label);
        EditorGUILayout.Space ();
     }


}
