using UnityEngine;
using Cinemachine;

public class CameraController : CinemachineExtension
{
    [SerializeField] private CinemachineVirtualCamera vcam;

    private void Start()
    {
        if (Screen.height / Screen.width >= 2)
        {
            vcam.m_Lens.FieldOfView = 90;
        }
    }

    protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
    {
        var pos = state.RawPosition;
        pos.x = 0;
        pos.y = 9.3f;
        state.RawPosition = pos;
    }
}
