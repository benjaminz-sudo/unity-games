using System.Collections;
using UnityEngine;

public class CoinGeneration : MonoBehaviour
{
    public GameObject coinPrefab;
    public BoxCollider boxCollider;
    public GameObject Coins;
    public Vector3 GetRandomPointInside()
    {
        Vector3 size = boxCollider.size;
        Vector3 center = boxCollider.center;

        Vector3 localRandom = new Vector3(
                Random.Range(-size.x / 2f, size.x / 2f),
                Random.Range(-size.y / 2f, size.y / 2f),
                Random.Range(-size.z / 2f, size.z / 2f)
        );

        // Transform to world coordinates considering scale and rotation
        return boxCollider.transform.TransformPoint(center + localRandom);
    }

    void Start()
    {
        StartCoroutine(SpawnLoop());
    }

    IEnumerator SpawnLoop()
    {
        while (true)
        {
            Vector3 P = GetRandomPointInside();
            Quaternion rotation = Quaternion.identity;
            rotation.eulerAngles = new Vector3(90, 0, 0);
            Instantiate(coinPrefab,P, rotation,Coins.transform);
            yield return new WaitForSeconds(0.1f);
        }
    }

}
