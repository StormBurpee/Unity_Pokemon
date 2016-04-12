using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public GameObject playerCamera;
    public GameObject battleCamera;

	void Start () {
        playerCamera.SetActive(true);
        battleCamera.SetActive(false);
    }
	
	void Update () {
	
	}

    public void EnterBattle(Rarity rarity)
    {
        playerCamera.SetActive(false);
        battleCamera.SetActive(true);
    }
}
