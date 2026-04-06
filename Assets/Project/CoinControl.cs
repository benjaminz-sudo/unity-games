using UnityEngine;

public class CoinControl : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        float maxDist = 5f;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, maxDist))
        {
            string N = hit.collider.gameObject.name;

            if (N.Contains("Walls") || N.Contains("chip") || N.Contains("Cube"))
                Destroy(this.gameObject);
        }

        if (transform.position[1] < -5)
            Destroy(gameObject);
    }
}
