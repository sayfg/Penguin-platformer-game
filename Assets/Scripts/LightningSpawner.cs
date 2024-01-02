using UnityEngine;

public class LightningSpawner : MonoBehaviour
{
    public GameObject lightningPrefab;
    private float spawnRate = 3f;
    private float timer = 0f;

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {

            Vector3 spawnPosition = new Vector3(transform.position.x, transform.position.y -3, transform.position.z);

            Instantiate(lightningPrefab, spawnPosition, transform.rotation);
            timer = 0f;
        }
    }
}
