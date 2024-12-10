using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoTurret : MonoBehaviour
{

    public BoxCollider2D boxcolider_;
    public Animator animacion_;
    public int vida;
    public int DAMAGE;
    //public GameObject moneda;
     enemigo enemigobase;
    public class enemigo : Body
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
        animacion_ = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (enemigobase.Life_ < 1)
        {
            animacion_.SetBool("Death", true);
            Destroy(this.gameObject, 6);
        }
        if (animacion_.GetBool("GetDamage"))
        {
            boxcolider_.enabled = false;
        }
        else
        {
            boxcolider_.enabled = true;
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Hit")
        {
            print("HIT");
            animacion_.SetBool("GetDamage", true);
            
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
    public enemigo getenemy()
    {
        return enemigobase;
    }
    private void money()
    {
       // GameObject monedaspawn = Instantiate(moneda, new Vector2(transform.position.x + 0.5f, transform.position.y), transform.rotation);

    }
    public void notdamage()
    {
        animacion_.SetBool("GetDamage", false);
    }
}

