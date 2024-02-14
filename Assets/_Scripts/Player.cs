using System;
using _Scripts.Components;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

namespace _Scripts
{
    public class Player : MonoBehaviour
    {
        private Stat _health;
        private Stat _sanctity;
        
        private Stat _stamina;
        
        
        private int _atk;
        private int _def;
        private int _luck; // experiment 
        
        
        private int _coin;

        public TMP_Text HealthText;
        public TMP_Text SanctityText;
        public TMP_Text StaminaText;
        public TMP_Text AtkText;
        public TMP_Text DefText;
        public TMP_Text LuckText;
        public TMP_Text CoinText;

        private void Awake()
        {
            _health = new Stat(100, 100);
            _stamina = new Stat(100, 100);
            _sanctity = new Stat(100, 100);

            _atk = 10;
            _def = 0;
            _luck = 0;
            _coin = 20;
            UpdateText();
        }

        private void UpdateText()
        {
            HealthText.SetText("Health: " + _health.Get() + " / " + _health.GetMax());
            SanctityText.SetText("Sanctity: " + _sanctity.Get() + " / " + _sanctity.GetMax());
            StaminaText.SetText("Stamina: " + _stamina.Get() + " / " + _stamina.GetMax());
            AtkText.SetText("Atk: " + _atk);
            DefText.SetText("Def: " + _def);
            LuckText.SetText("Luck: " + _luck);
            CoinText.SetText("Coin: " + _coin);
        }

        void Start()
        {
        
        }

        void Update()
        {
        
        }
    }
}
