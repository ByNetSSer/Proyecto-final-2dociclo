using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class animacion : MonoBehaviour
{
    public Animator animacion_;
    public SpriteRenderer renderer_;
    public GameObject Damage;
    public Player player;
    public GameObject efecto;
    public AudioSource golpe;
    public AudioSource KO;
    float horizontal;
    float vertical;
    public float timerecovered = 4;
    public float timerecoveredD = 1;
    public float count;
    public float countD;

    void Awake()
    {
        animacion_ = GetComponent<Animator>();
        renderer_ = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if(Time.timeScale == 1 )
        {
            if(animacion_.GetBool("ispunch"))
            {
                count = count + Time.deltaTime;
                if(count > timerecovered){
                    notpunch();
                   count = 0;
                }
            }
            else
            {
                count = 0;
            }
            if (animacion_.GetBool("in damage"))
            {
                countD = countD + Time.deltaTime;
                if (countD > timerecoveredD)
                {
                    notstun();

                    countD = 0;

                }
            }
            else
            {
                countD = 0;
            }
            if (animacion_.GetBool("ispunch") != true && !animacion_.GetBool("Dead") && !animacion_.GetBool("in damage") && !animacion_.GetBool("defend") &&!animacion_.GetBool("win") )
            {
                horizontal = Input.GetAxisRaw("Horizontal");
                vertical = Input.GetAxisRaw("Vertical");
            }
            else
            {
                horizontal = 0;
                vertical = 0;
            }
            if (animacion_.GetBool("ispunch") != true && !animacion_.GetBool("Dead") && !animacion_.GetBool("in damage") && !animacion_.GetBool("defend") )
            {
                animacion_.SetInteger("ismovingx", (int)vertical);
                animacion_.SetInteger("ismovingy", (int)horizontal);
            }

               

            if (horizontal < 0 && animacion_.GetBool("ispunch") != true)
            {
                renderer_.flipX = true;

            }
            else if (horizontal > 0)
            {
                renderer_.flipX = false;

            }

            if (Input.GetKeyDown("k") && animacion_.GetBool("ispunch") != true && !animacion_.GetBool("Dead") && !animacion_.GetBool("in damage") && animacion_.GetInteger("rndpunch") == 0 && !animacion_.GetBool("win"))
            {
                animacion_.SetBool("ispunch", true);
                animacion_.SetInteger("rndpunch", 1);
            }
            if (Input.GetKeyDown("l") && animacion_.GetBool("ispunch") != true && !animacion_.GetBool("Dead") && !animacion_.GetBool("in damage") && animacion_.GetInteger("rndpunch") == 0 && !animacion_.GetBool("win"))
            {
                animacion_.SetBool("ispunch", true);
                animacion_.SetInteger("rndpunch", 2);
            }

            /*
            if (animacion_.GetCurrentAnimatorStateInfo(0).IsName("punch") )
            {
                print("cosa 1");
                //animacion_.SetBool("ispunch", false);
            }

            if (animacion_.GetCurrentAnimatorStateInfo(0).IsName("punch2") != true)
            {
                animacion_.SetBool("ispunch", false);
            }
            */
        }

    }
    
    public void notpunch()
    {
        animacion_.SetInteger("rndpunch", 0);
        animacion_.SetBool("ispunch", false);
        
    }
    public void notstun()
    {
        animacion_.SetBool("in damage",false);
    }
    public void CreateDamage()
    {
        if (renderer_.flipX)
        {
            golpe.Play();
            GameObject hit=Instantiate(Damage, new Vector2(transform.position.x - 0.4f, transform.position.y - 0.35f), transform.rotation);
            hit.GetComponent<GetDamageToobjet>().getdamage(player.setdamage());
            hit.GetComponent<GetDamageToobjet>().getefecto(efecto);
            hit.GetComponent<GetDamageToobjet>().getplayer(player);
        }
        else
        {
            golpe.Play();
            GameObject Hit=Instantiate(Damage, new Vector2(transform.position.x + 0.4f, transform.position.y - 0.35f), transform.rotation);
            Hit.GetComponent<GetDamageToobjet>().getdamage(player.setdamage());
            Hit.GetComponent<GetDamageToobjet>().getefecto(efecto);
            Hit.GetComponent<GetDamageToobjet>().getplayer(player);
        }

    }
    public void KOplay()
    {
        if(KO != null)
        {
            KO.Play();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Damage" || !player.invencible) {
            animacion_.SetBool("in damage", true);
        }
    }
    
}
