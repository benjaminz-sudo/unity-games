using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class StickCharacter : MonoBehaviour
{
    private CharacterController characterController;

    public float speed = 3f;                // Speed of the character
    public float rotationSpeed = 200f;      // Speed of rotation

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        float hInput = Input.GetAxis("Horizontal");
        float vInput = Input.GetAxis("Vertical");

        // Rotate character
        transform.Rotate(Vector3.up, hInput * rotationSpeed * Time.deltaTime);

        // Moves the character forward
        characterController.SimpleMove(transform.forward * vInput * speed);
    }
}