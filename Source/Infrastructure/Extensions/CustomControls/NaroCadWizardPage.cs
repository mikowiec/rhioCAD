/*
 * Created by SharpDevelop.
 * User: Ciprian
 * Date: 2/20/2009
 * Time: 9:19 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CustomControls
{
	/// <summary>
	/// Description of NaroCadWizardPage.
	/// </summary>
	public partial class WizardPage : UserControl
	{
		string _title;
		string _description;
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="title"></param>
		/// <param name="description"></param>
		public WizardPage(string title, string description)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			_title = title;
			_description = description;
		}
		
		/// <summary>
		/// 
		/// </summary>
		public string Title
		{
			get
			{
				return _title;
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		public string Description
		{
			get
			{
				return _description;
			}
		}
	}
}
