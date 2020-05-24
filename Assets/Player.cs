using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour
{
    [Tooltip("In ms^-1")] [SerializeField] float xSpeed = 4f;
    [Tooltip("In m")] [SerializeField] float xRange = 6f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xThrow = CrossPlatformInputManager.GetAxis("Horizontal");
        float xOffset = xThrow * xSpeed * Time.deltaTime;
        float rawXPos = transform.localPosition.x + xOffset;
        float clampedPos = Mathf.Clamp(rawXPos, -xRange, xRange);
        transform.localPosition = new Vector3(clampedPos, transform.localPosition.y, transform.localPosition.z);
    }
}
