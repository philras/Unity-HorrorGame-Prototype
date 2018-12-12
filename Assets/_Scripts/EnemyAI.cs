using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

    Transform tr_Player;
    public float rotSpeed = 3.0f, moveSpeed = 3.0f;

	// Use this for initialization
	void Start () {

        tr_Player = GameObject.FindGameObjectWithTag("Player").transform;

	}
	
	// Update is called once per frame
	void Update () {

        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(tr_Player.position - transform.position), rotSpeed * Time.deltaTime);

        transform.position += transform.forward * moveSpeed * Time.deltaTime;
	}
}
