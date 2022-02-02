using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiscordRpcInjection;

namespace worker_cs
{
    internal class worker_cs
    {
        //DiscordRPC functions
        DiscordRpc.EventHandlers handlers;
        DiscordRpc.RichPresence presence;

        //DiscordRPC
        public void runDiscordRPC()
        {
            this.presence.state = "Login";
            this.presence.largeImageKey = "1024x1024";
            this.presence.largeImageText = "VPN Client by GGS-Network";
            DiscordRpc.UpdatePresence(ref this.presence);
        }

        public void updateDiscordRPC(string details, string state, string largeImageKey, string largeImageText, int startTimestamp, int partySize, int partyMax, string partyID, string joinSecret)
        {
            this.presence.details = details;
            this.presence.state = state;
            this.presence.largeImageKey = largeImageKey;
            this.presence.largeImageText = largeImageText;
            this.presence.startTimestamp = startTimestamp;
            this.presence.partySize = partySize;
            this.presence.partyMax = partyMax;
            this.presence.partyId = partyID;
            this.presence.joinSecret = joinSecret;
            DiscordRpc.UpdatePresence(ref this.presence);
        }
    }
}
