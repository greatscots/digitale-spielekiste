using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DigitaleSpielekiste
{
    public static class NetworkController
    {
        /// <summary>
        /// Creates a new Room
        /// </summary>
        /// <remarks>
        /// Tries to create a new room with a random ID.
        /// </remarks>
        /// <returns>
        /// Callback contains the created Room, which is an Instance of the RoomController.
        /// </returns>
        /// <param name="playerSettings">An Instance of <c>PlayerSettings</c></param>
        /// <param name="roomSettings">An Instance of <c>RoomSettings</c> without the ID specified.</param>
        public static void CreateRoom(
            PlayerSettings playerSettings,
            RoomSettings roomSettings,
            Event<RoomController> callback
        ) {

        }

        /// <summary>
        /// Tries to join a Room.
        /// </summary>
        /// <remarks>
        /// Tries to join a room with the given ID.
        /// </remarks>
        /// <returns>
        /// Callback contains the Room settings of the joined Room.
        /// </returns>
        public static void JoinRoom(
            PlayerSettings playerSettings,
            string roomId,
            Event<RoomController> callback
        ) {

        }

        public delegate void Event<T>(T args);
    }
}