using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class controlmap : MonoBehaviour
{
    public GameObject level2;
    public GameObject level3;
    public int nivel;
    // Start is called before the first frame update
    void Awake()
    {
       nivel = PlayerPrefs.GetInt("nivel");
    }

    // Update is called once per frame
    void Update()
    {
        if(nivel >= 1)
        {
            level2.SetActive(false);
        }
        if (nivel >= 2)
        {
            level3.SetActive(false);
        }
    }
}
