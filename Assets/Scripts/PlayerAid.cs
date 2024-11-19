using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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
    [SerializeField] GameObject CubesLocationSFX;
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

    GameObject Previous; 

    void Start()
    {
        DeactivateAid();
        Previous = CubesLocation; 
    }

    // Update is called once per frame
    void Update()
    {
     

        if (Cubes.activeInHierarchy && !CubesInstructions.activeInHierarchy)
        {
            DeactivateAid(); 
            CubesInstructions.SetActive(true);
            //CubesInstructions.GetComponent<AudioSource>().Play();
            CubesDone = true;
        }
        else if (Glyph.activeInHierarchy && !GlyphInstructions.activeInHierarchy)
        {
            DeactivateAid();
            GlyphInstructions.SetActive(true);
            //GlyphInstructions.GetComponent<AudioSource>().Play();
            GlyphDone = true;

        }
        else if (Pit.activeInHierarchy && !PitInstructions.activeInHierarchy)
        {
            DeactivateAid();
            PitInstructions.SetActive(true);
            //PitInstructions.GetComponent<AudioSource>().Play();
            PitDone = true;

        }
        else if (Maze.activeInHierarchy && !MazeInstructions.activeInHierarchy)
        {
            DeactivateAid();
            MazeInstructions.SetActive(true);
            //MazeInstructions.GetComponent<AudioSource>().Play();
            MazeDone = true;

        }
        else if (TriggerArea1.activeInHierarchy || TriggerArea2.activeInHierarchy || TriggerArea3.activeInHierarchy || TriggerArea4.activeInHierarchy && !MonstersInstructions.activeInHierarchy)
        {
            DeactivateAid();
            MonstersInstructions.SetActive(true);
            //MonstersInstructions.GetComponent<AudioSource>().Play();

        }
        else if (!CubesDone && !CubesLocation.activeInHierarchy && !GlyphLocation.activeInHierarchy && !PitLocation.activeInHierarchy && !MazeLocation.activeInHierarchy)
        {
            DeactivateAid();
            CubesLocation.SetActive(true);
            //CubesLocation.GetComponent<AudioSource>().Play();

        }
        else if (!GlyphDone && !CubesLocation.activeInHierarchy && !GlyphLocation.activeInHierarchy && !PitLocation.activeInHierarchy && !MazeLocation.activeInHierarchy)
        {
            DeactivateAid();
            GlyphLocation.SetActive(true);
            //GlyphLocation.GetComponent<AudioSource>().Play();
        }
        else if (!PitDone && !CubesLocation.activeInHierarchy && !GlyphLocation.activeInHierarchy && !PitLocation.activeInHierarchy && !MazeLocation.activeInHierarchy)
        {

            DeactivateAid(); 
            PitLocation.SetActive(true);
            //PitInstructions.GetComponent <AudioSource>().Play();

        }
        else if (!MazeDone && !CubesLocation.activeInHierarchy && !GlyphLocation.activeInHierarchy && !PitLocation.activeInHierarchy && !MazeLocation.activeInHierarchy)
        {
            DeactivateAid(); 
            MazeLocation.SetActive(true); 
            //MazeInstructions.GetComponent <AudioSource>().Play();
        }

        
    }

    voic 
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
