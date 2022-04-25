using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float lookSpeed;
    public float walkSpeed;
    public float smoothTime = 0.3f;
    public float gravity = -9.8f;
    public Camera cam;
    // variables 
    Vector2 rotation = Vector2.zero;
    Vector2 currentDir = Vector2.zero;
    Vector2 currentDirVelo = Vector2.zero;

    float camPitch = 0f;
    float velocityY = 0f;
    CharacterController controller = null;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        // hides the cursour
    }

    // Update is called once per frame
    void Update()
    {
        mouselook();
        moveUpdate();

        {

        }
    }

    void mouselook()
    {
        rotation = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        // looking around
        camPitch -= rotation.y * lookSpeed;
        camPitch = Mathf.Clamp(camPitch, -90.0f, 90.0f);
        cam.transform.localEulerAngles = Vector3.right * camPitch;
        // mouse making cam move
        transform.Rotate(Vector3.up * rotation.x * lookSpeed);
    }

    void moveUpdate()
    {
        Vector2 wasd = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        wasd.Normalize();
        currentDir = Vector2.SmoothDamp(currentDir, wasd, ref currentDirVelo, smoothTime);
        //movement 

        velocityY += gravity * Time.deltaTime;

        Vector3 velocity = (transform.forward * currentDir.y + transform.right * currentDir.x) * walkSpeed + Vector3.up * velocityY;
        controller.Move(velocity * Time.deltaTime);
        //velocity 
    }
}



