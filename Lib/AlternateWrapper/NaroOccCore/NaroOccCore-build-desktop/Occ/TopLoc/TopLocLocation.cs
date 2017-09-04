#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.TopLoc;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.TopLoc
{
	public class TopLocLocation : NativeInstancePtr
	{
		public TopLocLocation()
 :
			base(TopLoc_Location_Ctor() )
		{}
		public TopLocLocation(gpTrsf T)
 :
			base(TopLoc_Location_Ctor72D78650(T.Instance) )
		{}
		public TopLocLocation(TopLocDatum3D D)
 :
			base(TopLoc_Location_Ctor2F68E136(D.Instance) )
		{}
			public void Identity()
				{
					TopLoc_Location_Identity(Instance);
				}
			public TopLocLocation Multiplied(TopLocLocation Other)
				{
					return new TopLocLocation(TopLoc_Location_Multiplied15DCA881(Instance, Other.Instance));
				}
			public TopLocLocation Divided(TopLocLocation Other)
				{
					return new TopLocLocation(TopLoc_Location_Divided15DCA881(Instance, Other.Instance));
				}
			public TopLocLocation Predivided(TopLocLocation Other)
				{
					return new TopLocLocation(TopLoc_Location_Predivided15DCA881(Instance, Other.Instance));
				}
			public TopLocLocation Powered(int pwr)
				{
					return new TopLocLocation(TopLoc_Location_PoweredE8219145(Instance, pwr));
				}
			public int HashCode(int Upper)
				{
					return TopLoc_Location_HashCodeE8219145(Instance, Upper);
				}
			public bool IsEqual(TopLocLocation Other)
				{
					return TopLoc_Location_IsEqual15DCA881(Instance, Other.Instance);
				}
			public bool IsDifferent(TopLocLocation Other)
				{
					return TopLoc_Location_IsDifferent15DCA881(Instance, Other.Instance);
				}
		public bool IsIdentity{
			get {
				return TopLoc_Location_IsIdentity(Instance);
			}
		}
		public TopLocDatum3D FirstDatum{
			get {
				return new TopLocDatum3D(TopLoc_Location_FirstDatum(Instance));
			}
		}
		public int FirstPower{
			get {
				return TopLoc_Location_FirstPower(Instance);
			}
		}
		public TopLocLocation NextLocation{
			get {
				return new TopLocLocation(TopLoc_Location_NextLocation(Instance));
			}
		}
		public gpTrsf Transformation{
			get {
				return new gpTrsf(TopLoc_Location_Transformation(Instance));
			}
		}
		public TopLocLocation Inverted{
			get {
				return new TopLocLocation(TopLoc_Location_Inverted(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopLoc_Location_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopLoc_Location_Ctor72D78650(IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopLoc_Location_Ctor2F68E136(IntPtr D);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopLoc_Location_Identity(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopLoc_Location_Multiplied15DCA881(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopLoc_Location_Divided15DCA881(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopLoc_Location_Predivided15DCA881(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopLoc_Location_PoweredE8219145(IntPtr instance, int pwr);
		[DllImport("NaroOccCore.dll")]
		private static extern int TopLoc_Location_HashCodeE8219145(IntPtr instance, int Upper);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TopLoc_Location_IsEqual15DCA881(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TopLoc_Location_IsDifferent15DCA881(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TopLoc_Location_IsIdentity(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopLoc_Location_FirstDatum(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int TopLoc_Location_FirstPower(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopLoc_Location_NextLocation(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopLoc_Location_Transformation(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopLoc_Location_Inverted(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public TopLocLocation(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ TopLocLocation_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void TopLocLocation_Dtor(IntPtr instance);
	}
}
