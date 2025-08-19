using UnityEngine;

public class CubeSapawn : MonoBehaviour
{
    public GameObject cubePrefab;
    public GameObject plane;
    public float spawnRateMin = 0.5f;
    public float spawnRateMax = 3f;

    private Renderer planerend;

    private float interval;
    private float timer;
    //private float speed = 7f;
    Vector3 spawnPos = new Vector3();

    void Start()
    {
        timer = 0f;
        interval = Random.Range(spawnRateMin, spawnRateMax);
    }


    void Update()
    {
        timer += Time.deltaTime;

        if (timer > interval)
        {
            SpawnCube();
            timer = 0f;
            interval = Random.Range(spawnRateMin, spawnRateMax);
        }




    }

    void SpawnCube()
    {
        planerend = plane.GetComponent<Renderer>();

        Vector3 min = planerend.bounds.min;
        Vector3 max = planerend.bounds.max;

        float x = Random.Range(min.x, max.x);
        float z = Random.Range(min.z, max.z);

        spawnPos.Set(x, 10f, z);
        Instantiate(cubePrefab, spawnPos, transform.rotation);
        cubePrefab.SetActive(true);

    }
}
