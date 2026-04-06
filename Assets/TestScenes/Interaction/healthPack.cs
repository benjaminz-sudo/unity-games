using Unity.VisualScripting;
using UnityEngine;

public class healthPack : MonoBehaviour
{
    public GameObject B;

    void OnMouseDown()
    {
        Manager gameManager = B.GetComponent<Manager>();
        gameManager.setHP(100);
    }
}