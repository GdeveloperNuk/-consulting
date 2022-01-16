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
                    talk.text = "안녕하세요.";
                    mytalk.text = "";
                }
                else if (tiara == 2)
                {
                    talk.text = "";
                    mytalk.text = "반갑다. 티아라 카터.";
                }
                else if(tiara == 3)
                {
                    talk.text = "혹시 언제까지 상담하려나요?";
                    mytalk.text = "";
                }
                else if(tiara == 4)
                {
                    talk.text = "";
                    mytalk.text = "음... 문제가 해결될때까지?";
                }
                else if(tiara == 5)
                {
                    talk.text = "";
                    mytalk.text = "";
                    choose_1.text = "1. 티아라카터 무슨 고민이라도 있는거야?";
                    choose_2.text = "2. 요즘따라 얼굴이 우중충해보이는구나. 몸도 축 늘어져있고.";
                    choose_3.text = "3. 왜 상담하기 싫어? 하지마?";
                    choose = true;
                }
                else if(tiara == 6)
                {
                    mytalk.text = "";
                    choose_1.text = "";
                    choose_2.text = "";
                    choose_3.text = "";
                    if (choose_num == 1)
                    {
                        talk.text = "고민이야 많죠, 고민이야 많은데";
                        GetComponent<State>().Mental_add(-5);
                    }
                    else if (choose_num == 2)
                    {
                        talk.text = "어제 엄마한테 뒤지게 혼났거든요. \n성적이 왜 이 모양이냐구 하면서.";
                        GetComponent<State>().Friendship_add(5);
                    }
                    else if (choose_num == 3)
                    {
                        talk.text = "네, 그만하시죠";
                        GetComponent<State>().Mental_add(-25);
                    }
                }
                else if(tiara == 7)
                {
                    talk.text = "";
                    if (choose_num == 1)
                    {
                        mytalk.text = "이야기하기는 싫구나.";
                    }
                    else if (choose_num == 2)
                    {
                        mytalk.text = "역시. 그럴줄 알았단다.";
                    }
                    else if (choose_num == 3)
                    {
                        mytalk.text = "어어?";
                        value2 = false;
                        Invoke("End_talk", 2.5f);
                    }
                }
                else if(tiara == 8)
                {
                    talk.text = "";
                    mytalk.text = "뭐, 어쨌든 담임선생님에게 연락이 왔단다. \n전교 순위권을 잡아먹었던 놈이, 왜 갑작스레 이런 꼴이 되버렸는지. 필히 좀 알려달라고 하시더라.";
                }
                else if(tiara == 9)
                {
                    talk.text = "저도 몰라요. 그냥 운이 좀 안좋았던거 뿐이니까.";
                    mytalk.text = "";
                }
                else if(tiara == 10)
                {
                    talk.text = "";
                    mytalk.text = "선생님은 말 안해도 다 알아. 연인이 생긴거야?";
                }
                else if(tiara == 11)
                {
                    talk.text = "그런거 아니에요. 그리고 만약 \n'연인'이 생겼다고 한들무슨 상관인데요? \n엄연한 자유죠.";
                    mytalk.text = "";
                }
                else if(tiara == 12)
                {
                    talk.text = "";
                    mytalk.text = "";
            
                    choose_1.text = "1. 연애는 대학가서도 충분히 할 수 있는거 몰라? 이건 시기상조란다";
                    choose_2.text = "2. 잘 생각해봐. 지금같이 중요한 시기에, 연애를 하는게 맞는건지.";
                    choose_3.text = "3. 그래, 선생님은 카터가 잘하리라 믿어 의심치 않는단다.";
                    choose = true;
                    
                }
                else if(tiara == 13)
                {
                    mytalk.text = "";
                    choose_1.text = "";
                    choose_2.text = "";
                    choose_3.text = "";
                    if (choose_num == 1)
                    {
                        talk.text = "정말, 실망인데요";
                        GetComponent<State>().Mental_add(-25);
                        value2 = false;
                        Invoke("End_talk", 2.5f);
                    }
                    else if (choose_num == 2)
                    {
                        talk.text = "정말, 실망인데요";
                        GetComponent<State>().Mental_add(-5);
                        GetComponent<State>().Friendship_add(-5);
                    }
                    else if (choose_num == 3)
                    {
                        talk.text = "네, 감사해요.";
                            GetComponent<State>().Friendship_add(5);

                    }
                }
                else if(tiara == 14)
                {
                    talk.text = "";
                    mytalk.text = "다음번 시험은 반드시 잘해내야 해. \n대학 진학이 코앞으로 다가오고 말았으니까";
                }
                else if(tiara == 15)
                {
                    talk.text = "알아요. 걱정하지 마세요.";
                    mytalk.text = "";
                    value2 = false;
                    Invoke("End_talk", 2.5f);
                }
                else if(tiara == 16)
                {
                    talk.text = "";
                    mytalk.text = "요즘 하루는 어떠니? \n이제 막 시험이 끝났으니까, 조금 맘편히 지내도 괜찮단다.";
                }
                else if(tiara == 17)
                {
                    talk.text = "이를테면요?";
                    mytalk.text = "";
                }
                else if(tiara == 18)
                {
                    talk.text = "";
                    mytalk.text = "";
                    choose_1.text = "1. 친구들과 광란의 파티를 보낸다던지.";
                    choose_3.text = "2. 연인과 뜨거운 하루를 보낸다던지.";
                    choose = true;
                }
                else if(tiara == 19)
                {
                    choose_1.text = "";
                    choose_2.text = "";
                    choose_3.text = "";
                    mytalk.text = "";
                    if(choose_num == 1)
                    {
                        GetComponent<State>().Friendship_add(-5);
                    }
                    else
                    {
                        GetComponent<State>().Friendship_add(-10);
                    }
                    if (GetComponent<State>().friendship_1 >= 30)
                    {
                        talk.text = "솔직히 말해서 그러고 싶은데. \n그러질 못할 뿐이죠.";
                    }
                    else
                    {
                        talk.text = "그러고 싶은 기분 아니에요. \n그리고 저 친구 없어요. 단 한명도.";
                    }
                    
                }
                else if(tiara == 20)
                {
                    talk.text = "";
                    mytalk.text = "그럼 주로 어떤걸 하며 시간을 보내지?";
                }
<<<<<<< HEAD
<<<<<<< HEAD
                else if(tiara == 21)
                {
                    talk.text = "그냥 뭐, 침대에 누워서 시간을 보내요. \n노래나 들으면서.";
                    mytalk.text = "";
                }
                else if(tiara == 22)
                {
                    talk.text = "";
                    mytalk.text = "주로 무슨 노래를 듣는데?";
                }
                else if(tiara == 23)
                {
                    talk.text = "요즘은 비틀즈의 \n<Don't Let Me Down>을 들어요. \n무슨 노래인줄 아세요?";
                    mytalk.text = "";
                }
                else if(tiara == 24)
                {
                    talk.text = "";
                    mytalk.text = "";
                    choose_1.text = "( 모른다 !)";
                    choose_3.text = "( 안다 !)";
                    choose = true;
                }
                else if(tiara == 25)
                {
                    talk.text = "";
                    choose_1.text = "";
                    choose_2.text = "";
                    choose_3.text = "";
                    if (choose_num == 1)
                    {
                        mytalk.text = "자, 잘 알지 유명한 노래잖아. ";
                    }
                    else if(choose_num == 3)
                    {
                        mytalk.text = "존의 이야기가 함축적으로 담겨있는 노래. 맞지?";
                    }
                }
                else if(tiara == 26)
                {
                    mytalk.text = "";
                    if (choose_num == 1)
                    {
                        talk.text = "네, 유명하죠. \n그런데 잘 모르시는 것 같아요. ";
                        GetComponent<State>().Friendship_add(-5);
                    }
                    else if (choose_num == 3)
                    {
                        talk.text = "맞아요, 잘 아시네요. \n아주 애절한 감정이 잘 드러나죠.";
                        GetComponent<State>().Mental_add(5);
                    }
                }
                else if(tiara == 27)
                {
                    talk.text = "";
                    if (choose_num == 1)
                    {
                        mytalk.text = "들켰구나. ";
                        value2 = false;
                        Invoke("End_talk", 2.5f);
                    }
                    else if (choose_num == 3)
                    {
                        mytalk.text = "한때 선생님도 많이 들었단다.";
                        value2 = false;
                        Invoke("End_talk", 2.5f);
                    }
                }
                else if(tiara == 28)
                {
                    mytalk.text = "";
                    if(GetComponent<State>().mental_1 >= 30)
                    {
                        talk.text = "선생님, 저 사실 고민이 있는데요. \n진짜 아무한테도 말하시면 안돼요.";
                    }
                    else
                    {
                        talk.text = "저... 사실은요. 그... 뭐라고나 할까...";
                    }
                }
                else if(tiara == 29)
                {
                    talk.text = "";
                    mytalk.text = "";
                    choose_1.text = "1. 혹시 성 정체성에 관련된 고민이니? 부담없이 말해보려구나. 선생님은 아주 개방적이니까.";
                    choose_2.text = "2. 무슨 고민인데?";
                    choose_3.text = "3. 부담없이 말해봐.";
                    choose = true;
                }
                else if(tiara == 30)
                {
                    mytalk.text = "";
                    choose_1.text = "";
                    choose_2.text = "";
                    choose_3.text = "";
                    if (choose_num == 1)
                    {
                        talk.text = ".......";
                        GetComponent<State>().Mental_add(-5);
                        GetComponent<State>().Friendship_add(-10);
                    }
                    else if (choose_num == 2)
                    {
                        talk.text = "저 사실 음악이 하고 싶어요.";
                        GetComponent<State>().Mental_add(-5);
                        GetComponent<State>().Friendship_add(5);
                    }
                    else if(choose_num == 3)
                    {
                        talk.text = "저 사실 음악이 하고 싶어요.";
                        GetComponent<State>().Mental_add(5);
                        GetComponent<State>().Friendship_add(-5);
                    }
                }
                else if(tiara == 31)
                {
                    talk.text = "부모님 뜻처럼, 의사가 되고 싶은 마음은 \n쥐뿔도 없거든요.";
                    mytalk.text = "";
                    if (choose_num == 1)
                    {
                        talk.text = "아니에요. 사실 아무것도 아니에요. \n저 약속이 있어서 이만 가볼게요.";
                        tiara = 46;
                        value2 = false;
                        Invoke("End_talk", 2.5f);
                    }
                }
                else if(tiara == 32)
                {
                    talk.text = "";
                    mytalk.text = "진심이니?";
                }
                else if(tiara == 33)
                {
                    talk.text = "네, 진심이에요. 저는 비틀즈를 동경해요. \n그리고 실제 비틀즈처럼, 밴드를 결성하고 싶어요. \n오직 사람들을 위해서 공연하는, 그런 밴드말이에요.";
                    mytalk.text = "";
                }
                else if(tiara == 34)
                {
                    talk.text = "";
                    mytalk.text = "";
                    choose_1.text = "1. 사실 나또한 학창시절에 그런 친구가 있었단다.";
                    choose_3.text = "2. 그렇구나. 무슨 말인지 잘 알겠어.";
                    choose = true;
                }
                else if(tiara == 35)
                {
                    choose_1.text = "";
                    choose_2.text = "";
                    choose_3.text = "";
                    if (choose_num == 3)
                    {
                        tiara = 43;
                    }
                    talk.text = "어떤 친구였나요?";
                    mytalk.text = "";
                }
                else if(tiara == 36)
                {
                    talk.text = "";
                    mytalk.text = "공부도 아주 잘했고, 성격도 아주 친화적이었지. 인기도 많았어.";
                }
                else if(tiara == 37)
                {
                    talk.text = "그런데요?";
                    mytalk.text = "";
                }
                else if(tiara == 38)
                {
                    talk.text = "";
                    mytalk.text = "갑자기 가수를 하겠다고 하더라. \n진정한 길은 사실 거기에 있었는데,";
                }
                else if(tiara == 39)
                {
                    talk.text = "";
                    mytalk.text = "지금껏 너무나 많은 방황을 해온 것 같다고. \n이제부터라도 꿈을 찾아 나서겠다고.";
                }
                else if(tiara == 40)
                {
                    talk.text = "그래서요?　그 친구는 어떻게 되었어요?";
                    mytalk.text = "";
                }
                else if(tiara == 41)
                {
                    talk.text = "";
                    mytalk.text = "죽었어. 무명 생활 10년동안, 아무것도 이뤄낼 수 없었거든.";
                }
                else if(tiara == 42)
                {
                    talk.text = "";
                    mytalk.text = "물론 그 녀석의 주관적인 기준에 한해서지만.";
                }
                else if(tiara == 43)
                {
                    talk.text = "비참하군요.";
                    mytalk.text = "";
                    tiara = 44;
                }
                else if(tiara == 44)
                {
                    talk.text = "이해해주시는건가요?";
                    mytalk.text = "";
                }
                else if(tiara == 45)
                {
                    talk.text = "";
                    mytalk.text = "그래, 아무렴. 결국은 잘 생각하는게 좋을거야.";
                }
                else if(tiara == 46)
                {
                    talk.text = "";
                    mytalk.text = "고집을 부리는 것은 아닌지, 진정 음악을 사랑하는지.";
                    value2 = false;
                    Invoke("End_talk", 2.5f);
                }
                if(GetComponent<State>().friendship_1 >= 21 && GetComponent<State>().mental_1 >= 21)
                {
                    if (tiara == 47)
                    {
                        talk.text = "전, 정했어요. 누가뭐래도 음악을 할거에요.";
                        mytalk.text = "";
                    }
                    else if(tiara == 48)
                    {
                        talk.text = "";
                        mytalk.text = "그렇구나. 솔직히 말하자면, 쉽지 않을거야.";
                    }
                    else if(tiara == 49)
                    {
                        talk.text = "";
                        mytalk.text = "현실적으로 무리일지도 모르지.";
                    }
                    else if(tiara == 50)
                    {
                        talk.text = "";
                        mytalk.text = "꿈이라는 이상적 모토에 다가가는 것이, \n사실 말처럼 쉬운 일은 아니니까.";
                    }
                    else if(tiara == 51)
                    {
                        talk.text = "필히 감내해야하는 부분이겠죠.";
                        mytalk.text = "";
                    }
                    else if(tiara == 52)
                    {
                        talk.text = "";
                        mytalk.text = "원래 창작이 그래.";
                    }
                    else if(tiara == 53)
                    {
                        talk.text = "";
                        mytalk.text = "수많은 경쟁자들 속에서, 소수의 재능과 운을 겸비한 사람들만이 선택받고, \n세상에 드러나게 되는거야.";
                    }
                    else if(tiara == 54)
                    {
                        talk.text = "";
                        mytalk.text = "아직 우리가 모르는 '비틀즈'는 세상에 넘치고 넘쳤어";
                    }
                    else if(tiara == 55)
                    {
                        talk.text = "하지만 도전해볼 가치는 충분하다고 생각해요.";
                        mytalk.text = "";
                    }
                    else if(tiara == 56)
                    {
                        talk.text = "막연하고 두렵다는 이유 하나로, \n안정된 길만을 추구하려 한다면";
                        mytalk.text = "";
                    }
                    else if(tiara == 57)
                    {
                        talk.text = "분명 나중에 후회할거에요. \n그때 왜 도전을 망설였을까, 하고.";
                        mytalk.text = "";
                    }
                    else if (tiara == 58)
                    {
                        talk.text = "";
                        mytalk.text = "좋아. 그대신 공부도 중요하단다. 무슨 말인지 알지?";
                    }
                    else if (tiara == 59)
                    {
                        talk.text = "네, 당연하죠.";
                        mytalk.text = "";
                        GetComponent<State>().stan_ending = 2;
                        value2 = false;
                        Invoke("End_talk", 2.5f);
                    }

                }
                else if (GetComponent<State>().friendship_1 < 21 && GetComponent<State>().mental_1 < 21)
                {
                    GetComponent<State>().stan_ending = 1;
                }
            }
            else if(GetComponent<State>().join_student == 2)
            {
                if (stan == 1)
                {
                    talk.text = "";
                    mytalk.text = "안녕 스탠 리. 숙제는 해 왔어?";
                }
                else if (stan == 2)
                {
                    talk.text = "사실 아직 못했어요. 이번 상담에서 제 생각을 \n조금이라도 확고히 하고 싶어서.";
                    mytalk.text = "";
                }
                else if(stan == 3)
                {
                    talk.text = "";
                    mytalk.text = "그런 이유라면 잘했어. 나쁘지 않은 선택을 했네.";
                    GetComponent<State>().Friendship_add(5);
                }
                else if(stan == 4)
                {
                    talk.text = "선생님은…. 어떤 선택이 맞다고 생각하세요?";
                    mytalk.text = "";
                }
                else if(stan == 5)
                {
                    talk.text = "";
                    choose_1.text = "1. 내가 결정할 순 없을 것 같은데.";
                    choose_2.text = "2. 계속 축구하는 거.";
                    choose_3.text = "3. 지금이라도 공부하는 거.";
                    choose = true;
                }
                else if(stan == 6)
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
                else if(stan == 7)
                {
                    talk.text = "";
                    if (choose_num == 1)
                        mytalk.text = "네 인생에 남인 내가 정답을 줄 순 없지. \n어렵겠지만 어쩔 수 없어. 그야 인생을 좌우하는 일인데.";
                    else if (choose_num == 2)
                        mytalk.text = "음. 내가 유추해본 결과 네가 원하는 게 그거라고 생각했거든.";
                    else if (choose_num == 3)
                        mytalk.text = "솔직히 말하자면. 내 주관적인 의견이 필요하다는 것 같아서. 물론 내 생각일 뿐이야.";
                }
                else if(stan == 8)
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
                    else if (choose_num == 3) { 
                        talk.text = "그렇군요. \n그럼 이제 혼자 생각할 시간이 필요할 것 같아요. \n오늘은 이만 가볼게요.";
                        stan = 10;
                        value2 = false;
                        Invoke("End_talk", 2.5f);
              
                    }
                }
                else if(stan == 9)
                {
                    talk.text = "";
                    mytalk.text = "그냥 네가 하고 싶은 걸 해. \n안 좋아하는 거 하는 대신 성공한 인생을 산다 해도 결국 스트레스 엄청 받을 걸.";
                }
                else if(stan == 10)
                {
                    talk.text = "그렇군요. 뭔가 알 듯 말 듯 하네요. \n아무튼 고마워요. \n선생님 말대로라면 혼자 생각할 시간이 필요하겠어요. 이만 가볼게요!";
                    mytalk.text = "";
                    value2 = false;
                    Invoke("End_talk", 2.5f);
                }
                else if (stan == 11)
                {
                    talk.text = "저, 드디어 말하고 왔어요.";
                    mytalk.text = "";
                }
                else if(stan == 12)
                {
                    talk.text = "";
                    mytalk.text = "멋지네. 다행히 저번에 생각이 확고해졌나 봐?";
                }
                else if(stan == 13)
                {
                    mytalk.text = "";
                    if(GetComponent<State>().friendship_2 <= 20 || GetComponent<State>().mental_2 <= 20)
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
                else if(stan == 14)
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
                else if(stan == 15)
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
                else if(stan == 16)
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
                else if(stan == 17)
                {
                    talk.text = "네. 앞으로 열심히 공부할 거니깐요.";
                    mytalk.text = "";
                    GetComponent<State>().stan_ending = 2;
                    value2 = false;
                    Invoke("End_talk", 2.5f);
                }
=======

            }
            else if(GetComponent<State>().join_student == 2)
            {

>>>>>>> parent of 155aa7e (final)
=======

            }
            else if(GetComponent<State>().join_student == 2)
            {

>>>>>>> parent of 155aa7e (final)
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
                        talk.text = "뭐, 알겠어. 다음번에도 여기로 오면 되냐?";
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
<<<<<<< HEAD
<<<<<<< HEAD
                    mytalk.text = "너무 상심하지 마. 노력은 반드시 배신하지 않으니까,\n꼭 빛을 보게 될 걸.";
                else if (olivia == 46)
=======
                    mytalk.text = "�ʹ� ������� ��. ����� �ݵ�� ������� �����ϱ�,\n�� ���� ���� �� ��.";
                else if (olivia == 44)
>>>>>>> parent of 155aa7e (final)
=======
                    mytalk.text = "�ʹ� ������� ��. ����� �ݵ�� ������� �����ϱ�,\n�� ���� ���� �� ��.";
                else if (olivia == 44)
>>>>>>> parent of 155aa7e (final)
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
