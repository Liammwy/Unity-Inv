using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCharacterInput : MonoBehaviour
{
    [Header("Character Input Values")]
    public Vector2 move;
    public Vector2 look;
    public bool jump;
    public bool sprint;
    public bool server;

    public GameObject serverHitBox;
    public GameObject serverOBJ;
    public GameObject inventoryUi;

    public GameObject inventoryUI;
    public GameObject InputPrompt;

    private Server _driveList;
    private ServerHitBox _serverHitBox;
    [Header("Movement Settings")]
    public bool analogMovement;

    [Header("Mouse Cursor Settings")]
    public bool cursorLocked = true;
    public bool cursorInputForLook = true;

    private void Start()
    {
        _serverHitBox = serverHitBox.GetComponent<ServerHitBox>();
        _driveList = serverOBJ.GetComponent<Server>();
    }

    public void OnMove(InputValue value)
    {
        MoveInput(value.Get<Vector2>());
    }

    public void OnLook(InputValue value)
    {
        if (cursorInputForLook)
        {
            LookInput(value.Get<Vector2>());
        }
    }

    public void OnJump(InputValue value)
    {
        JumpInput(value.isPressed);
    }

    public void OnSprint(InputValue value)
    {
        SprintInput(value.isPressed);
    }

    public void OnServer(InputValue value)
    {
        if (_serverHitBox.in_zone && _driveList.drives.Count > 0)
        {
            if (_driveList.drives.Count > 0)
            {
                inventoryUi.SetActive(!inventoryUi.activeInHierarchy);
                InputPrompt.SetActive(!InputPrompt.activeInHierarchy);
            }
        }
    }


    public void MoveInput(Vector2 newMoveDirection)
    {
        move = newMoveDirection;
    }

    public void LookInput(Vector2 newLookDirection)
    {
        look = newLookDirection;
    }

    public void JumpInput(bool newJumpState)
    {
        jump = newJumpState;
    }

    public void SprintInput(bool newSprintState)
    {
        sprint = newSprintState;
    }

    private void OnApplicationFocus(bool hasFocus)
    {
        SetCursorState(cursorLocked);
    }

    private void SetCursorState(bool newState)
    {
        Cursor.lockState = newState ? CursorLockMode.Locked : CursorLockMode.None;
    }
}
