using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class miner_icon_controller : MonoBehaviour {

    public int nomber;

    public int move_on = 0;
    public float time_on = 0f;

    private float rotat = 0;
    private float rotat2 = 0;

    private Image _image;
    private Transform _trans;

    void Awake ()
    {
        miner_controller.miner_icon[nomber] = this;
        _image = GetComponent<Image>();
        _trans = transform;
        _image.color = new Vector4(1f,1f,1f,0f);
        _trans.rotation = Quaternion.Euler(0f, 0f, Random.Range(-10f, 10f));
    }
	
	
	void Update ()
    {
		if(move_on == 0)
        {
            time_on = Random.Range(1f,9f);
            move_on = 1;
        }
        if(move_on == 1)
        {
            time_on -= 1f * Time.deltaTime;
            if(time_on <= 0f)
            {
                _image.color = new Vector4(1f, 1f, 1f, 1f);
                _trans.position = new Vector3(0.14f + Random.Range(-0.3f, 0.1f), -1.8f, 0f);
                _trans.rotation = Quaternion.Euler(0f, 0f, rotat);
                move_on = 2;
            }
        }
        if (move_on == 2)
        {
            //anim walk
            if (rotat2 == 0)
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
            _trans.rotation = Quaternion.Euler(0f, 0f, rotat);

            //walk
            _trans.position = new Vector3(_trans.position.x - 1f * Time.deltaTime, _trans.position.y, 0f);

            if(_trans.position.x <= -2.55f)
            {
                move_on = 3;
                _image.color = new Vector4(1f, 1f, 1f, 0f);
            }
        }
        if (move_on == 3)
        {
            time_on = Random.Range(1f, 9f);
            move_on = 4;
        }
        if (move_on == 4)
        {
            time_on -= 1f * Time.deltaTime;
            if (time_on <= 0f)
            {
                _image.color = new Vector4(1f, 1f, 1f, 1f);
                _trans.position = new Vector3(-2.55f + Random.Range(-0.1f, 0.1f), -1.8f, 0f);
                _trans.rotation = Quaternion.Euler(0f, 180f, rotat);
                move_on = 5;
            }
        }
        if (move_on == 5)
        {
            //anim walk
            if (rotat2 == 0)
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
            _trans.rotation = Quaternion.Euler(0f, 180f, rotat);

            //walk
            _trans.position = new Vector3(_trans.position.x + 1f * Time.deltaTime, _trans.position.y, 0f);

            if (_trans.position.x >= 0.14f)
            {
                move_on = 0;
                _image.color = new Vector4(1f, 1f, 1f, 0f);
            }
        }





    }
}
