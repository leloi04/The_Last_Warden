using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float HorizontalInput;
    public float VerticalInput;
    public bool MouseButtonDown;
    public bool SpaceKeyDown;
    public Joystick MovementJoystick;

    private void Awake()
    {
        if (MovementJoystick == null)
        {
            MovementJoystick = FindObjectOfType<Joystick>();
        }
    }

    void Update()
    {
        if (!MouseButtonDown && Time.timeScale != 0)
        {
            MouseButtonDown = Input.touchCount == 0 && Input.GetMouseButtonDown(0);
        }
        if (!SpaceKeyDown && Time.timeScale != 0)
        {
            SpaceKeyDown = Input.GetKeyDown(KeyCode.Space);
        }

        if (MovementJoystick != null &&
            (MovementJoystick.Horizontal != 0f || MovementJoystick.Vertical != 0f))
        {
            HorizontalInput = MovementJoystick.Horizontal;
            VerticalInput = MovementJoystick.Vertical;
        }
        else
        {
            HorizontalInput = Input.GetAxisRaw("Horizontal");
            VerticalInput = Input.GetAxisRaw("Vertical");
        }
    }

    public void OnAttackButtonPressed()
    {
        if (Time.timeScale != 0f)
        {
            MouseButtonDown = true;
        }
    }

    public void OnDashButtonPressed()
    {
        if (Time.timeScale != 0f)
        {
            SpaceKeyDown = true;
        }
    }

    //stop update when player/gameobject is dead, make it uncontrollable
    private void OnDisable()
    {
        clearCache();

    }

    public void clearCache()
    {
        MouseButtonDown = false;
        SpaceKeyDown = false;
        HorizontalInput = 0;
        VerticalInput = 0;
    }
}
