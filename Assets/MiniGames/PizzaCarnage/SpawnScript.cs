using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject[] alienPrefabs;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float startDelay = 2;
        float spawnInterval = 3;
        InvokeRepeating("Spawn", startDelay, spawnInterval);
    }

    void Spawn()
    {
        int randomValue = Random.Range(0, 3);  // generate a random integer number between 0 and 2
        Vector3 spawnPosition = new Vector3(Random.Range(1, 4), 1, Random.Range(-3.5f, 3.5f));
        Instantiate(alienPrefabs[randomValue], spawnPosition, alienPrefabs[randomValue].transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
