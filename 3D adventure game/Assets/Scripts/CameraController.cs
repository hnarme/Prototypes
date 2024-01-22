using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    public float rotateSpeed;

    public Transform pivot;

    public float maxViewAngle;
    public float minViewAngle;

    public bool invertY;

    public MenuManager menuManager;

    // Start is called before the first frame update
    void Start()
    {
        offset = target.position - transform.position;

        //pivot.transform.position = target.transform.position;
        pivot.transform.parent = null;

        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (!menuManager.isGamePaused)
        {
            pivot.transform.position = target.transform.position;

            //Get the x position of the mouse and rotate the target
            float horizontal = Input.GetAxis("Mouse X") * rotateSpeed;
            pivot.Rotate(0, horizontal, 0);

            // Get the Y position of the mouse and rotate the pivot
            float vertical = Input.GetAxis("Mouse Y") * rotateSpeed;
            //pivot.Rotate(-vertical, 0, 0);
            if (invertY)
            {
                pivot.Rotate(-vertical, 0, 0);
            }
            else
            {
                pivot.Rotate(vertical, 0, 0);
            }

            //Limit up/down camera rotation
            if (pivot.rotation.eulerAngles.x > maxViewAngle && pivot.rotation.eulerAngles.x < 180f)
            {
                pivot.rotation = Quaternion.Euler(maxViewAngle, 0, 0);
            }

            if (pivot.rotation.eulerAngles.x > 180f && pivot.rotation.eulerAngles.x < 360f + minViewAngle)
            {
                pivot.rotation = Quaternion.Euler(360f + minViewAngle, 0, 0);
            }

            //Move the camera based on the rotation of the target & the original offset
            float desiredYangle = pivot.eulerAngles.y;
            float desiredXangle = pivot.eulerAngles.x;

            Quaternion rotation = Quaternion.Euler(desiredXangle, desiredYangle, 0);
            transform.position = target.position - (rotation * offset);

            //transform.position = target.position - offset;
            if (transform.position.y < target.position.y)
            {
                transform.position = new Vector3(transform.position.x, target.position.y, transform.position.z);
            }
            transform.LookAt(target);
        }else
        {
            Cursor.lockState = CursorLockMode.Confined;
        }
    }
}
