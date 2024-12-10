using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StadsManager : MonoBehaviour{}
public class Body
{
    protected int life;
    protected int life_contain;
    protected int damage;
    public Body() { }
    public virtual void GetuniversalDamage(int damage){

        life_contain = life_contain - damage;
    }

}
