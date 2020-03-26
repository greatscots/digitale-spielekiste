using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DigitaleSpielekiste
{
    public class RoomController
    {
        public RoomSettings settings {
            private set;
            get;
        }

        public RoomController(RoomSettings roomSettings) {
            this.settings = roomSettings;
        }

        public PlayerSettings[] GetPlayers() {
            return new PlayerSettings[0];
        }
    }
}