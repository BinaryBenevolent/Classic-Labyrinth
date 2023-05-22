using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartPanel : MonoBehaviour
{
    [SerializeField] private Image clickImage;

    [SerializeField] private Vector3 mMinScale;
    [SerializeField] private Vector3 mMaxScale;
    [SerializeField] private Vector3 mScaleSpeed;

    [SerializeField] private Vector3 currentScaleSpeed;

    private void Start()
    {
        Time.timeScale = 0f;
    }

    private void Update()
    {
        if (transform.localScale.x <= mMinScale.x || transform.localScale.x >= mMaxScale.x)
        {
            currentScaleSpeed.x *= -1; //invert it
        }

        if (transform.localScale.y <= mMinScale.y || transform.localScale.y >= mMaxScale.y)
        {
            currentScaleSpeed.y *= -1; //invert it
        }

        if (transform.localScale.z <= mMinScale.z || transform.localScale.z >= mMaxScale.z)
        {
            currentScaleSpeed.z *= -1; //invert it
        }

        transform.localScale = transform.localScale + currentScaleSpeed * Time.deltaTime;

        if (Input.touchCount > 0)
        {
            Time.timeScale = 1f;
            Destroy(this.gameObject);
        }
    }
}