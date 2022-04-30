using UnityEngine;

public class ButtonEvent : MonoBehaviour
{
	public void OnClick_960x540()
	{
		// 横幅 pixel、縦幅 pixel、ウィンドウモード、リフレッシュレート(Hz) を指定
		// ウィンドウモードの場合、ウィンドウサイズも変わる
		Screen.SetResolution(960, 540, FullScreenMode.Windowed, 60);
	}
	public void OnClick_1280x720()
	{
		// 横幅 pixel、縦幅 pixel、ウィンドウモード、リフレッシュレート(Hz) を指定
		// ウィンドウモードの場合、ウィンドウサイズも変わる
		Screen.SetResolution(1280, 720, FullScreenMode.Windowed, 60);
	}
	public void OnClick_1600x900()
	{
		// 横幅 pixel、縦幅 pixel、ウィンドウモード、リフレッシュレート(Hz) を指定
		// ウィンドウモードの場合、ウィンドウサイズも変わる
		Screen.SetResolution(1600, 900, FullScreenMode.Windowed, 60);
	}
}
