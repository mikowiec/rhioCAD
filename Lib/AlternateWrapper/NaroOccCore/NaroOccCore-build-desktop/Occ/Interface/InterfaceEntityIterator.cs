#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Standard;
using NaroCppCore.Occ.Interface;

#endregion

namespace NaroCppCore.Occ.Interface
{
	public class InterfaceEntityIterator : NativeInstancePtr
	{
		public InterfaceEntityIterator()
 :
			base(Interface_EntityIterator_Ctor() )
		{}
			public void AddItem(StandardTransient anentity)
				{
					Interface_EntityIterator_AddItemF411CB01(Instance, anentity.Instance);
				}
			public void GetOneItem(StandardTransient anentity)
				{
					Interface_EntityIterator_GetOneItemF411CB01(Instance, anentity.Instance);
				}
			public void SelectType(StandardType atype,bool keep)
				{
					Interface_EntityIterator_SelectTypeC4B77EEF(Instance, atype.Instance, keep);
				}
			public int NbTyped(StandardType type)
				{
					return Interface_EntityIterator_NbTypedE2B3EAC1(Instance, type.Instance);
				}
			public InterfaceEntityIterator Typed(StandardType type)
				{
					return new InterfaceEntityIterator(Interface_EntityIterator_TypedE2B3EAC1(Instance, type.Instance));
				}
			public void Start()
				{
					Interface_EntityIterator_Start(Instance);
				}
			public void Next()
				{
					Interface_EntityIterator_Next(Instance);
				}
			public void Destroy()
				{
					Interface_EntityIterator_Destroy(Instance);
				}
		public int NbEntities{
			get {
				return Interface_EntityIterator_NbEntities(Instance);
			}
		}
		public bool More{
			get {
				return Interface_EntityIterator_More(Instance);
			}
		}
		public StandardTransient Value{
			get {
				return new StandardTransient(Interface_EntityIterator_Value(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Interface_EntityIterator_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern void Interface_EntityIterator_AddItemF411CB01(IntPtr instance, IntPtr anentity);
		[DllImport("NaroOccCore.dll")]
		private static extern void Interface_EntityIterator_GetOneItemF411CB01(IntPtr instance, IntPtr anentity);
		[DllImport("NaroOccCore.dll")]
		private static extern void Interface_EntityIterator_SelectTypeC4B77EEF(IntPtr instance, IntPtr atype,bool keep);
		[DllImport("NaroOccCore.dll")]
		private static extern int Interface_EntityIterator_NbTypedE2B3EAC1(IntPtr instance, IntPtr type);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Interface_EntityIterator_TypedE2B3EAC1(IntPtr instance, IntPtr type);
		[DllImport("NaroOccCore.dll")]
		private static extern void Interface_EntityIterator_Start(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Interface_EntityIterator_Next(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Interface_EntityIterator_Destroy(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Interface_EntityIterator_NbEntities(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Interface_EntityIterator_More(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Interface_EntityIterator_Value(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public InterfaceEntityIterator(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ InterfaceEntityIterator_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void InterfaceEntityIterator_Dtor(IntPtr instance);
	}
}
