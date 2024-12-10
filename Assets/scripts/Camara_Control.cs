using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara_Control : MonoBehaviour
{
    public GameObject objetivo;
    public float minpositionX;
    public float maxpositionX;
    public float minpositionY;
    public float maxpositionY;

    Vector3 vectorZero = new Vector3(0,0,0);
    public float speedcamera;
    // Start is calledbefore the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (objetivo != null)
        {
            float positionY = Mathf.Clamp(objetivo.transform.position.y, minpositionY, maxpositionY);
            float positionX = Mathf.Clamp(objetivo.transform.position.x, minpositionX, maxpositionX);
            transform.position = new Vector3(positionX, positionY, -20);
            
            //transform.position = new Vector3(objetivo.transform.position.y, positionY, -20);
            //transform.position = Vector3.SmoothDamp(transform.position, new Vector3(objetivo.transform.position.x,objetivo.transform.position.y,-10), ref vectorZero, speedcamera);

        }
    }
    public void getobjetive(GameObject nuevo)
    {
        objetivo = nuevo;
    }
}
