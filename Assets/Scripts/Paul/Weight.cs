using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weight : MonoBehaviour
{
    private LayerMask groundLayers;
    public int damage =5;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        groundLayers = LayerMask.NameToLayer("Ground");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerLife>().Hurt(damage);
            Player.GetComponent<PlayerMovement>().Respawn();
        }
        if(collision.gameObject.layer == groundLayers)
        {
            Destroy(this);
        }
    }
}
