using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab6Script : MonoBehaviour
{
   
    public int minCylinders = 3; // Minimum number of cylinders to spawn
    public int maxCylinders = 10; // Maximum number of cylinders to spawn
    public float minScale = 0.5f; // Minimum scale for the cylinders
    public float maxScale = 2.0f; // Maximum scale for the cylinders

    // Materials for the platform, cylinders, and pyramid rows
    public Material cubeMaterial; // Material for the platform
    public Material cylinderMaterial; // Material for the cylinders
    public Material pyramidbottom; // Material for the bottom row of the pyramid
    public Material pyramidsecondrow; // Material for the second row of the pyramid
    public Material pyramidthirdrow; // Material for the third row of the pyramid
    public Material pyramidfourthrow; // Material for the fourth row of the pyramid
    public Material pyramidfifthrow; // Material for the fifth row of the pyramid

    void Start()
    {
        // Create the platform (base cube for the pyramid)
        GameObject baseCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        baseCube.transform.localScale = new Vector3(8f, 1f, 8f); // Set the size of the platform
        Renderer baseCubeRenderer = baseCube.GetComponent<Renderer>();
        baseCubeRenderer.material = cubeMaterial; // Apply the platform material

        // Generate the pyramid structure
        CreatePyramid();

        // Generate the cylinders on top of the platform
        GenerateCylinders(baseCube);
    }

    void CreatePyramid()
    {
        // Create the bottom row of the pyramid
        int horcubepresent = 0;
        float xposition = 0.75f; // Starting X position for the bottom row
        while (horcubepresent <= 4)
        {
            // Create a cube for the bottom row
            GameObject pyramidcube1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            pyramidcube1.transform.position = new Vector3(xposition, 0.75f, 0f); // Set position
            pyramidcube1.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f); // Set scale
            xposition -= 0.75f; // Move to the next position in the row
            horcubepresent++; // Increment the cube counter
            Renderer pyramidcube1Renderer = pyramidcube1.GetComponent<Renderer>();
            pyramidcube1Renderer.material = pyramidbottom; // Apply the bottom row material
        }

        // Create the vertical rows of the pyramid
        int vercubepresent = 0;
        float xpositionsecondcube = 0.75f; // Starting X position for the vertical rows
        while (vercubepresent <= 4)
        {
            // Create cubes for the vertical rows
            GameObject pyramidcube2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            pyramidcube2.transform.position = new Vector3(xpositionsecondcube, 0.75f, -0.75f);
            pyramidcube2.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            Renderer pyramidcube2Renderer = pyramidcube2.GetComponent<Renderer>();
            pyramidcube2Renderer.material = pyramidbottom; // Apply the bottom row material

            GameObject pyramidcube3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            pyramidcube3.transform.position = new Vector3(xpositionsecondcube, 0.75f, -1.5f);
            pyramidcube3.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            Renderer pyramidcube3Renderer = pyramidcube3.GetComponent<Renderer>();
            pyramidcube3Renderer.material = pyramidbottom; // Apply the bottom row material

            GameObject pyramidcube4 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            pyramidcube4.transform.position = new Vector3(xpositionsecondcube, 0.75f, -2.25f);
            pyramidcube4.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            Renderer pyramidcube4Renderer = pyramidcube4.GetComponent<Renderer>();
            pyramidcube4Renderer.material = pyramidbottom; // Apply the bottom row material

            GameObject pyramidcube5 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            pyramidcube5.transform.position = new Vector3(xpositionsecondcube, 0.75f, 0f);
            pyramidcube5.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            Renderer pyramidcube5Renderer = pyramidcube5.GetComponent<Renderer>();
            pyramidcube5Renderer.material = pyramidbottom; // Apply the bottom row material

            xpositionsecondcube -= 0.75f; // Move to the next position in the row
            vercubepresent++; // Increment the cube counter
        }

        // Create the second row of the pyramid
        int secondrow = 0;
        float xpositionsecondrowcube = 0.4f; // Starting X position for the second row
        while (secondrow <= 3)
        {
            // Create cubes for the second row
            GameObject seconrowcube1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            seconrowcube1.transform.position = new Vector3(xpositionsecondrowcube, 1.25f, -0.5f);
            seconrowcube1.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            Renderer secondrowcube1Renderer = seconrowcube1.GetComponent<Renderer>();
            secondrowcube1Renderer.material = pyramidsecondrow; // Apply the second row material

            GameObject secondrowcube2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            secondrowcube2.transform.position = new Vector3(xpositionsecondrowcube, 1.25f, -1.25f);
            secondrowcube2.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            Renderer secondrowcube2Renderer = secondrowcube2.GetComponent<Renderer>();
            secondrowcube2Renderer.material = pyramidsecondrow; // Apply the second row material

            GameObject secondrowcube3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            secondrowcube3.transform.position = new Vector3(xpositionsecondrowcube, 1.25f, -2.0f);
            secondrowcube3.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            Renderer secondrowcube3Renderer = secondrowcube3.GetComponent<Renderer>();
            secondrowcube3Renderer.material = pyramidsecondrow; // Apply the second row material

            xpositionsecondrowcube -= 0.75f; // Move to the next position in the row
            secondrow++; // Increment the cube counter
        }

        // Create the third row of the pyramid
        int thirdrow = 0;
        float xpositionthirdrowcube = 0.0f; // Starting X position for the third row
        while (thirdrow <= 2)
        {
            // Create cubes for the third row
            GameObject thirdrowcube1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            thirdrowcube1.transform.position = new Vector3(xpositionthirdrowcube, 1.75f, -0.5f);
            thirdrowcube1.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            Renderer thirdrowcube1Renderer = thirdrowcube1.GetComponent<Renderer>();
            thirdrowcube1Renderer.material = pyramidthirdrow; // Apply the third row material

            GameObject thirdrowcube2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            thirdrowcube2.transform.position = new Vector3(xpositionthirdrowcube, 1.75f, -1.25f);
            thirdrowcube2.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            Renderer thirdrowcube2Renderer = thirdrowcube2.GetComponent<Renderer>();
            thirdrowcube2Renderer.material = pyramidthirdrow; // Apply the third row material

            GameObject thirdrowcube3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            thirdrowcube3.transform.position = new Vector3(xpositionthirdrowcube, 1.75f, -2.0f);
            thirdrowcube3.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            Renderer thirdrowcube3Renderer = thirdrowcube3.GetComponent<Renderer>();
            thirdrowcube3Renderer.material = pyramidthirdrow; // Apply the third row material

            xpositionthirdrowcube -= 0.75f; // Move to the next position in the row
            thirdrow++; // Increment the cube counter
        }

        // Create the fourth row of the pyramid
        int fourthrow = 0;
        float xpositionfourthrowcube = -0.4f; // Starting X position for the fourth row
        while (fourthrow <= 1)
        {
            // Create cubes for the fourth row
            GameObject fourthrowcube1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            fourthrowcube1.transform.position = new Vector3(xpositionfourthrowcube, 2.25f, -0.85f);
            fourthrowcube1.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            Renderer fourthrowcube1Renderer = fourthrowcube1.GetComponent<Renderer>();
            fourthrowcube1Renderer.material = pyramidfourthrow; // Apply the fourth row material

            GameObject fourthrowcube2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            fourthrowcube2.transform.position = new Vector3(xpositionfourthrowcube, 2.25f, -1.75f);
            fourthrowcube2.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            Renderer fourthrowcube2Renderer = fourthrowcube2.GetComponent<Renderer>();
            fourthrowcube2Renderer.material = pyramidfourthrow; // Apply the fourth row material

            xpositionfourthrowcube -= 0.75f; // Move to the next position in the row
            fourthrow++; // Increment the cube counter
        }

        // Create the final cube at the top of the pyramid
        GameObject finalcube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        finalcube.transform.position = new Vector3(-0.75f, 2.75f, -1.3f);
        finalcube.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        Renderer fifthrowcube1Renderer = finalcube.GetComponent<Renderer>();
        fifthrowcube1Renderer.material = pyramidfifthrow; // Apply the fifth row material
    }

    void GenerateCylinders(GameObject platform)
    {
        // Get the platform's position and size
        Vector3 platformPosition = platform.transform.position;
        Vector3 platformScale = platform.transform.localScale;

        // Calculate the platform's bounds
        float platformMinX = platformPosition.x - platformScale.x / 2f; // Minimum X bound
        float platformMaxX = platformPosition.x + platformScale.x / 2f; // Maximum X bound
        float platformMinZ = platformPosition.z - platformScale.z / 2f; // Minimum Z bound
        float platformMaxZ = platformPosition.z + platformScale.z / 2f; // Maximum Z bound

        // Define the pyramid's bounds (adjust these values based on your pyramid's size)
        float pyramidMinX = -2.5f; // Minimum X bound of the pyramid
        float pyramidMaxX = 2.5f;  // Maximum X bound of the pyramid
        float pyramidMinZ = -2.5f; // Minimum Z bound of the pyramid
        float pyramidMaxZ = 2.5f;  // Maximum Z bound of the pyramid

        // Generate a random number of cylinders
        int numberOfCylinders = Random.Range(minCylinders, maxCylinders + 1);

        for (int i = 0; i < numberOfCylinders; i++)
        {
            // Create a cylinder
            GameObject cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
            // Set the material color to green
            Renderer cylinderRenderer = cylinder.GetComponent<Renderer>();
            cylinderRenderer.material = cylinderMaterial;

            // Generate random X and Z positions within the platform's bounds but outside the pyramid's bounds
            float randomX, randomZ;
            do
            {
                randomX = Random.Range(platformMinX, platformMaxX); // Random X position
                randomZ = Random.Range(platformMinZ, platformMaxZ); // Random Z position
            } while (randomX >= pyramidMinX && randomX <= pyramidMaxX && randomZ >= pyramidMinZ && randomZ <= pyramidMaxZ);

            // Set the cylinder's position (on top of the platform)
            float platformTopY = platformPosition.y + platformScale.y / 2f; // Y position on top of the platform
            cylinder.transform.position = new Vector3(randomX, platformTopY, randomZ);

            // Set random scale for the cylinder
            float randomScaleX = Random.Range(minScale, maxScale); // Random X scale
            float randomScaleY = Random.Range(minScale, maxScale); // Random Y scale
            float randomScaleZ = Random.Range(minScale, maxScale); // Random Z scale
            cylinder.transform.localScale = new Vector3(randomScaleX, randomScaleY, randomScaleZ);
        }
    }
}