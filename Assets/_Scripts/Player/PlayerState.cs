using UnityEngine;

public class PlayerState
{
    public PlayerStateMachine CurrentPlayerState { get; private set; }

    public void StartState(PlayerStateMachine state)
    {
        CurrentPlayerState = state;
        CurrentPlayerState.OnEnter();
    }

    public void ChangeState(PlayerStateMachine state)
    {
        CurrentPlayerState.OnExit();
        CurrentPlayerState = state;
        CurrentPlayerState.OnEnter();
    }
}
