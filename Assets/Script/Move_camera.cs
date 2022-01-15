using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_camera : MonoBehaviour
{
    public float speed;
    public Camera final_pos;
    public Camera camera;
    public bool value;

    private void Awake()
    {
        value = false;
    }
    private void Update()
    {
        if(value)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(final_pos.transform.position.x, final_pos.transform.position.y-2, final_pos.transform.position.z + 15), Time.deltaTime * speed);
            camera.transform.position = Vector3.Lerp(camera.transform.position, final_pos.transform.position, Time.deltaTime * speed);
            camera.transform.forward = transform.position;
            if(Mathf.Round(camera.transform.position.x) == Mathf.Round(final_pos.transform.position.x) && Mathf.Round(camera.transform.position.y) == Mathf.Round(final_pos.transform.position.y) && Mathf.Round(camera.transform.position.z) == Mathf.Round(final_pos.transform.position.z))
            {
                final_pos.gameObject.SetActive(true);
                value = false;
                camera.gameObject.SetActive(false);
            }
        }
    }
    public void Move_camera_()
    {
        transform.position = new Vector3(camera.transform.position.x - 10, camera.transform.position.y, camera.transform.position.z + 1);
        value = true;
    }
}
