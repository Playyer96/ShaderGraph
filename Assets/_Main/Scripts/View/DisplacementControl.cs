using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplacementControl : MonoBehaviour {
    public float displacemntAmount;
    public MeshRenderer meshRender;

    void Update () {
        displacemntAmount = Mathf.Lerp (displacemntAmount, 0, Time.deltaTime);
        meshRender.material.SetFloat ("_Amount", displacemntAmount);

        if (Input.GetButtonDown ("Jump")) {
            displacemntAmount += 1;
        }
    }
}