using KinematicCharacterController;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerCharacterController : MonoBehaviour, ICharacterController
{
    [SerializeField] private KinematicCharacterMotor motor;

    private void Start()
    {
        motor.CharacterController = this;
    }

    public void AfterCharacterUpdate(float deltaTime)
    {
        //throw new System.NotImplementedException();
    }

    public void BeforeCharacterUpdate(float deltaTime)
    {
        //throw new System.NotImplementedException();
    }

    public bool IsColliderValidForCollisions(Collider coll)
    {
        //throw new System.NotImplementedException();
        return false;
    }

    public void OnDiscreteCollisionDetected(Collider hitCollider)
    {
        //throw new System.NotImplementedException();
    }

    public void OnGroundHit(Collider hitCollider, Vector3 hitNormal, Vector3 hitPoint, ref HitStabilityReport hitStabilityReport)
    {
        //throw new System.NotImplementedException();
    }

    public void OnMovementHit(Collider hitCollider, Vector3 hitNormal, Vector3 hitPoint, ref HitStabilityReport hitStabilityReport)
    {
        //throw new System.NotImplementedException();
    }

    public void PostGroundingUpdate(float deltaTime)
    {
        //throw new System.NotImplementedException();
    }

    public void ProcessHitStabilityReport(Collider hitCollider, Vector3 hitNormal, Vector3 hitPoint, Vector3 atCharacterPosition, Quaternion atCharacterRotation, ref HitStabilityReport hitStabilityReport)
    {
        //throw new System.NotImplementedException();
    }

    public void UpdateRotation(ref Quaternion currentRotation, float deltaTime)
    {
        //throw new System.NotImplementedException();
    }

    public void UpdateVelocity(ref Vector3 currentVelocity, float deltaTime)
    {
        //throw new System.NotImplementedException();
    }
}

[System.Serializable]
public struct InputPackage
{
    public Vector2 Move;
    public Vector2 Aim;
    public bool jumpPressed;
    public bool jumpHeld;
    public bool jumpReleased;
    public bool crouchPressed;
    public bool crouchHeld;
    public bool crouchReleased;
    public bool actionPressed;
    public bool actionHeld;
    public bool actionReleased;
}
