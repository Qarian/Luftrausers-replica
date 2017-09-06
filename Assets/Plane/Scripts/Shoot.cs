using UnityEngine;

public class Shoot : MonoBehaviour {

    public GameObject missle;
    public float firerate;
    float time;

	void Update () {
        if (Input.GetKey("z"))
        {
            if (time > firerate)
            {
                GameObject x = Instantiate(missle, transform.position, transform.parent.rotation);
                x.GetComponent<Rigidbody2D>().AddForce(x.transform.up*500);
                time = 0;
            }
        }
        time += Time.deltaTime;
    }
}
