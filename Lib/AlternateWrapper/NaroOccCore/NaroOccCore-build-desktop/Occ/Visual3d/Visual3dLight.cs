#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.Graphic3d;
using NaroCppCore.Occ.Quantity;
using NaroCppCore.Occ.Visual3d;

#endregion

namespace NaroCppCore.Occ.Visual3d
{
	public class Visual3dLight : MMgtTShared
	{
		public Visual3dLight()
 :
			base(Visual3d_Light_Ctor() )
		{}
		public Visual3dLight(QuantityColor Color)
 :
			base(Visual3d_Light_Ctor8FD7F48(Color.Instance) )
		{}
		public Visual3dLight(QuantityColor Color,Graphic3dVector Direction,bool Headlight)
 :
			base(Visual3d_Light_Ctor37E700E8(Color.Instance, Direction.Instance, Headlight) )
		{}
		public Visual3dLight(QuantityColor Color,Graphic3dVertex Position,double Fact1,double Fact2)
 :
			base(Visual3d_Light_Ctor75C213E8(Color.Instance, Position.Instance, Fact1, Fact2) )
		{}
		public Visual3dLight(QuantityColor Color,Graphic3dVertex Position,Graphic3dVector Direction,double Concentration,double Fact1,double Fact2,double AngleCone)
 :
			base(Visual3d_Light_Ctor3F337B1E(Color.Instance, Position.Instance, Direction.Instance, Concentration, Fact1, Fact2, AngleCone) )
		{}
			public void Values(QuantityColor Color)
				{
					Visual3d_Light_Values8FD7F48(Instance, Color.Instance);
				}
			public void Values(QuantityColor Color,Graphic3dVector Direction)
				{
					Visual3d_Light_Values7778B201(Instance, Color.Instance, Direction.Instance);
				}
			public void Values(QuantityColor Color,Graphic3dVertex Position,ref double Fact1,ref double Fact2)
				{
					Visual3d_Light_Values75C213E8(Instance, Color.Instance, Position.Instance, ref Fact1, ref Fact2);
				}
			public void Values(QuantityColor Color,Graphic3dVertex Position,Graphic3dVector Direction,ref double Concentration,ref double Fact1,ref double Fact2,ref double AngleCone)
				{
					Visual3d_Light_Values3F337B1E(Instance, Color.Instance, Position.Instance, Direction.Instance, ref Concentration, ref Fact1, ref Fact2, ref AngleCone);
				}
		public double Angle{
			set { 
				Visual3d_Light_SetAngle(Instance, value);
			}
		}
		public double Attenuation1{
			set { 
				Visual3d_Light_SetAttenuation1(Instance, value);
			}
		}
		public double Attenuation2{
			set { 
				Visual3d_Light_SetAttenuation2(Instance, value);
			}
		}
		public double Concentration{
			set { 
				Visual3d_Light_SetConcentration(Instance, value);
			}
		}
		public Graphic3dVector Direction{
			set { 
				Visual3d_Light_SetDirection(Instance, value.Instance);
			}
		}
		public Graphic3dVertex Position{
			set { 
				Visual3d_Light_SetPosition(Instance, value.Instance);
			}
		}
		public bool Headlight{
			get {
				return Visual3d_Light_Headlight(Instance);
			}
		}
		public QuantityColor Color{
			set { 
				Visual3d_Light_SetColor(Instance, value.Instance);
			}
			get {
				return new QuantityColor(Visual3d_Light_Color(Instance));
			}
		}
		public Visual3dTypeOfLightSource LightType{
			get {
				return (Visual3dTypeOfLightSource)Visual3d_Light_LightType(Instance);
			}
		}
		public static int Limit{
			get {
				return Visual3d_Light_Limit();
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Visual3d_Light_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Visual3d_Light_Ctor8FD7F48(IntPtr Color);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Visual3d_Light_Ctor37E700E8(IntPtr Color,IntPtr Direction,bool Headlight);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Visual3d_Light_Ctor75C213E8(IntPtr Color,IntPtr Position,double Fact1,double Fact2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Visual3d_Light_Ctor3F337B1E(IntPtr Color,IntPtr Position,IntPtr Direction,double Concentration,double Fact1,double Fact2,double AngleCone);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_Light_Values8FD7F48(IntPtr instance, IntPtr Color);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_Light_Values7778B201(IntPtr instance, IntPtr Color,IntPtr Direction);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_Light_Values75C213E8(IntPtr instance, IntPtr Color,IntPtr Position,ref double Fact1,ref double Fact2);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_Light_Values3F337B1E(IntPtr instance, IntPtr Color,IntPtr Position,IntPtr Direction,ref double Concentration,ref double Fact1,ref double Fact2,ref double AngleCone);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_Light_SetAngle(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_Light_SetAttenuation1(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_Light_SetAttenuation2(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_Light_SetConcentration(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_Light_SetDirection(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_Light_SetPosition(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Visual3d_Light_Headlight(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_Light_SetColor(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Visual3d_Light_Color(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Visual3d_Light_LightType(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Visual3d_Light_Limit();

		#region NativeInstancePtr Convert constructor

		public Visual3dLight(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ Visual3dLight_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3dLight_Dtor(IntPtr instance);
	}
}
