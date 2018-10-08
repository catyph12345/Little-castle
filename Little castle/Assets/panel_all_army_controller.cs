using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panel_all_army_controller : MonoBehaviour {

    public static panel_sold_controller[] pan_sold = new panel_sold_controller[12];

    void Awake()
    {
        game_manager.panel_army = this;
        transform.localPosition = new Vector3(-2.5f,0f,0f);
        game_manager.pan_all[0] = gameObject;
        gameObject.SetActive(false);
    }


    public void Update_all_sold()
    {
        for(int i = 0; i < game_manager.armt_amount; i++)
        {
            pan_sold[i].Update_text();
        }
    }
	
	
}
