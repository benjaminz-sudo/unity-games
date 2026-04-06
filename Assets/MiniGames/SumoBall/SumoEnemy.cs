using UnityEngine;
using UnityEngine.Windows;

public class SumoEnemy : MonoBehaviour
{
    public float maxSpeed = 7.5f;
    public int intensity = 2000;
    private GameObject Player;
    private Rigidbody rb;
    private bool frozen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float dT = Time.deltaTime;
        Vector3 moveVector = (Player.transform.position - this.transform.position);
        moveVector.y = 0;
        moveVector.Normalize();
        rb.AddForce(moveVector * intensity * dT);
        Vector3 velocity = rb.linearVelocity;
        if (velocity.magnitude > maxSpeed)
            rb.linearVelocity = velocity.normalized * maxSpeed;
    }
}
