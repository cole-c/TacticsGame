using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TacticsCamera : MonoBehaviour {

    public void RotateRight()
    {
        transform.Rotate(Vector3.up, -90, Space.Self);
    }

    public void RotateLeft()
    {
        transform.Rotate(Vector3.up, 90, Space.Self);
    }
}
