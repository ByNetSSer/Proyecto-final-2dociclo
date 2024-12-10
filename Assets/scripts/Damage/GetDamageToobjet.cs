using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetDamageToobjet : MonoBehaviour
{
     int damage;
    GameObject efecto;
    Player jugador;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void getefecto(GameObject efectito)
    {
        efecto = efectito;
    }
    public void getdamage(int newdamage)
    {
        damage = newdamage;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemigo")
        {
            objet();
            collision.GetComponent<Enemigo_>().getdamagepublic(damage);
            jugador.GETIRA(12);
        }
        if(collision.gameObject.tag == "object")
        {
            objet();
            collision.GetComponent<ObjetcBase>().Getdamagepublic(damage); 
        }
        if(collision.gameObject.tag == "turret")
        {
            objet();
            collision.GetComponent<EnemigoTurret>().getenemy().GetuniversalDamage(damage);
            jugador.GETIRA(8);
        }
        if (collision.gameObject.tag == "bomb")
        {
            objet();
            jugador.GETIRA(20);
        }
    }
    void  objet()
    {
        GameObject hit = Instantiate(efecto, new Vector2(transform.position.x, transform.position.y + 0.38f), transform.rotation);
        hit.GetComponent<SpriteRenderer>().sortingOrder = 10   ;
    }
    public void getplayer(Player playeeer)
    {
        jugador = playeeer;
    }
}
