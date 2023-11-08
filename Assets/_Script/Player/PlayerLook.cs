using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MyMonoBehaviour
{
    [SerializeField] private new Camera camera;
    public Camera Camera => camera;
    [SerializeField] private float xSensitivity = 30f;
    [SerializeField] private float ySensitivity = 30f;

    private float _xRotation = 0f;

    private void Start()
    {
        LockCursor();
    }
    private void Update()
    {
        
    }
    private void LockCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void UpdateCursor()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(Cursor.lockState == CursorLockMode.Locked)
            {
                Cursor.lockState = CursorLockMode.None;
            }
            //else if (Cursor.lockState == CursorLockMode.None)
            //{
            //    Cursor.lockState = CursorLockMode.Locked;
            //}
        }
    }
    public void Look(Vector2 input)
    {
        float mouseX = input.x;
        float mouseY = input.y;

        // caculate camera rotation for looking up and down
        _xRotation -= (mouseY * Time.deltaTime) * ySensitivity;
        _xRotation = Mathf.Clamp(_xRotation, -80f, 80f);
        // apply this to our camera transform
        camera.transform.localRotation = Quaternion.Euler(_xRotation, 0, 0);
        // rotate player to look left and right
        transform.Rotate(Vector3.up * (mouseX * Time.deltaTime) * xSensitivity);
    }
}
