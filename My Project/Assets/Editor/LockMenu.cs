using UnityEditor;

public class LockMenu : Editor
{
    [MenuItem("Tools/Toggle Inspector Lock %l")] // Ctrl + L (строковый литерал)
    public static void ToggleInspectorLock()
    {
        ActiveEditorTracker.sharedTracker.isLocked = !ActiveEditorTracker.sharedTracker.isLocked;
        ActiveEditorTracker.sharedTracker.ForceRebuild();
    }
}
