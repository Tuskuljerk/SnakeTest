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
        // ����������� �� ����
        Vector3 direction = _target.position - transform.position;
        // ��������� �� ����
        float distance = direction.magnitude;
        // ���� ���������� �� ���� ������ ������ ���������
        if (distance > _targetDistance)
        {
            // ������� �����
            transform.position += direction.normalized * (distance - _targetDistance);
            // ������� �� ����
            transform.LookAt(_target);
        }
    }
}
