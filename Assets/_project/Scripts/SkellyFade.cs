using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkellyFade : MonoBehaviour {

    public Material skellyMaterial;

    public Color Active, Passive;

    bool faded = false;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Period))
        {
            if(faded)
            {
                print("Fading In");
                FadeMaterial(false);
            }
            else
            {
                print("Fading out");
                FadeMaterial(true);
            }
            faded = !faded;
        }
    }

    public void FadeMaterial(bool transparent)
    {
        if(transparent)
        {
            skellyMaterial.color = Passive;
        }
        else
        {
            skellyMaterial.color = Active;
        }
    }
}
