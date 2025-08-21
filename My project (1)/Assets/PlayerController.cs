using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerbody;
    public GameObject gmObj;
    public GameManager gameManager;
    public float speed = 8f;
    
    //Vector3 velocity = new Vector3(xspeed, 0, zspeed);
    Vector3 velocity = new Vector3(0, 0, 0);

    private void Update()
    {
        float xinput = Input.GetAxis("Horizontal");
        float zinput = Input.GetAxis("Vertical");

        float xspeed = xinput * speed;
        float zspeed = zinput * speed;

        velocity.Set(xspeed, 0, zspeed);
        playerbody.linearVelocity = velocity;
        //��ü�� ���� 1�� ���� �󸶳�, � �������� �����̰� �ִ���(���ӵ�)          

    }

    public void Die()
    {
        gameObject.SetActive(false);
        gmObj = GameObject.FindWithTag("GameController");
       
        gameManager = gmObj.GetComponent<GameManager>();
               
        gameManager.EndGame();
    }

}
