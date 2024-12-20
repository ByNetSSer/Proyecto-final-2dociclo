using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetcBase : MonoBehaviour
{
    public int vida;
    public GameObject Objetobase;
    GameObject Destruccion;
    public ObjectDestructible Base;
    public Animator Recibedaņo;
    public Transform PlayerP;
    public SpriteRenderer imagen;
   public void recibeanimator(Animator animador)
    {
        Recibedaņo = animador;
    }
      // Start is called before the first frame update
    void Awake()
    {

        Base = new ObjectDestructible(Destruccion, vida);
        if(imagen == null)
        {
            imagen = GetComponent<SpriteRenderer>();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Base.Vidarestante_ < 1) {
            Recibedaņo.SetTrigger("dead");
            
        }

        if (PlayerP.position.y > transform.position.y)
        {
            imagen.sortingOrder = 6;
        }
        if (PlayerP.position.y < transform.position.y)
        {
            imagen.sortingOrder = 4;

        }

    }
    public void destroy()
    {
        Destroy(Objetobase);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Hit")
        {
            Recibedaņo.SetBool("Hit", true);
            print("colisiono");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Hit")
        {
            print("trigeo");
            Recibedaņo.SetBool("Hit", true);

        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        

    }
    public void Getdamagepublic(int damage)
    {
        Base.GetDamage(damage);
        print("recibio");
    }
    public void NotDamage()
    {
        Recibedaņo.SetBool("Hit", false) ;
    }
}
