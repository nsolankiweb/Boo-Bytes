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

    [SerializeField] AudioSource AidSound; 

    void Start()
    {
        DeactivateAid();
        Cubes.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {


        if (Cubes.activeInHierarchy && !CubesInstructions.activeInHierarchy)
        {
            DeactivateAid();
            CubesInstructions.SetActive(true);
            AidSound.clip = CubesInstructions.GetComponent<AudioSource>().clip;
            CubesDone = true;
        }
        else if (Glyph.activeInHierarchy && !GlyphInstructions.activeInHierarchy)
        {
            DeactivateAid();
            GlyphInstructions.SetActive(true);
            AidSound.clip = GlyphInstructions.GetComponent<AudioSource>().clip;
            GlyphDone = true;

        }
        else if (Pit.activeInHierarchy && !PitInstructions.activeInHierarchy)
        {
            DeactivateAid();
            PitInstructions.SetActive(true);
            AidSound.clip = PitInstructions.GetComponent<AudioSource>().clip;
            PitDone = true;

        }
        else if (Maze.activeInHierarchy && !MazeInstructions.activeInHierarchy)
        {
            DeactivateAid();
            MazeInstructions.SetActive(true);
            AidSound.clip = MazeInstructions.GetComponent<AudioSource>().clip;
            MazeDone = true;

        }
        else if (TriggerArea1.activeInHierarchy || TriggerArea2.activeInHierarchy || TriggerArea3.activeInHierarchy || TriggerArea4.activeInHierarchy && !MonstersInstructions.activeInHierarchy)
        {
            DeactivateAid();
            MonstersInstructions.SetActive(true);
            AidSound.clip = MonstersInstructions.GetComponent<AudioSource>().clip;

        }
        else if (!Cubes.activeInHierarchy && !Glyph.activeInHierarchy && !Pit.activeInHierarchy && !Maze.activeInHierarchy) 
        {
            if (!CubesDone && !CubesLocation.activeInHierarchy && !GlyphLocation.activeInHierarchy && !PitLocation.activeInHierarchy && !MazeLocation.activeInHierarchy)
            {
                DeactivateAid();
                CubesLocation.SetActive(true);
                AidSound.clip = CubesLocation.GetComponent<AudioSource>().clip;

            }
            else if (!GlyphDone && !CubesLocation.activeInHierarchy && !GlyphLocation.activeInHierarchy && !PitLocation.activeInHierarchy && !MazeLocation.activeInHierarchy)
            {
                DeactivateAid();
                GlyphLocation.SetActive(true);
                AidSound.clip = GlyphLocation.GetComponent<AudioSource>().clip;
            }
            else if (!PitDone && !CubesLocation.activeInHierarchy && !GlyphLocation.activeInHierarchy && !PitLocation.activeInHierarchy && !MazeLocation.activeInHierarchy)
            {

                DeactivateAid();
                PitLocation.SetActive(true);
                AidSound.clip = PitInstructions.GetComponent<AudioSource>().clip;

            }
            else if (!MazeDone && !CubesLocation.activeInHierarchy && !GlyphLocation.activeInHierarchy && !PitLocation.activeInHierarchy && !MazeLocation.activeInHierarchy)
            {
                DeactivateAid();
                MazeLocation.SetActive(true);
                AidSound.clip = MazeInstructions.GetComponent<AudioSource>().clip;
            }

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
