using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    float minXClamp = -2f
        , minYClamp = -7f
        , maxXClamp = 10f
        , maxYClamp = 5f;
    
    private void LateUpdate()
    {
        if (GameManager.Instance.playerInstance)
        {
            Vector3 cameraTransform;

            cameraTransform = transform.position;

            cameraTransform.x = GameManager.Instance.playerInstance.transform.position.x;
            cameraTransform.y = GameManager.Instance.playerInstance.transform.position.y;

            cameraTransform.x = Mathf.Clamp(cameraTransform.x, minXClamp, maxXClamp);
            cameraTransform.y = Mathf.Clamp(cameraTransform.y, minYClamp, maxYClamp);

            transform.position = cameraTransform;
        }
    }
}
