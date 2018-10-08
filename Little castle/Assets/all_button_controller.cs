using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class all_button_controller : MonoBehaviour {

    private Transform _trans;

    void Awake()
    {
        _trans = transform;
        game_manager.all_but = this;
        Update_polX();
    }

    public void Update_polX()
    {
        if(game_manager.nomber_pan >= 0)
        {
            _trans.localPosition = new Vector3(0f,0f,0f);
        }
        else
        {
            _trans.localPosition = new Vector3(-2.96f, 0f, 0f);
        }
    }
}
