using UnityEngine;

public class PostEffect : MonoBehaviour {

    public Material myMaterial;

    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, myMaterial);
    }
}
