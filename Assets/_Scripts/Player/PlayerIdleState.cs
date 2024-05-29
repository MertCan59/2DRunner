using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleState : PlayerStateMachine
{
    public PlayerIdleState(PlayerController playerController, PlayerState playerState, PlayerInput playerInput) : base(playerController, playerState, playerInput)
    { }

    public override void OnEnter()
    {
        base.OnEnter();
    }

    public override void OnUpdate()
    {
        base.OnUpdate();
        if (Direction.x < 0)
        {
            PlayerState.ChangeState(PlayerController.PlayerLeftMovementState);
        }
        else if (Direction.x > 0)
        {
            PlayerState.ChangeState(PlayerController.PlayerRightMovementState);
        }
    }

    public override void OnExit()
    {
        base.OnExit();
        Timer = 0f;
    }
}
