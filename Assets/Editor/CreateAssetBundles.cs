using System.IO;
using UnityEngine;
using UnityEditor;

public class CreateAssetBundles
{
   [MenuItem("Assets/Build AssetBundles")]
   static void BuildAllAssetBundles()
   {
      var assetBundleDirectory = "Assets/StreamingAssets";
      if (!Directory.Exists(Application.streamingAssetsPath))
         Directory.CreateDirectory(assetBundleDirectory);

      BuildPipeline.BuildAssetBundles(
         assetBundleDirectory,
         BuildAssetBundleOptions.None,
         EditorUserBuildSettings.activeBuildTarget
      );
   }
}
