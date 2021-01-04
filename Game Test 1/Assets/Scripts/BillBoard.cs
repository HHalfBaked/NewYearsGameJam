using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillBoard : MonoBehaviour
{
    public Camera Cam;

    public bool StaticBillBoard;

    void LateUpdate()
    {
        if (!StaticBillBoard)
        {
            transform.LookAt(Cam.transform);
        }
        else
        {
            transform.rotation = Cam.transform.rotation;
        }

        transform.rotation = Quaternion.Euler(0f, transform.rotation.eulerAngles.y, 0f);
    }
}
