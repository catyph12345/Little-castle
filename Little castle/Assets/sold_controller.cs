using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Math = System.Math;

public class sold_controller : MonoBehaviour {

    private Transform tran_sold;

    public int nomber;

    private float rotat = 0;
    private float rotat2 = 0;

    void Start ()
    {
        tran_sold = transform;
        tran_sold.rotation = Quaternion.Euler(0f, 0f, Random.Range(-10f,10f));
    }
	
	
	void FixedUpdate ()
    {
        //anim walk
        if(rotat2 == 0)
        {
            rotat += 30f * Time.deltaTime;
            if (rotat >= 10f)
            {
                rotat2 = 1;
            }
                
        }
        else
        {
            rotat -= 30f * Time.deltaTime;
            if (rotat <= -10f)
            {
                rotat2 = 0;
            }
                
        }
        tran_sold.rotation = Quaternion.Euler(0f,0f, rotat);

        //walk
        tran_sold.position = new Vector3(tran_sold.position.x + 1f*Time.deltaTime, tran_sold.position.y,0f);
        if(tran_sold.position.x >= 3.4f)
        {
            damage_enemy();
            gameObject.SetActive(false);
        }


    }

    //damage on enemy
    public void damage_enemy()
    {
        double profit = game_manager.army_dmg[nomber];

        game_manager.enemy_hp -= profit;
        if (profit > game_manager.enemy_mhp)
            profit = game_manager.enemy_mhp;

        profit = 1d / game_manager.enemy_mhp * profit;


        game_manager.player_coin += Math.Floor(game_manager.enemy_coin * profit);
    }


    




}
