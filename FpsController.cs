using UnityEngine;

public class FpsController : MonoBehaviour
{
    private void Start()
    {
        Application.targetFrameRate = 120;
    }
}