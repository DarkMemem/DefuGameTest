using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(SurfaceSlider))]
public abstract class Movement : MonoBehaviour
{
    [SerializeField] protected float speed;

    private Rigidbody rigidbody;
    private SurfaceSlider surfaceSlider;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        surfaceSlider = GetComponent<SurfaceSlider>();
    }

    public void Move(Vector3 direction)
    {
        Vector3 directionAlongSurface = surfaceSlider.Project(direction.normalized);
        Vector3 offset = directionAlongSurface * (speed * Time.deltaTime);

        rigidbody.MovePosition(rigidbody.position + offset);
    }
}
