using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;

    private void Start()
    {
        _rigidbody2D = GetComponent<rigidbody2D>();

    }
}
        