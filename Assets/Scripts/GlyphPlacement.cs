using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia; 

public class GlyphPlacement : MonoBehaviour
{
   
    [SerializeField] private GameObject glyph;
    [SerializeField] private GameObject stage;
    [SerializeField] private GameObject sfxSource; 
    private AudioSource sfx; 

    private int nameCount = 0;

    private float scaleFactor = 1f;

    private GameObject currentObj;

    [SerializeField]
    private GameObject virusArea;

    private bool placed = false;

    private Transform pos; 

    // Start is called before the first frame update
    void Start()
    {
        virusArea.SetActive(false);
        sfx = sfxSource.GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && placed == false)
        {
            Touch currentTouch = Input.GetTouch(0);

            switch (currentTouch.phase)
            {
                case (TouchPhase.Began):
                    scaleFactor = 1f;
                    break;

                case (TouchPhase.Moved):
                    scaleFactor *= 1.0005f;
                    currentObj.transform.localScale += new Vector3(scaleFactor, scaleFactor, scaleFactor);
                    currentObj.transform.position += new Vector3(-scaleFactor, 0f, -scaleFactor); 
                    break;

                case (TouchPhase.Stationary):
                    scaleFactor *= 1.0005f;
                    currentObj.transform.localScale += new Vector3(scaleFactor, scaleFactor, scaleFactor);
                    currentObj.transform.position += new Vector3(-scaleFactor, 0f, -scaleFactor);
                    break;

                case (TouchPhase.Ended):
                    if(currentObj != null)
                    {
                        sfx.Play();
                    }
                    break;

            }
        }

        if(currentObj.CompareTag("Solved"))
        {
            virusArea.SetActive(true);
            virusArea.GetComponent<Renderer>().enabled = true;
            
        }
        
    }

    public void AnchorCreator(Transform worldPositioning)
    {
        GameObject ObjectToAnchor = Instantiate(glyph, worldPositioning.position, Quaternion.Euler(0, worldPositioning.rotation.y, 0));
        AnchorBehaviour myAnchor = ObjectToAnchor.AddComponent<AnchorBehaviour>();
        myAnchor.ConfigureAnchor("Anchor"+nameCount.ToString(), worldPositioning.position, Quaternion.Euler(0, worldPositioning.rotation.y, 0));
        nameCount++;

        currentObj = ObjectToAnchor;
        stage.SetActive(false);
    }

    public void DonePlacing()
    {
        placed = true; 
    }

}
