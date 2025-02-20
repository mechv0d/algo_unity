using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class CreatePrimitives : MonoBehaviour
    {
        private void CreatePrimitive(Vector3 position)
        {
            var primitive = GameObject.CreatePrimitive(PrimitiveType.Cube)
                .transform.position = new Vector3(position.x, position.y, position.z);
        }

        private void Start()
        {
            CreatePrimitive(Vector3.zero);
            
            CreatePrimitive(new(-.5f, 1f, 0));
            CreatePrimitive(new(.5f, 1f, 0));
            
            CreatePrimitive(new(-.5f, 2f, 0));
            CreatePrimitive(new(.5f, 2f, 0));
            
            CreatePrimitive(new(0, 3f, 0));
        }
    }
}