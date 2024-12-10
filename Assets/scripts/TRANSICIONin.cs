using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TRANSICIONin : MonoBehaviour
{
    public Image transicionin;
    public float velocity;
    void Awake()
    {
        transicionin = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transicionin.color.a > 0)
        {
            Color color = transicionin.color;
            color.a = color.a - velocity * Time.deltaTime;
            transicionin.color = color;
        }
        
    }
}
