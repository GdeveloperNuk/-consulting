using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour
{
    public int join_student;
    public int friendship_1;
    public int friendship_2;
    public int friendship_3;
    public int mental_1;
    public int mental_2;
    public int mental_3;
    public TextMesh txt;
    public TextMesh name_txt;
    public GameObject outline_tiara;
    public GameObject outline_stan;
    public GameObject outline_olibia;
    public Transform cam;
    public Transform targetCam;

    private bool moveCheck;
    private bool choose_stu;
    private int year;
    private int month;
    private void Start()
    {
        friendship_1 = 60;
        friendship_2 = 40;
        friendship_3 = 80;
        mental_1 = 70;
        mental_2 = 30;
        mental_3 = 70;
        join_student = 1; //0으로 수정
        year = 2022;
        month = 3;
        choose_stu = true;  //false로 변경
        moveCheck = false;
        txt.text = year + "Y " + month + "M";
    }
    private void Update()
    {
        if (moveCheck)
        {
            CameraAni();
        }
        Limit_sensor();
        if (choose_stu)
        {
            name_txt.text = "상담할 사람을 골라주세요";
            RaycastHit hitInfo = new RaycastHit();
            if (Input.GetMouseButtonDown(0))
            {
                if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo))
                {
                    outline_tiara.SetActive(false);
                    outline_stan.SetActive(false);
                    outline_olibia.SetActive(false);
                    switch (hitInfo.transform.tag)
                    {
                        case "tiara":
                            join_student = 1;
                            choose_stu = false;
                            name_txt.text = "오늘의 상담\n티아라 카터";
                            moveCheck = true;
                            break;
                        case "stan":
                            join_student = 2;
                            choose_stu = false;
                            name_txt.text = "오늘의 상담\n스텐 리";
                            moveCheck = true;
                            break;
                        case "olibia":
                            join_student = 3;
                            choose_stu = false;
                            name_txt.text = "오늘의 상담\n올리비아 영";
                            moveCheck = true;
                            break;
                    }
                }
            }
            else
            {
                if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo))
                {
                    switch (hitInfo.transform.tag)
                    {
                        case "tiara":
                            outline_tiara.SetActive(true);
                            break;
                        case "stan":
                            outline_stan.SetActive(true);
                            break;
                        case "olibia":
                            outline_olibia.SetActive(true);
                            break;
                        default:
                            outline_tiara.SetActive(false);
                            outline_stan.SetActive(false);
                            outline_olibia.SetActive(false);
                            break;
                    }
                }
            }
        }

    }
    public void Friendship_add(int value)
    {
        switch (join_student)
        {
            case 1:
                friendship_1 += value;
                break;
            case 2:
                friendship_2 += value;
                break;
            case 3:
                friendship_3 += value;
                break;
        }
    }
    public void Mental_add(int value)
    {
        switch (join_student)
        {
            case 1:
                mental_1 += value;
                break;
            case 2:
                mental_2 += value;
                break;
            case 3:
                mental_3 += value;
                break;
        }
    }
    private void Limit_sensor()
    {
        if (friendship_1 > 100)
            friendship_1 = 100;
        else if (friendship_2 > 100)
            friendship_2 = 100;
        else if (friendship_3 > 100)
            friendship_3 = 100;
        if (mental_1 > 100)
            mental_1 = 100;
        else if (mental_2 > 100)
            mental_2 = 100;
        else if (mental_3 > 100)
            mental_3 = 100;
    }
    public void Date_add()
    {
        month++;
        if (month >= 13)
        {
            year++;
            month = 1;
        }
        txt.text = year + "Y " + month + "M";
    }

    public void CameraAni()
    {
        cam.position = Vector3.Lerp(transform.position, targetCam.position, Time.deltaTime * 0.01f);

        if(cam.position == targetCam.position)
        {
            moveCheck = false;
        }
    }
}