using Mediapipe.Tasks.Vision.HandLandmarker;
using Mediapipe.Unity.Sample.HandLandmarkDetection;
using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;

[System.Serializable]
public class Eventkumar : UnityEvent<HandLandmarkerResult> { }

public class LandmarkResultReceiver : MonoBehaviour
{
    private HandLandmarkerRunner handLandmarkerRunner;
    public static LandmarkResultReceiver Instance { get; private set; }

    public static Eventkumar testkumar = new Eventkumar();
    public GameObject kumar;

    public GameObject[] spheres = new GameObject[21];


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            UnityThread.initUnityThread();
        }
        else
        {
            Destroy(this);
        }
    }

    private void OnDestroy()
    {
        if (Instance == this)
        {
            Instance = null;
        }
    }

    void Start()
    {
        handLandmarkerRunner = FindObjectOfType<HandLandmarkerRunner>();
        if (handLandmarkerRunner == null)
        {
            Debug.LogError("HandLandmarkerRunner not found in the scene.");
        }
    }

    public void ReceiveLandmarkResult(HandLandmarkerResult result)
    {
        Debug.Log(result);
        UnityThread.executeInUpdate(() =>
        {
            // Update the position of each predefined sphere with the corresponding landmark position
            for (int i = 0; i < spheres.Length && i < result.handLandmarks[0].landmarks.Count; i++)
            {
                Vector3 landmarkPosition = new Vector3(
                    result.handLandmarks[0].landmarks[i].x * 5,    // Scale factor for Unity's 3D space
                    -result.handLandmarks[0].landmarks[i].y * 5,   // Invert Y for Unity's coordinate system
                    result.handLandmarks[0].landmarks[i].z * 5     // Scale factor for depth
                );

                spheres[i].transform.position = landmarkPosition;
            }
        });
    }



}
