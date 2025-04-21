using UnityEngine;
using System.Collections;

public class ParatrooperController : MonoBehaviour
{
    public float fallSpeed = 2f;
    public float spawnXMin = -7f;
    public float spawnXMax = 7f;
    public float spawnY = 5f;
    private GameManager gameManager;
    private Animator animator;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        animator = GetComponent<Animator>();
        float spawnX = Random.Range(spawnXMin, spawnXMax);
        transform.position = new Vector3(spawnX, spawnY, 0);
    }

    void Update()
    {
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Boat"))
        {
            animator.SetTrigger("LandOnBoat");
            gameManager.AddScore();
            StartCoroutine(DestroyAfterAnimation(0.5f)); 
        }
        else if (other.CompareTag("Water"))
        {
            animator.SetTrigger("FallIntoWater");
            gameManager.LoseLife();
            StartCoroutine(DestroyAfterAnimation(0.5f)); 
        }
    }

    IEnumerator DestroyAfterAnimation(float delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(gameObject);
    }
}
