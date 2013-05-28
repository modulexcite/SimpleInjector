﻿namespace SimpleInjector.Tests.Unit.Diagnostics
{
    using System.Collections.Generic;
    using System.Linq;
    using SimpleInjector.Diagnostics;

    internal static class DebuggerViewItemExtensions
    {
        internal static IEnumerable<DebuggerViewItem> Items(this DebuggerViewItem item)
        {
            if (item.Value is IEnumerable<DebuggerViewItem>)
            {
                return item.Value as IEnumerable<DebuggerViewItem>;
            }

            return Enumerable.Empty<DebuggerViewItem>();
        }
    }
}