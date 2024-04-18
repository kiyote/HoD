// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;
[assembly: SuppressMessage( "Performance", "CA1812:Avoid uninstantiated internal classes", Justification = "DI is a thing.", Scope = "module" )]
[assembly: SuppressMessage( "Reliability", "CA2007:Consider calling ConfigureAwait on the awaited task", Justification = "Using ConfigureAwait.Fody", Scope = "module" )]
