﻿// Copyright (c) AlphaSierraPapa for the SharpDevelop Team (for details please see \doc\copyright.txt)
// This code is distributed under MIT X11 license (for details please see \doc\license.txt)

using System;

namespace ICSharpCode.NRefactory.CSharp.Resolver
{
	public interface IResolveVisitorNavigator
	{
		ResolveVisitorNavigationMode Scan(INode node);
	}
	
	public enum ResolveVisitorNavigationMode
	{
		/// <summary>
		/// Scan into the children of the current node, without resolving the current node.
		/// </summary>
		Scan,
		/// <summary>
		/// Skip the current node - do not scan into it; do not resolve it.
		/// </summary>
		Skip,
		/// <summary>
		/// Resolve the current node; but only scan subnodes which are not required for resolving the current node.
		/// </summary>
		Resolve,
		/// <summary>
		/// Resolves all nodes in the current subtree.
		/// </summary>
		ResolveAll
	}
}
