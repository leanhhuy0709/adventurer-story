using _Scripts.Components;
using UnityEngine;
using UnityEngine.Serialization;

namespace _Scripts
{
    public class GameEventManager : MonoBehaviour
    {
        public TextAsset JsonFile;
        void Start()
        {
            var employeesInJson = JsonUtility.FromJson<GameEvents>(JsonFile.text);
            
            foreach (var employee in employeesInJson.data)
            {
                if(employee.mob != null)
                    Debug.Log(employee.mob.atk);
            }
        }

        void Update()
        {
        
        }
    }
}
