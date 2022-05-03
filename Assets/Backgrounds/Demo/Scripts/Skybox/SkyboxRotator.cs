using UnityEngine;

public class SkyboxRotator : MonoBehaviour
{
    private float RotationPerSecond = 3;
    private bool _rotate = true;

    protected void Update()
    {
        if (_rotate) RenderSettings.skybox.SetFloat("_Rotation", Time.time * RotationPerSecond);
    }

    public void ToggleSkyboxRotation()
    {
        _rotate = !_rotate;
    }
}