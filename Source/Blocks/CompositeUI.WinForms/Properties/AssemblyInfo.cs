//===============================================================================
// Microsoft patterns & practices
// CompositeUI Application Block
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================

using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Permissions;
// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly : AssemblyTitle("Microsoft.Practices.CompositeUI.WinForms")]
[assembly : AssemblyProduct("Microsoft Composite UI WinForms Application Block")]
[assembly : FileIOPermission(SecurityAction.RequestMinimum, Unrestricted = true)]
[assembly : ReflectionPermission(SecurityAction.RequestMinimum, Flags = ReflectionPermissionFlag.MemberAccess)]
[assembly : UIPermission(SecurityAction.RequestMinimum, Unrestricted = true)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly : Guid("9ddd621d-e7f8-4537-ad74-c75225d5631a")]