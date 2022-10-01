using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace Rollaboll
{
    public class AddForceMovement : MonoBehaviour
    {
        private Rigidbody _rigidbody;
        [SerializeField] public static float  speed =5f;
        [SerializeField] private Text text;
        private int score = 0;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void FixedUpdate()
        {
            if(Input.GetKey(KeyCode.W))
            {
                _rigidbody.velocity = transform.TransformDirection(new Vector3(0f,0f,-10f) * speed);
            }
            if (Input.GetKey(KeyCode.S))
            {
                _rigidbody.velocity = transform.TransformDirection(new Vector3(0f, 0f, 10f) * speed);
            }
            if (Input.GetKey(KeyCode.A))
            {
                _rigidbody.velocity = transform.TransformDirection(new Vector3(10f, 0f, 0f) * speed);
            }
            if (Input.GetKey(KeyCode.D))
            {
                _rigidbody.velocity = transform.TransformDirection(new Vector3(-10f, 0f, 0f) * speed);
            }
            if (Input.GetKey(KeyCode.Space))
            {
                _rigidbody.velocity = transform.TransformDirection(new Vector3(0f, 50f, 0f) * speed);
            }


        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Coins")
            {
                Destroy(other.gameObject);
                score++;
                if (score!=10)
                {
                    text.text = "Монет собрано:" + score;
                }
                if (score >= 10)
                {
                    text.text = "Дойдите до финиша";
                }
                
            }
            if (other.gameObject.tag == "Finish")
            {
                Time.timeScale = 0;
                text.text = "Игра окончена";
            }
        }






    }



}
