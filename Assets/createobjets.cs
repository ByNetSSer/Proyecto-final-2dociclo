using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createobjets : MonoBehaviour
{
    public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void generar()
    {
        Instantiate(explosion, transform.position, transform.rotation);
    }
}
