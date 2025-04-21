using UnityEngine;

public class ParatrooperAnimationController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void LandOnBoat()
    {
        animator.SetTrigger("LandOnBoat");
    }

    public void FallIntoWater()
    {
        animator.SetTrigger("FallIntoWater");
    }
}
