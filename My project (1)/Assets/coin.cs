using UnityEngine;

public class coin : MonoBehaviour
{
    private Rigidbody coinbody;
    public int score;
    

    private void Start()
    {
        coinbody = GetComponent<Rigidbody>();   //ÀÚµ¿È­
        Destroy(gameObject,5f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            score += 10;
            Destroy(gameObject);
        }
    }

    void Update()
    {
        transform.Rotate(0f, 0f, 180f * Time.deltaTime, Space.Self);
    }
}

