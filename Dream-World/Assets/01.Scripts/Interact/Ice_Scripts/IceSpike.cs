using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSpike : TriggerObject
{
    protected override void TriggerWithPlayer(PlayerController _player)
    {
        Debug.Log("����!!!!!");
        _player.Hit();
    }
}