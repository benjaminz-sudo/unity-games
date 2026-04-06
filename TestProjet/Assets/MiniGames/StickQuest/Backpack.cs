using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Backpack : MonoBehaviour
{
    private List<string> items = new List<string> { "stick", "stick" };
    public Transform inventoryUI;
    public List<Sprite> sprites;

    void Start() { RefreshUI(); }

    void RefreshUI()
    {
        int i = 0;

        foreach (Transform child in inventoryUI)
        {
            Image img = child.GetComponent<Image>();

            if (i < items.Count)
            {
                img.sprite = sprites.Find(s => s.name == items[i]);
                img.enabled = true;
                i++;
            }
            else
            {
                img.sprite = null;
                img.enabled = false;
            }
        }
    }

    public void AddItem(string name)
    {
        items.Add(name);
        RefreshUI();
    }

    public Boolean hasSticks()
    {
        int stickCount = items.FindAll(item => item == "stick").Count;
        if (stickCount >= 5)
        {
            int removed = 0;
            items.RemoveAll(item =>
            {
                if (item == "stick" && removed < 5)
                {
                    removed++;
                    return true;
                }
                return false;
            });

            RefreshUI();
            return true;
        }
        return false;
    }
    void Update() { }
}