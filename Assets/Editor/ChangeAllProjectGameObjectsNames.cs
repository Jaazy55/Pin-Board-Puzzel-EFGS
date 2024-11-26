using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ChangeAllProjectGameObjectsNames : EditorWindow
{
    private string oldPrefix = "";
    private string newPrefix = "";

    [MenuItem("Tools/Replace Prefix in All Project GameObject Names")]
    public static void ShowWindow()
    {
        GetWindow<ChangeAllProjectGameObjectsNames>("Replace Prefix in All Project GameObject Names");
    }

    private void OnGUI()
    {
        GUILayout.Label("Replace Prefix in All Project GameObject Names:");

        oldPrefix = EditorGUILayout.TextField("Old Prefix:", oldPrefix);
        newPrefix = EditorGUILayout.TextField("New Prefix:", newPrefix);

        if (GUILayout.Button("Replace Prefix"))
        {
            if (!string.IsNullOrEmpty(oldPrefix) && !string.IsNullOrEmpty(newPrefix))
            {
                Undo.RecordObject(Selection.activeObject, "Replace Prefix in Project GameObject Names");

                GameObject[] allGameObjects = GameObject.FindObjectsOfType<GameObject>();

                foreach (GameObject go in allGameObjects)
                {
                    if (go.name.StartsWith(oldPrefix))
                    {
                        go.name = go.name.Replace(oldPrefix, newPrefix);
                        EditorUtility.SetDirty(go);
                    }
                }

                AssetDatabase.SaveAssets();
                AssetDatabase.Refresh();
            }
        }
    }
}
