// -----------------------------------------------------------------------
// <copyright file="Plugin.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace DisableFemurBreaker
{
    using System;
    using Exiled.API.Features;

    /// <inheritdoc />
    public class Plugin : Plugin<Config>
    {
        private EventHandlers eventHandlers;

        /// <inheritdoc/>
        public override string Author => "Build";

        /// <inheritdoc/>
        public override string Name => "DisableFemurBreaker";

        /// <inheritdoc/>
        public override string Prefix => "DisableFemurBreaker";

        /// <inheritdoc/>
        public override Version Version { get; } = new Version(1, 0, 0);

        /// <inheritdoc/>
        public override Version RequiredExiledVersion { get; } = new Version(5, 2, 1);

        /// <inheritdoc/>
        public override void OnEnabled()
        {
            eventHandlers = new EventHandlers();
            Exiled.Events.Handlers.Scp106.Containing += eventHandlers.OnContaining;
            Exiled.Events.Handlers.Server.WaitingForPlayers += eventHandlers.OnWaitingForPlayers;
            base.OnEnabled();
        }

        /// <inheritdoc/>
        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Scp106.Containing -= eventHandlers.OnContaining;
            Exiled.Events.Handlers.Server.WaitingForPlayers -= eventHandlers.OnWaitingForPlayers;
            eventHandlers = null;
            base.OnDisabled();
        }
    }
}