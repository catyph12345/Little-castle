using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class battle_controller : MonoBehaviour {

    //SOLDER
    //sold 0
    public static GameObject[] pool_sold0 = new GameObject[20];
    public static int coint_sold0 = 0;
    public GameObject sold0;
    //sold 1
    public static GameObject[] pool_sold1 = new GameObject[20];
    public static int coint_sold1 = 1;
    public GameObject sold1;
    //sold 2
    public static GameObject[] pool_sold2 = new GameObject[20];
    public static int coint_sold2 = 0;
    public GameObject sold2;
    //sold 3
    public static GameObject[] pool_sold3 = new GameObject[20];
    public static int coint_sold3 = 0;
    public GameObject sold3;
    //sold 4
    public static GameObject[] pool_sold4 = new GameObject[20];
    public static int coint_sold4 = 0;
    public GameObject sold4;
    //sold 5
    public static GameObject[] pool_sold5 = new GameObject[20];
    public static int coint_sold5 = 0;
    public GameObject sold5;
    //sold 6
    public static GameObject[] pool_sold6 = new GameObject[20];
    public static int coint_sold6 = 0;
    public GameObject sold6;
    //sold 7
    public static GameObject[] pool_sold7 = new GameObject[20];
    public static int coint_sold7 = 0;
    public GameObject sold7;
    //sold 8
    public static GameObject[] pool_sold8 = new GameObject[20];
    public static int coint_sold8 = 0;
    public GameObject sold8;
    //sold 9
    public static GameObject[] pool_sold9 = new GameObject[20];
    public static int coint_sold9 = 0;
    public GameObject sold9;
    //sold 10
    public static GameObject[] pool_sold10 = new GameObject[20];
    public static int coint_sold10 = 0;
    public GameObject sold10;
    //sold 11
    public static GameObject[] pool_sold11 = new GameObject[20];
    public static int coint_sold11 = 0;
    public GameObject sold11;



    private void Awake()
    {
        game_manager.batl_con = this;
    }

    void Start()
    {
        //sold 0
        for (int i = 0; i < 20; i++)
        {
            pool_sold0[i] = Instantiate(sold0, new Vector3(0.14f, -1.8f, 0f), Quaternion.identity);
            pool_sold0[i].transform.SetParent(this.transform);
            pool_sold0[i].SetActive(false);
        }
        //sold 1
        for (int i = 0; i < 20; i++)
        {
            pool_sold1[i] = Instantiate(sold1, new Vector3(0.14f, -1.8f, 0f), Quaternion.identity);
            pool_sold1[i].transform.SetParent(this.transform);
            pool_sold1[i].SetActive(false);
        }
        //sold 2
        for (int i = 0; i < 20; i++)
        {
            pool_sold2[i] = Instantiate(sold2, new Vector3(0.14f, -1.8f, 0f), Quaternion.identity);
            pool_sold2[i].transform.SetParent(this.transform);
            pool_sold2[i].SetActive(false);
        }
        //sold 3
        for (int i = 0; i < 20; i++)
        {
            pool_sold3[i] = Instantiate(sold3, new Vector3(0.14f, -1.8f, 0f), Quaternion.identity);
            pool_sold3[i].transform.SetParent(this.transform);
            pool_sold3[i].SetActive(false);
        }
        //sold 4
        for (int i = 0; i < 20; i++)
        {
            pool_sold4[i] = Instantiate(sold4, new Vector3(0.14f, -1.8f, 0f), Quaternion.identity);
            pool_sold4[i].transform.SetParent(this.transform);
            pool_sold4[i].SetActive(false);
        }
        //sold 5
        for (int i = 0; i < 20; i++)
        {
            pool_sold5[i] = Instantiate(sold5, new Vector3(0.14f, -1.8f, 0f), Quaternion.identity);
            pool_sold5[i].transform.SetParent(this.transform);
            pool_sold5[i].SetActive(false);
        }
        //sold 6
        for (int i = 0; i < 20; i++)
        {
            pool_sold6[i] = Instantiate(sold6, new Vector3(0.14f, -1.8f, 0f), Quaternion.identity);
            pool_sold6[i].transform.SetParent(this.transform);
            pool_sold6[i].SetActive(false);
        }
        //sold 7
        for (int i = 0; i < 20; i++)
        {
            pool_sold7[i] = Instantiate(sold7, new Vector3(0.14f, -1.8f, 0f), Quaternion.identity);
            pool_sold7[i].transform.SetParent(this.transform);
            pool_sold7[i].SetActive(false);
        }
        //sold 8
        for (int i = 0; i < 20; i++)
        {
            pool_sold8[i] = Instantiate(sold8, new Vector3(0.14f, -1.8f, 0f), Quaternion.identity);
            pool_sold8[i].transform.SetParent(this.transform);
            pool_sold8[i].SetActive(false);
        }
        //sold 9
        for (int i = 0; i < 20; i++)
        {
            pool_sold9[i] = Instantiate(sold9, new Vector3(0.14f, -1.8f, 0f), Quaternion.identity);
            pool_sold9[i].transform.SetParent(this.transform);
            pool_sold9[i].SetActive(false);
        }
        //sold 10
        for (int i = 0; i < 20; i++)
        {
            pool_sold10[i] = Instantiate(sold10, new Vector3(0.14f, -1.8f, 0f), Quaternion.identity);
            pool_sold10[i].transform.SetParent(this.transform);
            pool_sold10[i].SetActive(false);
        }
        //sold 11
        for (int i = 0; i < 20; i++)
        {
            pool_sold11[i] = Instantiate(sold1, new Vector3(0.14f, -1.8f, 0f), Quaternion.identity);
            pool_sold11[i].transform.SetParent(this.transform);
            pool_sold11[i].SetActive(false);
        }
    }



    public void sold_on(int _sold_nom)
    {
        //sold 0
        if (_sold_nom == 0)
        {
            pool_sold0[coint_sold0].SetActive(true);
            pool_sold0[coint_sold0].transform.position = new Vector3(0.14f + Random.Range(-0.1f,0.2f), -1.8f, 0f);
            coint_sold0 += 1;
            if (coint_sold0 == 20)
                coint_sold0 = 0;
        }
        //sold 1
        if (_sold_nom == 1)
        {
            pool_sold1[coint_sold1].SetActive(true);
            pool_sold1[coint_sold1].transform.position = new Vector3(0.14f + Random.Range(-0.1f, 0.2f), -1.8f, 0f);
            coint_sold1 += 1;
            if (coint_sold1 == 20)
                coint_sold1 = 0;
        }
        //sold 2
        if (_sold_nom == 2)
        {
            pool_sold2[coint_sold2].SetActive(true);
            pool_sold2[coint_sold2].transform.position = new Vector3(0.14f + Random.Range(-0.1f, 0.2f), -1.8f, 0f);
            coint_sold2 += 1;
            if (coint_sold2 == 20)
                coint_sold2 = 0;
        }
        //sold 3
        if (_sold_nom == 3)
        {
            pool_sold3[coint_sold3].SetActive(true);
            pool_sold3[coint_sold3].transform.position = new Vector3(0.14f + Random.Range(-0.1f, 0.2f), -1.8f, 0f);
            coint_sold3 += 1;
            if (coint_sold3 == 20)
                coint_sold3 = 0;
        }
        //sold 4
        if (_sold_nom == 4)
        {
            pool_sold4[coint_sold4].SetActive(true);
            pool_sold4[coint_sold4].transform.position = new Vector3(0.14f + Random.Range(-0.1f, 0.2f), -1.8f, 0f);
            coint_sold4 += 1;
            if (coint_sold4 == 20)
                coint_sold4 = 0;
        }
        //sold 5
        if (_sold_nom == 5)
        {
            pool_sold5[coint_sold5].SetActive(true);
            pool_sold5[coint_sold5].transform.position = new Vector3(0.14f + Random.Range(-0.1f, 0.2f), -1.8f, 0f);
            coint_sold5 += 1;
            if (coint_sold5 == 20)
                coint_sold5 = 0;
        }
        //sold 6
        if (_sold_nom == 6)
        {
            pool_sold6[coint_sold6].SetActive(true);
            pool_sold6[coint_sold6].transform.position = new Vector3(0.14f + Random.Range(-0.1f, 0.2f), -1.8f, 0f);
            coint_sold6 += 1;
            if (coint_sold6 == 20)
                coint_sold6 = 0;
        }
        //sold 7
        if (_sold_nom == 7)
        {
            pool_sold7[coint_sold7].SetActive(true);
            pool_sold7[coint_sold7].transform.position = new Vector3(0.14f + Random.Range(-0.1f, 0.2f), -1.8f, 0f);
            coint_sold7 += 1;
            if (coint_sold7 == 20)
                coint_sold7 = 0;
        }
        //sold 8
        if (_sold_nom == 8)
        {
            pool_sold8[coint_sold8].SetActive(true);
            pool_sold8[coint_sold8].transform.position = new Vector3(0.14f + Random.Range(-0.1f, 0.2f), -1.8f, 0f);
            coint_sold8 += 1;
            if (coint_sold8 == 20)
                coint_sold8 = 0;
        }
        //sold 9
        if (_sold_nom == 9)
        {
            pool_sold9[coint_sold9].SetActive(true);
            pool_sold9[coint_sold9].transform.position = new Vector3(0.14f + Random.Range(-0.1f, 0.2f), -1.8f, 0f);
            coint_sold9 += 1;
            if (coint_sold9 == 20)
                coint_sold9 = 0;
        }
        //sold 10
        if (_sold_nom == 10)
        {
            pool_sold10[coint_sold10].SetActive(true);
            pool_sold10[coint_sold10].transform.position = new Vector3(0.14f + Random.Range(-0.1f, 0.2f), -1.8f, 0f);
            coint_sold10 += 1;
            if (coint_sold10 == 20)
                coint_sold10 = 0;
        }
        //sold 11
        if (_sold_nom == 11)
        {
            pool_sold11[coint_sold11].SetActive(true);
            pool_sold11[coint_sold11].transform.position = new Vector3(0.14f + Random.Range(-0.1f, 0.2f), -1.8f, 0f);
            coint_sold11 += 1;
            if (coint_sold11 == 20)
                coint_sold11 = 0;
        }
    }
	
	
}
