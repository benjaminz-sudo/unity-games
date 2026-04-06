using System.Collections;
using UnityEngine;

public class SumoPlayerScript : MonoBehaviour
{
    public int intensity = 2000;
    public int maxSpeed = 10;
    public bool hasPowerup=false;
    public GameObject PowerIndicator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Powerup"))
        {
            Destroy(other.gameObject);
            hasPowerup = true;
            StartCoroutine(EndPowerup());
        }
    }
    IEnumerator EndPowerup()
    {
        yield return new WaitForSeconds(5);

        // Stop powerup
        hasPowerup = false;
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Enemy") & this.hasPowerup)
        {
            Rigidbody rbe = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 moveVector = collision.gameObject.transform.position - transform.position;
            rbe.AddForce(15 * moveVector, ForceMode.Impulse);
            StartCoroutine(KnockbackRoutine(collision.gameObject));
        }
    }
    IEnumerator KnockbackRoutine(GameObject enemy)
    {
        MonoBehaviour aiScript = enemy.GetComponent<SumoEnemy>();
        aiScript.enabled = false;
        yield return new WaitForSeconds(5);
        aiScript.enabled = true;
    }


    // Update is called once per frame
    void Update()
    {
        
        if (hasPowerup) PowerIndicator.SetActive(true);
        else PowerIndicator.SetActive(false);

        float dT = Time.deltaTime;
        float vInput = Input.GetAxis("Vertical");
        float hInput = Input.GetAxis("Horizontal");

        GameObject Center = GameObject.Find("Focal Point");
        GameObject Camera = GameObject.Find("Main Camera");
        Vector3 moveVector = (Center.transform.position - Camera.transform.position);
        moveVector.y = 0;
        moveVector.Normalize();
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce( moveVector * intensity * dT * vInput);


        Vector3 V2 = Quaternion.Euler(0, 90, 0) * moveVector;
        
        rb.AddForce(V2 * intensity * dT * hInput);

        Vector3 velocity = rb.linearVelocity;
        //Debug.Log(velocity.magnitude);

        if (velocity.magnitude > maxSpeed)
            rb.linearVelocity = velocity.normalized * maxSpeed;
    }
}
