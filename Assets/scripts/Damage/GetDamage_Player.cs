using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetDamage_Player : MonoBehaviour
{
    int damage;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void getdamage(int newdamage)
    {
        damage = newdamage;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.GetComponent<Player>().GetDamage(damage);
        }
    }
}
