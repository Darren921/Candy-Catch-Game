using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InputManager
{
    private static Controls _Controls;
    
    public static void Init(Player Player1)
    {
        _Controls = new Controls();
        _Controls.Perm.Enable();
        _Controls.InGame.Movement.performed += ctx =>
        {
            Player1.SetMoveDirection(ctx.ReadValue<Vector2>());
        };
    }
    public static void setGameControls()
    {
        _Controls.InGame.Enable();
        _Controls.UI.Disable();

    }
    public static void setUIControls()
    {
        _Controls.UI.Disable();
        _Controls.InGame.Disable();
    }

}
