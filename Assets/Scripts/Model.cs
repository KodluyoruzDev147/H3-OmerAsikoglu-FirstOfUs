using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public abstract class Model : MonoBehaviour
{
    private Rigidbody rigidbody;
    protected virtual void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    protected virtual void Start()
    {

    }
    protected virtual void Update()
    {

    }
}
