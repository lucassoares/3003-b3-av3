using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

[CustomPropertyDrawer(typeof(PotionSelectorAttribute))]
public class PotionSelectorDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        int index = 0;
        string[] names = new string[PotionDB.Instance.potions.Length];

        for(int i = 0; i < PotionDB.Instance.potions.Length; i++)
        {
            names[i] = PotionDB.Instance.potions[i].name;
            if(names[i] == property.stringValue)
            {
                index = i;
            }
        }
        index = EditorGUI.Popup(position, index, names);
        property.stringValue = names[index];
    }
}
