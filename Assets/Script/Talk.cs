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
                    mytalk.text = "안녕, 반가워.";
                else if (stan == 2)
                    mytalk.text = "진로 상담실에 축구부가 올 줄은 몰랐네.";
                else if (stan == 3)
                    mytalk.text = "전부 축구선수가 꿈일 거라 생각 했거든.\n아무래도 너에게 고민이 꽤 많은 것 같은데.";
                else if (stan == 4)
                {
                    talk.text = "하하. 맞아요. 진로 칸에 아무것도\n못 적고 혼자 끙끙거리느니";
                    mytalk.text = "";
                }
                else if (stan == 5)
                    talk.text = "누구에게 털어놓는 것도 괜찮은 방법이라는\n생각이 들어서 와 봤어요.";
                else if (stan == 6)
                {
                    talk.text = "";
                    mytalk.text = "좋은 마음가짐이야. 그럼 본론으로 들어갈까?\n무슨 고민이길래 그래?";
                }
                else if (stan == 7)
                {
                    talk.text = "음 그러니까, 축구 말이에요.";
                    mytalk.text = "";
                }
                else if (stan == 8)
                    talk.text = "계속해서 하는 게 맞는 걸까요?";
                else if (stan == 9)
                {
                    talk.text = "";
                    mytalk.text = "음...";
                }
                else if (stan == 10)
                    mytalk.text = "아! 물론 축구에 의욕이 없거나 재미가 없다는\n말은 아니에요. 이걸 뭐라고 해야 하지.";
                else if (stan == 11)
                {
                    mytalk.text = "";
                    choose_1.text = "1. 그냥 솔직하게 하고 싶지 않다고 해.";
                    choose_2.text = "2. 현실적인 고민이 앞서는 거구나?";
                    choose = true;
                }
                else if (stan == 12)
                {
                    choose_1.text = "";
                    choose_2.text = "";
                    if (choose_num == 1)
                    {
                        GetComponent<State>().Mental_add(-15);
                        talk.text = "...그건 너무 함부러 말씀하시는 거 아닌가요?";
                    }
                    else if (choose_num > 1)
                    {
                        GetComponent<State>().Friendship_add(5);
                        talk.text = "맞아요. 그도 그럴 게 전\n벌써 3학년 이잖아요";
                    }
                }
                else if (stan == 13)
                {
                    if (choose_num == 1)
                    {
                        talk.text = "큰 용기를 내서 온 건데...\n전 이만 가볼게요.";
                        value2 = false;
                        Invoke("End_talk", 2.5f);
                    }
                    else if (choose_num > 1)
                        talk.text = "어릴 때처럼 단순히 축구를 애정하고,\n사랑한다 해서 되는 일이 아닌 것 같아요.";
                }
                else if (stan == 14)
                    talk.text = "예체능은 원래 재능이라고들 하잖아요.\n그동안 무시해왔지만 이제 슬슬";
                else if (stan == 15)
                    talk.text = "제 한계가 드러나는 기분이에요.";
                else if (stan == 16)
                {
                    talk.text = "";
                    mytalk.text = "확실히 현실적인 고민이네.\n음... 그렇다면 이거 하나만 말해 봐.";
                }
                else if (stan == 17)
                {
                    mytalk.text = "";
                    choose_1.text = "1. 요즘도 축구가 재밌어?";
                    choose_2.text = "2. 축구를 제대로 할 생각은 있는 거니?";
                    choose_3.text = "3. 네 실력이 어느 정도 된다고 생각하니?";
                    choose = true;

                }
                else if (stan == 18)
                {
                    choose_1.text = "";
                    choose_2.text = "";
                    choose_3.text = "";
                    if (choose_num == 1)
                        talk.text = "...솔직히 말하자면 예정과\n같은 재미가 느껴지지 않아요.";
                    else if (choose_num == 2)
                    {
                        GetComponent<State>().Mental_add(-5);
                        talk.text = "...솔직히 잘 모르겠어요. 제 의지 탓일 걸까요?\n이젠 숙소만 들어가도 숨이 턱 막혀요.";
                    }
                    else if (choose_num == 3)
                    {
                        GetComponent<State>().Mental_add(-5);
                        talk.text = "...그냥 평균? 딱 그 정도인 것 같아요.\n어디에든 있는 특별할 것 없는 선수죠.";
                    }
                }
                else if (stan == 19)
                {
                    if (choose_num == 1)
                        talk.text = "이제는 진학을 위해서 같이 경기하던\n선수들끼리도 경쟁을 해야 하잖아요?";
                    else if (choose_num == 2)
                        stan++;
                    else if (choose_num == 3)
                        talk.text = "이젠 숙소에 들어가서 부원들\n얼굴만 봐도 자신감이 사라져요.";
                }
                if (stan == 20)
                    talk.text = "언제까지고 이런 생활을\n지속해야 하는 걸까요?";
                else if(stan == 21)
                {
                    talk.text = "";
                    mytalk.text = "정말 막막한 기분이겠네. 그래도 스탠 리,\n네가 계속 축구에 만족을 느끼지 못하고";
                }
                else if (stan == 22)
                    mytalk.text = "부담감만 느낀다면 그만두는 것도 하나의 방법이야.";
                else if (stan == 23)
                {
                    talk.text = "아뇨. 솔직히 그만두진 못하겠어요.\n그만 둘 수가 없죠.";
                    mytalk.text = "";
                }
                else if (stan == 24)
                    talk.text = "그러면 6년 동안 제 어린 치기만 믿고\n뒷바라지 해 준 부모님은 뭐가 되겠어요.";
                else if (stan == 25)
                    talk.text = "부모님들은 제가 좋은 프로 선수가 되리라\n믿어 의심치 않으시거든요.";
                if (stan == 26)
                {
                    talk.text = "";
                    choose_1.text = "1. 부모님을 걱정시키지 않고 싶은 거구나?";
                    choose_2.text = "2. 부모님의 너에 대한 믿음이 오히려 부담 된 거구나.";
                    choose_3.text = "3. 그건 그래. 부모님을 실망하게 해선 안 되지.";
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
                        talk.text = "맞아요. 전 그냥 걱정 안 끼치고,뭐든지\n척척 해내는 아들이 될 수 있으면 좋겠어요.";
                    }
                    else if (choose_num == 2)
                    {
                        GetComponent<State>().Friendship_add(5);
                        talk.text = "...맞아요, 이기적인 마음인 거 알지만\n그런 생각이 들어요.";
                    }
                    else if (choose_num == 3)
                    {
                        GetComponent<State>().Mental_add(-5);
                        talk.text = "역시 그런 거겠죠? ...후,\n저 머리가 너무 답답해서 오늘은 이만 가볼게요.";
                    }
                }
                else if (stan == 28)
                {
                    if (choose_num == 1)
                    {
                        talk.text = "";
                        mytalk.text = "하지만 스탠 리. 완벽한 아들이란 존재하지 않아.\n모두 너와 같은 고민을 하고 있지.";
                    }
                    else if (choose_num == 2)
                    {
                        talk.text = "자꾸, 차라리 부모님이 날 막아줬다면\n다른 친구들과 같이 평범한 길을 걷지 않았을까?";
                    }
                    else if (choose_num == 3)
                    {
                        talk.text = "죄송합니다.";
                        stan = 34;
                        value2 = false;
                        Invoke("End_talk", 2.5f);
                    }
                }
                else if (stan == 29)
                {
                    if (choose_num == 1)
                        mytalk.text = "사람은 완벽할 수 없거든. 그저 너는 예체능이라는\n확연한 다른 길을 걷고 있기에 고민이 더\n두드러 진 거야.";
                    else if (choose_num == 2)
                    {
                        talk.text = "";
                        mytalk.text = "하지만 스탠 리. 평범한 길이란 존재하지 않아.\n너와 같은 고민을 하며 다른 길을 개척하고 있어.";
                    }
                }
                else if (stan == 30)
                {
                    if (choose_num == 1)
                    {
                        mytalk.text = "";
                        talk.text = "...그런 건가요. 그렇기에 다들 이 고민을\n해결할 방법을 찾아야 하는 거겠죠.";
                    }
                    else if (choose_num == 2)
                        mytalk.text = "그저 너는 예체능이라는 확연히\n다른 길을 걷고 있기에 고민이 더 두드러진 거지.";
                }
                else if (stan == 31)
                {
                    if (choose_num == 1)
                        talk.text = "덕분에 정신이 좀 들어요.";
                    else if (choose_num == 2)
                    {
                        mytalk.text = "";
                        talk.text = "...그런 건가요? 그렇기에 다들 이 고민을\n해결할 방법을 찾아야 하는 거겠죠.";
                    }
                }
                else if (stan == 32)
                {
                    if (choose_num == 1)
                    {
                        talk.text = "";
                        mytalk.text = "그렇다면 다행이네. 머리가 많이 아플 것 같은데\n오늘은 그만 쉬는 게 어때?";
                    }

                    else if (choose_num == 2)
                        talk.text = "덕분에 정신이 좀 들어요.";
                }
                else if (stan == 33)
                {
                    talk.text = "";
                    mytalk.text = "대신 자면서 찬찬히 생각해 봐.\n고민을 어떤 방식으로 풀고 싶은지.";
                }
                else if (stan == 34)
                {
                    mytalk.text = "";
                    talk.text = "그래야겠어요. 그럼 이만 가볼게요.\n다음에 봬요!";
                    value2 = false;
                    Invoke("End_talk", 2.5f);
                }
                else if (stan == 35)
                    talk.text = "생각을 좀 해봤어요. 어쩌면 지금처럼\n이렇게 살아가는 것도 나쁘지 않지 않을까요?";
                else if (stan == 36)
                    talk.text = "인생은 어떻게든 굴러갈 텐데요 뭐.";
                else if(stan == 37)
                {
                    talk.text = "";
                    mytalk.text = "음... 하나 가정을 해보자";
                }
                else if (stan == 37)
                    mytalk.text = "만약 축구를 그만 두고 싶다는 본심을 꼭꼭\n감춘 채 살아간다면 네가 미래에 뭐가 되어 있을 것 같아?";
                else if (stan == 38)
                {
                    mytalk.text = "";
                    talk.text = "뭐, 어딘가 어디 어쭙잖은 지역팀이라도\n들어가 선수 생활을 하지 않을까요?";
                }
                else if (stan == 39)
                {
                    talk.text = "";
                    choose_1.text = "1. 정말 그걸 원하니?";
                    choose_2.text = "2. 그것도 나쁘지 않지.";
                    choose_3.text = "3. 최악인데. 차라리 그냥 축구를 그만두겠다고 말해.";
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
                        talk.text = "...아뇨. 사실 전혀. 그럴 리가요.";
                    }
                    else if (choose_num == 2)
                    {
                        GetComponent<State>().Mental_add(-5);
                        mytalk.text = "그럼 지금이라도 부모님께 가서\n그렇게 말하고 와";
                    }
                    else if (choose_num == 3)
                    {
                        GetComponent<State>().Mental_add(-5);
                        talk.text = "...뭐라고요?";
                    }
                }
                else if(stan == 41)
                {
                    mytalk.text = "";
                    talk.text = "어떤 식으로요? 난 이대로 축구 해봤자\n어쭙잖은 인생만 살 것 같다고요?";
                }
                else if(stan == 42)
                    talk.text = "그러니 축구 못하겠다고? 부모님께서 6년 동안\n아침 일찍부터 식당에 나가 뼈 빠지게 모은 돈으로";
                else if(stan == 43)
                    talk.text = "억지를 부려 배운 축구를\n이제 그만 하겠습니다. 라고요?";
                else if(stan == 44)
                {
                    talk.text = "";
                    choose_1.text = "1. 미안. 내가 잘못 말했다. 그건 좀 그렇긴 하네.";
                    choose_2.text = "2. 스탠 리. 넌 지금 억지를 부리고 있어.";
                    choose_3.text = "3. 그렇다면 너는 무슨 방법을 원하는 거야?";
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
                        talk.text = "...선생님 때문에 더 혼란스러운데요.";
                    }
                    else if (choose_num == 2)
                    {
                        GetComponent<State>().Mental_add(5);
                        talk.text = "억지라고요? 무슨 그런 말을 하세요?";
                    }
                    else if (choose_num == 3)
                    {
                        GetComponent<State>().Mental_add(10);
                        talk.text = "...그러게요. 모르겠네요.";
                    }
                }
                else if (stan == 46)
                {
                    if (choose_num == 1)
                    {
                        talk.text = "";
                        mytalk.text = "아니. 네가 이것도 싫다. 저것도 싫다\n그러니깐 나도 헷갈린 거잖아.";
                    }
                    else if (choose_num == 2)
                    {
                        talk.text = "";
                        mytalk.text = "지금 너는 네가 제시한 선택지 두 개\n모두를 거부하고 있는 거잖아.";
                    }
                    else if (choose_num == 3)
                        talk.text = "사실 저도 제가 계속 억지를\n부리고 있다는 거 알고 있어요.";
                }
                else if (stan == 47)
                {
                    if (choose_num == 1)
                    {
                        talk.text = "그게 말이 돼요?";
                        mytalk.text = "";
                    }
                    else if (choose_num == 2)
                        mytalk.text = "그러면서 화만 내고.\n그건 억지밖에 더 되지 않아.";
                    else if (choose_num == 3)
                    {
                        talk.text = "";
                        mytalk.text = "...스탠 리. 결정하지 못하겠다면 행동부터 하는 건 어때?";
                    }
                }
                else if (stan == 48)
                {
                    if (choose_num == 1)
                    {
                        talk.text = "";
                        mytalk.text = "흠... 아무튼, 네가 둘 중에서 선택하지\n못하겠다면 할 수 있는 건 하나뿐이네.";
                    }
                    else if (choose_num == 2)
                    {
                        mytalk.text = "";
                        talk.text = "...그건...";
                    }
                    else if (choose_num == 3)
                        mytalk.text = "네 고민을 해결하기 위해선 결국 꼭 해야하는 행동이 있잖아.";
                }
                else if (stan == 49)
                {
                    if (choose_num == 1 || choose_num == 3)
                        stan++;
                    else if (choose_num == 2)
                    {
                        mytalk.text = "뭐, 결국 방법은 하나잖아.";
                        talk.text = "";
                    }
                }
                if (stan == 50)
                {
                    talk.text = "";
                    mytalk.text = "부모님께 진지하게 네 고민에 관해 얘기해 봐.";
                }
                else if(stan == 51)
                {
                    talk.text = "결국 그 방법밖에 없는 건가요?";
                    mytalk.text = "";
                }
                else if (stan == 52)
                {
                    talk.text = "";
                    mytalk.text = "그래. 다음 상담 때까지 해와. 중요한 일이니까.\n너무 힘들면 그냥 와도 돼.";
                }
                else if(stan == 53)
                    mytalk.text = "그래도 언젠가는 해야 하는 거지만.";
                else if(stan == 54)
                {
                    talk.text = "...알겠어요. 고마워요 선생님.";
                    mytalk.text = "";
                    value2 = false;
                    Invoke("End_talk", 2.5f);
                }
                if (stan == 55)
                {
                    talk.text = "";
                    mytalk.text = "안녕 스탠 리. 숙제는 해 왔어?";
                }
                else if (stan == 56)
                {
                    talk.text = "사실 아직 못했어요. 이번 상담에서 제 생각을 \n조금이라도 확고히 하고 싶어서.";
                    mytalk.text = "";
                }
                else if (stan == 57)
                {
                    talk.text = "";
                    mytalk.text = "그런 이유라면 잘했어. 나쁘지 않은 선택을 했네.";
                    GetComponent<State>().Friendship_add(5);
                }
                else if (stan == 58)
                {
                    talk.text = "선생님은…. 어떤 선택이 맞다고 생각하세요?";
                    mytalk.text = "";
                }
                else if (stan == 59)
                {
                    talk.text = "";
                    choose_1.text = "1. 내가 결정할 순 없을 것 같은데.";
                    choose_2.text = "2. 계속 축구하는 거.";
                    choose_3.text = "3. 지금이라도 공부하는 거.";
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
                        talk.text = "왜죠?";
                    }
                    else if (choose_num == 2)
                    {
                        GetComponent<State>().Friendship_add(5);
                        talk.text = "그게 맞다고 생각하는 거에요?";
                    }
                    else if (choose_num == 3)
                    {
                        GetComponent<State>().Mental_add(-5);
                        talk.text = "그게 맞다고 생각하는 거에요?";
                    }

                }
                else if (stan == 61)
                {
                    talk.text = "";
                    if (choose_num == 1)
                        mytalk.text = "네 인생에 남인 내가 정답을 줄 순 없지. \n어렵겠지만 어쩔 수 없어. 그야 인생을 좌우하는 일인데.";
                    else if (choose_num == 2)
                        mytalk.text = "음. 내가 유추해본 결과 네가 원하는 게 그거라고 생각했거든.";
                    else if (choose_num == 3)
                        mytalk.text = "솔직히 말하자면. 내 주관적인 의견이 필요하다는 것 같아서. 물론 내 생각일 뿐이야.";
                }
                else if (stan == 62)
                {
                    mytalk.text = "";
                    if (choose_num == 1)
                        talk.text = "그래도요.";
                    else if (choose_num == 2)
                    {
                        talk.text = "그렇군요. \n선생님 답변을 듣고 엄청 안도됐던 걸 보면 그럴지도요. \n생각 정리를 하고 싶어요. 오늘은 이만 가볼게요!";
                        stan = 10;
                        value2 = false;
                        Invoke("End_talk", 2.5f);

                    }
                    else if (choose_num == 3)
                    {
                        talk.text = "그렇군요. \n그럼 이제 혼자 생각할 시간이 필요할 것 같아요. \n오늘은 이만 가볼게요.";
                        stan = 10;
                        value2 = false;
                        Invoke("End_talk", 2.5f);

                    }
                }
                else if (stan == 63)
                {
                    talk.text = "";
                    mytalk.text = "그냥 네가 하고 싶은 걸 해. \n안 좋아하는 거 하는 대신 성공한 인생을 산다 해도 결국 스트레스 엄청 받을 걸.";
                }
                else if (stan == 64)
                {
                    talk.text = "그렇군요. 뭔가 알 듯 말 듯 하네요. \n아무튼 고마워요. \n선생님 말대로라면 혼자 생각할 시간이 필요하겠어요. 이만 가볼게요!";
                    mytalk.text = "";
                    value2 = false;
                    Invoke("End_talk", 2.5f);
                }
                else if (stan == 65)
                {
                    talk.text = "저, 드디어 말하고 왔어요.";
                    mytalk.text = "";
                }
                else if (stan == 66)
                {
                    talk.text = "";
                    mytalk.text = "멋지네. 다행히 저번에 생각이 확고해졌나 봐?";
                }
                else if (stan == 67)
                {
                    mytalk.text = "";
                    if (GetComponent<State>().friendship_2 <= 20 || GetComponent<State>().mental_2 <= 20)
                    {
                        talk.text = "그건 아니고... 더 이상 깊게 생각하고 싶지 않았어요. 머리 아픈걸요.";
                    }
                    else if (GetComponent<State>().friendship_2 < 30 || GetComponent<State>().mental_2 < 40)
                    {
                        talk.text = "네. 제가 맞는다고 생각한 걸 선택했어요.";
                    }
                    else if (GetComponent<State>().friendship_2 >= 30 || GetComponent<State>().mental_2 >= 40)
                    {
                        talk.text = "네. 뭔가 성장한 기분이 들었달까.... \n결국 제가 원하는 걸 선택했어요.";
                    }
                }
                else if (stan == 68)
                {
                    talk.text = "";
                    if (GetComponent<State>().friendship_2 <= 20 || GetComponent<State>().mental_2 <= 20)
                    {
                        mytalk.text = "그런 자포자기식은 좋지 않아";
                    }
                    else if (GetComponent<State>().friendship_2 < 30 || GetComponent<State>().mental_2 < 40)
                    {
                        mytalk.text = "뭔지 물어봐도 될까.";
                    }
                    else if (GetComponent<State>().friendship_2 >= 30 || GetComponent<State>().mental_2 >= 40)
                    {
                        mytalk.text = "원하는 거라. 좋네. ";
                    }
                }
                else if (stan == 69)
                {
                    mytalk.text = "";
                    if (GetComponent<State>().friendship_2 <= 20 || GetComponent<State>().mental_2 <= 20)
                    {
                        talk.text = "전 그냥 이게 편해요. 이번 상담에 온 것도 선생님한테 이 말만 전하려고 온 거였어요. \n그래야 제 마음이 완전히 편해질 것 같아서. 대답은 듣고 싶지 않네요. 그럼 이만.";
                        GetComponent<State>().stan_ending = 1;
                        value2 = false;
                        Invoke("End_talk", 2.5f);
                    }
                    else if (GetComponent<State>().friendship_2 < 30 || GetComponent<State>().mental_2 < 40)
                    {
                        talk.text = "네 뭐. 너무 늦었을지도 모르지만, \n검정고시를 볼까 생각 중이에요. \n축구는 취미로 남기고.";
                    }
                    else if (GetComponent<State>().friendship_2 >= 30 || GetComponent<State>().mental_2 >= 40)
                    {
                        talk.text = "부모님이 제게 무슨 말씀하셨는지 궁금하지 않으세요?";
                    }
                }
                else if (stan == 70)
                {
                    talk.text = "";
                    if (GetComponent<State>().friendship_2 < 30 || GetComponent<State>().mental_2 < 40)
                    {
                        mytalk.text = "그 길을 선택했구나. 뭐, 나쁘지 않지.";
                    }
                    else if (GetComponent<State>().friendship_2 >= 30 || GetComponent<State>().mental_2 >= 40)
                    {
                        mytalk.text = "뭘. 네가 원하는 거라며. 그럼 그게 맞는 거겠지.";
                        GetComponent<State>().stan_ending = 3;
                        value2 = false;
                        Invoke("End_talk", 2.5f);
                    }
                }
                else if (stan == 71)
                {
                    talk.text = "네. 앞으로 열심히 공부할 거니깐요.";
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
                else if (olivia == 46)
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
