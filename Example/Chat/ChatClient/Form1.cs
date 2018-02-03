using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ONetworkTalk.Core;
using ONetworkTalk.Contract;

namespace ChatClient
{
    public partial class Form1 : Form
    {
        public OClientEngine clientEngine;
        public Form1()
        {
            InitializeComponent();
            clientEngine = new OClientEngine();
            ClientCustomizeHandler clientCustomizeHandler = new ClientCustomizeHandler();
            clientEngine.Login("","","");
            clientEngine.RunEngineAsync("127.0.0.1", 18888, clientCustomizeHandler);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = RtbSend.Text.Trim();
            if (string.IsNullOrEmpty(msg)) return;
            ChatContent chat = new ChatContent() { Content = msg };
            clientEngine.BasicOutter.Send<ChatContent>(1,(chat1)=> {
                this.RtbMsgList.AppendText(chat1.Content);
                this.RtbSend.Text = "";
            }, chat);
        }
    }
}
