using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FpsController : MonoBehaviour
{
    private void Start()
    {
        Application.targetFrameRate = 120;
    }
}