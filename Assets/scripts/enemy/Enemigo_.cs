using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemigo_ : MonoBehaviour
{
    public bool grolabJEFE = false;
    public animacion_E animacion_e;
    BoxCollider2D boxcolider_;
    public int vida;
    public int DAMAGE;
    //public GameObject moneda;
     enemigo enemigobase;
    
    class enemigo : Body
    {
        public int Life_ { get { return life; } set { life = value; } }
        public int damage_ { get { return damage; } set { damage = value; } }
        public enemigo(int vida, int damage)
        {
            life = vida;
            damage_ = damage;
        }
        public override void GetuniversalDamage(int damage)
        {

            life = life - damage;
        }
    }
     
    // Start is called before the first frame update
    void Awake()
    {
        enemigobase = new enemigo(vida, DAMAGE);
        boxcolider_ = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(enemigobase.Life_ < 2)
        {
            animacion_e.animacion_.SetBool("Death", true);
            Destroy(this.gameObject, 6);
        }
        if (animacion_e.animacion_.GetBool("GetDamage") && grolabJEFE != true)
        {
            boxcolider_.enabled = false;
        }
        else
        {
            boxcolider_.enabled = true;
        }
        vida = enemigobase.Life_;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Hit")
        {
            animacion_e.animacion_.SetBool("GetDamage", true);
            
            //Text texto = Instantiate(prefabTextDamage, new Vector2(transform.position.x-150.0f, transform.position.y-10.0f), transform.rotation);
            //texto.text = DAMAGE.ToString();
            //texto.transform.SetParent(elcanvas.transform,false);
            
        }
    }
    public void getdamagepublic(int setdamage)
    {
        enemigobase.GetuniversalDamage(setdamage);
        DAMAGE = setdamage;
    }
    public int getLifepublic()
    {
        return enemigobase.Life_;
    }
    public int setdamage()
    {
        return enemigobase.damage_;
    }
    private void money()
    {
       //GameObject monedaspawn= Instantiate(moneda, new Vector2(transform.position.x +0.5f,transform.position.y), transform.rotation);

    }
}
