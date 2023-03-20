using UnityEngine;
using UnityEngine.Audio;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public float jumpHeight = 2.0f;
    private float gravity = -20.0f;
    private Vector3 moveDirection = Vector3.zero;
    private CharacterController controller;
    private AudioSource audioSource; // reference to the Audio Source component
    public AudioClip jumpSound; // the audio clip for the jump sound

    void Start()
    {
        controller = GetComponent<CharacterController>();
        audioSource = GetComponent<AudioSource>(); // get the Audio Source component
        audioSource.clip = jumpSound; // set the audio clip for the jump sound
    }

    void Update()
    {
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection *= speed;

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = Mathf.Sqrt(2 * jumpHeight * -gravity);
                audioSource.Play();
            }
        }

        moveDirection.y += gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
}

