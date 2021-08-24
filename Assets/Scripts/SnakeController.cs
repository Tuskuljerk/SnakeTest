using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeController : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    [SerializeField]
    private float _rotateSpeed = 60f;

    public GameObject Tail;

    Transform _snakeHead;
    public void Start()
    {
       
    }
    private void Update()
    {
        Move();
    }

    void Move()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);

        float xAxis = Input.GetAxis("Horizontal");
        Vector3 pos = transform.position;
        pos.x += xAxis * _rotateSpeed * Time.deltaTime;
        transform.position = pos;
    }
}
