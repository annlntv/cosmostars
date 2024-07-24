using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // �������� �������� ���������
    public float screenLimitX = 4f; // ������� �� ��� X
    private Rigidbody2D rb;
    public int points;

    [SerializeField] Projectile _projectile;
    [SerializeField] float shootTimer;
    [SerializeField] float shootInterval;
    [SerializeField] Transform shootPoint;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
        shootTimer -= Time.deltaTime;
        Shoot();
    }
    void Shoot()
    {
        if (_projectile != null & shootTimer <= 0)
        {
            Instantiate(_projectile, shootPoint.position, Quaternion.identity);
            shootTimer = shootInterval;

        }
    }
    void Move()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");

        // �������� ����� ��� ������
        rb.velocity = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);

        // ����������� �������� ��������� �� �����������
        Vector2 position = transform.position;
        position.x = Mathf.Clamp(position.x, -screenLimitX, screenLimitX);
        transform.position = position;

        // ��������, ������ �� ������� "A" ��� "D"
        if (horizontalInput < 0)
        {
            // �������� �����
            transform.localScale = new Vector3(-1f, 1f, 1f); // ������� ������� ��������� �����
        }
        else if (horizontalInput > 0)
        {
            // �������� ������
            transform.localScale = new Vector3(1f, 1f, 1f); // ������� ������� ��������� ������
        }
    } 
}