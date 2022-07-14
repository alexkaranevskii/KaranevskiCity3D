using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Скорость перемещения игрока без ускорения
    [SerializeField] private float speed = 3.0f;

    // Скорость перемещения игрока с ускорением
    [SerializeField] private float runSpeed = 5.0f;

    // Гравитация игрока
   [SerializeField] private float gravity = 10.0f;

    // Скорость прыжка игрока
    [SerializeField] private float jumpSpeed = 2.0f;

    private Vector3 direction;

    private const string horizontal = "Horizontal";
    private const string vertical = "Vertical";
    private const string running = "Running";

    private bool isRunning;

    private void Start()
    {
        
    }

    void Update()
    {
        direction.x = Input.GetAxis(horizontal);
        direction.z = Input.GetAxis(vertical);
        isRunning = Input.GetButton(running);

        if (Input.GetKeyUp(KeyCode.Space))
        {
            direction.y = jumpSpeed;
        }

     //   direction.y -= gravity * Time.deltaTime;
        transform.position += direction * (isRunning ? runSpeed : speed) * Time.deltaTime;
    }

}
