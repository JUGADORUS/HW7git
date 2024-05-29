using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;

    void Update()
    {
        transform.Translate(Vector3.forward * _movementSpeed * Time.deltaTime);
    }
}
