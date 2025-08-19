using UnityEngine;

public class coin : MonoBehaviour
{
    private Rigidbody coinbody;
   
  
        private void Start()
    {
        coinbody = GetComponent<Rigidbody>();   //ÀÚµ¿È­          
        Destroy(gameObject, 5f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.coincount++;
            Destroy(gameObject);
        }

    }

    void Update()
    {
        transform.Rotate(0f, 0f, 180f * Time.deltaTime, Space.Self);
    }
}

