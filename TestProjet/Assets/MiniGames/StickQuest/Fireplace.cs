using System;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class Fireplace : MonoBehaviour, IInteractable
{
    public GameObject fireplaceInterior;
    public Boolean isLit = false;
    public Material Mat_lit;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public string GetInteractionText()
    {
        if (!isLit)
            return "Light fire for 5 sticks";
        return "Bonefire lit";
    }

    public void PerformAction(KeyCode c, GameObject Character)
    {
        if (c == KeyCode.R)
        {
            Backpack backpack = Character.GetComponent<Backpack>();
            if (backpack != null)
            {
                if(!isLit && backpack.hasSticks())
                {
                    Renderer objectRenderer = fireplaceInterior.GetComponent<Renderer>();
                    objectRenderer.material = Mat_lit;
                    isLit= true;
                }


            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
