using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    // �������� ����������� ������ ��� ���������
    [SerializeField] private float speed = 3.0f;

    // �������� ����������� ������ � ����������
    [SerializeField] private float runSpeed = 5.0f;

    // ���������� ������
    private float gravity = 20.0f;

    // �������� ������ ������
    [SerializeField] private float jumpSpeed = 8.0f;

    private Vector3 moveDir = Vector3.zero;

    private const string horizontal = "Horizontal";
    private const string vertical = "Vertical";
    private const string running = "Running";

    private CharacterController controller;


    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void FixedUpdate()
    {
        if (controller.isGrounded)
        {
            moveDir = new Vector3(Input.GetAxis(horizontal), 0, Input.GetAxis(vertical));
            moveDir = transform.TransformDirection(moveDir);
            moveDir *= speed;
        }

        if (Input.GetKeyUp(KeyCode.Space) && controller.isGrounded)
        {
            moveDir.y = jumpSpeed;
        }

        moveDir.y -= gravity * Time.deltaTime;
        controller.Move(moveDir * Time.deltaTime);
    }

}
