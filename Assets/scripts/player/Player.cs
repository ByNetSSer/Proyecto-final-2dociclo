using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public animacion animatorplayer;
    public Image barradevida;
    public Image barradefuria;
    public Text puntaje;
    public AudioSource coin;
    public AudioSource health;
    public AudioSource recibirgolpe;
    public AudioSource recibirgolpebullet;
    public GameObject preesed;
    public GameObject fire;
    public bool invencible;
    public int puntos;
    public int vida;

    
    public static float operator *(Player a, Enemigo_ b)
    {
        float distance = Mathf.Sqrt(Mathf.Pow(a.GetComponent<Transform>().position.x - b.GetComponent<Transform>().position.x, 2) +Mathf.Pow(a.GetComponent<Transform>().position.y - b.GetComponent<Transform>().position.y, 2));
        return distance;
    }
    
    public class Jugador : Body
    {
        int Hearts;
        float Stamina;
        int limitStamina;
        public int limitStamina_ { get { return limitStamina; } set { limitStamina = value; } }
        public int Hearts_ { get { return Hearts; }set { Hearts = value; } }
        public int Life { get { return life; } set { life = value; } }
        public int Life_contain { get { return life_contain; } set { life_contain = value; } }
        public float Stamina_ { get { return Stamina; } set { Stamina = value; } }
        public int Damage { get { return damage; } set { damage = value; } }

        public Jugador()
        {
            Life = 200;
            life_contain = 200;
            Stamina = 0;
            limitStamina = 200;
            damage = 10;
        }
        public  void GetuniversalDamages(int damage)
        {
            Life_contain = Life_contain- damage;
            if (Life_contain < 0)
            {
                life_contain = 0;
            } 
        }
        public  void Getuniversalfury(int staminaup)
        {
            Stamina = Stamina + staminaup;
            if (Stamina > limitStamina)
            {
                Stamina = limitStamina;
            }
        }
        public static Jugador operator +(Jugador a, int num)
        {
            a.Life_contain = a.Life_contain + num;
            return a;
        }
        
    }
    Jugador player = new Jugador();
    // Start is called before the first frame update
    void Start()
    {
        barradevida.fillAmount = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(player.Stamina_ == player.limitStamina_)
        {
            preesed.SetActive(true);
        }
        else
        {
            preesed.SetActive(false);
        }
        if (player.Stamina_ == player.limitStamina_ && Input.GetKeyDown(KeyCode.Space))
        {
            invencible = true;
        }
        if (invencible)
        {
            fire.SetActive(true);
            player.Damage = 18;
            player.Stamina_ = player.Stamina_-30*Time.deltaTime;
        }
        else
        {
            fire.SetActive(false);
            player.Damage = 10;
        }
        if(player.Stamina_<1 && invencible)
        {
            player.Stamina_ = 0;
            invencible = false;
        }
        puntaje.text = puntos.ToString();
        if (player.Life< player.Life_contain) {
            player.Life_contain = player.Life;
        }
        barradevida.fillAmount = Mathf.Clamp01((float)player.Life_contain / player.Life);
        vida = player.Life_contain;
        if (player.Life_contain < 1)
        {
            animatorplayer.animacion_.SetBool("Dead", true);
        }
        if (player.Stamina_ > player.limitStamina_)
        {
            player.Stamina_ = player.limitStamina_;
        }
        barradefuria.fillAmount = Mathf.Clamp01((float)player.Stamina_ / player.limitStamina_);
    }
    public int setdamage()
    {
        return player.Damage;  

    }
    public void GetDamage(int damage)
    {
        if (!animatorplayer.animacion_.GetBool("win") && !invencible)
        {
            player.GetuniversalDamages(damage);
        }
        
    }
    public void GETIRA( int ira)
    {
        if (!invencible)
        {
            player.Getuniversalfury(ira);
        }
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!invencible)
        {
            if (collision.gameObject.tag == "Hit_e" && !animatorplayer.animacion_.GetBool("win"))
            {
                animatorplayer.animacion_.SetBool("in damage", true);
                recibirgolpe.Play();
                //Text texto = Instantiate(prefabTextDamage, new Vector2(transform.position.x-150.0f, transform.position.y-10.0f), transform.rotation);
                //texto.text = DAMAGE.ToString();
                //texto.transform.SetParent(elcanvas.transform,false);

            }
            if (collision.gameObject.tag == "bullet" && !animatorplayer.animacion_.GetBool("win"))
            {
                recibirgolpebullet.Play();
                Destroy(collision.gameObject);
                animatorplayer.animacion_.SetBool("in damage", true);
                player.GetuniversalDamage(2);

            }
        }
       
        if (collision.gameObject.tag == "vida")
        {
            health.Play();
            Destroy(collision.gameObject);
            player = player + 15;

        }
        if(collision.gameObject.tag == "moneda")
        {
            coin.Play();
            Destroy(collision.gameObject);
            int puntosactuales = PlayerPrefs.GetInt("points");
            PlayerPrefs.SetInt("points",puntosactuales + 125);
            puntos = puntos + 125;
        }
        
    }
    public void sound()
    {
        recibirgolpe.Play();
    }

}
