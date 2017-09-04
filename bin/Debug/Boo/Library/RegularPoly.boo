

import System
import Naro.Infrastructure.Interface.GeomHelpers from Infrastructure.Interface
import BooGearPlugin.Modifiers
import NaroConstants.Names
import OCNaroWrappers from OCWrappers
import ShapeFunctionsInterface.Utils
import TreeData.AttributeInterpreter
import TreeData.NaroData
import PointUtils from PointUtils

internal class RegularPoly(BooLibraryShape):

	public def constructor():
		AddPoint3DDependency()
		AddPoint3DDependency()
		AddIntDependency(5)

	
	private static def ComputeLegStep(position as Point3D, radius as double, index as int, steps as int) as Point3D:
		angle  = (((2 * Math.PI) * index) / steps)
		return Point3D((position.X + (radius * Math.Cos(angle))), (position.Y + (radius * Math.Sin(angle))), position.Z)

	
	public override def Execute(document as Document) as bool:
		position  = Get[of Point3D](0)
		secondPoint  = Get[of Point3D](1)
		steps  = Get[of int](2)
		pointLinker = DocumentPointLinker(document, document.Root[0])
		radius  = secondPoint.Distance(position)
		builder  = NodeBuilder()
		for index in range(0, steps):
			builder = NodeBuilder(document, FunctionNames.LineTwoPoints)
			builder[0].Reference = pointLinker.GetPoint(ComputeLegStep(position, radius, index, steps)).Node
			builder[1].Reference = pointLinker.GetPoint(ComputeLegStep(position, radius, (index + 1), steps)).Node
			if not builder.ExecuteFunction():
				return false

		diff  = secondPoint.SubstractCoordinate(position)		
		return true

