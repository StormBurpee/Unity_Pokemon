using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BasePokemon : MonoBehaviour {

    public string Name;
    public Sprite image;
    public BiomeList biomeFound;
    public PokemonType type;
    public float baseHP;
    private float maxHP;
    public float baseAttack;
    public float maxAttack;
    public float baseDef;
    public float maxDef;
    public float speed;

    private int level;

	void Start () {
	
	}
	void Update () {
	
	}
}

public enum Rarity
{
    VeryCommon,
    Common,
    SemiRare,
    Rare,
    VeryRare
}

public enum PokemonType
{
    Flying,
    Ground,
    Rock,
    Steel,
    Fire,
    Water,
    Grass,
    Ice,
    Electra,
    Psychic,
    Dark,
    Dragon
}