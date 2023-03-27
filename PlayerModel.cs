using System.Collections;
using System.Collections.Generic;
using _Scripts;
using UnityEngine;

public class PlayerModel : MonoBehaviour, IModel
{
    private int damage;
    private int test;
    
    public void Initialized(int _damage)
    {
        damage = _damage;
    }

    public int GetDamage()
    {
        return damage;
    }
}
