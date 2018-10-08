using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bar_army_controller : MonoBehaviour {

    public int nomber;

    private Transform _trans;

    private void Start()
    {
        _trans = transform;
    }

    void Update ()
    {
        _trans.localScale = new Vector3(1f/game_manager.army_mbar[nomber]*game_manager.army_bar[nomber], 1f,1f);
    }
}
