using UnityEngine;

public class ButtonEvent : MonoBehaviour
{
	public void OnClick_960x540()
	{
		// ���� pixel�A�c�� pixel�A�E�B���h�E���[�h�A���t���b�V�����[�g(Hz) ���w��
		// �E�B���h�E���[�h�̏ꍇ�A�E�B���h�E�T�C�Y���ς��
		Screen.SetResolution(960, 540, FullScreenMode.Windowed, 60);
	}
	public void OnClick_1280x720()
	{
		// ���� pixel�A�c�� pixel�A�E�B���h�E���[�h�A���t���b�V�����[�g(Hz) ���w��
		// �E�B���h�E���[�h�̏ꍇ�A�E�B���h�E�T�C�Y���ς��
		Screen.SetResolution(1280, 720, FullScreenMode.Windowed, 60);
	}
	public void OnClick_1600x900()
	{
		// ���� pixel�A�c�� pixel�A�E�B���h�E���[�h�A���t���b�V�����[�g(Hz) ���w��
		// �E�B���h�E���[�h�̏ꍇ�A�E�B���h�E�T�C�Y���ς��
		Screen.SetResolution(1600, 900, FullScreenMode.Windowed, 60);
	}
}
