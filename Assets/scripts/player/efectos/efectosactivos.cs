using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class efectosactivos : MonoBehaviour
{
    public GameObject efecto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void activar()
    {
        efecto.SetActive(true);
    }
    public void desactivar()
    {
        efecto.SetActive(false);
    }
}
