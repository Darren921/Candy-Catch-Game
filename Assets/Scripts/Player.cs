using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private float speed;
    private Vector2 _moveDir;
    // Start is called before the first frame update
    void Start()
    {
        InputManager.Init(this);
        InputManager.setGameControls();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.rotation * (speed * Time.deltaTime * _moveDir);
    }
    public void SetMoveDirection(Vector2 NewDirection)
    {
        _moveDir = NewDirection;
    }
}
