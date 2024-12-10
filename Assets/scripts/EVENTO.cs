using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EVENTO : MonoBehaviour
{
    public Camara_Control camara;
    public GameObject objetvenew;
    public AudioSource audiopausa;
    public AudioSource audioempiesa;
    public GameObject Jugador;
    public GameObject timer;
    public GameObject box;
    public bool evento;
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            box.SetActive(true);
            timer.SetActive(true);
            camara.getobjetive(objetvenew);
        }
    }
}
