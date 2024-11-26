using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;

public class CustomPrefixChangeScript : EditorWindow
{
    private string oldPrefix = "DS";
    private string newPrefix = "TG";

    [MenuItem("Tools/Change Prefix in All Project Script Names")]
    public static void ShowWindow()
    {
        GetWindow<CustomPrefixChangeScript>("Change Prefix in All Project Script Names");
    }

    private void OnGUI()
    {
        GUILayout.Label("Change Prefix in All Project Script Names:");

        oldPrefix = EditorGUILayout.TextField("Old Prefix:", oldPrefix);
        newPrefix = EditorGUILayout.TextField("New Prefix:", newPrefix);

        if (GUILayout.Button("Change Prefix"))
        {
            
            //if (!string.IsNullOrEmpty(oldPrefix) && !string.IsNullOrEmpty(newPrefix))
            //{
            //    List<Type> monoBehaviourTypes = new List<Type>();
            //    Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();

            //    foreach (Assembly assembly in assemblies)
            //    {
            //        Type[] typesInAssembly = assembly.GetTypes();
            //        monoBehaviourTypes.AddRange(typesInAssembly.Where(t => typeof(MonoBehaviour).IsAssignableFrom(t) && t != typeof(MonoBehaviour));
            //    }
            //}



        }
    }

}
