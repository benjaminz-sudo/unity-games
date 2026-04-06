using Unity.Mathematics;
using UnityEngine;

public class PusherAnim : MonoBehaviour
{
    private Rigidbody rb;
    private float z0;
    private float time;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        time= 0;
        z0 = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        float dt = Time.deltaTime;
        time += dt;
        Vector3 pos = transform.position;
        pos.z = z0 + Mathf.Sin(2 * math.PI / 5 * time);
        rb.MovePosition(pos);  // command the rigidbody
    }
}
