using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CinemachinePOVExtension : CinemachineExtension
{
    [SerializeField] float horizontalSpeed = 10;
    [SerializeField] float verticalSpeed = 10;

    [SerializeField] float clampedAngle = 80;

    private InputManager inputManager;
    Vector3 startingRotation;


    protected override void Awake()
    {
        inputManager = InputManager.Instance;
        base.Awake();
        if (startingRotation == null)
        {
            startingRotation = transform.localRotation.eulerAngles;
        }
    }

    protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
    {
        if (vcam.Follow)
        {
            if (stage == CinemachineCore.Stage.Aim)
            {
                Vector2 deltaRotation = inputManager.GetMouseDelta();
                startingRotation.x += deltaRotation.x * verticalSpeed * Time.deltaTime;
                startingRotation.y += deltaRotation.y * horizontalSpeed * Time.deltaTime;
                startingRotation.y = Mathf.Clamp(startingRotation.y, -clampedAngle, clampedAngle);
                state.RawOrientation = Quaternion.Euler(-startingRotation.y, startingRotation.x, 0);
            }
        }
    }

}
