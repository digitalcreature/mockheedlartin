using UnityEngine;

public class PlaneWing : Plane.Part {

  public float maxLift = 10;  // measured in Ns/m

  public Vector3 lift {
    get {
      Vector3 airVel = plane.airSpeedVelocity;
      airVel *= Mathf.Clamp01(-Vector3.Dot(airVel.normalized, transform.forward));
      return transform.up * airVel.magnitude * maxLift;
    }
  }

  void FixedUpdate() {
    plane.body.AddForceAtPosition(lift, transform.position);
  }

  void OnDrawGizmos() {
    Color color = Gizmos.color;
    Gizmos.color = Color.blue;
    Gizmos.DrawRay(transform.position, transform.up);
    Gizmos.DrawRay(transform.position, transform.forward / 2);
    Gizmos.color = color;
  }

}