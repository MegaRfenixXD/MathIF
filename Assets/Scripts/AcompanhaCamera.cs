using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcompanhaCamera : MonoBehaviour
{

    public Transform target;

    public Vector3 offset;

    public bool useOffsetValues;

    public float rotateSpeed;

    public Transform pivot;

    void Start()
    {
        if (!useOffsetValues)
        {

            offset = target.position - transform.position;
        }

        pivot.transform.position = target.transform.position;
        pivot.transform.parent = target.transform;

        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Mouse X") * rotateSpeed;
        target.Rotate(0, horizontal, 0);

        float vertical = Input.GetAxis("Mouse Y") * rotateSpeed;
        pivot.Rotate(-vertical, 0, 0);

        float desireYAngle = target.eulerAngles.y;
        float desireXAngle = pivot.eulerAngles.x;
        Quaternion rotation = Quaternion.Euler(desireXAngle, desireYAngle, 0);
        transform.position = target.position - (rotation * offset);

        transform.LookAt(target);

    
    }
}
