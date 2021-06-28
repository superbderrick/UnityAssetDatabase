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


    private const string STORE_CONFIGURATION = "SETUP FOR Membership Android";
    //private const string STORE_GOOGLE = "GOOGLE";
    
    private void OnGUI()
    {
        EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button(STORE_CONFIGURATION))
        {
            MembershipBuild.ConfigureMembershipSDK();
        }
 
        // if (GUILayout.Button(STORE_GOOGLE))
        // {
        //     Debug.Log("GOOGLE");
        // }
        //
        EditorGUILayout.EndHorizontal();
    }
}
