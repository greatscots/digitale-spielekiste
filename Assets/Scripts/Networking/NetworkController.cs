using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DigitaleSpielekiste
{
    public static class NetworkController
    {
        #region GlobalMethods

        private static RoomController room;

        /// <summary>
        /// Checks if the Device is connected to a Room.
        /// </summary>
        public static bool HasRoom() {
            return room != null;
        }

        /// <summary>
        /// Returns the Room
        /// </summary>
        /// <remarks>
        /// Device has to be connected to a room or else this will return <c>null</c>
        /// </remarks>
        public static RoomController GetRoom() {
            return room;
        }

        /// <summary>
        /// Creates a new Room
        /// </summary>
        /// <remarks>
        /// Tries to create a new room with a random ID.
        /// </remarks>
        /// <returns>
        /// If successful it will call the <c>onCreatedRoom</c> and then the <c>onJoinedRoom</c> event.
        /// </returns>
        /// <param name="playerSettings">An Instance of <c>PlayerSettings</c></param>
        /// <param name="roomSettings">An Instance of <c>RoomSettings</c> without the ID specified.</param>
        public static void CreateRoom(
            PlayerSettings playerSettings,
            RoomSettings roomSettings
        ) {

        }

        /// <summary>
        /// Tries to join a Room.
        /// </summary>
        /// <remarks>
        /// Tries to join a room with the given ID.
        /// </remarks>
        /// <returns>
        /// Callback contains an Instance of the <c>RoomController</c> for the joined Room.
        /// </returns>
        public static void JoinRoom(
            PlayerSettings playerSettings,
            string roomId
        ) {

        }

        #endregion

        #region Events

        public static NetworkEvent<RoomController> onJoinedRoom = delegate {};

        public static NetworkEvent<RoomController> onCreatedRoom = delegate {};

        public static NetworkEvent<string> onLeftRoom = delegate {};

        public static NetworkEvent<string> onLostConnection = delegate {};


        /// Add Event Listeners of return-type <c>RoomController</c>
        public static bool addEventListener(string name, NetworkEvent<RoomController> callback){
            switch(name) {
                case "joined-room":
                    onJoinedRoom += callback;
                    return true;
                case "created-room":
                    onCreatedRoom += callback;
                    return true;
            }

            return false;
        }

        /// Add Event Listeners with return-type <c>String</c>
        public static bool addEventListener(string name, NetworkEvent<string> callback) {
            switch(name) {
                case "left-room":
                    onLeftRoom += callback;
                    return true;
                case "lost-connection":
                    onLostConnection += callback;
                    return true;
            }

            return false;
        }

        #endregion

        public delegate void NetworkEvent<T>(T args);
    }
}