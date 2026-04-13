using UnityEngine;
using UnityEngine.EventSystems;

public class CameraChange : MonoBehaviour, IPointerClickHandler
{
    public GameObject camera1;
    public GameObject camera2;
    public GameObject camera3;
    public GameObject camera4;
    public GameObject camera5;
    public GameObject camera6;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        camera2.SetActive(false);
        camera3.SetActive(false);
        camera4.SetActive(false);
        camera5.SetActive(false);
        camera6.SetActive(false);
        if (gameObject.name.Equals("Camera2"))
            camera2.SetActive(true);
        else if (gameObject.name.Equals("Camera3"))
            camera3.SetActive(true);
        else if (gameObject.name.Equals("Camera4"))
            camera4.SetActive(true);
        else if (gameObject.name.Equals("Camera5"))
            camera5.SetActive(true);
        else if (gameObject.name.Equals("Camera6"))
            camera6.SetActive(true);

    }
}