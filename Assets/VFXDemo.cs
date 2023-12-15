using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class VFXDemo : MonoBehaviour
{
    VisualEffect _vfxGraph;

    // Start is called before the first frame update
    void Start()
    {
        _vfxGraph = GetComponent<VisualEffect>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            _vfxGraph.SendEvent("StartParticles");

        if(Input.GetKeyUp(KeyCode.Space))
            _vfxGraph.SendEvent("StopParticles");
    }
}
