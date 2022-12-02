using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ShopManager))]
public class ShopManagerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        var shopManager = target as ShopManager;
        var style = new GUIStyle(EditorStyles.label);
        style.richText = true;

        EditorGUILayout.LabelField("<b>ƒKƒ`ƒƒ‚ð‰ñ‚·</b>", style);
        if (GUILayout.Button("TurnTheHandle"))
        {
            shopManager.TurnTheHandle();
        }
    }
}
