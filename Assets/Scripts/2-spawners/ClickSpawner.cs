﻿using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;

/**
 * This component spawns the given object whenever the player clicks a given key.
 */
public class ClickSpawner : MonoBehaviour
{
    [SerializeField] protected InputAction spawnAction = new InputAction(type: InputActionType.Button);
    [SerializeField] protected GameObject prefabToSpawn;
    [SerializeField] protected Vector3 velocityOfSpawnedObject;
    [Tooltip("How many seconds to wait before the next spawn")]
    [SerializeField] protected float coolDown = 0.5f;
    private bool canSpawn = true;

    void OnEnable()
    {
        spawnAction.Enable();
    }

    void OnDisable()
    {
        spawnAction.Disable();
    }

    protected virtual GameObject spawnObject()
    {
        //Debug.Log("Spawning a new object");

        // Step 1: spawn the new object.
        Vector3 positionOfSpawnedObject = transform.position;  // span at the containing object position.
        Quaternion rotationOfSpawnedObject = Quaternion.identity;  // no rotation.
        GameObject newObject = Instantiate(prefabToSpawn, positionOfSpawnedObject, rotationOfSpawnedObject);

        // Step 2: modify the velocity of the new object.
        Mover newObjectMover = newObject.GetComponent<Mover>();
        if (newObjectMover)
        {
            newObjectMover.SetVelocity(velocityOfSpawnedObject);
        }

        return newObject;
    }

    private void Update()
    {
        if (canSpawn && spawnAction.WasPressedThisFrame())
        {
            spawnObject();
            canSpawn = false;
            StartCoroutine(ResetCooldown());
        }
    }

    private IEnumerator ResetCooldown()
    {
        yield return new WaitForSeconds(coolDown);
        canSpawn = true;
    }
}