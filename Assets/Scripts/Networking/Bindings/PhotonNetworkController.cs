using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

namespace DigitaleSpielekiste {
    public class PhotonNetworkController : IConnectionCallbacks, IMatchmakingCallbacks
    {

        private RoomSettings roomSettings;
        public void setRoomSettings(RoomSettings settings) {
            roomSettings = settings;
        }

        private string randomName(int length) {
            string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ123456789";
            string response = "";

            for(int i = 0; i < length; i++) {
                response += letters[Random.Range(0, letters.Length)];
            }

            return response;
        }

        public PhotonNetworkController() {
            PhotonNetwork.AddCallbackTarget(this);
        }

        // Start is called before the first frame update
        public void Initialize()
        {
            PhotonNetwork.ConnectUsingSettings();
        }

        public void CreateRoom(RoomSettings settings) {
            setRoomSettings(settings);
            TryCreateRoom();
        }

        public void TryCreateRoom() {
            string id = randomName(5);
            roomSettings.id = id;
            
            RoomOptions roomOptions = new RoomOptions();
            roomOptions.IsVisible = false;
            roomOptions.CustomRoomProperties = (ExitGames.Client.Photon.Hashtable)roomSettings.toHashtable();

            PhotonNetwork.CreateRoom(id, roomOptions);
        }

        public void OnConnected() {

        }

        public void OnDisconnected(DisconnectCause cause) {
            NetworkController.onDisconnected("");
        }

        public void OnRegionListReceived(RegionHandler region) {

        }

        public void OnCustomAuthenticationResponse(Dictionary<string, object> args) {

        }

        public void OnCustomAuthenticationFailed(string args) {
            NetworkController.onDisconnected("Custom Authentication Failed");
        }

        public void OnConnectedToMaster()
        {
            NetworkController.onInitialized();
        }

        public void OnFriendListUpdate(List<FriendInfo> friendInfos) {

        }

        public void OnCreatedRoom() {
            NetworkController.onCreatedRoom(new RoomController(roomSettings));
        }

        public void OnCreateRoomFailed(short desc, string args) {
            this.TryCreateRoom();
        }

        public void OnJoinedRoom() {
            RoomSettings settings = new RoomSettings();
            settings.fromHashtable(PhotonNetwork.CurrentRoom.CustomProperties);
            NetworkController.onJoinedRoom(new RoomController(settings));
        }

        public void OnJoinRoomFailed(short desc, string args) {

        }

        public void OnJoinRandomFailed(short desc, string args) {

        }

        public void OnLeftRoom() {
            NetworkController.onLeftRoom();
        }
    }
}