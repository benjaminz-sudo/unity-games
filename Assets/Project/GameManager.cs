using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TMP_Text textChip1;
    public TMP_Text textChip2;
    public TMP_Text textChip5;
    public TMP_Text textChip10;
    public TMP_Text textEuro;
    public TMP_Text textFace;
    public TMP_Text textStar;
    public TMP_Text textTotal;
    public int count1;
    public int count2;
    public int count5;
    public int count10;
    public int countEuro;
    public int countFace;
    public int countStar;

    public GameObject neonGroup1;
    public GameObject neonGroup2;
    public float glowCooldown = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
            count1 = 0;
            count2 = 0;
            count5 = 0;
            count10 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        textChip1.text = count1 + "";
        textChip2.text = count2 + "";
        textChip5.text = count5 + "";
        textChip10.text = count10 + "";
        textEuro.text = countEuro + "";
        textFace.text = countFace + "";
        textStar.text = countStar + "";
        int total = 1 * count1 + 2 * count2 + 5 * count5 + 10 * count10;
        textTotal.text = total+"$";  

        glowCooldown+=Time.deltaTime;
        if (glowCooldown > 10f)
        {
            neonGroup1.GetComponent<NeonGlow>().StartCoroutine("GlowRoutine");
            neonGroup2.GetComponent<NeonGlow>().StartCoroutine("GlowRoutine");
            glowCooldown = 0f;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        string N = other.gameObject.name;
        if (N.Contains("chip 10"))
            count10++;
        else if (N.Contains("chip 1"))
            count1++;
        else if (N.Contains("chip 2"))
            count2++;
        else if (N.Contains("chip 5"))
            count5++;
        else if (N.Contains("euro"))
            countEuro++;
        else if (N.Contains("face"))
            countFace++;
        else if (N.Contains("star"))
            countStar++;
        Destroy(other.gameObject);
        neonGroup1.GetComponent<NeonGlow>().StartCoroutine("GlowRoutine");
        neonGroup2.GetComponent<NeonGlow>().StartCoroutine("GlowRoutine");
        glowCooldown = 0f;
    }

}
