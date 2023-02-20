using UnityEngine;

namespace Balthazariy.IdleFishinClone.Immortal
{
    public class Immortal : MonoBehaviour
    {
        private void Awake()
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}