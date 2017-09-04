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
using System.Net;
using System.Reflection;
using System.Security.Permissions;
// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly : AssemblyTitle("Microsoft.Practices.CompositeUI")]
[assembly : AssemblyDescription("Microsoft Composite UI Application Block")]
[assembly :
	DataProtectionPermission(SecurityAction.RequestMinimum,
		Flags = DataProtectionPermissionFlags.ProtectData | DataProtectionPermissionFlags.UnprotectData)]
[assembly : FileIOPermission(SecurityAction.RequestMinimum, Unrestricted = true)]
[assembly : ReflectionPermission(SecurityAction.RequestMinimum, Flags = ReflectionPermissionFlag.MemberAccess)]
[assembly : SecurityPermission(SecurityAction.RequestMinimum, Flags = SecurityPermissionFlag.ControlPrincipal)]
[assembly : WebPermission(SecurityAction.RequestMinimum, Unrestricted = true)]