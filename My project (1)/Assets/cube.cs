using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class cube : MonoBehaviour
{
    private Rigidbody cubebody;

    private void Start()
    {
        cubebody = GetComponent<Rigidbody>();   
        Destroy(gameObject, 5f);
    }

    //Collider는 UnityEngine.Collider 클래스 타입
    //Unity의 모든 충돌체는 이 Collider를 상속
    //GetComponent =>게임오브젝트에 해당되는친구 불러오는용도
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            other.GetComponent<PlayerController>().Die();
        }
        else if(other.CompareTag("Plane"))
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        
    }
}
