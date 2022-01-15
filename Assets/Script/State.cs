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

    private bool choose_stu;
    private int year;
    private int month;
    private void Start()
    {
        friendship_1 = 30;
        friendship_2 = 30;
        friendship_3 = 30;
        mental_1 = 30;
        mental_2 = 30;
        mental_3 = 30;
        join_student = 1; //0으로 수정
        year = 2022;
        month = 3;
        choose_stu = true;  //false로 변경
        txt.text = year + "Y " + month + "M";
    }
    private void Update()
    {
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
                            break;
                        case "stan":
                            join_student = 2;
                            choose_stu = false;
                            name_txt.text = "오늘의 상담\n스텐 리";
                            break;
                        case "olibia":
                            join_student = 3;
                            choose_stu = false;
                            name_txt.text = "오늘의 상담\n올리비아 영";
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
        if (friendship_1 > 50)
            friendship_1 = 50;
        else if (friendship_2 > 50)
            friendship_2 = 50;
        else if (friendship_3 > 50)
            friendship_3 = 50;
        if (mental_1 > 50)
            mental_1 = 50;
        else if (mental_2 > 50)
            mental_2 = 50;
        else if (mental_3 > 50)
            mental_3 = 50;
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
}
