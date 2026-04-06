using System;
using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    public GameObject door;
    public Boolean isOpen = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public string GetInteractionText()
    {
        return "Open/Close";
    }

    public void PerformAction(KeyCode c, GameObject Character)
    {
        if (c == KeyCode.R)
        {
            if (isOpen)
            {
                door.transform.Rotate(0, 90, 0);
                isOpen = false;
            }
            else
            {
                door.transform.Rotate(0, -90, 0);
                isOpen = true;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
