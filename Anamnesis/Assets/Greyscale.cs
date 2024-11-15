using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Greyscale : MonoBehaviour
{

    public Material greyscaleMaterial;
    public Sprite spriteToExclude;  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnPreRender()
    {
        // Set the _ExcludeSprite texture on the material
        if(greyscaleMaterial != null && spriteToExclude != null)
            greyscaleMaterial.SetTexture("_ExcludeSprite", spriteToExclude.texture);
        else{
            Debug.LogError("Make sure the material and sprite are assigned in the inspector");
        }

    }

    private void OnRenderImage(RenderTexture source, RenderTexture destination) {
        if (greyscaleMaterial != null)
          Graphics.Blit(source, destination, greyscaleMaterial);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
