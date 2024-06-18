using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlacementSystem : MonoBehaviour
{
    [SerializeField]
    private GameObject mouseIndicator;//, cellIndicator;
    [SerializeField]
    private InputManager inputManager;
    [SerializeField]
    private Grid grid;

    private void Update()
    {
        Vector3 mousePosition = inputManager.GetSelectedMapPosition();
        mouseIndicator.transform.position = mousePosition;
        Vector3Int gridPosition = grid.WorldToCell(mousePosition);
        //cellIndicator.transform.position = grid.CellToWorld(gridPosition);


        //if (buildingState == null)
        //    return;

        //if (lastDetectedPosition != gridPosition)
        //{
        //    buildingState.UpdateState(gridPosition);
        //    lastDetectedPosition = gridPosition;
        //}

    }


    

    //[SerializeField]
    //private ObjectsDatabaseSO database;

    //[SerializeField]
    //private GameObject gridVisualization;

    //[SerializeField]
    //private AudioClip correctPlacementClip, wrongPlacementClip;
    //[SerializeField]
    //private AudioSource source;

    //private GridData floorData, furnitureData;

    //[SerializeField]
    //private PreviewSystem preview;

    //private Vector3Int lastDetectedPosition = Vector3Int.zero;

    //[SerializeField]
    //private ObjectPlacer objectPlacer;

    //IBuildingState buildingState;

    //[SerializeField]
    //private SoundFeedback soundFeedback;

    //private void Start()
    //{
    //    gridVisualization.SetActive(false);
    //    floorData = new();
    //    furnitureData = new();
    //}

    //public void StartPlacement(int ID)
    //{
    //    StopPlacement();
    //    gridVisualization.SetActive(true);
    //    buildingState = new PlacementState(ID,
    //                                       grid,
    //                                       preview,
    //                                       database,
    //                                       floorData,
    //                                       furnitureData,
    //                                       objectPlacer,
    //                                       soundFeedback);
    //    inputManager.OnClicked += PlaceStructure;
    //    inputManager.OnExit += StopPlacement;
    //}

    //public void StartRemoving()
    //{
    //    StopPlacement();
    //    gridVisualization.SetActive(true);
    //    buildingState = new RemovingState(grid, preview, floorData, furnitureData, objectPlacer, soundFeedback);
    //    inputManager.OnClicked += PlaceStructure;
    //    inputManager.OnExit += StopPlacement;
    //}

    //private void PlaceStructure()
    //{
    //    if (inputManager.IsPointerOverUI())
    //    {
    //        return;
    //    }
    //    Vector3 mousePosition = inputManager.GetSelectedMapPosition();
    //    Vector3Int gridPosition = grid.WorldToCell(mousePosition);

    //    buildingState.OnAction(gridPosition);

    //}

    ////private bool CheckPlacementValidity(Vector3Int gridPosition, int selectedObjectIndex)
    ////{
    ////    GridData selectedData = database.objectsData[selectedObjectIndex].ID == 0 ? 
    ////        floorData : 
    ////        furnitureData;

    ////    return selectedData.CanPlaceObejctAt(gridPosition, database.objectsData[selectedObjectIndex].Size);
    ////}

    //private void StopPlacement()
    //{
    //    soundFeedback.PlaySound(SoundType.Click);
    //    if (buildingState == null)
    //        return;
    //    gridVisualization.SetActive(false);
    //    buildingState.EndState();
    //    inputManager.OnClicked -= PlaceStructure;
    //    inputManager.OnExit -= StopPlacement;
    //    lastDetectedPosition = Vector3Int.zero;
    //    buildingState = null;
    //}


}