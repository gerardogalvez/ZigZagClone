using UnityEngine;
using UnityEditor;
using UnityEditor.Build.Reporting;
using System;
using System.Collections;

public static class Builder
{
	static string[] scenes = { "Assets/Remote.unity" };


	[MenuItem("Build/Build iOS")]
	public static void BuildiOS()
	{
		BuildReport error = BuildPipeline.BuildPlayer(scenes, "build/UnityRemoteNG-iOS", BuildTarget.iOS, BuildOptions.None);
		if (error != null) {
			throw new Exception("Build failed: " + error);
		}
	}


	[MenuItem("Build/Build Android")]
	public static void BuildAndroid()
	{
		string sdk = Environment.GetEnvironmentVariable("ANDROID_SDK_ROOT");
		EditorPrefs.SetString("AndroidSdkRoot", sdk);
		BuildReport error = BuildPipeline.BuildPlayer(scenes, "build/UnityRemoteNG-Android.apk", BuildTarget.Android, BuildOptions.None);

		if (error != null) {
			throw new Exception("Build failed: " + error);
		}
	}
}
