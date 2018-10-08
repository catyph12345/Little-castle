using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button_panel_controller : MonoBehaviour {

    public int nomber;

    private bool on_off = true;

    private Button but_knp;
    private Image img;

    void Start ()
    {
        but_knp = GetComponent<Button>();
        img = GetComponent<Image>();
    }
	
	
	void Update ()
    {
        //update button
        if (game_manager.nomber_pan == nomber)
        {
            if (on_off == false)
            {
                on_off = true;
                but_knp.interactable = true;
                img.color = new Vector4(1f, 1f, 1f, 1f);
            }
        }
        else
        {
            if (on_off == true)
            {
                on_off = false;
                but_knp.interactable = false;
                img.color = new Vector4(1f, 1f, 1f, 0.7f);
            }
        }
    }


    private void OnMouseUpAsButton()
    {
        if(game_manager.nomber_pan != nomber)
        {
            game_manager.Open_panel_all(nomber);
        }
        else
        {
            game_manager.Close_panel_all(nomber);
        }
    }

}
