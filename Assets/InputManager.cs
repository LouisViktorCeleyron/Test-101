using UnityEngine;

public class InputManager : MonoBehaviour
{
    public Movement movement;
    public KeyCode upInput, downInput, leftInput, rightInput,jumpInput;
    public void Update()
    {
        if(Input.GetKey(upInput))
        {
            movement.Move(Vector3.forward);
        }
        if (Input.GetKey(downInput))
        {
            movement.Move(Vector3.back);
        }
        if (Input.GetKey(leftInput))
        {
            movement.Move(Vector3.left);
        }
        if (Input.GetKey(rightInput))
        {
            movement.Move(Vector3.right);
        }
        if (Input.GetKeyDown(jumpInput))
        {
            movement.Jump();
        }
    }
}
