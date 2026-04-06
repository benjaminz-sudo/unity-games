using UnityEngine;

public class BonusScript : MonoBehaviour
{
    public float RotSpeed=10;
    public Material Mat1, Mat2;
    void Start() { }

    void Update()
    {
        Material tmp;
        transform.Rotate(0, Time.deltaTime*RotSpeed, 0);
        Renderer r = GetComponent<Renderer>();
        r.material = Mat1;
        tmp = Mat1;
        Mat1 = Mat2;
        Mat2= tmp;
        


    }
}