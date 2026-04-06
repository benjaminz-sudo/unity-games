using UnityEngine;

public class FinishColliz : MonoBehaviour
{
    public Material Mat_finish;

    void OnTriggerEnter()
    {
        Debug.Log("Termine !");
        Renderer objectRenderer = GameObject.Find("Banner").GetComponent<Renderer>();
        objectRenderer.material = Mat_finish;
    }
}