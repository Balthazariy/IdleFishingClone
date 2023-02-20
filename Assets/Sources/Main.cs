using UnityEngine;

namespace Balthazariy.IdleFishinClone
{
    public class Main : MonoBehaviour
    {
        public static Main Instance;

        private void Awake()
        {
            if (Instance == null)
                Instance = this;
        }
    }
}