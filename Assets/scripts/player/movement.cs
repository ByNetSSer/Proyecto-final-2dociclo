using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Transform transform_;
    Rigidbody2D rigid_;
    public float horizontal;
    public float vertical;
    public animacion _animacion;
    public Player player;
    // Start is called before the first frame update
    void Awake()
    {
        transform_ = GetComponent<Transform>();
        rigid_ = GetComponent<Rigidbody2D>();
        player = GetComponent<Player>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_animacion.animacion_.GetBool("ispunch") != true &&!_animacion.animacion_.GetBool("in damage") &&!_animacion.animacion_.GetBool("Dead") && !_animacion.animacion_.GetBool("win"))
        {
            horizontal = Input.GetAxisRaw("Horizontal");
            vertical = Input.GetAxisRaw("Vertical");
        }
        else{
            rigid_.velocity = new Vector2(0, 0);
        }
        
    }
    
    private void FixedUpdate()
    {
        if (_animacion.animacion_.GetBool("ispunch") != true && !_animacion.animacion_.GetBool("in damage") && !_animacion.animacion_.GetBool("Dead") && !_animacion.animacion_.GetBool("win"))
        {
            if (player.invencible)
            {
                rigid_.velocity = new Vector2(horizontal*1.5f, vertical * 0.6f*1.5f);
            }
            else
            {
                rigid_.velocity = new Vector2(horizontal, vertical * 0.6f);
            }
            
        }     
    }
}
