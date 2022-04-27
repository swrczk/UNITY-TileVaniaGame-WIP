using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
   [SerializeField] float bulletSpeed = 1f;
   PlayerMovement player;
   Rigidbody2D rgBody;
   float xSpeed;
   void Start()
   {
      rgBody = GetComponent<Rigidbody2D>();
      player = FindObjectOfType<PlayerMovement>();
      xSpeed = player.transform.localScale.x * bulletSpeed;
   }

   void Update()
   {
      rgBody.velocity = new Vector2(xSpeed, 0f);
   }
   void OnTriggerEnter2D(Collider2D other)
   {
      if (other.tag == "Enemy")
      {
         Destroy(other.gameObject);
      }
      Destroy(gameObject);
   }
}
