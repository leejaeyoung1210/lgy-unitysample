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

    //Collider�� UnityEngine.Collider Ŭ���� Ÿ��
    //Unity�� ��� �浹ü�� �� Collider�� ���
    //GetComponent =>���ӿ�����Ʈ�� �ش�Ǵ�ģ�� �ҷ����¿뵵
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
