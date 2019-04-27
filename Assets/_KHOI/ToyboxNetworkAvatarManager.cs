using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class ToyboxNetworkAvatarManager : MonoBehaviourPunCallbacks
{
    public Transform head;
    public Transform rHandAnchor;
    public Transform lHandAnchor;

    public override void OnJoinedRoom()
    {
        // PhotonNetwork.Instantiate("ToyBoxNetwork")
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
