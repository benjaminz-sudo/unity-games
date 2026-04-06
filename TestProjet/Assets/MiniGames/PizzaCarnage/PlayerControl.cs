using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public int maxSpeed = 30;
    public GameObject pizzaSlice;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dt = Time.deltaTime;
        float hInput = Input.GetAxis("Horizontal");
        Vector3 coordinates = transform.position;
        if (!(coordinates[2] > 4 && hInput < 0) & !(coordinates[2] < -4 && hInput > 0))
            transform.Translate(hInput * dt * maxSpeed * transform.right, Space.World);
        if (Input.GetKeyDown(KeyCode.Space))
            Instantiate(pizzaSlice, transform.position, pizzaSlice.transform.rotation);
    }
}
