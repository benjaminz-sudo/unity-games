using UnityEngine;

public class rotCube : MonoBehaviour
{
    public Vector3 rotationAxis = Vector3.up; //
    public float speed = 0.2f;
    public GameObject spotLightToDuplicate;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Start repeating the duplication every 3 seconds
        InvokeRepeating(nameof(DuplicateSpotLight), 0, 3);
    }

    void DuplicateSpotLight()
    {
        GameObject newSpot = Instantiate(spotLightToDuplicate);

        newSpot.transform.SetParent(gameObject.transform);

        newSpot.transform.localPosition = new Vector3(Random.Range(-3, 3), 0, Random.Range(-3, 3));
        newSpot.transform.localRotation = Quaternion.Euler(30, Random.Range(0f, 360f), 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationAxis, speed * 360 * Time.deltaTime);
    }
}



