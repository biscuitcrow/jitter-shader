using UnityEngine;

public class ShaderController : MonoBehaviour
{
    public float timeScale;

    public void SetTimeScale(float timeScale)
    {
        Debug.Log($"Shader Time Scale Set: {timeScale}");
        Shader.SetGlobalFloat("_Time_Multiplier", timeScale);
    }

    private void OnValidate()
    {
        Debug.Log($"ShaderController inspector changed.");
        SetTimeScale(timeScale);
    }
}
