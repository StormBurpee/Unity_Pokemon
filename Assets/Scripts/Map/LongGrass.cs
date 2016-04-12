using UnityEngine;
using System.Collections;

public class LongGrass : MonoBehaviour {

    public BiomeList grassType;

    private GameManager gm;

	void Start () {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
	}
	
	void Update () {
	    
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.GetComponent<PlayerMovement>())
        {
            //P = x / 187.5
            //VC = 10, C = 8.5, Semi-Are = 6.75, Rare = 3.33, VR = 1.25
            float vc = 10 / 187.5f;
            float c = 8.5f / 187.5f;
            float sr = 6.75f / 187.5f;
            float r = 3.33f / 187.5f;
            float vr = 1.25f / 187.5f;

            float p = Random.Range(0.0f, 100.0f);

            if(p < vr*100)
            {
                if (gm != null)
                    gm.EnterBattle(Rarity.VeryRare);
            }
            else if(p < r*100)
            {
                if (gm != null)
                    gm.EnterBattle(Rarity.Rare);
            }
            else if(p < sr*100)
            {
                if (gm != null)
                    gm.EnterBattle(Rarity.SemiRare);
            }
            else if(p < c*100)
            {
                if (gm != null)
                    gm.EnterBattle(Rarity.Common);
            }
            else if(p < vc*100)
            {
                if (gm != null)
                    gm.EnterBattle(Rarity.VeryCommon);
            }
        }
    }
}
