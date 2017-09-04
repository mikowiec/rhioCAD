/*
 * Created by SharpDevelop.
 * User: Ciprian
 * Date: 3/3/2009
 * Time: 7:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using Extensions.TreeData.AttributeInterpreter;
using System;
using Naro.Infrastructure.Library.Geometry;
using OCNaroWrappers;
using TreeData.NaroData;

namespace Naro.Solver.DataHelper
{
	/// <summary>
	/// Description of NodeHelper.
	/// </summary>
	public static class NodeHelper
	{
				
		public static OCgp_Pnt ComputeMidPoint(OCgp_Pnt point1, OCgp_Pnt point2)
		{
				OCgp_Pnt pointMid = new OCgp_Pnt();
				pointMid.SetCoord((point1.X() + point2.X()) / 2,
				                   (point1.Y() + point2.Y()) / 2,
				                   (point1.Z() + point2.Z()) / 2);
				return pointMid;
		}
		
		public static void AddVertex(Node rootNode, OCgp_Pnt point)
		{
			rootNode.AddNewChild().Update<GeometryInterpreter>().Value = point;
		}
		
		public static void AddLine(Node rootNode, OCgp_Pnt point1, OCgp_Pnt point2)
		{
				AddVertex(rootNode, point1);
				AddVertex(rootNode, point2);
				var pointmid = ComputeMidPoint(point1, point2);
				AddVertex(rootNode, pointmid);
		}
		
		public static void AddRectangle(Node rootNode, OCgp_Pnt point1, OCgp_Pnt point2, OCgp_Pnt point3)
		{
			var result = rootNode.AddNewChild();
			// The first pointe is generated from the other 3 points
            OCgp_Pnt point4 = new OCgp_Pnt(-point1.X() + point2.X() + point3.X(),
                                           -point1.Y() + point2.Y() + point3.Y(),
                                           -point1.Z() + point2.Z() + point3.Z());
			AddVertex(rootNode, point1);
			AddVertex(rootNode, ComputeMidPoint(point1, point2));
			AddVertex(rootNode, point2);
			AddVertex(rootNode, ComputeMidPoint(point2, point3));
			AddVertex(rootNode, point3);
			AddVertex(rootNode, ComputeMidPoint(point3, point4));
			AddVertex(rootNode, point4);
			AddVertex(rootNode, ComputeMidPoint(point4, point1));
		}

        public static void AddShape(Node rootNode, Shape2d shape)
        {
            var list = shape.GetMagicPoints();
            if (list != null)
            {
                OCgp_Pnt previousPoint = new OCgp_Pnt();
                bool secondPoint = false;
                foreach (OCgp_Pnt point in list)
                {
                    AddVertex(rootNode, point); 
                    // After the secodn point start calculating the mid points
                    if (secondPoint == true)
                    {
                        AddVertex(rootNode, ComputeMidPoint(previousPoint, point));
                    }

                    previousPoint = point;
                    secondPoint = true;
                }
            }
        }
	}
}
