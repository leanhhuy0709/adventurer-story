

using System;
using System.Collections.Generic;
using UnityEngine.Serialization;
// ReSharper disable All



namespace _Scripts.Components
{
    [Serializable]
    public class PlayerStat
    {
        public int health;
        public int sanctity;
        public int stamina;
        public int atk;
        public int def;
        public int luck;
        public int coin;
    }
    [Serializable]
    public class MobStat
    {
        public int health;
        public int atk;
        public int def;
        public int level;
    }
    [Serializable]
    public class GameEvent
    {
        public string name;
        public string description;
        public PlayerStat stat;
        public string type;
        public MobStat mob;
    }
    
    [Serializable]
    public class GameEvents
    {
        public List<GameEvent> data;
    }
}