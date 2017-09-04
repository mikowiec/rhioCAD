/*
 * Created by SharpDevelop.
 * User: Ciprian
 * Date: 2/23/2009
 * Time: 5:35 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System.Collections.Generic;
using Naro.Infrastructure.Interface;
using Naro.Sketcher.Constants;

namespace Naro.Sketcher
{
	/// <summary>
	/// Description of Update2DNotifier.
	/// </summary>
	public class Update2DModifier
	{
		private Update2DModifier()
		{
		}

		public static void RegisterAction(ActionType actionType, Action3d action)
		{
			_actions[actionType] = action;
		}
		
		public static Action3d CreateModifier(ActionType actionType)
		{
			if(_actions.ContainsKey(actionType))
			{
				return _actions[actionType];
			}
			return null;
		}

        static SortedDictionary<ActionType, Action3d> _actions
            = new SortedDictionary<ActionType, Action3d>();
	}
}
