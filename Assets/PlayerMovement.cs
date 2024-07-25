using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WildBall.Inputs
{
    [RequireComponent(typeof(Rigidbody))]

    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField, Range(18, 200)] private float speed = 20.0f;

        private Rigidbody playerRigidbody;


        private void Awake ()
        {
            playerRigidbody = GetComponent<Rigidbody>();
        }

        
        public void MoveCharacter(Vector3 movement)
        {
            playerRigidbody.AddForce(movement * speed);
        }

#if UNITY_EDITOR
        [ContextMenu("Reset values")]
        public void ResetValues()
        {
            speed = 20;
        }
#endif
    }
}