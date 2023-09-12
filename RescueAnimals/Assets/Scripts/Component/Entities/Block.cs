using System;
using Entities;
using UnityEngine;
using Util;

public class Block : MonoBehaviour, IPoolable<Block>
{
    [SerializeField] private double MaxHp = 10;
    [SerializeField] private double Hp = 10;
    [SerializeField] private Animator _animator;


    private Action<Block> _returnToPool;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var attackable = collision as IAttackable;
        if (attackable == null) return;
        Hp -= attackable.Atk;

        switch (Hp / MaxHp)
        {
            case <= 0:
                _animator.SetTrigger("0%");
                gameObject.SetActive(false);
                break;
            case <= 0.33:
                _animator.SetTrigger("33%");
                break;
            case <= 0.66:
                _animator.SetTrigger("66%");
                break;
        }
    }

    public void Initialize(Action<Block> returnAction)
    {
        _returnToPool = returnAction;
    }

    public void ReturnToPool()
    {
        _returnToPool?.Invoke(this);
    }

    private void OnDisable()
    {
        ReturnToPool();
    }
}