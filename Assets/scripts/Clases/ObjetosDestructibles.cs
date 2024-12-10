using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestructible
{
    public GameObject Particulas;
    int Vida;
    int Vidarestante;
    public int Vidarestante_ { get { return Vidarestante; } }
    public ObjectDestructible(GameObject particulas,int vida)
    {
        Particulas = particulas;
        Vida = vida;
        Vidarestante = Vida;
    }
    public void GetDamage(int damage)
    {
        Vidarestante = Vidarestante - damage;
        if(Vidarestante< 0)
        {
            Vidarestante = 0;
        }
    }
   
}
