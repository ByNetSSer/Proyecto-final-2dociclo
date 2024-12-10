using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlbutton : MonoBehaviour
{
    public GameObject PopUp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Activate()
    {
        PopUp.SetActive(true);
    }
    public void Desactive()
    {
        PopUp.SetActive(false);
    }
}
