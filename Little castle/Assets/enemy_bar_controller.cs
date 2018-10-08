using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_bar_controller : MonoBehaviour {

	private Transform _trand;

	void Start ()
    {
        _trand = transform;
    }
	
	
	void Update ()
    {
        float scaleX = (float)(1d / game_manager.enemy_mhp * game_manager.enemy_hp);

        _trand.localScale = new Vector3(scaleX, 1f,1f);
    }
}
