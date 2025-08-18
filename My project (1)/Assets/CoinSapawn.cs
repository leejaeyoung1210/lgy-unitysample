using UnityEngine;

public class CoinSapawn : MonoBehaviour
{
    public GameObject coinPrefab;
    public GameObject plane;
    public float spawnRateMin = 0.5f;
    public float spawnRateMax = 3f;

    private Renderer planerend;

    private float interval;
    private float timer;

    void Start()
    {
        timer = 0f;
        interval = Random.Range(spawnRateMin, spawnRateMax);
    }

    void Update()
    {
        timer += Time.deltaTime;

        if(timer>interval)
        {
          SpawnCoin();
            timer = 0f;
            interval = Random.Range(spawnRateMin, spawnRateMax);
        }

    }
    void SpawnCoin()
    {
        planerend = plane.GetComponent<Renderer>();

        Vector3 min = planerend.bounds.min;
        Vector3 max = planerend.bounds.max;

        float x = Random.Range(min.x, max.x);
        float z = Random.Range(min.z, max.z);

        Vector3 spawnPos = new Vector3(x, 0.5f, z);
        Instantiate(coinPrefab, spawnPos, transform.rotation);
        coinPrefab.SetActive(true); 

    }
}
