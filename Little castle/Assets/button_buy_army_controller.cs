using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button_buy_army_controller : MonoBehaviour {

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
        if (game_manager.player_curen >= game_manager.army_cost[nomber])
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
        if(on_off == true)
        {
            if (game_manager.player_curen >= game_manager.army_cost[nomber])
            {
                game_manager.player_curen -= game_manager.army_cost[nomber];
                game_manager.army_lvl[nomber] += game_manager.army_multy[nomber];

                game_manager.Upgrade_army();
            }
        }
    }
}
