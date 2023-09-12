using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EnumTypes;

public class Dragon : Animal, IAnimalBehaviour
{
    // ex) 용은 n초 동안 모든 공이 블럭을 관통하게 만듬
    private float _reinforceTime = 3f;
    
    public void OnResqueMove()
    {
        jailObj.SetActive(false);
    }
    public void OnResqueEffect(Player player)
    {
        //player.balls.강화(_reinforceTime);
    }
}
