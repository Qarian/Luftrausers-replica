using UnityEngine;

public class CameraFollow : MonoBehaviour {
    // Obiekt, za którym podąża kamera.
    public Transform target;

    // Szybkość, z jaką kamera gładko zbliża się do położenia gracza. Najlepiej od 0 do 1.
    public float smoothSpeed;

    // Odległość kamery od płaszczyzny gry. Cały czas zmieniało się z -1 na 1, więc zmieniłem nieco kod.
    //public Vector3 offset;

    public void FixedUpdate() {
        Vector3 desiredPosition = target.position + Vector3.back;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        // Linia poniżej będzie nieco obracać kamerą w trzecim wymiarze, nie wiem, czy to konieczne, ale na wypadek napisałem.
        //transform.LookAt(target);
    }
}
