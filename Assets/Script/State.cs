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

    private void Start()
    {
        friendship_1 = 60;
        friendship_2 = 40;
        friendship_3 = 80;
        mental_1 = 70;
        mental_2 = 30;
        mental_3 = 70;
        join_student = 1; //0으로 수정
    }
    private void Update()
    {
        Limit_sensor();
    }
    public void Friendship_add(int value)
    {
        switch(join_student)
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
}
