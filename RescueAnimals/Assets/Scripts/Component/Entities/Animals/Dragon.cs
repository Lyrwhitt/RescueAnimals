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
        jailObj.SetActive(false);
    }
    public void OnResqueEffect(Player player)
    {
        //player.balls.��ȭ(_reinforceTime);
    }
}
