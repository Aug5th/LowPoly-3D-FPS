using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MyMonoBehaviour
{
    private Camera _camera;
    [SerializeField] private float distance = 3.0f;
    protected override void LoadComponents()
    {
        _camera = GetComponent<PlayerLook>().Camera;
        base.LoadComponents();
    }

    public void Interact()
    {
        Ray ray = new Ray(_camera.transform.position, _camera.transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * distance);
        if (Physics.Raycast(ray, out RaycastHit hit, distance))
        {
            if (hit.collider.GetComponent<IInteractable>() != null)
            {
                hit.collider.GetComponent<IInteractable>().Interact();
            }
        }
    }
}
