using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
    public GameObject woodImpact, bloodImpact;
    public static VFXManager instance;
    private void Awake() {
        instance = this;
    }
}
