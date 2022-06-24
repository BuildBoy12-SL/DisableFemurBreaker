// -----------------------------------------------------------------------
// <copyright file="EventHandlers.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace DisableFemurBreaker
{
    using Exiled.API.Features;
    using Exiled.Events.EventArgs;

    /// <summary>
    /// General event handlers.
    /// </summary>
    public class EventHandlers
    {
        /// <inheritdoc cref="Exiled.Events.Handlers.Scp106.OnContaining(ContainingEventArgs)"/>
        public void OnContaining(ContainingEventArgs ev) => ev.IsAllowed = false;

        /// <inheritdoc cref="Exiled.Events.Handlers.Server.OnWaitingForPlayers()"/>
        public void OnWaitingForPlayers() => Scp106Container.AllowContain = true;
    }
}