using Unity.VisualScripting;
using UnityEngine;

public class toxicBarrel : MonoBehaviour
{
    public GameObject B;
    void OnMouseDown()
    {
        Manager gameManager = B.GetComponent<Manager>();
        gameManager.setHP(gameManager.getHP()-10);
    }
}