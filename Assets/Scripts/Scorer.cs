using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int counter = 0;

    private void OnCollisionEnter(Collision other) {
        counter++;
        Debug.Log("You have bumped into a thing &d times " + counter);
    }
}
