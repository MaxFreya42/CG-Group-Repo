using UnityEngine;

public class FootprintSpawner : MonoBehaviour
{
    public Transform leftFootPoint;
    public Transform rightFootPoint;

    public GameObject leftFootPrefab;
    public GameObject rightFootPrefab;

    public float stepDistance = 1f;

    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private float groundCheckDistance = 0.2f;
    [SerializeField] private Transform groundCheckPoint;

    private Vector3 lastStepPos;
    private bool nextIsLeft = true;

    void Start()
    {
        lastStepPos = transform.position;

        // fallback if not assigned
        if (groundCheckPoint == null)
            groundCheckPoint = transform;
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, lastStepPos);

        if (distance >= stepDistance)
        {
            SpawnFootprint();
            lastStepPos = transform.position;
        }

        Debug.Log("Grounded: " + IsGrounded());

    }

    private bool IsGrounded()
    {
        Vector3 origin = groundCheckPoint.position;
        return Physics.Raycast(origin, Vector3.down, groundCheckDistance, groundLayer);
    }

    void SpawnFootprint()
    {
        // Don't spawn in the air
        if (!IsGrounded()) return;

        Quaternion footprintRotation = Quaternion.Euler(90, transform.eulerAngles.y, 0);

        if (nextIsLeft)
            Instantiate(leftFootPrefab, leftFootPoint.position, footprintRotation);
        else
            Instantiate(rightFootPrefab, rightFootPoint.position, footprintRotation);

        nextIsLeft = !nextIsLeft;
    }
}
