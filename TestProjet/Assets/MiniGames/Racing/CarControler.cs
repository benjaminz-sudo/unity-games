using UnityEngine;

public class carControler : MonoBehaviour
{
    public float turnSpeed=30;
    public float maxSpeed=30;
    void Start() { }

    void Update()
    {
        //float v = Input.GetAxis("Horizontal");
        //Debug.Log(v);
        float dt = Time.deltaTime;
        float hInput = Input.GetAxis("Horizontal");
        transform.Rotate(0, hInput * turnSpeed * dt, 0);
        float vInput = Input.GetAxis("Vertical");
        transform.Translate(vInput * dt * maxSpeed * transform.forward, Space.World);
    }
}