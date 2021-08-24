using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailController : MonoBehaviour
{
    public Transform _target;
    [SerializeField]
    private float _targetDistance;

   

    private void Start()
    {
       
        //_target = GameObject.FindGameObjectWithTag("Player").transform;
        
    }
    private void Update()
    {
        // направление на цель
        Vector3 direction = _target.position - transform.position;
        // дистанция до цели
        float distance = direction.magnitude;
        // если расстояние до цели хвоста больше заданного
        if (distance > _targetDistance)
        {
            // двигаем хвост
            transform.position += direction.normalized * (distance - _targetDistance);
            // смотрим на цель
            transform.LookAt(_target);
        }
    }
}
