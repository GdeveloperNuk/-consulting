using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_move : MonoBehaviour
{
    public float min_x_pos;
    public float max_x_pos;
    public float min_y_pos;
    public float max_y_pos;
    public float speed;
    public float offset = 3f;
    private Vector3 pos;
    private void Update()
    {
        pos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, offset));
        if (pos.x < min_x_pos)
            pos.x = min_x_pos;
        else if (pos.x > max_x_pos)
            pos.x = max_x_pos;
        if (pos.y < min_y_pos)
            pos.y = min_y_pos;
        else if (pos.y > max_x_pos)
            pos.y = max_y_pos;
        pos.z = offset;
        transform.position = Vector3.Lerp(transform.position, pos, Time.deltaTime * speed);
    }
}
