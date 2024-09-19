using UnityEngine;
using UnityEngine.UI; // For UI components

public class PHONEControl : MonoBehaviour
{
    bool isOn = true;
    public GameObject uiImage; // Assign this in the Inspector or find it programmatically

    void Start()
    {
        // Optional: Find the GameObject if it is not assigned in the Inspector
        if (uiImage == null)
        {
            uiImage = GameObject.Find("ImageName"); // Replace "ImageName" with the actual name of your image in the Canvas
        }
    }

    public void ToggleImage()
    {
        isOn = !isOn; // Toggles between true and false

        // Check if uiImage is assigned, then toggle the Image component
        if (uiImage != null)
        {
            Image imageComponent = uiImage.GetComponent<Image>();
            if (imageComponent != null)
            {
                imageComponent.enabled = isOn; // Enable or disable the Image component
            }
            else
            {
                Debug.LogError("No Image component found on the assigned GameObject.");
            }
        }
        else
        {
            Debug.LogError("uiImage GameObject is not assigned.");
        }
    }
}