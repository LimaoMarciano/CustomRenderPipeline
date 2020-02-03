using UnityEngine;
using UnityEngine.Rendering;

public class CameraRenderer : MonoBehaviour
{
    ScriptableRenderContext context;

    Camera camera;

    public void Render (ScriptableRenderContext context, Camera camera)
    {
        this.context = context;
        this.camera = camera;
    }
}
