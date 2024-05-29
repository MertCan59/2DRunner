using UnityEngine;

public abstract class PlayerStateMachine
{
    protected PlayerState PlayerState;
    protected PlayerController PlayerController;
    private readonly PlayerInput _playerInput;
    protected float Timer;
    protected Vector2 Direction;

    public PlayerStateMachine(PlayerController playerController, PlayerState playerState, PlayerInput playerInput)
    {
        PlayerController = playerController;
        PlayerState = playerState;
        _playerInput = playerInput;
    }
    
    public virtual void OnEnter(){}

    public virtual void OnUpdate()
    {
        Direction = _playerInput.Player.Move.ReadValue<Vector2>();
        Timer += Time.deltaTime;
    }
    public virtual void OnFixedUpdate(){}
    public virtual void OnExit(){}

    protected T GetComponent<T>() where T : Component
    {
        return PlayerController.GetComponent<T>();
    }
}
