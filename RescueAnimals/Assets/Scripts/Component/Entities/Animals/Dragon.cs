using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EnumTypes;

public class Dragon : Animal, IAnimalBehaviour
{
    // ex) ���� n�� ���� ��� ���� ���� �����ϰ� ����
    private float _reinforceTime = 3f;
    
    public void OnResqueMove()
    {

    }
    public void OnResqueEffect(Player player)
    {
        //player.balls.��ȭ(_reinforceTime);
    }

    public void OnReinforced()
    {
        reinforceLevel += 1;
        _reinforceTime += 0.3f;
    }
}
