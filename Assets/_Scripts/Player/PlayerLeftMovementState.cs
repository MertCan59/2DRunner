using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerLeftMovementState : PlayerStateMachine
{
    public PlayerLeftMovementState(PlayerController playerController, PlayerState playerState, PlayerInput playerInput) : base(playerController, playerState, playerInput)
    { }
    
    private float _speed = 6f;
    private Transform _transform;
    public override void OnEnter()
    {
        base.OnEnter();
        _transform = GetComponent<Transform>();
    }
    public override void OnUpdate()
    {
        base.OnUpdate();
        if (Direction.x == 0f)
        {
            PlayerState.ChangeState(PlayerController.PlayerIdleState);
        }
    }
    public override void OnFixedUpdate()
    {
        base.OnFixedUpdate();
        Direction = Vector3.left * _speed;
        _transform.position += (Vector3)Direction * Time.fixedDeltaTime;
    }
}
