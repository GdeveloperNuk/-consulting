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
                tiara.text = "ī�� �θ�Բ� ������ �Դ�. ī�Ͱ� �������ٰ�.\n���� �ϳ� �ִ� ��Ÿ�� ì�ܼ�, ���� �������ȴٰ�.";
            else if(main_player.GetComponent<State>().tiara_ending == 2)
                tiara.text = "�׷κ��� 5���̶�� �ð��� �귶����,\nī���� �ҽ��� ��� �������� ã�� �� ������.";
        }
        else if (scenes == 2)
        {
            transform.position = Vector3.Lerp(transform.position, pos4.transform.position, speed);
            if (main_player.GetComponent<State>().stan_ending == 1)
                stan.text = "�� ���� �� �Ĵ翡�� ���� ���� �����ƴ�.\n������ �Ĵ� ���� �̾�ޱ�� �ߴٰ� �Ѵ�. ������ �ϳ� ���־���.";
            else if (main_player.GetComponent<State>().stan_ending == 2)
                stan.text = "�ᱹ ���� ���� �౸�� �׸��ξ���. �� �� ������ø�\n�غ� ���̶�� �ҽ��� ���� �����. ���� ������ �ֱ� �ٶ���.";
            else if (main_player.GetComponent<State>().stan_ending == 3)
                stan.text = "�� ������ �౸���� ���� ���� ���� �Ǿ���.\n���� ���� ���� ���̶�� ����� ô������ ��û���� �ູ�� ������.";
        }
        else if (scenes == 3)
        {
            transform.position = Vector3.Lerp(transform.position, pos6.transform.position, speed);
            if (main_player.GetComponent<State>().olivia_ending == 1)
                olivia.text = "�� �� �ø���ư� ������ ���ٴ� �ҽ��� �����.\n�׳� ���� ������ �о��ٰ� ������ �⿬�� �ø������ ����� �� �� �־���....";
            else if (main_player.GetComponent<State>().stan_ending == 2)
                olivia.text = "�ø���ƿ��� �� �� ���μ� ����� �ߵ��� �ʾ� ����ϰ� �ִٴ�\n������ �޾Ҵ�. ���� �����ٵ� �������� ���̶� �� �� �� ��߰ڴ�.";
            else if (main_player.GetComponent<State>().stan_ending == 3)
                olivia.text = "�ø���ƴ� ������ ���� �Ǿ���. ���� TV���� �⿬�ϴ� ����� �� �� �־���.";
        }
        else if(scenes == 4)
        {
            transform.position = Vector3.Lerp(transform.position, pos8.transform.position, speed);
            credit.text = "TEAM.����";
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
