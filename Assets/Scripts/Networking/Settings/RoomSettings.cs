using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DigitaleSpielekiste
{
    [System.Serializable]
    public class RoomSettings : ScriptableObject
    {
        new public string name;
        public string id;
        public string gameType;

        public Dictionary<object, object> toHashtable() {
            return new Dictionary<object, object>() {
                { "name", this.name },
                { "id", this.id },
                { "gameType", this.gameType }
            };
        }

        public void fromHashtable(Dictionary<object, object> table) {
            this.name = (string)table["name"];
            this.id = (string)table["id"];
            this.gameType = (string)table["gameType"];
        }
    }
}