using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class coin_controller : MonoBehaviour {

    public TextMeshProUGUI text_coin;
    public TextMeshProUGUI text_curren;
    public TextMeshProUGUI text_curren_per;

    void Update ()
    {
        text_coin.text = game_manager.Reduction_0(game_manager.player_coin);
        text_curren.text = game_manager.Reduction_0(game_manager.player_curen);
        text_curren_per.text = "<sprite=1>+"+ game_manager.Reduction_0(game_manager.player_curen_incom)+" per/sec";
    }
}
