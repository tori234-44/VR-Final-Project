using UnityEngine;

public class BallSound : MonoBehaviour
{
    public AudioSource audioSource;  // Drag your AudioSource component here in the Inspector
    public AudioClip bounceSound;    // Drag your bounce sound effect here in the Inspector

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // This method is called when the ball collides with another object
    void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with the ground (can add more specific checks if needed)
        if (collision.gameObject.CompareTag("Ground"))
        {
            // Play the bounce sound
            audioSource.PlayOneShot(bounceSound);
        }
    }
}
