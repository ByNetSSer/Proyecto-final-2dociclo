using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CHANGESCENEBUTTONS : MonoBehaviour
{
    public Image Transicion;
    public string Layoutevent;
    public bool ready;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void gotolayout()
    {
        SceneManager.LoadScene(Layoutevent);
    }
}
