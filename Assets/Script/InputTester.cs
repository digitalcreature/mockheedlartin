using UnityEngine;

public class InputTester : MonoBehaviour {

  void Update() {
    for (KeyCode code = KeyCode.Backspace; code <= KeyCode.Joystick8Button19; code ++) {
      if (Input.GetKey(code)) {
        Debug.Log(code);
      }
    }
  }

}