using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeScreenshotURP : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            ScreenCapture.CaptureScreenshot("Screenshot_" + Time.time + ".png");
            Debug.Log("Screenshot Taken");
        }
    }
}

