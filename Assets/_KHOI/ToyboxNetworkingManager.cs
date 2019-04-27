using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class ToyboxNetworkingManager : MonoBehaviourPunCallbacks
{
    public Transform head;
    public Transform rHandAnchor;
    public Transform lHandAnchor;

    public Transform[] spawnPositions;

    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("OnConnectedToMaster() was called by PUN.");
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.IsVisible = true;
        roomOptions.MaxPlayers = 4;
        PhotonNetwork.JoinOrCreateRoom("test", roomOptions, TypedLobby.Default);
    }

    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();
        Debug.Log("ROOM JOINED");
        SpawnAvatar();
    }

    public void SpawnAvatar()
    {
        GameObject tbna = PhotonNetwork.Instantiate("ToyBoxNetworkedAvatar", spawnPositions[PhotonNetwork.PlayerList.Length].position, Quaternion.identity);
        ToyboxNetworkedAvatar networkedAvatar = tbna.GetComponent<ToyboxNetworkedAvatar>();
        networkedAvatar.lHandFollow.SetTransform(lHandAnchor);
        networkedAvatar.rHandFollow.SetTransform(rHandAnchor);
        networkedAvatar.headFollow.SetTransform(head);
    }
}
