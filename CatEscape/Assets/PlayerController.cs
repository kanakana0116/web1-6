using System.Collections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
   
    
        public void LeftArrow() {
            transform.Translate(-3, 0, 0);
        }
    public void ReftArrow() {
            transform.Translate(3, 0, 0);
        }
    }
