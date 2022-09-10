using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayerWelcome : MonoBehaviour
{
    private int playerCount = 0;
    void OnPlayerConnected(NetworkPlayer player)
    {
        Debug.Log("Player " + playerCount + " connected from " + player.ipAddress + ":" + player.port "Welcome Aboard");
    }
}
