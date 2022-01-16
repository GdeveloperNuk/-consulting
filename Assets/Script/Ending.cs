using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{
    public GameObject main_player;
    public float speed = 0.5f;
    public GameObject pos1;
    public GameObject pos2;
    public GameObject pos3;
    public GameObject pos4;
    public GameObject pos5;
    public GameObject pos6;
    public GameObject pos7;
    public GameObject pos8;
    public GameObject black;
    public TextMesh tiara;
    public TextMesh stan;
    public TextMesh olivia;
    public TextMesh date;
    public TextMesh credit;
    private int scenes;
    private void Awake()
    {
        scenes = 0;
        transform.position = pos1.transform.position;
        transform.forward = pos1.transform.forward;
        Invoke("Pos1", 1);
    }
    private void Update()
    {
        if (scenes == 1)
        {
            transform.position = Vector3.Lerp(transform.position, pos2.transform.position, speed);
            if (main_player.GetComponent<State>().tiara_ending == 1)
                tiara.text = "카터 부모님께 연락이 왔다. 카터가 도망갔다고.\n집에 하나 있는 기타를 챙겨서, 집을 나가버렸다고.";
            else if(main_player.GetComponent<State>().tiara_ending == 2)
                tiara.text = "그로부터 5년이라는 시간이 흘렀지만,\n카터의 소식은 어느 곳에서도 찾을 수 없었다.";
        }
        else if (scenes == 2)
        {
            transform.position = Vector3.Lerp(transform.position, pos4.transform.position, speed);
            if (main_player.GetComponent<State>().stan_ending == 1)
                stan.text = "얼마 전에 간 식당에서 스탠 리를 마주쳤다.\n가업인 식당 일을 이어받기로 했다고 한다. 음식은 꽤나 맛있었다.";
            else if (main_player.GetComponent<State>().stan_ending == 2)
                stan.text = "결국 스탠 리는 축구를 그만두었다. 얼마 후 검정고시를\n준비 중이라는 소식을 전해 들었다. 좋은 성과가 있길 바란다.";
            else if (main_player.GetComponent<State>().stan_ending == 3)
                stan.text = "꽤 유명한 축구팀에 스탠 리가 들어가게 되었다.\n스탠 리는 그저 운이라며 담담한 척했지만 엄청나게 행복해 보였다.";
        }
        else if (scenes == 3)
        {
            transform.position = Vector3.Lerp(transform.position, pos6.transform.position, speed);
            if (main_player.GetComponent<State>().olivia_ending == 1)
                olivia.text = "얼마 전 올리비아가 감옥에 갔다는 소식을 들었다.\n그날 저녁 은행을 털었다고 뉴스에 출연한 올리비아의 모습을 볼 수 있었다....";
            else if (main_player.GetComponent<State>().stan_ending == 2)
                olivia.text = "올리비아에게 얼마 전 댄서로서 취업이 잘되지 않아 고생하고 있다는\n연락을 받았다. 많이 힘들텐데 다음번에 밥이라도 한 끼 사 줘야겠다.";
            else if (main_player.GetComponent<State>().stan_ending == 3)
                olivia.text = "올리비아는 유명한 댄서가 되었다. 가끔 TV에도 출연하는 모습을 볼 수 있었다.";
        }
        else if(scenes == 4)
        {
            transform.position = Vector3.Lerp(transform.position, pos8.transform.position, speed);
            credit.text = "TEAM.혀국";
        }

    }
    private void Pos1()
    {
        date.text = main_player.GetComponent<State>().year + "Y " + main_player.GetComponent<State>().month + "M";
        scenes = 1;
        Invoke("Pos2", 5);
    }
    private void Pos2()
    {
        date.text = "";
        black.SetActive(false);
        tiara.text = "";
        transform.position = pos3.transform.position;
        transform.forward = pos3.transform.forward;
        scenes = 2;
        Invoke("Pos3", 5);
    }
    private void Pos3()
    {
        stan.text = "";
        transform.position = pos5.transform.position;
        transform.forward = pos5.transform.forward;
        scenes = 3;
        Invoke("Pos4", 5);
    }
    private void Pos4()
    {
        olivia.text = "";
        transform.position = pos7.transform.position;
        transform.forward = pos7.transform.forward;
        scenes = 4;
        Invoke("End", 4);
    }
    private void End()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
