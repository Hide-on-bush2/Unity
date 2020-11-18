using UnityEditor;
using UnityEngine;

namespace RPGCharacterAnimsFREE
{

	public class SetupMessageWindow:EditorWindow
	{
		void OnGUI()
		{
			EditorGUILayout.LabelField("Before attempting to use the RPG Animation Mecaim Animation Pack FREE, you must first ensure that the layers and inputs are correctly defined.  There is an included InputManager.preset and LayerManager.preset which contains all the settings that you can load in.\n \nYou can remove this message by deleting the SetupInputLayersFREE.cs script.", EditorStyles.wordWrappedLabel);
		}
	}

	class SetupInputLayers:AssetPostprocessor
	{
		static void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths)
		{
			SetupMessageWindow window  = (SetupMessageWindow)EditorWindow.GetWindow(typeof(SetupMessageWindow), true, "Load Input and Layer Presets");
			window.maxSize = new Vector2(315f, 125f);
			window.minSize = window.maxSize;
		}
	}
}