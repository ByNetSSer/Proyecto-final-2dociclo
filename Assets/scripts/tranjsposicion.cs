using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tranjsposicion : MonoBehaviour
{
    Animator animador;
    public GameObject baseee;
   public  COUNTIMER timer;
    // Start is called before the first frame update
    void Awake()
    {
        animador = GetComponent<Animator>();
        baseee.GetComponent<ObjetcBase>().recibeanimator(animador);
    }

    // Update is called once per frame
    void Update()
    {
        if(timer.currentTime < 1)
        {
            animador.SetTrigger("win");
        }
    }
    public void pasarlayoutdead()
    {
        SceneManager.LoadScene("Lose");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Hit")
        {
            baseee.GetComponent<ObjetcBase>().Getdamagepublic(20);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Hit")
        {
            baseee.GetComponent<ObjetcBase>().Getdamagepublic(20);
        }
    }
    public void destruccion()
    {
        Destroy(this.gameObject);
    }

}
