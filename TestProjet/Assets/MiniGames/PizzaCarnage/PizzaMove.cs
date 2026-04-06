using UnityEngine;

public class PizzaMove : MonoBehaviour
{
    int speed = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (transform.position[0] > 10)
            Destroy(gameObject);

    }
}
