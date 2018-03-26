using UnityEngine;
using System.Collections;

public class VehicleShooting2 : MonoBehaviour
{
	public Rigidbody bulletPrefab;
	public Transform Front;
	public float fireRate = 15f;

	private float nextTimeToFire = 2f;

	void Update()
	{
		if (Input.GetButton("Fire2") && Time.time >= nextTimeToFire) 
		{
			nextTimeToFire = Time.time + 20f / fireRate;
			Rigidbody bulletInstance;
			bulletInstance = Instantiate (bulletPrefab, Front.position, Front.rotation) as Rigidbody;
			bulletInstance.AddForce (Front.forward * 1);
		}
	}
}