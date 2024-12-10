using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Player player1;
    public Player player2;
    public Player PlayerP;
    public float speed;
    Enemigo_ scriptenemigo;
    public animacion_E animacionenemigo;
    public float distanciaminima;
    public float countactions;
    public float timmeractions;
    [SerializeField]
    int eleccion;
    int limit = 60;
    bool ACTIVATE = false;
    public SpriteRenderer EnemigoImagen;
    // Start is called before the first frame update
    void Awake()
    {
        scriptenemigo = GetComponent<Enemigo_>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ACTIVATE && Time.timeScale == 1)
        {
            float distance = 0;

            countactions = countactions + Time.deltaTime;
            if (countactions > timmeractions && scriptenemigo.animacion_e.animacion_.GetBool("IsWalking") != true && scriptenemigo.animacion_e.animacion_.GetBool("Ispunch") != true && scriptenemigo.animacion_e.animacion_.GetBool("burla") != true && scriptenemigo.animacion_e.animacion_.GetBool("GetDamage") != true && scriptenemigo.getLifepublic() > 0)
            {
                eleccion = Random.Range(1, limit);
                if (eleccion > 0 && eleccion <= 3)
                {
                    scriptenemigo.animacion_e.animacion_.SetBool("burla", true);
                }
                else if (eleccion > 3 && eleccion <= 60)
                {
                    scriptenemigo.animacion_e.animacion_.SetBool("IsWalking", true);
                }
                else if (eleccion > 60 && eleccion <= 100)
                {
                    scriptenemigo.animacion_e.animacion_.SetBool("Ispunch", true);

                }

                eleccion = 0;
                countactions = 0;
            }
            if (scriptenemigo.animacion_e.animacion_.GetBool("Death") != true && animacionenemigo.animacion_.GetBool("IsWalking"))
            {
                if (player1 * scriptenemigo < player2 * scriptenemigo)
                {
                    distance = player1 * scriptenemigo;
                    transform.position = Vector2.MoveTowards(transform.position, player1.transform.position, speed * Time.deltaTime);
                }
                else
                {
                    distance = player2 * scriptenemigo;
                    transform.position = Vector2.MoveTowards(transform.position, player2.transform.position, speed * Time.deltaTime);
                }
                //distance = Mathf.Abs(transform.position.x-PlayerP.position.x);
                if (PlayerP.transform.position.y > transform.position.y)
                {
                    EnemigoImagen.sortingOrder = 6;
                    transform.position = new Vector2(transform.position.x, transform.position.y + 0.0004f);
                }
                if (PlayerP.transform.position.y < transform.position.y)
                {
                    EnemigoImagen.sortingOrder = 4;
                    transform.position = new Vector2(transform.position.x, transform.position.y - 0.0004f);
                }
            }

            /*
            if ()
            {




                // El enemigo no se acerca dentro del cuadrado
                //que aun este en la posicion minima baje 
                // triger de acctivacion de enemigo
                // dos puntos de seguimiento objetos vacios y que el enemigo pregunte cual esta mas cerca 
                // y se diriga hacia ahi

            }

            */
            if (distance < distanciaminima)
            {
                limit = 100;
                scriptenemigo.animacion_e.animacion_.SetBool("IsWalking", false);
            }
            else
            {
                limit = 60;
            }
        }
        



    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "activate")
        {
            ACTIVATE = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "activate")
        {
            ACTIVATE = true;
        }
    }

}
