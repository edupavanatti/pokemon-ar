using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleARCore;

public class PokemonController : MonoBehaviour
{
    private DetectedPlane detectedPlane;
    public GameObject pokemonPrefab;

    void SpawnPokemon()
    {
        Vector3 pos = detectedPlane.CenterPose.position;
        Instantiate(pokemonPrefab, pos, Quaternion.identity, transform);
    }

    public void SetPlane(DetectedPlane plane)
    {
        detectedPlane = plane;
        SpawnPokemon();
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
