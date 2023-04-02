using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    [SerializeField] Mover _target;

    private void Start()
    {
        _target.enabled = true;
    }
}
