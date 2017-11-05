using UnityEngine;
using System;
using System.Collections.Generic;

public class Plane : MonoBehaviour {

  public Transform centerOfMass;
  public Rigidbody body { get; private set; }
  
  public float initialSpeed = 10;

  [Range(0, 1)]
  public float throttle;
  public Transform targetHeading;

  public Vector3 groundSpeedVelocity {
    get {
      return body.velocity;
    }
  }
  public Vector3 airSpeedVelocity {
    get {
      return -body.velocity;
    }
  }

  void Awake() {
    body = GetComponent<Rigidbody>();
    body.centerOfMass = centerOfMass == null ? transform.position : centerOfMass.position;
  }

  void Start() {
    body.velocity = transform.forward * initialSpeed;
  }

  public abstract class Part : MonoBehaviour {

    public Plane plane { get; private set; }

    protected virtual void Awake() {
      plane = GetComponentInParent<Plane>();
    }


  }

}
