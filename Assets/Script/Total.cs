using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Total : MonoBehaviour
{
    public GameObject friendship_total;
    public GameObject mental_total;
    public GameObject main_player;
    public GameObject[] friendship;
    public GameObject[] mental;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hitInfo = new RaycastHit();
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo))
            {
                switch(hitInfo.transform.tag)
                {
                    case "tomorrow_button":
                        friendship_total.SetActive(false);
                        mental_total.SetActive(false);

                        break;
                    case "friendship_button":
                        Friendship_test();
                        friendship_total.SetActive(true);
                        mental_total.SetActive(false);
                        break;
                    case "mental_button":
                        Mental_test();
                        friendship_total.SetActive(false);
                        mental_total.SetActive(true);
                        break;
                }
            }
        }
    }
    private void Friendship_test()
    {
        for (int i = 0; i < 15; i++)
            friendship[i].SetActive(false);
        if (main_player.GetComponent<State>().friendship_1 > 10)
            friendship[0].SetActive(true);
        if (main_player.GetComponent<State>().friendship_1 > 20)
            friendship[1].SetActive(true);
        if (main_player.GetComponent<State>().friendship_1 > 30)
            friendship[2].SetActive(true);
        if (main_player.GetComponent<State>().friendship_1 > 40)
            friendship[3].SetActive(true);
        if (main_player.GetComponent<State>().friendship_1 > 45)
            friendship[4].SetActive(true);
        if (main_player.GetComponent<State>().friendship_2 > 10)
            friendship[5].SetActive(true);
        if (main_player.GetComponent<State>().friendship_2 > 20)
            friendship[6].SetActive(true);
        if (main_player.GetComponent<State>().friendship_2 > 30)
            friendship[7].SetActive(true);
        if (main_player.GetComponent<State>().friendship_2 > 40)
            friendship[8].SetActive(true);
        if (main_player.GetComponent<State>().friendship_2 > 45)
            friendship[9].SetActive(true);
        if (main_player.GetComponent<State>().friendship_3 > 10)
            friendship[10].SetActive(true);
        if (main_player.GetComponent<State>().friendship_3 > 20)
            friendship[11].SetActive(true);
        if (main_player.GetComponent<State>().friendship_3 > 30)
            friendship[12].SetActive(true);
        if (main_player.GetComponent<State>().friendship_3 > 40)
            friendship[13].SetActive(true);
        if (main_player.GetComponent<State>().friendship_3 > 45)
            friendship[14].SetActive(true);
    }
    private void Mental_test()
    {
        for (int i = 0; i < 15; i++)
            mental[i].SetActive(false);
        if (main_player.GetComponent<State>().mental_1 > 10)
            mental[0].SetActive(true);
        if (main_player.GetComponent<State>().mental_1 > 20)
            mental[1].SetActive(true);
        if (main_player.GetComponent<State>().mental_1 > 30)
            mental[2].SetActive(true);
        if (main_player.GetComponent<State>().mental_1 > 40)
            mental[3].SetActive(true);
        if (main_player.GetComponent<State>().mental_1 > 45)
            mental[4].SetActive(true);
        if (main_player.GetComponent<State>().mental_2 > 10)
            mental[5].SetActive(true);
        if (main_player.GetComponent<State>().mental_2 > 20)
            mental[6].SetActive(true);
        if (main_player.GetComponent<State>().mental_2 > 30)
            mental[7].SetActive(true);
        if (main_player.GetComponent<State>().mental_2 > 40)
            mental[8].SetActive(true);
        if (main_player.GetComponent<State>().mental_2 > 45)
            mental[9].SetActive(true);
        if (main_player.GetComponent<State>().mental_3 > 10)
            mental[10].SetActive(true);
        if (main_player.GetComponent<State>().mental_3 > 20)
            mental[11].SetActive(true);
        if (main_player.GetComponent<State>().mental_3 > 30)
            mental[12].SetActive(true);
        if (main_player.GetComponent<State>().mental_3 > 40)
            mental[13].SetActive(true);
        if (main_player.GetComponent<State>().mental_3 > 45)
            mental[14].SetActive(true);
    }
}
