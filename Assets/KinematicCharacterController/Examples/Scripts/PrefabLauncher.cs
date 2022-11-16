using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace KinematicCharacterController.Examples
{
    public class PrefabLauncher : MonoBehaviour
    {
        public Rigidbody ToLaunch;
        public float Force;

        void Update()
        {
            if (Keyboard.current.enterKey.wasPressedThisFrame)
            {
                Rigidbody inst = Instantiate(ToLaunch, transform.position, transform.rotation);
                inst.AddForce(transform.forward * Force, ForceMode.VelocityChange);
                Destroy(inst.gameObject, 8f);
            }
        }
    }
}