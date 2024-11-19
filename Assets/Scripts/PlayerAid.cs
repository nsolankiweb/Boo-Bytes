using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia; 

public class PlayerAid : MonoBehaviour
{
    [SerializeField] GameObject GlyphInstructions;
    [SerializeField] GameObject GlyphLocation;
    [SerializeField] GameObject PitInstructions;
    [SerializeField] GameObject PitLocation;
    [SerializeField] GameObject MazeInstructions; 
    [SerializeField] GameObject MazeLocation;
    [SerializeField] GameObject CubesInstructions;
    [SerializeField] GameObject CubesLocation;
    [SerializeField] GameObject MonstersInstructions;


    [SerializeField] GameObject Glyph;
    [SerializeField] GameObject Pit; 
    [SerializeField] GameObject Maze;
    [SerializeField] GameObject Cubes;

    bool GlyphDone = false;
    bool PitDone = false;
    bool MazeDone = false;  
    bool CubesDone = false;

    [SerializeField] GameObject TriggerArea1; 
    [SerializeField] GameObject TriggerArea2;
    [SerializeField] GameObject TriggerArea3;
    [SerializeField] GameObject TriggerArea4;

    void Start()
    {
        DeactivateAid();
    }

    // Update is called once per frame
    void Update()
    {
        DeactivateAid();

        if (Cubes.activeInHierarchy)
        {
            CubesInstructions.SetActive(true);
            CubesDone = true;

        }
        else if (Glyph.activeInHierarchy)
        {

            GlyphInstructions.SetActive(true);
            GlyphDone = true;

        }
        else if (Pit.activeInHierarchy)
        {
            PitInstructions.SetActive(true);
            PitDone = true;

        }
        else if (Maze.activeInHierarchy)
        {
            MazeInstructions.SetActive(true);
            MazeDone = true;

        }
        else if (TriggerArea1.activeInHierarchy || TriggerArea2.activeInHierarchy || TriggerArea3.activeInHierarchy || TriggerArea4.activeInHierarchy)
        {
            MonstersInstructions.SetActive(true);

        }
        else if (!CubesDone)
        {
            CubesLocation.SetActive(true);

        }
        else if (!GlyphDone)
        {
            GlyphLocation.SetActive(true);
        }
        else if (!PitDone)
        {

            PitInstructions.SetActive(true);

        }
        else if (!MazeDone)
        {
            MazeInstructions.SetActive(true); 
        }

        
    }

    void DeactivateAid()
    {
        GlyphInstructions.SetActive(false);
        GlyphLocation.SetActive(false);
        PitInstructions.SetActive(false);
        PitLocation.SetActive(false);
        MazeInstructions.SetActive(false);
        MazeLocation.SetActive(false);
        CubesInstructions.SetActive(false);
        CubesLocation.SetActive(false);
        MonstersInstructions.SetActive(false);
    }
}
