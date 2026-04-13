using System;
using System.Collections;
using UnityEngine;

public class NeonGlow : MonoBehaviour
{
    public Material glowMat;
    public Material defaultMat;
    public Boolean isGlowing = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetMat(gameObject, defaultMat);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator GlowRoutine()
    {
        SetMat(gameObject, glowMat);
        isGlowing = true;
        for (int i = 0; i < 4; i++)
        {
            yield return new WaitForSeconds(1);
            if (isGlowing)
            {
                SetMat(gameObject, defaultMat);
                isGlowing = false;
            }
            else
            {
                SetMat(gameObject, glowMat);
                isGlowing = true;
            }
        }
        SetMat(gameObject, defaultMat);
        isGlowing = false;
    }
    void SetMat(GameObject group, Material mat)
    {
        foreach (Transform child in group.transform)
        {
            GameObject obj = child.gameObject;
            obj.GetComponent<Renderer>().material = mat;

        }
    }
}
