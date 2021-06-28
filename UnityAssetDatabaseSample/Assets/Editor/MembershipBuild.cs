using System;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class MembershipBuild 
{
    private const string MembershipPath = "Assets/SSMembership/";
    private const string ExamplesPath = "Assets/Examples/";
    private const string PluginsPath = "Assets/Plugins/";
    
    private const string ALERT_MESSAGE = "Which store want to configure? Amazon or Google ";
    private const string ALERT_TITLE = "Membership SDK";
    private const string ALERT_YES = "Google";
    private const string ALERT_NO = "Amazon";

    public enum Target
    {
        DEBUG,
        RELEASE
    }
    
            
        public static void ConfigureMembershipSDK()
        {

            if (EditorUtility.DisplayDialog(ALERT_TITLE,
                ALERT_MESSAGE, ALERT_YES, ALERT_NO))
            {
                Debug.Log("google");
            }
            else
            {
                Debug.Log("amazon");
            }
            
        }
    }

