using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Talk : MonoBehaviour
{
    public int tiara;
    public int stan;
    public int olivia;

    private bool first;
    public Camera main_camera;
    public Camera total_camera;
    public TextMesh talk;
    public TextMesh mytalk;
    public TextMesh choose_1;
    public TextMesh choose_2;
    public TextMesh choose_3;
    private bool choose;
    private bool value;
    private bool value2;
    private int choose_num;
    private void Start()
    {
        first = true;
        tiara = 0;
        stan = 0;
        olivia = 0;
        choose = false;
        value = false;
        value2 = true;
    }

    private void Update()
    {
        if (GetComponent<State>().choose_stu == false)
        {
            if (value2 && Input.GetMouseButtonDown(0))
            {
                value = true;
                if (choose == false)
                {
                    if (GetComponent<State>().join_student == 1)
                        tiara++;
                    else if (GetComponent<State>().join_student == 2)
                        stan++;
                    else if (GetComponent<State>().join_student == 3)
                        olivia++;
                }
                else
                {
                    RaycastHit hitInfo = new RaycastHit();
                    if (Input.GetMouseButtonDown(0))
                    {
                        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo))
                        {
                            switch (hitInfo.transform.tag)
                            {
                                case "choose_1":
                                    choose_num = 1;
                                    if (GetComponent<State>().join_student == 1)
                                        tiara++;
                                    else if (GetComponent<State>().join_student == 2)
                                        stan++;
                                    else if (GetComponent<State>().join_student == 3)
                                        olivia++;
                                    choose = false;
                                    break;
                                case "choose_2":
                                    choose_num = 2;
                                    if (GetComponent<State>().join_student == 1)
                                        tiara++;
                                    else if (GetComponent<State>().join_student == 2)
                                        stan++;
                                    else if (GetComponent<State>().join_student == 3)
                                        olivia++;
                                    choose = false;
                                    break;
                                case "choose_3":
                                    choose_num = 3;
                                    if (GetComponent<State>().join_student == 1)
                                        tiara++;
                                    else if (GetComponent<State>().join_student == 2)
                                        stan++;
                                    else if (GetComponent<State>().join_student == 3)
                                        olivia++;
                                    choose = false;
                                    break;
                            }
                        }
                    }
                }
            }
        }
        if(value)
        {
            value = false;
            if(GetComponent<State>().join_student == 1)
            {
                if (tiara == 1)
                {
                    talk.text = "";
                    mytalk.text = "";
                }
                if (tiara == 2)
                {
                    talk.text = "";
                    mytalk.text = "";
                }
                if (tiara == 3)
                {
                    talk.text = "";
                    mytalk.text = "";
                }
                if (tiara == 4)
                {
                    talk.text = "";
                    mytalk.text = "";
                }
                if (tiara == 5)
                {
                    talk.text = "";
                    mytalk.text = "";
                }
                if (tiara == 6)
                {
                    talk.text = "";
                    mytalk.text = "";
                }
                if (tiara == 7)
                {
                    talk.text = "";
                    mytalk.text = "";
                }
                if (tiara == 8)
                {
                    talk.text = "";
                    mytalk.text = "";
                }
                if (tiara == 9)
                {
                    talk.text = "";
                    mytalk.text = "";
                }
                if (tiara == 10)
                {
                    talk.text = "";
                    mytalk.text = "";
                }
                if (tiara == 11)
                {
                    talk.text = "";
                    mytalk.text = "";
                }
                if (tiara == 12)
                {
                    talk.text = "";
                    mytalk.text = "";
                }
                if (tiara == 13)
                {
                    talk.text = "";
                    mytalk.text = "";
                }
                if (tiara == 14)
                {
                    talk.text = "";
                    mytalk.text = "";
                }
                if (tiara == 15)
                {
                    talk.text = "";
                    mytalk.text = "";
                }
                if (tiara == 16)
                {
                    talk.text = "";
                    mytalk.text = "";
                }
                if (tiara == 17)
                {
                    talk.text = "";
                    mytalk.text = "";
                }
                if (tiara == 18)
                {
                    talk.text = "";
                    mytalk.text = "";
                }
                if (tiara == 19)
                {
                    talk.text = "";
                    mytalk.text = "";
                }
                if (tiara == 20)
                {
                    talk.text = "";
                    mytalk.text = "";
                }
                if (tiara == 21)
                {
                    talk.text = "";
                    mytalk.text = "";
                }
                if (tiara == 22)
                {
                    talk.text = "";
                    mytalk.text = "";
                }
                if (tiara == 23)
                {
                    talk.text = "";
                    mytalk.text = "";
                }
                if (tiara == 24)
                {
                    talk.text = "";
                    mytalk.text = "";
                }
                if (tiara == 25)
                {
                    talk.text = "";
                    mytalk.text = "";
                }
                if (tiara == 26)
                {
                    talk.text = "";
                    mytalk.text = "";
                }
                if (tiara == 27)
                {
                    talk.text = "";
                    mytalk.text = "";
                }
                if (tiara == 28)
                {
                    talk.text = "";
                    mytalk.text = "";
                }
                if (tiara == 29)
                {
                    talk.text = "";
                    mytalk.text = "";
                }
                if (tiara == 30)
                {
                    talk.text = "";
                    mytalk.text = "";
                }
                if (tiara == 31)
                {
                    talk.text = "";
                    mytalk.text = "";
                }
                if (tiara == 32)
                {
                    talk.text = "";
                    mytalk.text = "";
                }
                if (tiara == 33)
                {
                    talk.text = "";
                    mytalk.text = "";
                }
                if (tiara == 34)
                {
                    talk.text = "";
                    mytalk.text = "";
                }
                if (tiara == 35)
                {
                    talk.text = "";
                    mytalk.text = "";
                }
                if (tiara == 36)
                {
                    talk.text = "";
                    mytalk.text = "";
                }

            }
            else if(GetComponent<State>().join_student == 2)
            {

            }
            else if(GetComponent<State>().join_student == 3)
            {
                if (olivia == 1)
                {
                    talk.text = "�ȳ�, ����";
                    mytalk.text = "";
                }
                else if (olivia == 2)
                {
                    talk.text = "";
                    mytalk.text = "�ݸ� ����ϴ� �ž�?\n�׷��� �� �ȳ�, �ø����. �ݰ���.";
                }
                else if (olivia == 3)
                {
                    talk.text = "���뵵 �ƴϰ� �׷� �� ������ ��.";
                    mytalk.text = "";
                }
                else if (olivia == 4)
                {
                    talk.text = "�׳����� �̰� ���� �� ����?\n������ ���̴µ�.";
                    mytalk.text = "";
                }
                else if (olivia == 5)
                {
                    talk.text = "";
                    mytalk.text = "������ζ�� ������ �� 4�� ��� �� �ž�.\n��������? �׷� ��� �����Ұ�! ��..";
                }
                else if (olivia == 6)
                {
                    mytalk.text = "";
                    choose_1.text = "1. �� ���� ����?";
                    choose_2.text = "2. ������ �� �ϰ� ���´�?";
                    choose_3.text = "3. �̸��� ���� ��O���� ��������.";
                    choose = true;
                }
                else if (olivia == 7)
                {
                    mytalk.text = "";
                    choose_1.text = "";
                    choose_2.text = "";
                    choose_3.text = "";
                    if (choose_num == 1)
                    {
                        GetComponent<State>().Mental_add(-5);
                        talk.text = "����? ���� �����ϱ� ���� �� ���ݾ�\n��... �׳� ��� �;��µ�.";
                    }
                    else if (choose_num == 2)
                    {
                        GetComponent<State>().Friendship_add(5);
                        talk.text = "�ֵ��̶� �뷡�� ���� ��� �Ծ�.\n���� �뷡�� ���� ���� �� �߰ŵ�.";
                    }
                    else if (choose_num == 3)
                    {
                        GetComponent<State>().Mental_add(-25);
                        talk.text = "����� �ž�. ���� �׷� �� �����?";
                    }
                }
                else if (olivia == 8)
                {
                    talk.text = "";
                    if (choose_num == 1)
                        mytalk.text = "���� ĭ�� ���� �� ���� �ִ���.\n���� �ƹ��ų� ���ϴ� �� ���� ���� ������.";
                    else if (choose_num == 2)
                        mytalk.text = "��, �׷� ���� ���̶� ���õ� �ŷ���?\n�ƹ��ų� ���غ�.";
                    else if (choose_num == 3)
                        mytalk.text = "�̾�. �峭 �� �� �þ�.";
                }
                else if (olivia == 9)
                {
                    mytalk.text = "";
                    if (choose_num == 1 || choose_num == 2)
                        talk.text = "��? �� �� �ߴϱ�.";
                    else if (choose_num == 3)
                    {
                        talk.text = "��.... ¥�� ����. ��� �� ��.";
                        value2 = false;
                        Invoke("End_talk", 2.5f);
                    }
                }
                else if (olivia == 10)
                {
                    talk.text = "";
                    mytalk.text = "������. ���ϴ� �� ���η� ��� �� ���� ������.";
                    GetComponent<State>().Friendship_add(5);
                }
                else if (olivia == 11)
                {
                    mytalk.text = "";
                    talk.text = "�ű�� �����ϱ⵵ �ϴϱ�?\n�׳� �ƹ� ���̳� �� �� ������ ���� ������ �� ����.";
                }
                else if (olivia == 12)
                {
                    talk.text = "";
                    mytalk.text = "�ܹ��� ���ϴ� �� ã�ҳ�. ���� ���̾�.";
                }
                else if (olivia == 13)
                {
                    mytalk.text = "";
                    choose_1.text = "1. �׷��� ���� ��. 3�г��ε� ���� ���θ� ��. ������ ���.";
                    choose_2.text = "2. �׷��� �̷�� ���� ��ü���� ��ȹ�� ¥�� �� ����?";
                    choose_3.text = "3. �׷��� ���� ��㿡 ��� ���� �̷��� ��ȹ�غ���?";
                    choose = true;
                }
                else if (olivia == 14)
                {
                    mytalk.text = "";
                    choose_1.text = "";
                    choose_2.text = "";
                    choose_3.text = "";
                    if (choose_num == 1)
                    {
                        GetComponent<State>().Mental_add(-25);
                        talk.text = "¥������. �ⲯ �� �����.";
                        value2 = false;
                        Invoke("End_talk", 2.5f);
                    }
                    else if (choose_num == 2)
                    {
                        GetComponent<State>().Mental_add(-5);
                        talk.text = "��������. ��... �˰ھ�. �̸� �� ����.";
                        olivia = 16;
                        value2 = false;
                        Invoke("End_talk", 2.5f);
                    }
                    else if (choose_num == 3)
                    {
                        GetComponent<State>().Friendship_add(5);
                        talk.text = "��, �˰ھ�. ���������� ����� ���� �ǳ�?";
                    }
                }
                else if (olivia == 15)
                {
                    talk.text = "";
                    mytalk.text = "�¾�. �׸��� ���� ��� ������ �ؿ� �� �ϳ� �־�.\n���� ���� �ϱ� �� ȥ�ڼ� �����ϰԶ� ���� �̷�� ���� ��ȹ�� ¥ ����.";
                }
                else if (olivia == 16)
                {
                    mytalk.text = "";
                    talk.text = "��û �����ص� ������? �׷� �̸� ��¥ �� ����.";
                    value2 = false;
                    Invoke("End_talk", 2.5f);
                }
                else if (olivia == 17)
                {
                    mytalk.text = "�ݰ���. ��ȹ�� ¥ �Ծ�, �ø����?";
                }
                else if (olivia == 18)
                {
                    mytalk.text = "";
                    if (GetComponent<State>().friendship_3 >= 30)
                        talk.text = "���ϱ� �������� ���� �����Ѵٴ���. \n�ű� �����ϴ� �� ��� ������?";
                    else
                        talk.text = "��, ��Ծ���. ����� �� ¥ �Ծ�.";
                }
                else if (olivia == 19)
                {
                    talk.text = "";
                    if (GetComponent<State>().friendship_3 >= 30)
                    {
                        mytalk.text = "��. Ŀ��� ���� �� �ְڴ�. ���� ��ȹ�ε�.";
                        GetComponent<State>().Friendship_add(5);
                    }
                    else
                        mytalk.text = "�׷�����. ���� ���� �� �ôµ� �̹� �������� ����\n�����ϴ���. �ű� �����ϴ� �� �?";
                }
                else if (olivia == 20)
                {
                    if (GetComponent<State>().friendship_3 >= 30)
                        olivia++;
                    else
                    {
                        mytalk.text = "";
                        talk.text = "��... ��հڳ�. ���� �� ����.";
                    }
                }
                if (olivia == 21)
                {
                    mytalk.text = "";
                    talk.text = "�ٵ� �� ���� ��. ���� �� �� �� ������?";
                }
                else if (olivia == 22)
                {
                    talk.text = "";
                    choose_1.text = "1. ��⸦ ��! ������ �б� �����ϴ� �� �ôµ� ���ϴ���.";
                    choose_2.text = "2. ������ ������. ���� ���� �ƴϴϱ�.";
                    choose_3.text = "3. �� �и� �հ��� �� ������.";
                    choose = true;
                }
                else if (olivia == 23)
                {
                    mytalk.text = "";
                    choose_1.text = "";
                    choose_2.text = "";
                    choose_3.text = "";
                    if (choose_num == 1)
                    {
                        GetComponent<State>().Mental_add(5);
                        talk.text = "���� �����ϴ� �� �þ���?";
                    }
                    else if (choose_num == 2)
                    {
                        GetComponent<State>().Mental_add(3);
                        GetComponent<State>().Friendship_add(-5);
                        talk.text = "����. �� �� �� �ְŵ�? ���� �װ͵� �� �ұ� ��?";
                    }
                    else if (choose_num == 3)
                    {
                        GetComponent<State>().Mental_add(-10);
                        GetComponent<State>().Friendship_add(5);
                        talk.text = "�翬����! �� ���� �� �ص� ���� �� ������.\n���� ��� ���� �հ� �ҽ� ��� �ð�.";
                        value2 = false;
                        olivia = 25;
                        Invoke("End_talk", 2.5f);
                    }
                }
                else if (olivia == 24)
                {
                    talk.text = "";
                    if (choose_num == 1)
                        mytalk.text = "�װ� �� ��ٰ� ��������ϱ� �ñ��ؼ�.\n���� ���� �����.";
                    else if (choose_num == 2)
                        mytalk.text = "����ģ �ڽŰ��� ���� �ʾ�. ��յ� �ʿ���.";
                }
                else if (olivia == 25)
                {
                    mytalk.text = "";
                    if (choose_num == 1)
                    {
                        talk.text = "��, ��ڳ�. ������ ��� ���� ��� ��� ���ƿð�!";
                        value2 = false;
                        Invoke("End_talk", 2.5f);
                    }
                    else if (choose_num == 2)
                    {
                        talk.text = "�ƾ�. ������ �̸� �� ����.";
                        value2 = false;
                        Invoke("End_talk", 2.5f);
                    }
                }
                else if (olivia == 26)
                {
                    if (GetComponent<State>().mental_3 >= 30)
                        talk.text = "�� ���� ���ݾ�, �پ���! �������.\n�� ���� �� �� �� ������?";
                    else
                        talk.text = "������. �� ��������. ���� �� ��.\n���� ���� �� �� �� �ִ� �� �´� �ɱ�?";
                }
                else if (olivia == 27)
                {
                    talk.text = "";
                    choose_1.text = "1. �� �� �־�.";
                    choose_2.text = "2. �� �� �� ����.";
                    choose_3.text = "3. ���� ����.";
                    choose = true;
                }
                else if (olivia == 28)
                {
                    choose_1.text = "";
                    choose_2.text = "";
                    choose_3.text = "";
                    if (choose_num == 1)
                    {
                        GetComponent<State>().Friendship_add(4);
                        GetComponent<State>().Mental_add(-4);
                        mytalk.text = "�翬����! �� �и� �ְ��� ���� �� �ž�.";
                    }
                    else if (choose_num == 2)
                    {
                        GetComponent<State>().Mental_add(-30);
                        mytalk.text = "��? ���� �Ҹ� �ϴ� �ž�. ���������� ������.\n�� ���� 3�г��ε� �����ؾ���. ���� ���� ���� �� ������ ǰ�� �־���?";
                    }
                    else if (choose_num == 3)
                    {
                        GetComponent<State>().Mental_add(5);
                        GetComponent<State>().Friendship_add(-5);
                        mytalk.text = "���� ����? Ȯ���� �� �� ����. �׷��� �� �ǰ��� ���� ���غ���.\n�װ� ������ ����Ѵٸ� �и� �س� �� ���� �Ŷ�� ������.";
                    }
                }
                else if (olivia == 29)
                {
                    mytalk.text = "";
                    if (choose_num == 1)
                        talk.text = "...����. ���п� ���δ� Ȯ���� ���� �� ����. ";
                    else if (choose_num == 2)
                    {
                        talk.text = "...��? �׷� ���� ���ݱ��� ���� ���� �� ������\n�ƴ϶�����̿���? ���̰� ����.\n�б����� �߸��� ��� ������ ��ƶ�.";
                        value2 = false;
                        olivia = 31;
                        Invoke("End_talk", 2.5f);
                    }
                    else if (choose_num == 3)
                        talk.text = "�װ� �ᱹ ����϶�� �Ҹ���?\n��¥ ¥�����µ�, Ʋ�� ���� �ƴϱ� ��. ";
                }
                else if (olivia == 30)
                {
                    talk.text = "";
                    if (choose_num == 1)
                        mytalk.text = "�װ� �����̳�.\n�´�, ���߿� ���� ���������� ���� �� ����.";
                    else if (choose_num == 3)
                        mytalk.text = "�׷�. � ���̵� ����� �ʼ����̴ϱ�.";
                }
                else if (olivia == 31)
                {
                    mytalk.text = "";
                    if (choose_num == 1)
                        talk.text = "�װ� ��... ����� ����.\n��, ���� ����� �־���.�� �̸� ����!";
                    else if (choose_num == 3)
                        talk.text = "����� �˰� �־�. �� �´�.\n���� ģ���� �� �����ϱ�� ��� ��Ҿ��µ�.\n�� �̸� ������! ";
                    value2 = false;
                    Invoke("End_talk", 2.5f);
                }
                else if (olivia == 32)
                {
                    if (GetComponent<State>().mental_3 >= 36 && GetComponent<State>().friendship_3 >= 36)
                        olivia = 38;
                    else
                        talk.text = "�̰� ������ ����ΰ�?";
                }
                else if (olivia == 33)
                {
                    talk.text = "";
                    mytalk.text = "�׷���. �ð� �� ����.";
                }
                else if (olivia == 34)
                {
                    talk.text = "���ݾ�. �� ���� ���� �Ƿ���. ��� ��������\n���� ���� ������ �Ծ���.";
                    mytalk.text = "";
                }
                else if (olivia == 35)
                    talk.text = "���� ���� �� �� ���� �����غ� �� �����µ� �ű��ϴ�.\n���ϵ� ����� �ִ�.";
                else if (olivia == 36)
                {
                    talk.text = "";
                    mytalk.text = "����? ���� ���� �� ������ ������� �ʹ�\n�̸��� �ʳ�. ������ ����� �߾�?";
                }
                else if (olivia == 37)
                {
                    talk.text = "����. �λ��� �����̾�. ��� �ܼҸ� �� �Ÿ� ������\n�� �ְ�. ����ϸ� �� ���߷� �ð�!";
                    mytalk.text = "";
                    GetComponent<State>().olivia_ending = 2;
                    value2 = false;
                    Invoke("End_talk", 2.5f);
                }
                else if (olivia == 38)
                    talk.text = "�̰� ������ ����ΰ�?";
                else if (olivia == 39)
                {
                    talk.text = "";
                    mytalk.text = "�׷���. �ð� �� ����.";
                }
                else if (olivia == 40)
                {
                    talk.text = "��, ������ ������ ���� �Ǳ� ���ؼ� ����Ϸ���.";
                    mytalk.text = "";
                }
                else if (olivia == 41)
                    talk.text = "�� ������ �ޱ�� �߾�!\n��� �ٷ� ������� ���� ������ �߾��µ�.";
                else if (olivia == 42)
                    talk.text = "�����ϸ� �Ҽ��� �� ����\n������ ���� �������?";
                else if (olivia == 43)
                    talk.text = "�̷��� ������ �ϴ� ���� ������ �� �ְ���.";
                else if (olivia == 44)
                {
                    talk.text = "";
                    mytalk.text = "���ִ� ���������̾�. �����ε� �׷��Ը� �ϸ� �ǰڴ� ��.\n�׸��� ���� �Ŀ� �� ����ǿ� ����������...";
                }
                else if (olivia == 45)
                    mytalk.text = "�ʹ� ������� ��. ����� �ݵ�� ������� �����ϱ�,\n�� ���� ���� �� ��.";
                else if (olivia == 44)
                {
                    mytalk.text = "";
                    talk.text = "�׷�. ���������� ¥�� ���� ���̱� �ص�\n������ �� ������ �鸮��. ���� ����.";
                    GetComponent<State>().olivia_ending = 3;
                    value2 = false;
                    Invoke("End_talk", 2.5f);
                }
            }
        }
    }
    private void End_talk()
    {
        talk.text = "";
        mytalk.text = "";
        choose_1.text = "";
        choose_2.text = "";
        choose_3.text = "";
        if (first && GetComponent<State>().join_student == 1)
            GetComponent<State>().Human_2();
        else if (first && GetComponent<State>().join_student == 2)
            GetComponent<State>().Human_3();
        else
        {
            value2 = true;
            first = false;
            GetComponent<State>().Date_add();
            GetComponent<State>().choose_stu = true;
            Go_total();
        }
    }
    private void Go_total()
    {
        total_camera.GetComponent<Total>().All_out();
        total_camera.gameObject.SetActive(true);
        main_camera.gameObject.SetActive(false);
    }
}
