using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrowObject : MonoBehaviour
{
    public GameObject Prefab;
    public AudioSource sonidito;
    public AudioSource win;
    public AudioSource destroy;
    public AudioSource stopit;
    bool sonud; 
    public float XADD;

    public float YADD;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CreateObject()
    {
        if (Prefab != null)
        {


            Instantiate(Prefab, new Vector2(transform.position.x + XADD, transform.position.y + YADD), transform.rotation);
        }
        
    }
    public void autodestruccion()
    {
        
        Destroy(this.gameObject);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "activate")
        {

            sonud = true;
        }
    }
    public void playshoot()
    {
        if(sonidito != null && sonud)
        {
            sonidito.Play();
        }
    
    }
    public void playit()
    {
        if (win != null)
        {
            win.Play();
        }
    }
    public void explosion()
    {
        if (destroy != null)
        {
            destroy.Play();
        }
    }
    public void stopited()
    {
        if (stopit != null)
        {
            stopit.Stop();
        }
    }
}
