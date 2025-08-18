using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerbody;
    public float speed = 8f;

    private void Update()
    {
        float xinput = Input.GetAxis("Horizontal");
        float zinput = Input.GetAxis("Vertical");
        
        float xspeed = xinput * speed;
        float zspeed = zinput * speed;

        Vector3 velocity = new Vector3(xspeed, 0, zspeed);

        playerbody.linearVelocity = velocity;//��ü�� ���� 1�� ���� �󸶳�, � �������� �����̰� �ִ���(���ӵ�)


       

    }

    public void Die()
    {
        gameObject.SetActive(false);    
    }

}
