using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    public float speed, topSpeed, jumpForce, radius, mouseSenitivity;
    public Transform playerTrans, right, cameraTrans, forward;
    private Rigidbody _playerRb;
    private MovementClass _playerMc;
    private PlayerClass _playerPc;
    
    // Start is called before the first frame update
    void Start()
    {
        _playerRb = gameObject.GetComponent<Rigidbody>();
        _playerMc = new MovementClass(speed, jumpForce, speed, topSpeed, KeyCode.D, KeyCode.A, KeyCode.Space, KeyCode.None,
            KeyCode.W, KeyCode.S, _playerRb, ForceMode.VelocityChange, ForceMode.Impulse, ForceMode.VelocityChange);
        _playerPc = new PlayerClass(_playerMc, transform);

        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 horizontal = right.position - transform.position;
        Vector3 forwardDir = forward.position - transform.position;
        _playerPc.CcPlusPlayerMovement(6, horizontal, Vector3.up, forwardDir, radius, mouseSenitivity, 
            cameraTrans);
    }
}
