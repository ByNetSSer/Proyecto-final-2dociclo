using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinState : MonoBehaviour
{
    public GameObject Objetivo;
    public animacion animacionwin;
    public BoxCollider2D triger;
    public bool eventwin;
    bool notry = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Objetivo == null)
        {
            eventwin = true;
        }
        if (eventwin == true && notry == true)
        {
            int valor = PlayerPrefs.GetInt("nivel", 0);
            PlayerPrefs.SetInt("nivel", valor+1);
            animacionwin.animacion_.SetBool("win",true);
            notry = false;
        }
    }

}
