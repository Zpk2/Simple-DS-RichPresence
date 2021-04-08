using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRpcDemo;

namespace Simple_RPC
{
    public partial class simplerpc : Form
    {
        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;
        public simplerpc()
        {
            InitializeComponent();
        }

        private void simplerpc_Load(object sender, EventArgs e)
        {

        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize(idtxt.Text, ref this.handlers, true, null);
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize(idtxt.Text, ref this.handlers, true, null);
            this.presence.state = statetxt.Text;
            this.presence.details = dettxt.Text;
            this.presence.largeImageKey = largeimgkeytxt.Text;
            this.presence.smallImageKey = smallimgkeytxt.Text;
            this.presence.largeImageText = largeimgtxt.Text;
            this.presence.smallImageText = smallimgtxt.Text;
            DiscordRpc.UpdatePresence(ref this.presence);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://niaso.cf");
        }
    }
}
