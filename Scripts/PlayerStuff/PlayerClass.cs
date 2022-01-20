using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerClass
{
    //movement clases the player will need to move
    private MovementClass movement;
    private Transform transform;
    private float _xRotation = 0;

    //for 2d movement
    public PlayerClass(MovementClass movement, Transform transform)
    {
        this.movement = movement;
        this.transform = transform;
    }


    public virtual void TwoDPlayerMovement (int caseInt, Vector3 hDirection, Vector3 vDirection, float radius)
    {
        if (GroundCheck(radius)) movement.MoveInDirection(caseInt, hDirection, vDirection);
    }

   
    public virtual void CcPlusPlayerMovement (int caseInt, Vector3 hDirection, Vector3 vDirection, Vector3 fDirection, float radius, float mouseSensitivity, Transform cameraObj)
    {
        if (GroundCheck(radius)) movement.MoveInDirection(caseInt, hDirection, vDirection, fDirection);
        MouseLook(mouseSensitivity, cameraObj);
    }

    /// <summary>
    /// checks for gameobjects on the Ground layer with an overlap sphere
    /// </summary>
    /// <param name="transform">the Vector3 poistion for the sphere</param>
    /// <param name="radius">the radius of the sphere</param>
    /// <param name="grounded">a ref bool that changes depending on where the sphere overlaps with Ground or not</param>
    public bool GroundCheck(float radius)
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius, LayerMask.GetMask("Ground"));
        if (colliders.Length > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    /// <summary>
    /// allows your mouse to control the camera
    /// </summary>
    /// <param name="mouseSensitivity">the speed in which the camera moves when your mouse moves</param>
    /// <param name="transform">the GameObject rotates on the X</param>
    /// <param name="cameraObj">the transform of the camera</param>
    /// <param name="xRotation">the angle in degrees that the camera moves</param>
    public void MouseLook(float mouseSensitivity, Transform cameraObj)
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        _xRotation -= mouseY;
        _xRotation = Mathf.Clamp(_xRotation, -90, 90);
        transform.Rotate(Vector3.up * mouseX);
        cameraObj.localRotation = Quaternion.Euler(_xRotation, 0, 0);
    }

    /// <summary>
    /// stops time, unlocks the cursor, and then spawns UI to restart
    /// </summary>
    /// <param name="deathUI">UI that should show up when the player dies</param>
    public void DeathStuff(GameObject deathUI)
    {
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        deathUI.SetActive(true);
    }

    /// <summary>
    /// loads a new scene
    /// </summary>
    /// <param name="next">the scene that we want to load</param>
    public void NextLevel(string next)
    {
        SceneManager.LoadScene(next);
    }
}