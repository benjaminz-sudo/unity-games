using Unity.VisualScripting;
using UnityEngine;

public class Crosshairfollow : MonoBehaviour
{
    public GameObject Coin;
    public LayerMask layer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity, layer))
        {
            // Use hit point but lock Y to constant height
            Vector3 lockedPos = new Vector3(hit.point.x, 4, hit.point.z);

            // Place crosshair on the wall surface
            transform.position = lockedPos + hit.normal * 0.01f;
        }
        //if (Input.GetMouseButtonDown(0))
        {
            Quaternion rotation = Quaternion.identity;
            rotation.eulerAngles = new Vector3(90, 0, 0);
            Instantiate(Coin, transform.position, rotation);
        }
    }
}

