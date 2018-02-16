using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyTheme : MonoBehaviour {

	void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
