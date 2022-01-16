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
    public GameObject move_camera;
    public Camera main_camera;
    public GameObject human1;
    public GameObject human2;
    public GameObject human3;
    public Camera ending_camera;


    public bool choose_stu;
    public int tiara_ending;
    public int stan_ending;
    public int olivia_ending;
    private bool first;
    public int year;
    public int month;
    private void Start()
    {
        first = true;
        friendship_1 = 30;
        friendship_2 = 15;
        friendship_3 = 20;
        mental_1 = 30;
        mental_2 = 25;
        mental_3 = 35;
        join_student = 1;
        year = 2022;
        month = 3;
        txt.text = year + "Y " + month + "M";
    }
    private void Update()
    {
        if (olivia_ending != 1 && (friendship_3 <= 20 || mental_3 <= 20))
            olivia_ending = 1;
        Limit_sensor();
        if (first)
        {
            Human_1();
            first = false;
            choose_stu = false;
        }
        else
        {
            if (choose_stu)
            {
                if ((friendship_1 <= 10 || mental_1 <= 10) && (friendship_2 <= 10 || mental_2 <= 10) && (friendship_3 <= 10 || mental_3 <= 10))
                    End_s();
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
                                if(friendship_1 > 10 && mental_1 > 10)
                                {
                                    join_student = 1;
                                    choose_stu = false;
                                    name_txt.text = "오늘의 상담\n티아라 카터";
                                    human1.SetActive(true);
                                    human2.SetActive(false);
                                    human3.SetActive(false);
                                    move_camera.GetComponent<Move_camera>().Move_camera_();
                                }
                                else
                                    name_txt.text = "티아라 카터가\n상담을 거부합니다.";
                                break;
                            case "stan":
                                if (friendship_2 > 10 && mental_2 > 10)
                                {
                                    join_student = 2;
                                    choose_stu = false;
                                    name_txt.text = "오늘의 상담\n스텐 리";
                                    human1.SetActive(false);
                                    human2.SetActive(true);
                                    human3.SetActive(false);
                                    move_camera.GetComponent<Move_camera>().Move_camera_();
                                }
                                else if(GetComponent<Talk>().stan > 65)
                                    name_txt.text = "스탠 리은\n상담이 필요 없습니다.";
                                else
                                    name_txt.text = "스텐 리가\n상담을 거부합니다.";
                                break;
                            case "olibia":
                                if (friendship_3 > 10 && mental_3 > 10)
                                {
                                    join_student = 3;
                                    choose_stu = false;
                                    name_txt.text = "오늘의 상담\n올리비아 영";
                                    human1.SetActive(false);
                                    human2.SetActive(false);
                                    human3.SetActive(true);
                                    move_camera.GetComponent<Move_camera>().Move_camera_();
                                }
                                else if(GetComponent<Talk>().olivia > 30)
                                    name_txt.text = "올리비아 영은\n상담이 필요 없습니다.";
                                else
                                    name_txt.text = "올리비아 영이\n상담을 거부합니다.";
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
    }
    private void End_s()
    {
        ending_camera.gameObject.SetActive(true);
        main_camera.gameObject.SetActive(false);
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
    public void Human_1()
    {
        human1.gameObject.SetActive(true);
        human2.gameObject.SetActive(false);
        human3.gameObject.SetActive(false);
        join_student = 1;
    }
    public void Human_2()
    {
        human1.gameObject.SetActive(false);
        human2.gameObject.SetActive(true);
        human3.gameObject.SetActive(false);
        join_student = 2;
    }
    public void Human_3()
    {
        human1.gameObject.SetActive(false);
        human2.gameObject.SetActive(false);
        human3.gameObject.SetActive(true);
        join_student = 3;
    }
}
