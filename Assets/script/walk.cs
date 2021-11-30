using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour
{
    public float _speed = 2;
    private Vector3 _direction;
    public float Rotatespeed = 100f;
    public void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    private void Awake()
    {
        _direction = Vector3.zero;
    }
    private void Update()
    {
        _direction.x = Input.GetAxis("Horizontal");
        _direction.z = Input.GetAxis("Vertical");

    }
    private void FixedUpdate()
    {
        Move();
        transform.Rotate(0, Input.GetAxis("Mouse X") * Rotatespeed * Time.fixedDeltaTime, 0);
    }
    private void Move()
    {
        Vector3 direction = _speed * _direction * Time.fixedDeltaTime;
        transform.Translate(direction);
    }
}
