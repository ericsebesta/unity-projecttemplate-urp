using UnityEditor;

//A sample script only included in editor builds.
//The sample tests reference this script to ensure that assembly definition linkages are setup correctly.
public class NewEditorBehaviourScript : Editor
{
    /// <summary>
    /// Sample function that we can call for asmdef linkages and to validate test coverage.
    /// </summary>
    /// <returns></returns>
    public static int TestCall()
    {
        return UnityEngine.Random.Range(0, 10);
    }
}
