using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BecomeBigger : MonoBehaviour
{
    [SerializeField] private float _growingSpeed;

    void Update()
    {
        transform.localScale += Vector3.one*_growingSpeed * Time.deltaTime;
    }
}
