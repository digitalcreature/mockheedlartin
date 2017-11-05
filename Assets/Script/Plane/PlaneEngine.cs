using UnityEngine;

public class PlaneEngine : Plane.Part {

  public float maxThrust = 10;  // in N
  
  public Vector3 thrust {
    get {
      return transform.forward * maxThrust * plane.throttle;
    }
  }

  void FixedUpdate() {
    plane.body.AddForceAtPosition(thrust, transform.position);
  }

  void OnDrawGizmos() {
    Color color = Gizmos.color;
    Gizmos.color = Color.red;
    Gizmos.DrawRay(transform.position, - transform.forward);
    Gizmos.color = color;
  }

}