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
                if (stan == 1)
                    mytalk.text = "�ȳ�, �ݰ���.";
                else if (stan == 2)
                    mytalk.text = "���� ���ǿ� �౸�ΰ� �� ���� ������.";
                else if (stan == 3)
                    mytalk.text = "���� �౸������ ���� �Ŷ� ���� �߰ŵ�.\n�ƹ����� �ʿ��� ����� �� ���� �� ������.";
                else if (stan == 4)
                {
                    talk.text = "����. �¾ƿ�. ���� ĭ�� �ƹ��͵�\n�� ���� ȥ�� �����Ÿ�����";
                    mytalk.text = "";
                }
                else if (stan == 5)
                    talk.text = "�������� �о���� �͵� ������ ����̶��\n������ �� �� �þ��.";
                else if (stan == 6)
                {
                    talk.text = "";
                    mytalk.text = "���� ���������̾�. �׷� �������� ����?\n���� ����̱淡 �׷�?";
                }
                else if (stan == 7)
                {
                    talk.text = "�� �׷��ϱ�, �౸ ���̿���.";
                    mytalk.text = "";
                }
                else if (stan == 8)
                    talk.text = "����ؼ� �ϴ� �� �´� �ɱ��?";
                else if (stan == 9)
                {
                    talk.text = "";
                    mytalk.text = "��...";
                }
                else if (stan == 10)
                    mytalk.text = "��! ���� �౸�� �ǿ��� ���ų� ��̰� ���ٴ�\n���� �ƴϿ���. �̰� ����� �ؾ� ����.";
                else if (stan == 11)
                {
                    mytalk.text = "";
                    choose_1.text = "1. �׳� �����ϰ� �ϰ� ���� �ʴٰ� ��.";
                    choose_2.text = "2. �������� ����� �ռ��� �ű���?";
                    choose = true;
                }
                else if (stan == 12)
                {
                    choose_1.text = "";
                    choose_2.text = "";
                    if (choose_num == 1)
                    {
                        GetComponent<State>().Mental_add(-15);
                        talk.text = "...�װ� �ʹ� �Ժη� �����Ͻô� �� �ƴѰ���?";
                    }
                    else if (choose_num > 1)
                    {
                        GetComponent<State>().Friendship_add(5);
                        talk.text = "�¾ƿ�. �׵� �׷� �� ��\n���� 3�г� ���ݾƿ�";
                    }
                }
                else if (stan == 13)
                {
                    if (choose_num == 1)
                    {
                        talk.text = "ū ��⸦ ���� �� �ǵ�...\n�� �̸� �����Կ�.";
                        value2 = false;
                        Invoke("End_talk", 2.5f);
                    }
                    else if (choose_num > 1)
                        talk.text = "� ��ó�� �ܼ��� �౸�� �����ϰ�,\n����Ѵ� �ؼ� �Ǵ� ���� �ƴ� �� ���ƿ�.";
                }
                else if (stan == 14)
                    talk.text = "��ü���� ���� ����̶��� ���ݾƿ�.\n�׵��� �����ؿ����� ���� ����";
                else if (stan == 15)
                    talk.text = "�� �Ѱ谡 �巯���� ����̿���.";
                else if (stan == 16)
                {
                    talk.text = "";
                    mytalk.text = "Ȯ���� �������� ����̳�.\n��... �׷��ٸ� �̰� �ϳ��� ���� ��.";
                }
                else if (stan == 17)
                {
                    mytalk.text = "";
                    choose_1.text = "1. ���� �౸�� ��վ�?";
                    choose_2.text = "2. �౸�� ����� �� ������ �ִ� �Ŵ�?";
                    choose_3.text = "3. �� �Ƿ��� ��� ���� �ȴٰ� �����ϴ�?";
                    choose = true;

                }
                else if (stan == 18)
                {
                    choose_1.text = "";
                    choose_2.text = "";
                    choose_3.text = "";
                    if (choose_num == 1)
                        talk.text = "...������ �����ڸ� ������\n���� ��̰� �������� �ʾƿ�.";
                    else if (choose_num == 2)
                    {
                        GetComponent<State>().Mental_add(-5);
                        talk.text = "...������ �� �𸣰ھ��. �� ���� ſ�� �ɱ��?\n���� ���Ҹ� ���� ���� �� ������.";
                    }
                    else if (choose_num == 3)
                    {
                        GetComponent<State>().Mental_add(-5);
                        talk.text = "...�׳� ���? �� �� ������ �� ���ƿ�.\n��𿡵� �ִ� Ư���� �� ���� ������.";
                    }
                }
                else if (stan == 19)
                {
                    if (choose_num == 1)
                        talk.text = "������ ������ ���ؼ� ���� ����ϴ�\n�����鳢���� ������ �ؾ� ���ݾƿ�?";
                    else if (choose_num == 2)
                        stan++;
                    else if (choose_num == 3)
                        talk.text = "���� ���ҿ� ���� �ο���\n�󱼸� ���� �ڽŰ��� �������.";
                }
                if (stan == 20)
                    talk.text = "���������� �̷� ��Ȱ��\n�����ؾ� �ϴ� �ɱ��?";
                else if(stan == 21)
                {
                    talk.text = "";
                    mytalk.text = "���� ������ ����̰ڳ�. �׷��� ���� ��,\n�װ� ��� �౸�� ������ ������ ���ϰ�";
                }
                else if (stan == 22)
                    mytalk.text = "�δ㰨�� �����ٸ� �׸��δ� �͵� �ϳ��� ����̾�.";
                else if (stan == 23)
                {
                    talk.text = "�ƴ�. ������ �׸����� ���ϰھ��.\n�׸� �� ���� ����.";
                    mytalk.text = "";
                }
                else if (stan == 24)
                    talk.text = "�׷��� 6�� ���� �� � ġ�⸸ �ϰ�\n�޹ٶ��� �� �� �θ���� ���� �ǰھ��.";
                else if (stan == 25)
                    talk.text = "�θ�Ե��� ���� ���� ���� ������ �Ǹ���\n�Ͼ� �ǽ�ġ �����ðŵ��.";
                if (stan == 26)
                {
                    talk.text = "";
                    choose_1.text = "1. �θ���� ������Ű�� �ʰ� ���� �ű���?";
                    choose_2.text = "2. �θ���� �ʿ� ���� ������ ������ �δ� �� �ű���.";
                    choose_3.text = "3. �װ� �׷�. �θ���� �Ǹ��ϰ� �ؼ� �� ����.";
                    choose = true;
                }
                else if (stan == 27)
                {
                    choose_1.text = "";
                    choose_2.text = "";
                    choose_3.text = "";
                    if (choose_num == 1)
                    {
                        GetComponent<State>().Mental_add(5);
                        talk.text = "�¾ƿ�. �� �׳� ���� �� ��ġ��,������\nôô �س��� �Ƶ��� �� �� ������ ���ھ��.";
                    }
                    else if (choose_num == 2)
                    {
                        GetComponent<State>().Friendship_add(5);
                        talk.text = "...�¾ƿ�, �̱����� ������ �� ������\n�׷� ������ ����.";
                    }
                    else if (choose_num == 3)
                    {
                        GetComponent<State>().Mental_add(-5);
                        talk.text = "���� �׷� �Ű���? ...��,\n�� �Ӹ��� �ʹ� ����ؼ� ������ �̸� �����Կ�.";
                    }
                }
                else if (stan == 28)
                {
                    if (choose_num == 1)
                    {
                        talk.text = "";
                        mytalk.text = "������ ���� ��. �Ϻ��� �Ƶ��̶� �������� �ʾ�.\n��� �ʿ� ���� ����� �ϰ� ����.";
                    }
                    else if (choose_num == 2)
                    {
                        talk.text = "�ڲ�, ���� �θ���� �� ������ٸ�\n�ٸ� ģ����� ���� ����� ���� ���� �ʾ�����?";
                    }
                    else if (choose_num == 3)
                    {
                        talk.text = "�˼��մϴ�.";
                        stan = 34;
                        value2 = false;
                        Invoke("End_talk", 2.5f);
                    }
                }
                else if (stan == 29)
                {
                    if (choose_num == 1)
                        mytalk.text = "����� �Ϻ��� �� ���ŵ�. ���� �ʴ� ��ü���̶��\nȮ���� �ٸ� ���� �Ȱ� �ֱ⿡ ����� ��\n�ε巯 �� �ž�.";
                    else if (choose_num == 2)
                    {
                        talk.text = "";
                        mytalk.text = "������ ���� ��. ����� ���̶� �������� �ʾ�.\n�ʿ� ���� ����� �ϸ� �ٸ� ���� ��ô�ϰ� �־�.";
                    }
                }
                else if (stan == 30)
                {
                    if (choose_num == 1)
                    {
                        mytalk.text = "";
                        talk.text = "...�׷� �ǰ���. �׷��⿡ �ٵ� �� �����\n�ذ��� ����� ã�ƾ� �ϴ� �Ű���.";
                    }
                    else if (choose_num == 2)
                        mytalk.text = "���� �ʴ� ��ü���̶�� Ȯ����\n�ٸ� ���� �Ȱ� �ֱ⿡ ����� �� �ε巯�� ����.";
                }
                else if (stan == 31)
                {
                    if (choose_num == 1)
                        talk.text = "���п� ������ �� ����.";
                    else if (choose_num == 2)
                    {
                        mytalk.text = "";
                        talk.text = "...�׷� �ǰ���? �׷��⿡ �ٵ� �� �����\n�ذ��� ����� ã�ƾ� �ϴ� �Ű���.";
                    }
                }
                else if (stan == 32)
                {
                    if (choose_num == 1)
                    {
                        talk.text = "";
                        mytalk.text = "�׷��ٸ� �����̳�. �Ӹ��� ���� ���� �� ������\n������ �׸� ���� �� �?";
                    }

                    else if (choose_num == 2)
                        talk.text = "���п� ������ �� ����.";
                }
                else if (stan == 33)
                {
                    talk.text = "";
                    mytalk.text = "��� �ڸ鼭 ������ ������ ��.\n����� � ������� Ǯ�� ������.";
                }
                else if (stan == 34)
                {
                    mytalk.text = "";
                    talk.text = "�׷��߰ھ��. �׷� �̸� �����Կ�.\n������ �Ŀ�!";
                    value2 = false;
                    Invoke("End_talk", 2.5f);
                }
                else if (stan == 35)
                    talk.text = "������ �� �غþ��. ��¼�� ����ó��\n�̷��� ��ư��� �͵� ������ ���� �������?";
                else if (stan == 36)
                    talk.text = "�λ��� ��Ե� ������ �ٵ��� ��.";
                else if(stan == 37)
                {
                    talk.text = "";
                    mytalk.text = "��... �ϳ� ������ �غ���";
                }
                else if (stan == 37)
                    mytalk.text = "���� �౸�� �׸� �ΰ� �ʹٴ� ������ ����\n���� ä ��ư��ٸ� �װ� �̷��� ���� �Ǿ� ���� �� ����?";
                else if (stan == 38)
                {
                    mytalk.text = "";
                    talk.text = "��, ��� ��� �������� �������̶�\n�� ���� ��Ȱ�� ���� �������?";
                }
                else if (stan == 39)
                {
                    talk.text = "";
                    choose_1.text = "1. ���� �װ� ���ϴ�?";
                    choose_2.text = "2. �װ͵� ������ ����.";
                    choose_3.text = "3. �־��ε�. ���� �׳� �౸�� �׸��ΰڴٰ� ����.";
                    choose = true;
                }
                else if(stan == 40)
                {
                    choose_1.text = "";
                    choose_2.text = "";
                    choose_3.text = "";
                    if (choose_num == 1)
                    {
                        GetComponent<State>().Mental_add(5);
                        talk.text = "...�ƴ�. ��� ����. �׷� ������.";
                    }
                    else if (choose_num == 2)
                    {
                        GetComponent<State>().Mental_add(-5);
                        mytalk.text = "�׷� �����̶� �θ�Բ� ����\n�׷��� ���ϰ� ��";
                    }
                    else if (choose_num == 3)
                    {
                        GetComponent<State>().Mental_add(-5);
                        talk.text = "...������?";
                    }
                }
                else if(stan == 41)
                {
                    mytalk.text = "";
                    talk.text = "� �����ο�? �� �̴�� �౸ �غ���\n�������� �λ��� �� �� ���ٰ��?";
                }
                else if(stan == 42)
                    talk.text = "�׷��� �౸ ���ϰڴٰ�? �θ�Բ��� 6�� ����\n��ħ ������� �Ĵ翡 ���� �� ������ ���� ������";
                else if(stan == 43)
                    talk.text = "������ �η� ��� �౸��\n���� �׸� �ϰڽ��ϴ�. ����?";
                else if(stan == 44)
                {
                    talk.text = "";
                    choose_1.text = "1. �̾�. ���� �߸� ���ߴ�. �װ� �� �׷��� �ϳ�.";
                    choose_2.text = "2. ���� ��. �� ���� ������ �θ��� �־�.";
                    choose_3.text = "3. �׷��ٸ� �ʴ� ���� ����� ���ϴ� �ž�?";
                    choose = true;
                }
                else if(stan == 45)
                {
                    choose_1.text = "";
                    choose_2.text = "";
                    choose_3.text = "";
                    if (choose_num == 1)
                    {
                        GetComponent<State>().Friendship_add(-5);
                        talk.text = "...������ ������ �� ȥ���������.";
                    }
                    else if (choose_num == 2)
                    {
                        GetComponent<State>().Mental_add(5);
                        talk.text = "��������? ���� �׷� ���� �ϼ���?";
                    }
                    else if (choose_num == 3)
                    {
                        GetComponent<State>().Mental_add(10);
                        talk.text = "...�׷��Կ�. �𸣰ڳ׿�.";
                    }
                }
                else if (stan == 46)
                {
                    if (choose_num == 1)
                    {
                        talk.text = "";
                        mytalk.text = "�ƴ�. �װ� �̰͵� �ȴ�. ���͵� �ȴ�\n�׷��ϱ� ���� �򰥸� ���ݾ�.";
                    }
                    else if (choose_num == 2)
                    {
                        talk.text = "";
                        mytalk.text = "���� �ʴ� �װ� ������ ������ �� ��\n��θ� �ź��ϰ� �ִ� ���ݾ�.";
                    }
                    else if (choose_num == 3)
                        talk.text = "��� ���� ���� ��� ������\n�θ��� �ִٴ� �� �˰� �־��.";
                }
                else if (stan == 47)
                {
                    if (choose_num == 1)
                    {
                        talk.text = "�װ� ���� �ſ�?";
                        mytalk.text = "";
                    }
                    else if (choose_num == 2)
                        mytalk.text = "�׷��鼭 ȭ�� ����.\n�װ� �����ۿ� �� ���� �ʾ�.";
                    else if (choose_num == 3)
                    {
                        talk.text = "";
                        mytalk.text = "...���� ��. �������� ���ϰڴٸ� �ൿ���� �ϴ� �� �?";
                    }
                }
                else if (stan == 48)
                {
                    if (choose_num == 1)
                    {
                        talk.text = "";
                        mytalk.text = "��... �ƹ�ư, �װ� �� �߿��� ��������\n���ϰڴٸ� �� �� �ִ� �� �ϳ����̳�.";
                    }
                    else if (choose_num == 2)
                    {
                        mytalk.text = "";
                        talk.text = "...�װ�...";
                    }
                    else if (choose_num == 3)
                        mytalk.text = "�� ����� �ذ��ϱ� ���ؼ� �ᱹ �� �ؾ��ϴ� �ൿ�� ���ݾ�.";
                }
                else if (stan == 49)
                {
                    if (choose_num == 1 || choose_num == 3)
                        stan++;
                    else if (choose_num == 2)
                    {
                        mytalk.text = "��, �ᱹ ����� �ϳ��ݾ�.";
                        talk.text = "";
                    }
                }
                if (stan == 50)
                {
                    talk.text = "";
                    mytalk.text = "�θ�Բ� �����ϰ� �� ��ο� ���� ����� ��.";
                }
                else if(stan == 51)
                {
                    talk.text = "�ᱹ �� ����ۿ� ���� �ǰ���?";
                    mytalk.text = "";
                }
                else if (stan == 52)
                {
                    talk.text = "";
                    mytalk.text = "�׷�. ���� ��� ������ �ؿ�. �߿��� ���̴ϱ�.\n�ʹ� ����� �׳� �͵� ��.";
                }
                else if(stan == 53)
                    mytalk.text = "�׷��� �������� �ؾ� �ϴ� ������.";
                else if(stan == 54)
                {
                    talk.text = "...�˰ھ��. ������ ������.";
                    mytalk.text = "";
                    value2 = false;
                    Invoke("End_talk", 2.5f);
                }
                if (stan == 55)
                {
                    talk.text = "";
                    mytalk.text = "�ȳ� ���� ��. ������ �� �Ծ�?";
                }
                else if (stan == 56)
                {
                    talk.text = "��� ���� ���߾��. �̹� ��㿡�� �� ������ \n�����̶� Ȯ���� �ϰ� �;.";
                    mytalk.text = "";
                }
                else if (stan == 57)
                {
                    talk.text = "";
                    mytalk.text = "�׷� ������� ���߾�. ������ ���� ������ �߳�.";
                    GetComponent<State>().Friendship_add(5);
                }
                else if (stan == 58)
                {
                    talk.text = "����������. � ������ �´ٰ� �����ϼ���?";
                    mytalk.text = "";
                }
                else if (stan == 59)
                {
                    talk.text = "";
                    choose_1.text = "1. ���� ������ �� ���� �� ������.";
                    choose_2.text = "2. ��� �౸�ϴ� ��.";
                    choose_3.text = "3. �����̶� �����ϴ� ��.";
                    choose = true;
                }
                else if (stan == 60)
                {
                    mytalk.text = "";
                    choose_1.text = "";
                    choose_2.text = "";
                    choose_3.text = "";
                    if (choose_num == 1)
                    {
                        GetComponent<State>().Mental_add(5);
                        GetComponent<State>().Friendship_add(5);
                        talk.text = "����?";
                    }
                    else if (choose_num == 2)
                    {
                        GetComponent<State>().Friendship_add(5);
                        talk.text = "�װ� �´ٰ� �����ϴ� �ſ���?";
                    }
                    else if (choose_num == 3)
                    {
                        GetComponent<State>().Mental_add(-5);
                        talk.text = "�װ� �´ٰ� �����ϴ� �ſ���?";
                    }

                }
                else if (stan == 61)
                {
                    talk.text = "";
                    if (choose_num == 1)
                        mytalk.text = "�� �λ��� ���� ���� ������ �� �� ����. \n��ư����� ��¿ �� ����. �׾� �λ��� �¿��ϴ� ���ε�.";
                    else if (choose_num == 2)
                        mytalk.text = "��. ���� �����غ� ��� �װ� ���ϴ� �� �װŶ�� �����߰ŵ�.";
                    else if (choose_num == 3)
                        mytalk.text = "������ �����ڸ�. �� �ְ����� �ǰ��� �ʿ��ϴٴ� �� ���Ƽ�. ���� �� ������ ���̾�.";
                }
                else if (stan == 62)
                {
                    mytalk.text = "";
                    if (choose_num == 1)
                        talk.text = "�׷�����.";
                    else if (choose_num == 2)
                    {
                        talk.text = "�׷�����. \n������ �亯�� ��� ��û �ȵ��ƴ� �� ���� �׷�������. \n���� ������ �ϰ� �;��. ������ �̸� �����Կ�!";
                        stan = 10;
                        value2 = false;
                        Invoke("End_talk", 2.5f);

                    }
                    else if (choose_num == 3)
                    {
                        talk.text = "�׷�����. \n�׷� ���� ȥ�� ������ �ð��� �ʿ��� �� ���ƿ�. \n������ �̸� �����Կ�.";
                        stan = 10;
                        value2 = false;
                        Invoke("End_talk", 2.5f);

                    }
                }
                else if (stan == 63)
                {
                    talk.text = "";
                    mytalk.text = "�׳� �װ� �ϰ� ���� �� ��. \n�� �����ϴ� �� �ϴ� ��� ������ �λ��� ��� �ص� �ᱹ ��Ʈ���� ��û ���� ��.";
                }
                else if (stan == 64)
                {
                    talk.text = "�׷�����. ���� �� �� �� �� �ϳ׿�. \n�ƹ�ư ������. \n������ ����ζ�� ȥ�� ������ �ð��� �ʿ��ϰھ��. �̸� �����Կ�!";
                    mytalk.text = "";
                    value2 = false;
                    Invoke("End_talk", 2.5f);
                }
                else if (stan == 65)
                {
                    talk.text = "��, ���� ���ϰ� �Ծ��.";
                    mytalk.text = "";
                }
                else if (stan == 66)
                {
                    talk.text = "";
                    mytalk.text = "������. ������ ������ ������ Ȯ�������� ��?";
                }
                else if (stan == 67)
                {
                    mytalk.text = "";
                    if (GetComponent<State>().friendship_2 <= 20 || GetComponent<State>().mental_2 <= 20)
                    {
                        talk.text = "�װ� �ƴϰ�... �� �̻� ��� �����ϰ� ���� �ʾҾ��. �Ӹ� ���°ɿ�.";
                    }
                    else if (GetComponent<State>().friendship_2 < 30 || GetComponent<State>().mental_2 < 40)
                    {
                        talk.text = "��. ���� �´´ٰ� ������ �� �����߾��.";
                    }
                    else if (GetComponent<State>().friendship_2 >= 30 || GetComponent<State>().mental_2 >= 40)
                    {
                        talk.text = "��. ���� ������ ����� ����ޱ�.... \n�ᱹ ���� ���ϴ� �� �����߾��.";
                    }
                }
                else if (stan == 68)
                {
                    talk.text = "";
                    if (GetComponent<State>().friendship_2 <= 20 || GetComponent<State>().mental_2 <= 20)
                    {
                        mytalk.text = "�׷� �����ڱ���� ���� �ʾ�";
                    }
                    else if (GetComponent<State>().friendship_2 < 30 || GetComponent<State>().mental_2 < 40)
                    {
                        mytalk.text = "���� ������� �ɱ�.";
                    }
                    else if (GetComponent<State>().friendship_2 >= 30 || GetComponent<State>().mental_2 >= 40)
                    {
                        mytalk.text = "���ϴ� �Ŷ�. ����. ";
                    }
                }
                else if (stan == 69)
                {
                    mytalk.text = "";
                    if (GetComponent<State>().friendship_2 <= 20 || GetComponent<State>().mental_2 <= 20)
                    {
                        talk.text = "�� �׳� �̰� ���ؿ�. �̹� ��㿡 �� �͵� ���������� �� ���� ���Ϸ��� �� �ſ����. \n�׷��� �� ������ ������ ������ �� ���Ƽ�. ����� ��� ���� �ʳ׿�. �׷� �̸�.";
                        GetComponent<State>().stan_ending = 1;
                        value2 = false;
                        Invoke("End_talk", 2.5f);
                    }
                    else if (GetComponent<State>().friendship_2 < 30 || GetComponent<State>().mental_2 < 40)
                    {
                        talk.text = "�� ��. �ʹ� �ʾ������� ������, \n������ø� ���� ���� ���̿���. \n�౸�� ��̷� �����.";
                    }
                    else if (GetComponent<State>().friendship_2 >= 30 || GetComponent<State>().mental_2 >= 40)
                    {
                        talk.text = "�θ���� ���� ���� �����ϼ̴��� �ñ����� ��������?";
                    }
                }
                else if (stan == 70)
                {
                    talk.text = "";
                    if (GetComponent<State>().friendship_2 < 30 || GetComponent<State>().mental_2 < 40)
                    {
                        mytalk.text = "�� ���� �����߱���. ��, ������ ����.";
                    }
                    else if (GetComponent<State>().friendship_2 >= 30 || GetComponent<State>().mental_2 >= 40)
                    {
                        mytalk.text = "��. �װ� ���ϴ� �Ŷ��. �׷� �װ� �´� �Ű���.";
                        GetComponent<State>().stan_ending = 3;
                        value2 = false;
                        Invoke("End_talk", 2.5f);
                    }
                }
                else if (stan == 71)
                {
                    talk.text = "��. ������ ������ ������ �Ŵϱ��.";
                    mytalk.text = "";
                    GetComponent<State>().stan_ending = 2;
                    value2 = false;
                    Invoke("End_talk", 2.5f);
                }
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
                else if (olivia == 46)
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
        value2 = true;
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
