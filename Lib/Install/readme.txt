Version 1.8.8 Beta
Added the ability to drag the faces of 3D shapes
Implemented Box Selection
Improved the Solver
Improved the Cut tool usability
Improved Edge Match during sketch drawing
Fixed Open File bugs
Fixed New File crash
Fixed Cancel current action bugs
Fixed Dimension display for circles and lines

Version 1.8.7 Beta
Added the possibility to start drawing 2D shapes and perform 3D operations without having to click Start/End Sketch
Added three default planes for sketch creation
Fixed sketch creation from coordinates bug fixes
Improved Sketch editing functionality
Improved the Cut tool

Version 1.8.6 Beta
Displayed two shapes possible constraints in Property Grid
Added possibility to add two shapes constraints from Property Grid
Displayed relevant information during drawing for 2D and 3D tools
Improved the information displayed for tools in the Property Grid
Improved the Angle Draft tool
Fixed Enter Sketch bugs
Fixed Revolve bugs

Version 1.8.5 Beta
Improved PointToEdge constraint and the Solver
Improved Hints display
Improved the arc points generation for the Fillet2D tool
Improved the Measure and Dimension tools
Added more information to the mouse cursor during sketch drawing
Added constraint functionality to the line and circle Dimension
Improved the Trim, Chamfer and Fillet tools
Implemented the TransformationInfo list and integrated it in the transformation calculations 

Version 1.8.4 Beta
Improved face creation for complex sketches
Improved face creation on faces of solids
Fixed Extrude on adjacent shapes
Fixed Dimension display on Hinter match
Improved Hinter intersection detection
Fixed Open file point display issue

Version 1.8.3 Beta
Added ability to modify CSE arc radius, start, end and internal angles
Added solid corner points to geometry for point match
Fixed point match bugs
Fixed wrong ShapeGraph after Trim bug
Improved Hints display
Improved Point to Edge constraint properties editing
Improved Dimension and Line length display 
Improved the Trim tool
Added CSE arc unit tests
Updated old tests and cleaned old code

Version 1.8.2 Beta
Reimplemented Trsf handling for stacked objects
Improved translation for solids
Fixed FindSketchNode crashes
Improved TreeView display
Improved Spline display

Version 1.8.1 Beta
Displayed single shape possible constraints in Property Grid
Added possibility to add single shape constraints from Property Grid
Added reference to base solid for Sketch creation
Improved speed performance
Fixed solid rotation bugs
Fixed solid selection bugs
Fixed Boo script compiling bug

Version 1.8.0 Beta
Improved point match Hinter
Replaced the Solver images with drawn shapes
Displayed the current shape constraints in the Shape Property Tab
Fixed Boo script running errors
Fixed the Enter sketch from Tree View bug
Improved the point, lines and handles display
Improved Constraints display in Tree View
Fixed Cancel on save bug

Version 1.7.9 Beta
Improved node deletion algorithm
Improved Hinter performance
Added preview for Cut Through All and Cut to Depth
Fixed File tab closing bug
Improved Spline drawing and editing
Improved Dimension tool
Added input validations for 3D tools

Version 1.7.8 Beta
Generated and fixed a new wrapper set for OpenCascade 6.5.5
Fixed Cut to depth for negative values
Reimplemented Cut through All
Improved Undo and Redo functionality
Fixed Spline display and editing
Fixed display issues

Version 1.7.7 Beta
Automatic wrapper generator
Generated and fixed a new wrapper set using PInvoke for OpenCascade 6.3.0

Version 1.7.6 Beta
Added the Three Points Rectangle 
Added the Perpendicular line Hinter and improved the existing Hinters
Added coordinate increments for drawing and editing sketch shapes
Fixed Copy/Paste for Boolean solids
Fixed the Rotate Axis Tool for sketch shapes, solids and 3D shapes
Fixed the Property Grid Translate
Improved the Mirror Line, Mirror Point, Array Pattern and Circular Pattern tools
Improved the Line tool to display the length during drawing
Fixed the Measure Tool
Improved TreeData, NaroSKetchSolve and Action Tests

Version 1.7.5 Beta
Fixed Copy/Paste for sketch shapes, 3D shapes and solids
Improved the Mirror Point and Mirror Line tools
Improved the Array Pattern and Circular Pattern tools
Improved Revolve to work on the entire sketch face
Fixed Translate, Undo and Redo for solids

Version 1.7.4 Beta
Improved the Solver parameter loading and processing speed
Fixed undo/redo for translated solids
Fixed translate for complex shapes
Fixed Extrude mid plane
Improved Cut through all and Cut to depth
Improved TreeView selection highlight 

Version 1.7.3 Beta
Fixed Boo script commands for main 2D and 3D shapes and tools
Improved the Point to Edge and Point to Point constraints
Updated Boo script help and sample files
Property grid displayed values are automatically updated after shape resize
Fixed Document Tree selection bug

Version 1.7.2 Beta
Extrude and pipe can be performed on shapes with holes
Extrude, pipe and cut are performed on the entire sketch containing the selected shape
Cut can be performed on the shapes obtained from boolean operations
Improved the Translate gizmo for 3D solids
Fixed translate for solids obtained from extrude/cut
Fixed point position display on default plane
Fixed Save/Open for solids obtained from Extrude, Pipe and Cut operations
3D shapes are automatically notified when the underlying sketch changes and are redrawn
Sketch shapes are displayed on enter/edit sketch and hidden on exit sketch
Improved sketch selection algorithm
Fixed crash caused by multiple open commands

Version 1.7.1 Beta
Improved the Translate Gizmo for 3D shapes
Improved same coordinate match in 3D
Improved the solver constraints loading
Fixed rectangle drawing on faces
Fixed 2D and 3D chamfer and fillet
Improved hints display in 3D

Version 1.7.0 Beta
Fixed the Cut Tool
Fixed face selection, drawing and editing
Improved constraints and related shapes loading algorithm
Improved hinter speed
Improved rectangle drawing and solve speed
Fixed 3D solids drawing and property grid editing

Version 1.6.9 Beta
Fixed the Translate gizmo
Added the ability to edit existing sketches 
Fixed the drawing in sketches that aren't on the default plane
Hinter options are saved and loaded correctly
Fixed the duplicate lines and points bugs
Constraints are deleted without deleting shapes
Fixed the New File bug

Version 1.6.8 Beta 
Improved the existing Solver algorithm and added a new one
Replaced existing constraint error functions and added gradient functions
Added matrix and vector helper classes to simplify the Solver
Fixed circle constraints bugs
Fixed property grid editing for ellipse
Fixed tooltip display bug
Fixed floating point comparison bug
Refactored the Solver and constraints code and fixed dependency issues
Updated the constraints unit tests

Version 1.6.7 Beta
Added constraints for points, circles, arcs and their combinations
Added the fixed point constraint
Added point to point constraint
Added point to edge constraint
Improved the Solver speed
Fixed the code that handles constraints removal 
Fixed property grid bugs
Added the posibility to view existing constraints (per shape or entire sketch)

Version 1.6.6 Beta
Options are saved in AppData
Fixed bugs related to the installer and environment variables
Added lines and circles constraints tools

Version 1.6.5 Beta
Reimplemented extrude
Reverted to the old wrappers that were generated using C++/CLI
Improved the Trim tool
Improved the Hinter
Fixed the 2D Fillet and Chamfer tools

Version 1.6.4 Alpha
Updated the Solver to use the new Sketch concept
Updated the four lines rectangle
Implemented the parallel, perpendicular, horizontal, vertical, point on  point and point on line constraints for the new Solver
Added unit tests for the new constraints

Version 1.6.3 Alpha
Fixed arc drawing (both CSE and SER)
The Edit Gizmo is resizing as we zoom in and out
Fixed plane view change crash 
Fixed shape selection and editing
Fixed the New File crash
Updated the Trim tool to work on Circle
Updated unit tests to use the new Sketch structure
Added unit tests for the shapes that didn't have any

Version 1.6.2 Alpha
C# Sketchsolve automatic detection algorithm integrated with NaroCAD
Boo related sketch scripts fixed
Sketch constraints are previwed
Extrude is sketch aware (unfinished tool)
Added Fixed Point constraint 

Version 1.6.1 Alpha
Integrated C# Sketchsolve algorithm into NaroCAD
Implemented Sketch based 2D tools (line, rectangle, arc SER, Arc CSE, Ellipse, Polyline)
Reimplemented Extrude to work with Sketch based shapes and more than pone sketch at a time
Gizmo for 2D shapes
Finalized updater

Version 1.6.0
Added updater
Added hinter toolbar
Addded interpolated spline tool
Added control point spline
Added combine spline , split spline tools
Added edge intersection hinter for horizontal, vertical lines
Added angle between lines tool
Tilde functionality - the user can lanch a tool by pressing tilde
Fixed fillet/chamfer 2D
Implemented customizable per action toolbar support
Added hinter at gizmos
Removed selection type comboox

Version 1.5.7
Modify solver precision with scene zoom level.
The solver returns the closest solution not the first solution found.
Added Ortho tool. Blocks drawing on horizontal vertical direction.
Added Trim tool.
Block plane tool. The user can block drawing on a specific plane.
Measurement tool.
Enhanced line tool. While drawing the line length can be inserted on command line keeping the line preview angle.
Added spline path tool.
Copy paste tool. Combines copy paste with precision translate.
*Finalized porting the Sketchsolve code to C#

Version 1.5.6
Boo script evaluator on property grid, command line
Scene export as Boo script
Linear pattern
Circular pattern
Support for composed shapes from basic shapes
Fixed mirror
TreeView speed improvement for big scenes
Fixed color picker

Version 1.5.5
Added visual interface to manage plugins.
Added zoom in out at current mouse position instead of scene center.
Added import and export from/to naroxml.
Improved overall solver performance.
Improved solver to catch any point from scene under mouse not only the ones from current plane.
Add edge intersection magic points.
Added text solver hints.
Added spline editing handlers.
At parallelism solver matching improved visual representation.
Added Quality of service implementation. Slow solver functionality is detected and the user asked if he wants to disable it. 
Fixed normal line tool.
Added restore layout functionality.
Improve the Solver to use Document based drawing with undo redo instead of self handling the drawing.

Version 1.5.4
Added AngleDraft Tool.
Added Rotate Around Axis Tool.
Added helper tools: copy and synchronizing tools between shapes.
Added Rectangle with 3 points Tool.
Added Parallelogram Tool.
Added support for auxiliar geometry.
Added Layout Saving Support.
Added Edge on Edge constraint.
Fixed Solver Bugs, enhanced its speed.
Fixed unit tests.
Fixes in propagation scenarios.
Improved performance on File/Load when big scenes are loaded.
Fixed propagation issues.
Added center magic points at basic geometry (circle center, cone base center, etc).
Gizmos can be selected from tree.
New external plugin.
Property grid fixes.

Version 1.5.3
Fixed transformations. Solved problems that appeared when many rotates and translations applied on a shape.
Finalized and fixed Rotate and Scale Gizmo.
Removed SCSF from project.
Improved plugins to support adding custom icons on tree, custom property grid entries.
Improved translate tool.
9 bugs fixed. 

Version 1.5.2
51 bugs fixed.
Plugin support implemented. Sample plugin provided.
Added translate Gizmo.
Improved editing Gizmos.
Improved Fillet tool.
Improved visual appearance.
Color picker with 20 colors for shapes.


Vesion 1.5.1
New testing framework
Many fixes and code refactoring
Added mirror plane
Lua replaced with Boo
Improved unit tests
Reimplemented selection container
Improved drawing on scene, visual feedback
Fixed editing on shapes

Vesion 1.5.0
Changed wrappers to have finalizers. Reduces memory leaks
Added floating toolbar
Added custom mouse cursors for tools
Property grid fixes
GUI graphical improvements
Reorganized Options
Possibility to change scene background color, default drawing colors, antialising 

Vesion 1.4.7
Improved command line auto complete, fixed command line bugs
Added tips window
POrted Options dialog to WPF and fixed bugs related to it
Improved solver on helper lines
Added plugin support
Fixed mirror and pattern tools
Fixed selection from tree 

Version 1.4.6
Many bugs fixed
Improved transformations
Unified constraints under one tool

Version 1.4.5
Solver improvement
Polyline tool
Command line improvements
Constraint improvements
Many bugs fixed

Version 1.4.4
Ported the property grid to WPF
Added radius constraint, rectangle width and height constraint, length constraint, point to point constraint
Fixed transformations from property grid
Shapes can be selected also from tree
Added capabilities fucntionality. Tools are restricted on what shapes they work on. 

Version 1.4.3
Added fixed circle radius constraint
Added rectangle width and height constraint
Added line length constraint
Many bugs fixed

Version 1.4.2
More tools ported to command line
Improved constraints

Version 1.4.1 modifications
Right click context menu
Improved Cut
Fixes

Version 1.4 modifications
Add command line support for tools. Tool inputs can be given from mouse or command line.

Version 1.3 modifications
Implemented the GUI using WPF and Ribbon Control.

Version 1.0.2 modifications
- Previous work recovery in case of crash,
- Added editing with Drag and drop for 2D shapes. When no tool activated when clicking Line, Circle, Ellipse, Rectangle, Arc, Spline marker points appear and can be dragged with the mouse,
- Implemented Chamfer 3D to be applied on solids, Chamfer 2D to be applied on wires,
- Implemented diameter and length Dimensions,
- Implemented pattern repeat. A shape can be repeated and rotated a number of times having a guideline,
- Implemented Mirror relative to a line and to a point,
- Improved the error logging all errors are logged with log4net,
- Stabilized the intersection algorithm and data tree structure. Undo, Redo, Save, Open are fixed.

Version 1.0.2 Beta modifications

- Added an Option Dialog to add remove the toolbars,
- Added transform operations: from property grid can be set Translate on x, y, z axis, Rotate around x, y, z axis using also a pivot point, Scale, translation can be done also using the mouse,
- Added new shapes: circle and spline,
- Reimplemented the ellipse so that the first click is the ellipse center,
- Implemented copy paste,
- Added 3d shapes: Sphere, Cylinder, Cone,
- Added boolean operations: boolean cut, boolean fuse, boolean intersect,
- Improved the installer and the NaroStarter,
- Added at the geometric solver also detection of parallel lines,
- Fixes at the previously implemented tools.

NaroCAD version 1.0

NaroCAD is an opensource CAD design tool based on proven OpenCascade library (www.opencascade.org) written in C#/.NET. Also it provides wrappers for OpenCascade library that are accessible from any .NET language. This milestone is a hard work consisting in 1200 commits that adds a lot of features and we will point it out here:
- document model similar with OpenCascade's OCAF but C# based, using generics, easily debuggable. High performance undo/redo computing, serializable.
- the label's attributes are defined in a C#/.NET friendly way, no GUIDs involved, and the code of serializing/deserializing even complex types is trivial. You can work out of the box with the following types, but you can add on your own others: integer, double, string, color, reference,
- clean shape definition using dependency solving notifications and easily make possible parametric programming. Separate dependency framework that can be reused,
- command line extensible framework so you can automate your new added shapes,
- there is a solver component that let you get closest geometry. It is useful as it gives for user hints as long as he edit them,
- visual pipes&filters framework that  you have access to various resources like: OpenCascade's context and view, document, open and save dialogs, solver. In case is too complex for you, there is a premade action that gets your custom function and creates everything for you,
- easy to work OpenCascade wrapping focused to minimize the lines you will write your own extensions.

NaroCAD is opensource project, and you can take it's source at any given time from SourceForge's project homepage: https://sourceforge.net/projects/narocad/

If you are interested on site's blog activity you can read more there:
http://narocad.blogspot.com
