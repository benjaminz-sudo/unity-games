using UnityEngine;

public class FocalScript : MonoBehaviour
{
    public int rotSpeed = 30;
    GameObject HourHand;
    GameObject MinuteHand;
    GameObject SecondHand;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
            transform.Rotate(Vector3.up, -Time.deltaTime * rotSpeed);
        if (Input.GetKey(KeyCode.E))
            transform.Rotate(Vector3.up, Time.deltaTime * rotSpeed);
    }
}
