using System.Collections.Generic;
using UnityEditor;

public  class JenkinsAdapter
{
   [MenuItem("Jenkins/JenkinsBuild")] 
    public static void Build() {
        EditorUserBuildSettings.SwitchActiveBuildTarget( BuildTarget.iOS);

         // keystore 路径, G:\keystore\one.keystore
     /*   PlayerSettings.Android.keystoreName = "/Users/jiyuwangluo/Ceshi/userzs.keystore";
        // one.keystore 密码
        PlayerSettings.Android.keystorePass = "maczuihao8";

        // one.keystore 别名
        PlayerSettings.Android.keyaliasName = "userzs";
        // 别名密码
        PlayerSettings.Android.keyaliasPass = "maczuihao8";*/

        List<string> sceneList = new List<string>();
        EditorBuildSettingsScene[] temp = EditorBuildSettings.scenes;
        for (int i = 0, iMax = temp.Length; i < iMax; ++i) sceneList.Add(temp[i].path);
        BuildPipeline.BuildPlayer(sceneList.ToArray(), "testipa", BuildTarget.iOS, BuildOptions.None);
        
    }
}