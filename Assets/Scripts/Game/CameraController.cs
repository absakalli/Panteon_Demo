using Cinemachine;

public class CameraController : CinemachineExtension
{
    protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
    {
        var pos = state.RawPosition;
        pos.x = 0;
        pos.y = 9.3f;
        state.RawPosition = pos;
    }
}
