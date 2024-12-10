using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animacion_E : MonoBehaviour
{
    public GameObject Hitpunch;
    public Animator animacion_;
    public SpriteRenderer renderer_;
    public Enemigo_ enemigo;
    public Flip_E flip_e;
    public AudioSource dead;
    public AudioSource outsound;
    public Player jugador;
    
    // Start is called before the first frame update
    void Awake()
    {
        animacion_ = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NotDamage()
    {
        animacion_.SetBool("GetDamage", false);
    }
    public void NotWalk()
    {
        animacion_.SetBool("IsWalking", false);
    }
    public void Notjoke()
    {
        animacion_.SetBool("burla", false);
    }
    public void NotPunch()
    {
        animacion_.SetBool("Ispunch", false);
    }
    public void destruir()
    {
    }
    public void sounddead()
    {
        dead.Play();
    }
    public void soundout()
    {
        outsound.Play();
    }
    public void CreateHitPunch()
    {
        if (!flip_e.isfacingright)
        {
            GameObject hit = Instantiate(Hitpunch, new Vector2(transform.position.x - 0.4f, transform.position.y - 0.35f), transform.rotation);
            hit.GetComponent<GetDamage_Player>().getdamage(enemigo.setdamage());
            
        }
        else
        {
            GameObject Hit = Instantiate(Hitpunch, new Vector2(transform.position.x + 0.4f, transform.position.y - 0.35f), transform.rotation);
            Hit.GetComponent<GetDamage_Player>().getdamage(enemigo.setdamage());
        }
    }
}
