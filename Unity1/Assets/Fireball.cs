using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    private float speed = 10.0f;
    private int damage = 1;
    // Start is called before the first frame update
    void Start()
    {
         Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        PlayerCharacter player = other.GetComponent<PlayerCharacter>();
        if(player != null){
            player.Hurt(damage);
        }
        Destroy(this.gameObject);
    }
}
