using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recoil : MonoBehaviour
{
    [SerializeField] private float recoilX;
    [SerializeField] private float recoilY;
    [SerializeField] private float recoilZ;

    [SerializeField] private float snappiness;
    [SerializeField] private float returnSpeed;

    private Vector3 _currentRotation;
    private Vector3 _targetRotation;


    private void Update()
    {
        //Debug.Log(Time.deltaTime);
        _targetRotation = Vector3.Lerp(_targetRotation, Vector3.zero, returnSpeed * Time.deltaTime);
        _currentRotation = Vector3.Slerp(_currentRotation, _targetRotation, snappiness * Time.deltaTime);
        transform.localRotation = Quaternion.Euler(_currentRotation);
    }

    public void RecoilFire(float verticalRecoil)
    {
        _targetRotation += new Vector3(-verticalRecoil, Random.Range(-recoilY, recoilY), Random.Range(-recoilZ, recoilZ));
    }
}
