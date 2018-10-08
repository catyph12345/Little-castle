using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miner_controller : MonoBehaviour {

    public static int[] miner_on = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };



    public static miner_icon_controller[] miner_icon = new miner_icon_controller[14];

    


    public static void Update_miner()
    {
        for(int i = 0; i < game_manager.miner_amount; i++)
        {
            //if miner on need take move
            if (miner_on[i] == 1)
            {
                miner_icon[i].gameObject.SetActive(true);
                miner_on[i] = 2;
            }
            if (miner_on[i] == 0)
            {
                miner_icon[i].gameObject.SetActive(false);
                miner_on[i] = -1;
            }
        }
    }



}
