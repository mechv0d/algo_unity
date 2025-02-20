using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class Destroy : MonoBehaviour
    {
        private void Start()
        {
            Destroy(this.gameObject);
        }
    }
}