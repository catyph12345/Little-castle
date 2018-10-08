using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class panel_sold_controller : MonoBehaviour {

    public int nomber;

    public TextMeshProUGUI text_name;
    public TextMeshProUGUI text_dmg;
    public TextMeshProUGUI text_lvl;
    public TextMeshProUGUI text_cost;

    void Awake ()
    {
        panel_all_army_controller.pan_sold[nomber] = this;
	}
	
	
	public void Update_text()
    {
        text_name.text = all_text_manager.name_army[nomber];
        text_dmg.text = "<sprite=2>"+game_manager.Reduction_0(game_manager.army_dmg[nomber]);
        text_lvl.text = "Lv. "+game_manager.army_lvl[nomber];

        if(game_manager.army_multy[nomber] <= 1)
        {
            text_cost.text = "Level UP";
        }
        else
        {
            text_cost.text = "x"+ game_manager.army_multy[nomber];
        }
        text_cost.text += "\n<sprite=1><#807A68>" + game_manager.Reduction_0(game_manager.army_cost[nomber]);

    }



}
