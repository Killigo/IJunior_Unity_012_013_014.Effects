using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed = 6f;

    public Vector3 _targetPosition = new Vector3(20f, 0f, 0f);

    private void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, _targetPosition, _speed * Time.deltaTime);
    }
}
