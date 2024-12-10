using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public Animator animaciones;
    public float Timelife;
    // Start is called before the first frame update
    void Awake()
    {
        animaciones = GetComponent<Animator>();
        Destroy(this.gameObject, Timelife * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
