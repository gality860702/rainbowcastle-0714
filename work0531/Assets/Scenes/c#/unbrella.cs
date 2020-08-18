using UnityEngine;
using UnityEngine.EventSystems;

public class unbrella : MonoBehaviour, IPointerClickHandler
{
    [Header("前往方向")]
    public bool forward;
    public float speed = 10;

    public Transform targeta;
    public Transform targetb;

    private void Start()
    {
        transform.position = targeta.position;
    }

    private void Move()
    {
        if (forward) transform.position = Vector3.Lerp(transform.position, targetb.position, 0.5f * speed * Time.deltaTime);     // 往b移動
        else transform.position = Vector3.Lerp(transform.position, targeta.position, 0.5f * speed * Time.deltaTime);             // 往a移動
    }

    private void Update()
    {

        Move();

    }

    private void OnMouseDown()
    {
        // 2D Sprite
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        // UI
        forward = !forward;               // 前往方向 = 相反前往方向
    }
}
