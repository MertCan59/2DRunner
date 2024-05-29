using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerRightMovementState : PlayerStateMachine
{ 
    public PlayerRightMovementState(PlayerController playerController, PlayerState playerState, PlayerInput playerInput) : base(playerController, playerState, playerInput)
    { }

    private float _speed = 6;
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
        Direction = Vector3.right * _speed;
        _transform.position += (Vector3)Direction * Time.fixedDeltaTime;
    }
}
