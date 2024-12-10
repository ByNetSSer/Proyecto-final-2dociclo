using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientofondo : MonoBehaviour
{
    public float velocidad;
    public float limit;
    public float spawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //-15.55f   -14.2f     9.2f
        if (transform.position.y < limit)
        {
            transform.position = new Vector2(transform.position.x, spawn);
        }
        transform.position = new Vector2(transform.position.x,transform.position.y-velocidad*Time.deltaTime);
    }
}
