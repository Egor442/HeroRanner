using UnityEngine;

public class ScreenRotation : MonoBehaviour
{
    public void Update()
    {
        if (Screen.orientation != ScreenOrientation.LandscapeLeft)
        {
            Screen.orientation = ScreenOrientation.LandscapeLeft;
        }
    }
}