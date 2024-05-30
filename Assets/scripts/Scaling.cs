using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaling : MonoBehaviour
{
    [SerializeField] private float _growingSpeed;

    private void Update()
    {
        transform.localScale += Vector3.one*_growingSpeed * Time.deltaTime;
    }
}
