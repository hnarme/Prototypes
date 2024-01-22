using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float walkSpeed;
    public float sprintSpeed;
    public float jumpForce;
    public CharacterController controller;

    private Vector3 moveDirection;
    public float gravityScale;

    public float knockBackForce;
    public float knockBackTime;
    private float knockBackCounter;

    public Animator m_Animator;
    public Transform pivot;
    //public float rotateSpeed;
    public float rotateSpeed;

    public GameObject playerModel;

    public bool isRunning = false;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (knockBackCounter <= 0)
        {
            float yStore = moveDirection.y;
            moveDirection = (transform.forward * Input.GetAxis("Vertical")) + (transform.right * Input.GetAxis("Horizontal"));
            moveDirection = moveDirection.normalized * moveSpeed;
            moveDirection.y = yStore;

            //Only jump from the ground
            if (controller.isGrounded)
            {
                moveDirection.y = 0f;

                if (Input.GetKeyDown("space"))
                {
                    moveDirection.y = jumpForce;
                }

                if (Input.GetKey(KeyCode.LeftShift))
                {
                    moveSpeed = sprintSpeed;
                    isRunning = true;
                }
                else
                {
                    moveSpeed = walkSpeed;
                    isRunning = false;
                }
            }
        }
        else
        {
            knockBackCounter -= Time.deltaTime;
        }


        //Add gravity to player
        moveDirection.y = moveDirection.y + (Physics.gravity.y * gravityScale * Time.deltaTime);

        //move player by time instead of frame
        controller.Move(moveDirection * Time.deltaTime);

        //move the player in different directions based on camera direction
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            transform.rotation = Quaternion.Euler(0f, pivot.rotation.eulerAngles.y, 0f);
            Quaternion newRotation = Quaternion.LookRotation(new Vector3(moveDirection.x, 0f, moveDirection.z));
            playerModel.transform.rotation = Quaternion.Slerp(playerModel.transform.rotation, newRotation, rotateSpeed * Time.deltaTime);
        }

        m_Animator.SetBool("isRunning", isRunning);
        m_Animator.SetBool("isGrounded", controller.isGrounded);
        m_Animator.SetFloat("walkingSpeed", (Mathf.Abs(Input.GetAxis("Vertical")) + Mathf.Abs(Input.GetAxis("Horizontal"))));
    }

    public void KnockBack(Vector3 direction)
    {
        knockBackCounter = knockBackTime;

        moveDirection = direction * knockBackForce;

        moveDirection.y = knockBackForce;
    }
}

