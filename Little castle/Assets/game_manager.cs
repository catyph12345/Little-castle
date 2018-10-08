using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Math = System.Math;

public class game_manager : MonoBehaviour {

    //PLAYER
    public static double player_coin = 0;
    public static double player_curen = 0;
    public static double player_curen_incom = 0;


    //MINER
    public static int[] miner_lvl = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, };

    public static double[] miner_cost = new double[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
    public static double[] miner_start_cost = new double[] { 5, 50, 500, 5000, 50000, 500000, 5000000, 50000000, 500000000, 5000000000, 50000000000, 500000000000, 50000000000000, 5000000000000000, };
    public static int[] miner_multy = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };

    public static double[] miner_incom = new double[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
    public static double[] miner_start_incom = new double[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, };
    public static float[] miner_efect = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };


    //ARMY
    public static int[] army_lvl = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, };

    public static double[] army_cost = new double[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
    public static double[] army_start_cost = new double[] { 5, 50, 500, 5000, 50000, 500000, 5000000, 50000000, 500000000, 5000000000, 50000000000, 500000000000 };
    public static int[] army_multy = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };

    public static double[] army_dmg = new double[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
    public static double[] army_start_dmg = new double[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, };

    public static float[] army_bar = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
    public static float[] army_mbar = new float[] { 1, 1.5f, 2f, 2.5f, 3f, 3.5f, 4f, 4.5f, 5f, 5.6f, 6f, 6.5f, };

    //ENEMY
    public static int enemy_lvl = 1;

    public static double enemy_hp = 5;
    public static double enemy_mhp = 5;
    public static double enemy_rhp = 0;

    public static double enemy_coin = 5;


    //object
    public static panel_all_army_controller panel_army;
    public static panel_all_miner_controller panel_miner;
    public static battle_controller batl_con;
    public static all_button_controller all_but;

    public static GameObject[] pan_all = new GameObject[2];


    //other
    public static int x_buy = 1;
    public static int notation = 0;
    public static int nomber_pan = -1;

    public static int armt_amount = 12;
    public static int miner_amount = 14;


    void Start ()
    {
        Upgrade_army();
        Upgrade_miner();
        Upgrade_enemy();
    }


    void Update()
    {
        //ARMY WORK
        for (int i = 0; i < armt_amount; i++)
        {
            if(army_lvl[i] > 0)
            {
                army_bar[i] += 1f * Time.deltaTime;
                if(army_bar[i] >= army_mbar[i])
                {
                    army_bar[i] = 0f;
                    batl_con.sold_on(i);
                }
            }
        }
        //INCOM
        player_curen += player_curen_incom * Time.deltaTime;



        //ENEMY DIE
        if (enemy_hp <= 0)
        {
            Upgrade_enemy();
        }

    }

    //Update army
    public static void Upgrade_army()
    {
        //army amount update
        for (int i = 0; i < armt_amount; i++)
        {

            //nulty
            if (x_buy == 1)
                army_multy[i] = 1;
            if (x_buy == 2)
                army_multy[i] = 10;
            if (x_buy == 3)
                army_multy[i] = 25;
            if (x_buy == 4)
            {
                int mnoj = 0;
                for (int ia = 1; ia > 0; ia++)
                {
                    army_cost[i] = army_start_cost[i] * Math.Pow(1.07f, army_lvl[i]);
                    army_cost[i] = (Math.Pow(1 + 0.07f, ia) - 1) / 0.07f * army_cost[i];

                    if (player_curen < army_cost[i])
                    {
                        mnoj = ia - 1;
                        break;
                    }
                }
                if (mnoj == 0)
                    mnoj = 1;
                army_multy[i] = mnoj;
            }
            //ARMY COST
            army_cost[i] = army_start_cost[i] * Math.Pow(1.07, army_lvl[i]);
            army_cost[i] = (Math.Pow(1 + 0.07f, army_multy[i]) - 1) / 0.07f * army_cost[i];

            //ARMY DMG
            army_dmg[i] = army_start_dmg[i];
            //level
            army_dmg[i] *= army_lvl[i];


        }
        
        if(nomber_pan == 0)
            panel_army.Update_all_sold();
    }

    //Update miner
    public static void Upgrade_miner()
    {
        //army amount update
        for (int i = 0; i < miner_amount; i++)
        {

            //nulty
            if (x_buy == 1)
                miner_multy[i] = 1;
            if (x_buy == 2)
                miner_multy[i] = 10;
            if (x_buy == 3)
                miner_multy[i] = 25;
            if (x_buy == 4)
            {
                int mnoj = 0;
                for (int ia = 1; ia > 0; ia++)
                {
                    miner_cost[i] = miner_start_cost[i] * Math.Pow(1.07f, miner_lvl[i]);
                    miner_cost[i] = (Math.Pow(1 + 0.07f, ia) - 1) / 0.07f * miner_cost[i];

                    if (player_coin < miner_cost[i])
                    {
                        mnoj = ia - 1;
                        break;
                    }
                }
                if (mnoj == 0)
                    mnoj = 1;
                miner_multy[i] = mnoj;
            }
            //MINER COST
            miner_cost[i] = miner_start_cost[i] * Math.Pow(1.07, miner_lvl[i]);
            miner_cost[i] = (Math.Pow(1 + 0.07f, miner_multy[i]) - 1) / 0.07f * miner_cost[i];

            //if first miner
            //if(i == 0 && miner_lvl[i] == 0)
            //{
            //    miner_cost[i] = 0;
            //    miner_multy[i] = 1;
            //}

            //MINER INCOM
            miner_incom[i] = miner_start_incom[i];
            //level
            miner_incom[i] *= miner_lvl[i];


            //INCOM TOTAL
            if (i == 0)
                player_curen_incom = 0;
            player_curen_incom += miner_incom[i];

            //MINER ON
            if (miner_lvl[i] > 0)
            {
                if (miner_controller.miner_on[i] <= 0)
                    miner_controller.miner_on[i] = 1;
            }
            else
            {
                if(miner_controller.miner_on[i] >= 1)
                    miner_controller.miner_on[i] = 0;
            }
            miner_controller.Update_miner();

        }

        //effective
        for (int i = 0; i < miner_amount; i++)
        {
            miner_efect[i] = (float)(100d/player_curen_incom*miner_incom[i]);
        }
            

        if (nomber_pan == 1)
            panel_miner.Update_all_miner();

    }


    //enemy update
    public static void Upgrade_enemy()
    {
        enemy_mhp = 5 * Math.Pow(1.1f,enemy_lvl-1);

        enemy_hp = enemy_mhp;

        Upgrade_reward_enemy();
    }
    //enemy coin
    public static void Upgrade_reward_enemy()
    {
        enemy_coin = 5 + (1 * enemy_lvl) + (enemy_mhp * 0.011d);
    }


    //open panel
    public static void Open_panel_all(int nomber)
    {
        if(nomber_pan >= 0)
            pan_all[nomber_pan].SetActive(false);
        nomber_pan = nomber;
        pan_all[nomber_pan].SetActive(true);
        all_but.Update_polX();

        //0
        if (nomber_pan == 0)
            panel_army.Update_all_sold();
        //1
        if (nomber_pan == 1)
            panel_miner.Update_all_miner();


    }
    //close panel
    public static void Close_panel_all(int nomber)
    {
        pan_all[nomber_pan].SetActive(false);
        nomber_pan = -1;
        all_but.Update_polX();
    }



    //Reduction
    public static string Reduction_0(double costs)
    {
        string ret = "Over";

        if (notation == 0)
        {
            if (costs < 1000)
            {
                ret = costs.ToString("N0");
            }
            else
            {
                if (costs < 999999)
                {
                    ret = Math.Floor(costs).ToString();
                }
                else
                {
                    //ret = costs.ToString("g3"); 1.000e6 = 1 000 000
                    double prov = 1000000;
                    int prov_n = 0;
                    for (int i = 0; costs > prov; i++)
                    {
                        prov *= 10;
                        prov_n = i;
                    }

                    ret = (Math.Floor(costs / (prov / 10000d)) / 1000d) + "e" + (prov_n + 6);
                }
            }
        }


        return (ret);
    }


}
