using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Toggemute : MonoBehaviour
{
    public Toggle booleano;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void setmute()
    {
        if (booleano.isOn)
        {

            AudioListener.volume = 0;




        }
        else
        {
            float savedVolume = PlayerPrefs.GetFloat("GameVolume", 0.35f);
            AudioListener.volume = savedVolume;
        }
    }
}
