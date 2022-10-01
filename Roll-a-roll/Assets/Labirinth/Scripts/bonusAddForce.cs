using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rollaboll
{
    public class bonusAddForce : MonoBehaviour
    {
        

       
        private void OnCollisionEnter(Collision collision)
        {

            if (collision.gameObject)
            {
                Object.Destroy(gameObject);
                AddForceMovement.speed = 10f;
            }
        }










    }


    }
