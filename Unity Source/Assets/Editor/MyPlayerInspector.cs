using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(MyPlayer))]
public class MyPlayerInspector : Editor
{
    public int damageProp;
    public int armorProp;
    public GameObject gunProp;

    // Initilization
    void OnEnable()
    {
        MyPlayer myPlayer = target as MyPlayer;
        damageProp = myPlayer.damage;
        armorProp = myPlayer.armor;
        gunProp = myPlayer.gun;
    }

    public override void OnInspectorGUI()
    {
        // show slider and process bar
        damageProp =  EditorGUILayout.IntSlider("Damage", damageProp, 0, 100);
        ProgressBar(damageProp/ 100.0f, "Damage");

        // show slider and process bar
        armorProp = EditorGUILayout.IntSlider("Armor", armorProp, 0, 100);
        ProgressBar(armorProp/ 100.0f, "Armor");
            
        gunProp = EditorGUILayout.ObjectField("Player's Gun", gunProp, typeof(GameObject), true) as GameObject;

    }

    // Custom GUILayout progress bar.
    private void ProgressBar(float value, string label)
    {
        Rect rect = GUILayoutUtility.GetRect(18, 18, "TextField");
        EditorGUI.ProgressBar(rect, value, label);
        EditorGUILayout.Space();
    }


}
