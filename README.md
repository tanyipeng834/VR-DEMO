# How to Make a ToolTip for VR

## Download and open the Week 8 Unity Project
1. Download the existing Week 8 VRTut project if you have not done it last week
2. Open UnityHub → Open → Add project from disk → (select) VRTut (folder)
3. Click and open VRTur Unity project
4. You should see the server room from Week 8

## Create Cube (3D Object)

1. Right click in the hierarchy and select `3D Object` and then select `Cube`.
2. Left Click on the `Cube` and change the position of the cube under `Transform` in the Inspector window to `(X: -1, Y: 0.4, Z: 0)`
3. (Optional) You can click on `Environment` under the hierarchy and deselect the checkbox below the Inspector window to hide the Environment

## Create Tooltip (Empty GameObject)

1. Right click in the hierarchy and select `Create Empty`.
2. Rename the new object to `Tooltip`.
3. Adjust the Position of the Tooltip object to the desired location. (i.e. above the object you want to have a tooltip for)

## Creating the Line Renderer (Linking the Text to the Object)

1. In the hierarchy, right click on the Tooltip object and select `Create Empty`.
2. Rename the new object to `Line Renderer` and make sure its Position is 0, 0, 0.
3. Select the Line Renderer object and under the Inspector, click `Add Component` and search for `Line Renderer`.
4. Under the Line Renderer component, set the `Materials` to `Default-Line`.
5. Create a new script with variables `public Transform pointA`, `public Transform pointB`, `private LineRenderer line`.
6. Under the `Start` method, set `line = GetComponent<LineRenderer>()`.
7. Under the `Update` method, set `line.positionCount = 2`, `line.SetPosition(0, pointA.position)`, and `line.SetPosition(1, pointB.position)`. (Make sure you save your script!)
8. Attach the script to your Line Renderer object.

## Creating the 2 points (pointA and pointB)

1. In the hierarchy, right click on the Tooltip object and select `Create Empty` twice.
2. Rename them to `pointA` and `pointB`.
3. Select the Line Renderer object and under the Inspector, drag pointA and pointB objects into the script's `pointA` and `pointB` variables.
   **At this point, your line should be visible only when you press play. To make it visible in the editor, go back to the script and add `[ExecuteInEditMode]` above the class name.**
4. Select the Line Renderer object and under the Inspector, you can adjust the Width (0.005) and the Color of your choice (Yellow).
5. You can adjust the pointA and pointB objects to the desired location.

## Creating the Tooltip Box

1. In the hierachy, right click on PointB object and create a `Canvas` (UI > Canvas).
2. Select the Canvas object and under the Inspector, set the `Render Mode` to `World Space` and set its Position to 0, 0, 0 and its Scale to 0.001, 0.001, 0.001.
3. You can adjust the Canvas object to the desired location and shape.
4. Right click on the Canvas object and Create `Panel` (UI > Panel).
5. Set the `Source Image` of the Panel object to `None` and the Color to your desired color (Yellow).
6. Duplicate the Panel object and rename them to `Outline` and `Background`.
7. Adjust the Background object to the Color of your choice (Black).
8. Adjust the Background object's RectTransform to 5 (Left, Right, Top, Bottom).

## Creating the Text

1. In the hierachy, right click on the Background object and Create `Text - TextMeshPro` (UI > Text - TextMeshPro).
2. Select the Text object and under the Inspector, under the Rect Transform, click on the Anchor Presets, hold down the Ctl key and select the bottom right most anchor.
3. Adjust the Text object's Alignment to Center Center.

## To make the Tooltip always face you

1. Create a new script with variables `public Transform target`.
2. Under the `Update` method, set `transform.LookAt(target, Vector3.up)`. (Make sure you save your script!)
3. Attach the script to PointB object.
4. Select the PointB object and under the Inspector, drag the Main Camera object into the Target variable.
5. Under the hierachy, drag the Canvas object out of PointB object so that it is no longer a child of it.
6. Select the PointB object and under the Inspector, set the Y rotation to 180.
7. Under the hierachy, drag back the Canvas object into PointB so that it is a child of it.


## References

[YouTube - How To Make a Tooltip for VR – Unity Tutorial](https://www.youtube.com/watch?v=xyoswWxj_6o&t=405s)

# How to use ECS to improve the performance of Game Objects

## Importing the ECS Packages

1. Navigate to Package Manager under the Window Tab
2. Install the Entities and Entities Graphics Package

## Creating an Entity

1. First Create a `Subscene`
2. Then place a GameObject under the SubScene to create an `Entity`

## Creating an Component
1. We can create a `Struct` which would inherit from `IEComponentData`
2. Then, we would then place related data into the struct

## Creating an System
1. We would first create a system that would inherit from `SystemBase`
2. Then, we would then create an `onUpdate` Method that would update the component Data
3. Then, we would use an `SystemAPI.Query` to locate and manipulate the component on the entity.


