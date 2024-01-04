using UnityEngine;

public class SkyRotator : MonoBehaviour
{
    public float RotateSpeed = 1.0f;

    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * RotateSpeed);
    }
}
