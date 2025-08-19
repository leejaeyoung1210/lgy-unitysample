using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerbody;
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
        //물체가 지금 1초 동안 얼마나, 어떤 방향으로 움직이고 있는지(선속도)          

    }

    public void Die()
    {
        gameObject.SetActive(false);
        GameManager gameManager = FindFirstObjectByType<GameManager>(); 
        gameManager.EndGame();
    }

}
