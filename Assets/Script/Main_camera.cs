using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_camera : MonoBehaviour
{
    public GameObject target;
    private void Update()
    {
        this.transform.forward = new Vector3(target.transform.position.x, target.transform.position.y-1.2f, target.transform.position.z + 10);
    }
}
