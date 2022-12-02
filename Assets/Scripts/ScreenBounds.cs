using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenBounds : MonoBehaviour
{
    public static Vector2 screenBounds;
    private Camera mCamera;

    void Start()
    {
        mCamera = Camera.main;
    }

    void Update()
    {
        screenBounds = mCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    public static Vector2 getScreenBounds() {
        return screenBounds;
    }
}
