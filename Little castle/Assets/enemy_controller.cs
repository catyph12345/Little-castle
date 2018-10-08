using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_controller : MonoBehaviour {

    private float scalX = 0;
    private float scalY = 0;

    private Transform _this;

    void Start ()
    {
        _this = transform;

    }
	
	
	void Update ()
    {

        //scale enemy for anim
        if (scalX <= 1f)
        {
            _this.localScale = new Vector3(_this.localScale.x - 0.1f * Time.deltaTime, _this.localScale.y, 1f);
            scalX += 1f * Time.deltaTime;
            if (scalX >= 1f)
                _this.localScale = new Vector3(0.9f, 1f, 1f);
        }
        else
        {
            _this.localScale = new Vector3(_this.localScale.x + 0.1f * Time.deltaTime, _this.localScale.y, 1f);
            scalX += 1f * Time.deltaTime;
            if (scalX >= 2f)
            {
                scalX = 0f;
                _this.localScale = new Vector3(1f, 1f, 1f);
            }
        }
        if (scalY <= 1f)
        {
            _this.localScale = new Vector3(_this.localScale.x, _this.localScale.y - 0.1f * Time.deltaTime, 1f);
            scalY += 1f * Time.deltaTime;
            if (scalY >= 1f)
                _this.localScale = new Vector3(1f, 0.9f, 1f);
        }
        else
        {
            _this.localScale = new Vector3(_this.localScale.x, _this.localScale.y + 0.1f * Time.deltaTime, 1f);
            scalY += 1f * Time.deltaTime;
            if (scalY >= 2f)
            {
                scalY = 0f;
                _this.localScale = new Vector3(1f, 1f, 1f);
            }
        }



    }
}
