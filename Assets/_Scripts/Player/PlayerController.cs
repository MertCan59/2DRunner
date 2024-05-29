using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerInput _playerInput; 

    #region State

    public PlayerState PlayerState;
    public PlayerIdleState PlayerIdleState;
    public PlayerLeftMovementState PlayerLeftMovementState;
    public PlayerRightMovementState PlayerRightMovementState;

    #endregion

    private void Awake()
    {
        _playerInput = new PlayerInput();
    }

    // Start is called before the first frame update
    void Start()
    {
        PlayerState = new PlayerState();
        PlayerIdleState = new PlayerIdleState(this,PlayerState,_playerInput);
        PlayerLeftMovementState = new PlayerLeftMovementState(this, PlayerState, _playerInput);
        PlayerRightMovementState = new PlayerRightMovementState(this, PlayerState, _playerInput);
        PlayerState.StartState(PlayerIdleState);
        PlayerState.CurrentPlayerState.OnEnter();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerState.CurrentPlayerState.OnUpdate();
    }

    private void FixedUpdate()
    {
        PlayerState.CurrentPlayerState.OnFixedUpdate();
    }

    private void OnEnable()
    {
        _playerInput.Enable();
    }

    private void OnDisable()
    {
        _playerInput.Disable();
    }
}
