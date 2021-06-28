using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MembershipEditor : EditorWindow
{
    [MenuItem("Membership/StoreSettings")]
    static void Init()
    {
        MembershipEditor window = (MembershipEditor)EditorWindow.GetWindow(typeof(MembershipEditor));
    }


    private const string STORE_AMAZON = "AMAZON";
    private const string STORE_GOOGLE = "GOOGLE";
    
    private void OnGUI()
    {
        EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button(STORE_AMAZON))
        {
            Debug.Log("AMAZON");
        }
 
        if (GUILayout.Button(STORE_GOOGLE))
        {
            Debug.Log("GOOGLE");
        }
        
        EditorGUILayout.EndHorizontal();
    }
}
