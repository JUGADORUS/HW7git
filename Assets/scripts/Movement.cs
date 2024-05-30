using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;

    private void Update()
    {
        transform.Translate(Vector3.forward * _movementSpeed * Time.deltaTime);
    }
}
