using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour {

    public GameObject lookAtGameObj;
    public Vector3 offSet;

    private void Update()
    {
        this.transform.LookAt(lookAtGameObj.transform);
        transform.position = lookAtGameObj.transform.position + offSet;
    }
}
