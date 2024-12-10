using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparos : MonoBehaviour
{
    public Transform playerobjetive;
    public Animator animaciones;
    public GameObject bala;
    public bool sonu;
    public float timer;
    public float count;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count = count + Time.deltaTime;
        if (playerobjetive != null)
        {
            if (timer < count && playerobjetive.position.x < transform.position.x)
            {
                animaciones.SetBool("shoot", true);
                count = 0;
            }
        }
        
    }
    public void shoot()
    {
        if(bala != null)
        {
            GameObject balat = Instantiate(bala, new Vector2(transform.position.x - 0.42f, transform.position.y + 0.083f), transform.rotation);
            balat.GetComponent<Bullet>().Getplayer(playerobjetive);
        }
        
    }
    public void shootnt()
    {
        
            animaciones.SetBool("shoot", false);
        
        
    }
    public void destruccion()
    {
        Destroy(this.gameObject);
    }
}
