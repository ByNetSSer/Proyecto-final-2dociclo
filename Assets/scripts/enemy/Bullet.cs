using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed;
    public Transform player;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        Vector3 vetores = new Vector3(player.transform.position.x, player.transform.position.y - 0.31f, 0);
        Vector2 direcion = ( vetores- transform.position).normalized;
        rb.velocity = direcion * speed;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Getplayer(Transform ubicacion)
    {
        player = ubicacion;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "activate")
        {
            Vector3 vectores = new Vector3(player.transform.position.x, player.transform.position.y - 0.31f, 0);
            Vector2 direcion = (vectores - transform.position).normalized;
            rb.velocity = direcion * speed;
        }
    }
}
