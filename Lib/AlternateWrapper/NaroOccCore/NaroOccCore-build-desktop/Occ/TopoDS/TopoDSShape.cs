#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.TopAbs;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.TopLoc;

#endregion

namespace NaroCppCore.Occ.TopoDS
{
	public class TopoDSShape : NativeInstancePtr
	{
		public TopoDSShape()
 :
			base(TopoDS_Shape_Ctor() )
		{}
			public void Nullify()
				{
					TopoDS_Shape_Nullify(Instance);
				}
			public TopLocLocation Location()
				{
					return new TopLocLocation(TopoDS_Shape_Location(Instance));
				}
			public void Location(TopLocLocation Loc)
				{
					TopoDS_Shape_Location15DCA881(Instance, Loc.Instance);
				}
			public TopoDSShape Located(TopLocLocation Loc)
				{
					return new TopoDSShape(TopoDS_Shape_Located15DCA881(Instance, Loc.Instance));
				}
			public TopAbsOrientation Orientation()
				{
					return (TopAbsOrientation)TopoDS_Shape_Orientation(Instance);
				}
			public void Orientation(TopAbsOrientation Orient)
				{
					TopoDS_Shape_Orientation69EAD1AB(Instance, (int)Orient);
				}
			public TopoDSShape Oriented(TopAbsOrientation Or)
				{
					return new TopoDSShape(TopoDS_Shape_Oriented69EAD1AB(Instance, (int)Or));
				}
			public TopoDSTShape TShape()
				{
					return new TopoDSTShape(TopoDS_Shape_TShape(Instance));
				}
			public bool Free()
				{
					return TopoDS_Shape_Free(Instance);
				}
			public void Free(bool F)
				{
					TopoDS_Shape_Free461FC46A(Instance, F);
				}
			public bool Modified()
				{
					return TopoDS_Shape_Modified(Instance);
				}
			public void Modified(bool M)
				{
					TopoDS_Shape_Modified461FC46A(Instance, M);
				}
			public bool Checked()
				{
					return TopoDS_Shape_Checked(Instance);
				}
			public void Checked(bool C)
				{
					TopoDS_Shape_Checked461FC46A(Instance, C);
				}
			public bool Orientable()
				{
					return TopoDS_Shape_Orientable(Instance);
				}
			public void Orientable(bool C)
				{
					TopoDS_Shape_Orientable461FC46A(Instance, C);
				}
			public bool Closed()
				{
					return TopoDS_Shape_Closed(Instance);
				}
			public void Closed(bool C)
				{
					TopoDS_Shape_Closed461FC46A(Instance, C);
				}
			public bool Infinite()
				{
					return TopoDS_Shape_Infinite(Instance);
				}
			public void Infinite(bool C)
				{
					TopoDS_Shape_Infinite461FC46A(Instance, C);
				}
			public bool Convex()
				{
					return TopoDS_Shape_Convex(Instance);
				}
			public void Convex(bool C)
				{
					TopoDS_Shape_Convex461FC46A(Instance, C);
				}
			public void Move(TopLocLocation position)
				{
					TopoDS_Shape_Move15DCA881(Instance, position.Instance);
				}
			public TopoDSShape Moved(TopLocLocation position)
				{
					return new TopoDSShape(TopoDS_Shape_Moved15DCA881(Instance, position.Instance));
				}
			public void Reverse()
				{
					TopoDS_Shape_Reverse(Instance);
				}
			public void Complement()
				{
					TopoDS_Shape_Complement(Instance);
				}
			public void Compose(TopAbsOrientation Orient)
				{
					TopoDS_Shape_Compose69EAD1AB(Instance, (int)Orient);
				}
			public TopoDSShape Composed(TopAbsOrientation Orient)
				{
					return new TopoDSShape(TopoDS_Shape_Composed69EAD1AB(Instance, (int)Orient));
				}
			public bool IsPartner(TopoDSShape other)
				{
					return TopoDS_Shape_IsPartner9EBAC0C0(Instance, other.Instance);
				}
			public bool IsSame(TopoDSShape other)
				{
					return TopoDS_Shape_IsSame9EBAC0C0(Instance, other.Instance);
				}
			public bool IsEqual(TopoDSShape other)
				{
					return TopoDS_Shape_IsEqual9EBAC0C0(Instance, other.Instance);
				}
			public bool IsNotEqual(TopoDSShape other)
				{
					return TopoDS_Shape_IsNotEqual9EBAC0C0(Instance, other.Instance);
				}
			public int HashCode(int Upper)
				{
					return TopoDS_Shape_HashCodeE8219145(Instance, Upper);
				}
			public void EmptyCopy()
				{
					TopoDS_Shape_EmptyCopy(Instance);
				}
			public void TShape(TopoDSTShape T)
				{
					TopoDS_Shape_TShape3F0FF109(Instance, T.Instance);
				}
		public bool IsNull{
			get {
				return TopoDS_Shape_IsNull(Instance);
			}
		}
		public TopAbsShapeEnum ShapeType{
			get {
				return (TopAbsShapeEnum)TopoDS_Shape_ShapeType(Instance);
			}
		}
		public TopoDSShape Reversed{
			get {
				return new TopoDSShape(TopoDS_Shape_Reversed(Instance));
			}
		}
		public TopoDSShape Complemented{
			get {
				return new TopoDSShape(TopoDS_Shape_Complemented(Instance));
			}
		}
		public TopoDSShape EmptyCopied{
			get {
				return new TopoDSShape(TopoDS_Shape_EmptyCopied(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopoDS_Shape_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern void TopoDS_Shape_Nullify(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopoDS_Shape_Location(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopoDS_Shape_Location15DCA881(IntPtr instance, IntPtr Loc);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopoDS_Shape_Located15DCA881(IntPtr instance, IntPtr Loc);
		[DllImport("NaroOccCore.dll")]
		private static extern int TopoDS_Shape_Orientation(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopoDS_Shape_Orientation69EAD1AB(IntPtr instance, int Orient);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopoDS_Shape_Oriented69EAD1AB(IntPtr instance, int Or);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopoDS_Shape_TShape(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TopoDS_Shape_Free(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopoDS_Shape_Free461FC46A(IntPtr instance, bool F);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TopoDS_Shape_Modified(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopoDS_Shape_Modified461FC46A(IntPtr instance, bool M);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TopoDS_Shape_Checked(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopoDS_Shape_Checked461FC46A(IntPtr instance, bool C);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TopoDS_Shape_Orientable(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopoDS_Shape_Orientable461FC46A(IntPtr instance, bool C);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TopoDS_Shape_Closed(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopoDS_Shape_Closed461FC46A(IntPtr instance, bool C);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TopoDS_Shape_Infinite(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopoDS_Shape_Infinite461FC46A(IntPtr instance, bool C);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TopoDS_Shape_Convex(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopoDS_Shape_Convex461FC46A(IntPtr instance, bool C);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopoDS_Shape_Move15DCA881(IntPtr instance, IntPtr position);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopoDS_Shape_Moved15DCA881(IntPtr instance, IntPtr position);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopoDS_Shape_Reverse(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopoDS_Shape_Complement(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopoDS_Shape_Compose69EAD1AB(IntPtr instance, int Orient);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopoDS_Shape_Composed69EAD1AB(IntPtr instance, int Orient);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TopoDS_Shape_IsPartner9EBAC0C0(IntPtr instance, IntPtr other);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TopoDS_Shape_IsSame9EBAC0C0(IntPtr instance, IntPtr other);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TopoDS_Shape_IsEqual9EBAC0C0(IntPtr instance, IntPtr other);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TopoDS_Shape_IsNotEqual9EBAC0C0(IntPtr instance, IntPtr other);
		[DllImport("NaroOccCore.dll")]
		private static extern int TopoDS_Shape_HashCodeE8219145(IntPtr instance, int Upper);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopoDS_Shape_EmptyCopy(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopoDS_Shape_TShape3F0FF109(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TopoDS_Shape_IsNull(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int TopoDS_Shape_ShapeType(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopoDS_Shape_Reversed(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopoDS_Shape_Complemented(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopoDS_Shape_EmptyCopied(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public TopoDSShape(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ TopoDSShape_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void TopoDSShape_Dtor(IntPtr instance);
	}
}
