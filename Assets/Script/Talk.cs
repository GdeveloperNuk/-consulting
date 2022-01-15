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
                    talk.text = "안녕, 선생";
                    mytalk.text = "";
                }
                else if (olivia == 2)
                {
                    talk.text = "";
                    mytalk.text = "반말 사용하는 거야?\n그래도 뭐 안녕, 올리비아. 반가워.";
                }
                else if (olivia == 3)
                {
                    talk.text = "꼰대도 아니고 그런 거 따지지 마.";
                    mytalk.text = "";
                }
                else if (olivia == 4)
                {
                    talk.text = "그나저나 이거 오래 안 하지?\n지루해 보이는데.";
                    mytalk.text = "";
                }
                else if (olivia == 5)
                {
                    talk.text = "";
                    mytalk.text = "예정대로라면 앞으로 총 4번 상담 할 거야.\n적당하지? 그럼 상담 시작할게! 음..";
                }
                else if (olivia == 6)
                {
                    mytalk.text = "";
                    choose_1.text = "1. 넌 꿈이 뭐니?";
                    choose_2.text = "2. 오늘은 뭘 하고 지냈니?";
                    choose_3.text = "3. 이름을 보니 올O비영이 생각나네.";
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
                        talk.text = "몰라? 꿈이 없으니까 여기 온 거잖아\n하... 그냥 놀고 싶었는데.";
                    }
                    else if (choose_num == 2)
                    {
                        GetComponent<State>().Friendship_add(5);
                        talk.text = "애들이랑 노래방 가서 놀다 왔어.\n내가 노래는 몰라도 춤은 좀 추거든.";
                    }
                    else if (choose_num == 3)
                    {
                        GetComponent<State>().Mental_add(-25);
                        talk.text = "뭐라는 거야. 무슨 그런 걸 물어봐?";
                    }
                }
                else if (olivia == 8)
                {
                    talk.text = "";
                    if (choose_num == 1)
                        mytalk.text = "진로 칸에 꿈이 안 적혀 있더라.\n정말 아무거나 원하는 걸 말해 봐도 괜찮아.";
                    else if (choose_num == 2)
                        mytalk.text = "오, 그럼 꿈은 춤이랑 관련된 거려나?\n아무거나 말해봐.";
                    else if (choose_num == 3)
                        mytalk.text = "미안. 장난 좀 쳐 봤어.";
                }
                else if (olivia == 9)
                {
                    mytalk.text = "";
                    if (choose_num == 1 || choose_num == 2)
                        talk.text = "댄서? 춤 잘 추니까.";
                    else if (choose_num == 3)
                    {
                        talk.text = "하.... 짜증 나네. 상담 안 해.";
                        value2 = false;
                        Invoke("End_talk", 2.5f);
                    }
                }
                else if (olivia == 10)
                {
                    talk.text = "";
                    mytalk.text = "멋진데. 잘하는 걸 진로로 잡는 건 좋은 일이지.";
                    GetComponent<State>().Friendship_add(5);
                }
                else if (olivia == 11)
                {
                    mytalk.text = "";
                    talk.text = "거기다 좋아하기도 하니깐?\n그냥 아무 말이나 해 본 거지만 나름 괜찮은 거 같네.";
                }
                else if (olivia == 12)
                {
                    talk.text = "";
                    mytalk.text = "단번에 원하는 걸 찾았네. 좋은 일이야.";
                }
                else if (olivia == 13)
                {
                    mytalk.text = "";
                    choose_1.text = "1. 그래도 댄서는 좀. 3학년인데 이젠 공부를 해. 적당히 놀고.";
                    choose_2.text = "2. 그러면 이루기 위한 구체적인 계획을 짜서 와 볼래?";
                    choose_3.text = "3. 그러면 다음 상담에 어떻게 꿈을 이룰지 계획해볼까?";
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
                        talk.text = "짜증나네. 기껏 와 줬더니.";
                        value2 = false;
                        Invoke("End_talk", 2.5f);
                    }
                    else if (choose_num == 2)
                    {
                        GetComponent<State>().Mental_add(-5);
                        talk.text = "귀찮은데. 하... 알겠어. 이만 가 볼게.";
                        olivia = 16;
                        value2 = false;
                        Invoke("End_talk", 2.5f);
                    }
                    else if (choose_num == 3)
                    {
                        GetComponent<State>().Friendship_add(5);
                        talk.text = "뭐, 알겠어. 다음번에도 여기로 오면 되나?";
                    }
                }
                else if (olivia == 15)
                {
                    talk.text = "";
                    mytalk.text = "맞아. 그리고 다음 상담 전까지 해올 게 하나 있어.\n나랑 토의 하기 전 혼자서 간단하게라도 꿈을 이루기 위한 계획을 짜 와줘.";
                }
                else if (olivia == 16)
                {
                    mytalk.text = "";
                    talk.text = "엄청 간단해도 괜찮지? 그럼 이만 진짜 가 볼게.";
                    value2 = false;
                    Invoke("End_talk", 2.5f);
                }
                else if (olivia == 17)
                {
                    mytalk.text = "반가워. 계획은 짜 왔어, 올리비아?";
                }
                else if (olivia == 18)
                {
                    mytalk.text = "";
                    if (GetComponent<State>().friendship_3 >= 30)
                        talk.text = "보니까 축제에서 댄서를 모집한다던데. \n거기 참가하는 거 어떻게 생각해?";
                    else
                        talk.text = "아, 까먹었네. 노느라 안 짜 왔어.";
                }
                else if (olivia == 19)
                {
                    talk.text = "";
                    if (GetComponent<State>().friendship_3 >= 30)
                    {
                        mytalk.text = "오. 커리어를 쌓을 수 있겠다. 멋진 계획인데.";
                        GetComponent<State>().Friendship_add(5);
                    }
                    else
                        mytalk.text = "그렇구나. 내가 조사 해 봤는데 이번 축제에서 댄서를\n모집하더라. 거기 참가하는 게 어때?";
                }
                else if (olivia == 20)
                {
                    if (GetComponent<State>().friendship_3 >= 30)
                        olivia++;
                    else
                    {
                        mytalk.text = "";
                        talk.text = "음... 재밌겠네. 참가 해 볼까.";
                    }
                }
                if (olivia == 21)
                {
                    mytalk.text = "";
                    talk.text = "근데 좀 걱정 돼. 내가 잘 할 수 있을까?";
                }
                else if (olivia == 22)
                {
                    talk.text = "";
                    choose_1.text = "1. 용기를 내! 저번에 학교 공연하는 거 봤는데 잘하던데.";
                    choose_2.text = "2. 걱정될 만하지. 쉬운 일이 아니니까.";
                    choose_3.text = "3. 넌 분명 합격할 수 있을걸.";
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
                        talk.text = "내가 공연하는 거 봤었어?";
                    }
                    else if (choose_num == 2)
                    {
                        GetComponent<State>().Mental_add(3);
                        GetComponent<State>().Friendship_add(-5);
                        talk.text = "뭐래. 잘 할 수 있거든? 내가 그것도 못 할까 봐?";
                    }
                    else if (choose_num == 3)
                    {
                        GetComponent<State>().Mental_add(-10);
                        GetComponent<State>().Friendship_add(5);
                        talk.text = "당연하지! 난 연습 안 해도 붙을 수 있을걸.\n다음 상담 때는 합격 소식 들고 올게.";
                        value2 = false;
                        olivia = 25;
                        Invoke("End_talk", 2.5f);
                    }
                }
                else if (olivia == 24)
                {
                    talk.text = "";
                    if (choose_num == 1)
                        mytalk.text = "네가 잘 춘다고 얘기했으니까 궁금해서.\n보고 정말 놀랐어.";
                    else if (choose_num == 2)
                        mytalk.text = "지나친 자신감은 좋지 않아. 겸손도 필요해.";
                }
                else if (olivia == 25)
                {
                    mytalk.text = "";
                    if (choose_num == 1)
                    {
                        talk.text = "흠, 기쁘네. 다음번 상담 때는 결과 들고 돌아올게!";
                        value2 = false;
                        Invoke("End_talk", 2.5f);
                    }
                    else if (choose_num == 2)
                    {
                        talk.text = "됐어. 오늘은 이만 가 볼게.";
                        value2 = false;
                        Invoke("End_talk", 2.5f);
                    }
                }
                else if (olivia == 26)
                {
                    if (GetComponent<State>().mental_3 >= 30)
                        talk.text = "그 축제 있잖아, 붙었어! 대박이지.\n나 정말 댄서 할 수 있을까?";
                    else
                        talk.text = "선생님. 나 떨어졌어. 말도 안 돼.\n내가 정말 댄서 할 수 있는 게 맞는 걸까?";
                }
                else if (olivia == 27)
                {
                    talk.text = "";
                    choose_1.text = "1. 할 수 있어.";
                    choose_2.text = "2. 넌 할 수 없어.";
                    choose_3.text = "3. 나도 모르지.";
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
                        mytalk.text = "당연하지! 넌 분명 최고의 댄서가 될 거야.";
                    }
                    else if (choose_num == 2)
                    {
                        GetComponent<State>().Mental_add(-30);
                        mytalk.text = "응? 무슨 소릴 하는 거야. 현실적으로 생각해.\n넌 벌써 3학년인데 공부해야지. 설마 정말 댄서가 될 생각을 품고 있었어?";
                    }
                    else if (choose_num == 3)
                    {
                        GetComponent<State>().Mental_add(5);
                        GetComponent<State>().Friendship_add(-5);
                        mytalk.text = "나도 몰라? 확답은 할 수 없어. 그래도 내 의견을 더해 말해볼게.\n네가 끝까지 노력한다면 분명 해낼 수 있을 거라고 생각해.";
                    }
                }
                else if (olivia == 29)
                {
                    mytalk.text = "";
                    if (choose_num == 1)
                        talk.text = "...고마워. 덕분에 진로는 확실히 정한 것 같아. ";
                    else if (choose_num == 2)
                    {
                        talk.text = "...뭐? 그럼 설마 지금까지 해준 말은 다 진심이\n아니라거짓이였어? 어이가 없네.\n학교에서 잘리고 평생 거지로 살아라.";
                        value2 = false;
                        olivia = 31;
                        Invoke("End_talk", 2.5f);
                    }
                    else if (choose_num == 3)
                        talk.text = "그거 결국 노력하라는 소리지?\n진짜 짜증나는데, 틀린 말은 아니긴 해. ";
                }
                else if (olivia == 30)
                {
                    talk.text = "";
                    if (choose_num == 1)
                        mytalk.text = "그거 다행이네.\n맞다, 나중에 댄서로 유명해지면 사인 좀 해줘.";
                    else if (choose_num == 3)
                        mytalk.text = "그래. 어떤 일이든 노력은 필수적이니깐.";
                }
                else if (olivia == 31)
                {
                    mytalk.text = "";
                    if (choose_num == 1)
                        talk.text = "그건 뭐... 고민해 볼게.\n아, 오늘 약속이 있었지.나 이만 간다!";
                    else if (choose_num == 3)
                        talk.text = "충분히 알고 있어. 헉 맞다.\n오늘 친구랑 춤 연습하기로 약속 잡았었는데.\n나 이만 가볼게! ";
                    value2 = false;
                    Invoke("End_talk", 2.5f);
                }
                else if (olivia == 32)
                {
                    if (GetComponent<State>().mental_3 >= 36 && GetComponent<State>().friendship_3 >= 36)
                        olivia = 38;
                    else
                        talk.text = "이게 마지막 상담인가?";
                }
                else if (olivia == 33)
                {
                    talk.text = "";
                    mytalk.text = "그렇네. 시간 참 빨라.";
                }
                else if (olivia == 34)
                {
                    talk.text = "있잖아. 나 역시 댄서가 되려고. 상담 덕분인진\n몰라도 마음 완전히 먹었어.";
                    mytalk.text = "";
                }
                else if (olivia == 35)
                    talk.text = "진로 같은 거 한 번도 생각해본 적 없었는데 신기하다.\n내일도 오디션 있다.";
                else if (olivia == 36)
                {
                    talk.text = "";
                    mytalk.text = "벌써? 꿈을 정한 건 좋지만 오디션은 너무\n이르지 않나. 연습은 충분히 했어?";
                }
                else if (olivia == 37)
                {
                    talk.text = "뭐래. 인생은 실전이야. 계쏙 잔소리 할 거면 가본다\n잘 있고. 취업하면 얼굴 비추러 올게!";
                    mytalk.text = "";
                    GetComponent<State>().olivia_ending = 2;
                    value2 = false;
                    Invoke("End_talk", 2.5f);
                }
                else if (olivia == 38)
                    talk.text = "이게 마지막 상담인가?";
                else if (olivia == 39)
                {
                    talk.text = "";
                    mytalk.text = "그렇네. 시간 참 빨라.";
                }
                else if (olivia == 40)
                {
                    talk.text = "나, 앞으로 유명한 댄서가 되기 위해서 노력하려고.";
                    mytalk.text = "";
                }
                else if (olivia == 41)
                    talk.text = "춤 레슨도 받기로 했어!\n사실 바로 오디션을 볼까 생각도 했었는데.";
                else if (olivia == 42)
                    talk.text = "연습하면 할수록 난 아직\n부족한 점이 많더라고?";
                else if (olivia == 43)
                    talk.text = "이렇게 꾸준히 하다 보면 성공할 수 있겠지.";
                else if (olivia == 44)
                {
                    talk.text = "";
                    mytalk.text = "멋있는 마음가짐이야. 앞으로도 그렇게만 하면 되겠는 걸.\n그리고 만약 후에 본 오디션에 떨어지더라도...";
                }
                else if (olivia == 45)
                    mytalk.text = "너무 상심하지 마. 노력은 반드시 배신하지 않으니까,\n꼭 빛을 보게 될 걸.";
                else if (olivia == 44)
                {
                    mytalk.text = "";
                    talk.text = "그래. 원래였으면 짜증 났을 말이긴 해도\n오늘은 좀 괜찮게 들리네. 응원 고마워.";
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
