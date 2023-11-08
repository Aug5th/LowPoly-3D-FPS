using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MyMonoBehaviour
{
    private static CameraManager _instance;
    public static CameraManager Instance => _instance;

    private Camera _camera;
    protected override void LoadComponents()
    {
        if(_instance == null)
        {
            _instance = this;
        }
        _camera = GetComponent<Camera>();
        base.LoadComponents();
    }

    public void Zoom(float zoomPosition, float smooth)
    {
        _camera.fieldOfView = Mathf.Lerp(_camera.fieldOfView, zoomPosition, Time.deltaTime * smooth);
    }
}
