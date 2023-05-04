using UnityEditor;

public class LockMenu : Editor
{
    [MenuItem("Tools/Toggle Inspector Lock %l")] // Ctrl + L (��������� �������)
    public static void ToggleInspectorLock()
    {
        ActiveEditorTracker.sharedTracker.isLocked = !ActiveEditorTracker.sharedTracker.isLocked;
        ActiveEditorTracker.sharedTracker.ForceRebuild();
    }
}
