# AR Hand Tracker in Unity with Mediapipe (C#)
This project is a boilerplate library for implementing AR hand tracking in Unity built around Homuler's [MediaPipeUnityPlugin](https://github.com/homuler/MediaPipeUnityPlugin) in pure C#. It includes a custom 3D render pipeline and is designed as a starting point for augmented reality applications in Unity, providing a powerful and customizable hand tracking experience for interactive 3D applications.

## Key Features
- **Hand Tracking in AR:** Leverages Mediapipe's hand tracking to detect and track 21 landmarks on each hand in real-time.
- **Pure C# Implementation:** Built in pure C# for performance and flexibility without requiring Python or other external integrations.
- **Custom 3D Render Pipeline:** A custom-built 3D render pipeline is integrated to ensure the best visual performance tailored to this application.
- **Library and Boilerplate Design:** This is designed as a modular library for easy adaptation to other AR/VR projects or as a basis for hand tracking features in larger Unity projects.


## Hand Landmark Data Access
The project includes a LandmarkResultReceiver script, which:

- Receives and processes hand landmark data from Mediapipe.
- Updates the position of the 21 spheres in the scene according to hand landmark positions in 3D in real time.
- Allows for easy replacement or customization of the spheres with other interactive objects.

# Future Implementations
- Gesture Boilerplate (Functions such as pinch, grab, release)
- 2 handed gesture support
- Object pool management of Tracer Nodes
- Improved Modularity
- AR camera support (1:1 scaling)

# Contributing
Contributions are welcome! Please fork the repository and submit a pull request for any features, bug fixes, or improvements.

# License
This project is licensed under the MIT License.
