using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController charController;
    public float speed = 5;
    public float mouseSensitivity = 3.5f;

    Transform cameraTrans;
    float cameraPitch = 0;
    float gravityValue = Physics.gravity.y;
    float jumpHeight = -2f;

    float currentYVelocity;

    [SerializeField]
    //Transform gunPoint;


    // Start is called before the first frame update
    void Start()
    {
        charController = GetComponent<CharacterController>();
        cameraTrans = Camera.main.transform;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.instance.isGameOver)
        {
            Vector2 mouseDelta = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
            transform.Rotate(Vector3.up * mouseDelta.x * mouseSensitivity);

            //Constraint the camera pitch inbetween -90 to 90
            cameraPitch -= mouseDelta.y * mouseSensitivity;
            cameraPitch = Mathf.Clamp(cameraPitch, -90, 90);
            cameraTrans.localEulerAngles = Vector3.right * cameraPitch;
            //cameraTrans.Rotate(Vector3.left * mouseDelta.y * mouseSensitivity);


            Vector3 move = transform.rotation * new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));



            // Changes the height position of the player..
            if (Input.GetKeyDown(KeyCode.Space) && charController.isGrounded)
            {
                //currentYVelocity = Mathf.Sqrt(2 * jumpHeight * gravityValue);
            }
            else if (charController.isGrounded)
            {
                currentYVelocity = -0.5f;
            }
            move.y = currentYVelocity;
            currentYVelocity += gravityValue * Time.deltaTime;

            charController.Move(move * Time.deltaTime * speed);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            GameManager.instance.GameOver();
        }
    }
}