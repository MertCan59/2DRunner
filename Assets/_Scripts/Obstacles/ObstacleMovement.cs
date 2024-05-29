using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour,IMovable
{
    private MoveController<IMovable> _moveController;
    private Vector2 _dir;
    private Rigidbody2D _rgb;
    [SerializeField] private float speed;
    private float _timer;
    
    private void Awake()
    {
        _moveController = new MoveController<IMovable>();
        _rgb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _timer += Time.deltaTime;
        if (_timer > 150f)
        {
            speed += 0.1f;
            _timer = 0f;
        }
    }

    private void FixedUpdate()
    {
        _moveController.MoveObject(this);
    }

    public void Move()
    {
        _dir = Vector2.down*speed;
       _rgb.MovePosition(_rgb.position+_dir*Time.fixedDeltaTime);
    }
}
