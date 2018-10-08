using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class panel_miner_controller : MonoBehaviour {

    public int nomber;

    public TextMeshProUGUI text_name;
    public TextMeshProUGUI text_efect;
    public TextMeshProUGUI text_incom;
    public TextMeshProUGUI text_lvl;
    public TextMeshProUGUI text_cost;

    void Awake()
    {
        panel_all_miner_controller.pan_miner[nomber] = this;
    }


    public void Update_text()
    {
        text_name.text = all_text_manager.name_miner[nomber];
        text_efect.text = game_manager.Reduction_0(game_manager.miner_efect[nomber])+"%";
        text_incom.text = "<sprite=1>+" + game_manager.Reduction_0(game_manager.miner_incom[nomber])+" per/sec";
        text_lvl.text = "Lv. " + game_manager.miner_lvl[nomber];

        if (game_manager.miner_multy[nomber] <= 1)
        {
            text_cost.text = "Level UP";
        }
        else
        {
            text_cost.text = "x" + game_manager.miner_multy[nomber];
        }
        text_cost.text += "\n<sprite=0><#FFEE00>" + game_manager.Reduction_0(game_manager.miner_cost[nomber]);

    }
}
