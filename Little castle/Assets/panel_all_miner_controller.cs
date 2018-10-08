using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panel_all_miner_controller : MonoBehaviour {

    public static panel_miner_controller[] pan_miner = new panel_miner_controller[14];

    void Awake()
    {
        game_manager.panel_miner = this;
        transform.localPosition = new Vector3(-2.5f, 0f, 0f);
        game_manager.pan_all[1] = gameObject;
        gameObject.SetActive(false);
    }



    public void Update_all_miner()
    {
        for (int i = 0; i < game_manager.miner_amount; i++)
        {
            pan_miner[i].Update_text();
        }
    }
}
