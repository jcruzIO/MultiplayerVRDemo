﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun; 
using TMPro; 

public class LoginManager : MonoBehaviourPunCallbacks
{
    public TMP_InputField Playername_InputField; 

    #region UNITY Methods; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #endregion

    #region UI Callback Methods
    public void ConnectToPhotonServer()
    {
        if (Playername_InputField != null)
        {
            PhotonNetwork.NickName = Playername_InputField.text; 
            PhotonNetwork.ConnectUsingSettings(); 
        }
    }
    #endregion

    #region Photon Callback Methods
    public override void OnConnected()
    {
        Debug.Log("OnConnected is called. The server is available.");
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to the Master Server with player name: " + PhotonNetwork.NickName);
        PhotonNetwork.LoadLevel("HomeScene"); 
    }

    #endregion
}
