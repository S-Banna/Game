using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour {
    public float movespeed = 5f;
    private Rigidbody rb;
    private Vector2 moveInput;

    private void Start() {
        rb = GetComponent<Rigidbody>();
    }

    public void OnMove(InputAction.CallbackContext context) {
        moveInput = context.ReadValue<Vector2>();
        Debug.Log("Move input: " + moveInput);
    }

    private void FixedUpdate() {
        Vector3 move = new Vector3(moveInput.x, 0, moveInput.y) * movespeed;
        rb.AddForce(move, ForceMode.Force);
    }
}
