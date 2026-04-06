using UnityEngine;

public class StickCamera : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    
    public Transform cameraPivot;
    public float tiltSpeed = 120f;
    public float minmax = 60f;
    float pitch = 0f;

    // Update is called once per frame
    void Update()
    {
    // US keycode
    if (Input.GetKey(KeyCode.Q)) pitch += tiltSpeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.E)) pitch -= tiltSpeed * Time.deltaTime;
        pitch = Mathf.Clamp(pitch, -minmax, minmax);

        //localRotation.Xrot = pitch
        cameraPivot.localRotation = Quaternion.Euler(pitch, cameraPivot.localEulerAngles.y, cameraPivot.localEulerAngles.z);
    }
}
