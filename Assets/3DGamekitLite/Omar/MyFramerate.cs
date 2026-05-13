#pragma warning disable IDE0051
using UnityEngine;

public class MyFramerate : MonoBehaviour
{
    [SerializeField] int maxFrameRate;

    void Awake()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = maxFrameRate;
    }
}
