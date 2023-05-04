using UnityEditor;
using UnityEngine;
using System.Reflection;


namespace Framework.Core.EditorExtension
{
    public class OpenAdditionalLockedInpsector : MonoBehaviour
    {
        private static EditorWindow lockedInspectorWindow = null;

        [MenuItem("GameObject/Tools/Locked Inspector &%l", false, 199)]
        static void DisplayLockedInspector()
        {
            if (lockedInspectorWindow != null)
            {
                // Close locked inspector window
                lockedInspectorWindow.Close();
                DestroyImmediate(lockedInspectorWindow);
                lockedInspectorWindow = null;
            }
            else
            {
                // Create new inspector window
                lockedInspectorWindow = ScriptableObject.CreateInstance(GetInspectorWindowType()) as EditorWindow;
                lockedInspectorWindow.Show();

                // Lock new inspector window
                GetInspectorWindowType().GetMethod("FlipLocked", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static).Invoke(lockedInspectorWindow, null);
            }
        }

        private static System.Type GetInspectorWindowType()
        {
            return typeof(UnityEditor.Editor).Assembly.GetType("UnityEditor.InspectorWindow");
        }
    }
}