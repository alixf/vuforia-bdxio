using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
	void Update () {
        transform.Rotate(0f, 180f * Time.deltaTime, 0f, Space.World);
	}
}
