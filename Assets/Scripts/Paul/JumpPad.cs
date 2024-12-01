using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public Rigidbody2D Player;
    [SerializeField] private float JumpPadForce;
    // Start is called before the first frame update
    void Start()
    {
        //Player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, JumpPadForce), ForceMode2D.Impulse);
        }
    }
}
