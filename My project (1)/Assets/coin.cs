using UnityEngine;

public class coin : MonoBehaviour
{
    private Rigidbody coinbody;
    private GameManager manager;
  
        private void Start()
    {
        coinbody = GetComponent<Rigidbody>();   //ÀÚµ¿È­
        manager = GetComponent<GameManager>();   
        Destroy(gameObject, 5f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            manager.Addcoin();
            Destroy(gameObject);
        }

    }

    void Update()
    {
        transform.Rotate(0f, 0f, 180f * Time.deltaTime, Space.Self);
    }
}

