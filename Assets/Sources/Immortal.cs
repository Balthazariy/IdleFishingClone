using UnityEngine;

namespace Balthazariy.IdleFishinClone
{
    public class Immortal : MonoBehaviour
    {
        public static Immortal Instance;

        private void Awake()
        {
            if (Instance == null)
                Instance = new Immortal();

            DontDestroyOnLoad(gameObject);
        }
    }
}