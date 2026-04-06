using UnityEngine;

public class SumoSpawner : MonoBehaviour
{
    public GameObject enemy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float randomNumber = UnityEngine.Random.Range(-10f, 10f);
        float randomNumber2 = UnityEngine.Random.Range(-10f, 10f);
        while (randomNumber * randomNumber + randomNumber2 * randomNumber2 > 10 * 10)
        {
            randomNumber = UnityEngine.Random.Range(-10f, 10f);
            randomNumber2 = UnityEngine.Random.Range(-10f, 10f);
        }
         
        Vector3 position = new Vector3(randomNumber, 3, randomNumber2);
        Instantiate(enemy, position, enemy.transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
