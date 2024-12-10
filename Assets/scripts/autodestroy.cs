using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject,timer*Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
