using UnityEngine;
using Cinemachine;

public class Camera : CinemachineExtension
{
    [SerializeField] private CinemachineVirtualCamera vcam;

    private void Start()
    {
        float aspectRatio =  (float)Screen.height / Screen.width * 10;
        vcam.m_Lens.FieldOfView = 70 + aspectRatio;
    }

    protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
    {
        var pos = state.RawPosition;
        pos.x = 0;
        pos.y = 9.3f;
        state.RawPosition = pos;
    }
}
