using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class settextpoints : MonoBehaviour
{
    public Text points;
    // Start is called before the first frame update
    void Awake()
    {
        points.text ="puntos acumulados: "+ PlayerPrefs.GetInt("points").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
