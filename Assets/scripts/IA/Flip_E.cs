using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip_E : MonoBehaviour
{
    public Transform player;
    public bool isfacingright = false;
    public Enemigo_ scriptenemigo;
    // Start is called before the first frame update
    void Awake()
    {
            scriptenemigo = GetComponent<Enemigo_>();
        
       
    }

    // Update is called once per frame
    void Update()
    {
        if (!scriptenemigo.animacion_e.animacion_.GetBool("Death"))
        {
            bool isplayerright = transform.position.x < player.transform.position.x;
            Flip(isplayerright);
        }
       
    }
    private void Flip(bool isPlayerRight)
    {
        if ((isfacingright && !isPlayerRight) || (!isfacingright && isPlayerRight))
        {
            isfacingright = !isfacingright;
            Vector3 scale = transform.localScale;
            transform.localScale = transform.localScale*-1;
            scale.x *= -1;
            transform.localScale = scale;
        }
    }
}
