using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button_buy_miner_controller : MonoBehaviour {

    public int nomber;


    private bool on_off = true;

    private Button but_knp;
    private CanvasGroup cam_grp;


    void Awake()
    {
        cam_grp = GetComponent<CanvasGroup>();
        but_knp = GetComponent<Button>();
    }


    void Update()
    {
        //update button
        if (game_manager.player_coin >= game_manager.miner_cost[nomber])
        {
            if (on_off == false)
            {
                on_off = true;
                but_knp.interactable = true;
                cam_grp.alpha = 1f;
            }
        }
        else
        {
            if (on_off == true)
            {
                on_off = false;
                but_knp.interactable = false;
                cam_grp.alpha = 0.5f;
            }
        }
    }





    private void OnMouseUpAsButton()
    {
        if (on_off == true)
        {
            if (game_manager.player_coin >= game_manager.miner_cost[nomber])
            {
                game_manager.player_coin -= game_manager.miner_cost[nomber];
                game_manager.miner_lvl[nomber] += game_manager.miner_multy[nomber];

                game_manager.Upgrade_miner();
            }
        }
    }
}
