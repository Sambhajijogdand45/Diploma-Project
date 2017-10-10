using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Text;

namespace ChatClient
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
    
	public class ChatClientForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox ChatOut;
		private System.Windows.Forms.StatusBar statusBar1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.Button btnSend;
		private int serverport;
		private NetworkStream ns;
		private StreamReader sr;
		private TcpClient clientsocket;
		private Thread receive = null;
		private string serveraddress;
		private System.Windows.Forms.ListBox lbChatters;
		private System.Windows.Forms.RichTextBox rtbChatIn;
		private System.Windows.Forms.Button btnDisconnect;
		private string clientname;
		//private string destclient;
		private bool connected = false;
		private bool logging = false;
		private bool privatemode = false;
		private System.Windows.Forms.Button btnLog;
		private System.Windows.Forms.CheckBox cbPrivate;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
		private StreamWriter logwriter;


		public ChatClientForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			serverport = 5555;
			btnDisconnect.Enabled = false;
			btnSend.Enabled = false;

		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.cbPrivate = new System.Windows.Forms.CheckBox();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.lbChatters = new System.Windows.Forms.ListBox();
            this.ChatOut = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.rtbChatIn = new System.Windows.Forms.RichTextBox();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbPrivate
            // 
            this.cbPrivate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPrivate.Location = new System.Drawing.Point(314, 67);
            this.cbPrivate.Name = "cbPrivate";
            this.cbPrivate.Size = new System.Drawing.Size(64, 24);
            this.cbPrivate.TabIndex = 10;
            this.cbPrivate.Text = "Private";
            this.cbPrivate.CheckStateChanged += new System.EventHandler(this.cbPrivate_CheckedChanged);
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(447, 67);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(80, 24);
            this.btnLog.TabIndex = 9;
            this.btnLog.Text = "Start Logging";
            this.btnLog.Visible = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(112, 67);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(64, 24);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lbChatters
            // 
            this.lbChatters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbChatters.Location = new System.Drawing.Point(0, 0);
            this.lbChatters.Name = "lbChatters";
            this.lbChatters.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbChatters.Size = new System.Drawing.Size(207, 459);
            this.lbChatters.TabIndex = 7;
            // 
            // ChatOut
            // 
            this.ChatOut.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChatOut.Location = new System.Drawing.Point(12, 12);
            this.ChatOut.Multiline = true;
            this.ChatOut.Name = "ChatOut";
            this.ChatOut.Size = new System.Drawing.Size(764, 49);
            this.ChatOut.TabIndex = 2;
            this.ChatOut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ChatOut_KeyPress);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 67);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(80, 24);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // rtbChatIn
            // 
            this.rtbChatIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbChatIn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbChatIn.Location = new System.Drawing.Point(0, 0);
            this.rtbChatIn.Name = "rtbChatIn";
            this.rtbChatIn.ReadOnly = true;
            this.rtbChatIn.Size = new System.Drawing.Size(764, 457);
            this.rtbChatIn.TabIndex = 6;
            this.rtbChatIn.Text = "";
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 579);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(989, 16);
            this.statusBar1.SizingGrip = false;
            this.statusBar1.TabIndex = 3;
            this.statusBar1.Text = "Disconnected";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(201, 67);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(80, 24);
            this.btnDisconnect.TabIndex = 8;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ChatOut);
            this.panel1.Controls.Add(this.cbPrivate);
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Controls.Add(this.btnLog);
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Controls.Add(this.btnDisconnect);
            this.panel1.Location = new System.Drawing.Point(0, 469);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 104);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(989, 463);
            this.panel2.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbChatters);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(782, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(207, 463);
            this.panel4.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.rtbChatIn);
            this.panel3.Location = new System.Drawing.Point(12, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(764, 457);
            this.panel3.TabIndex = 8;
            // 
            // ChatClientForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(989, 595);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ChatClientForm";
            this.Text = "Chat";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChatClientForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion
		protected override void OnClosed(EventArgs e)
		{
			QuitChat();
			if(receive != null && receive.IsAlive)
				receive.Abort();
			
			base.OnClosed(e);
		}

		private void EstablishConnection()
		{
			statusBar1.Text = "Connecting to Server";
			try 
			{
				clientsocket = new TcpClient(serveraddress,serverport);
				ns = clientsocket.GetStream();
				sr = new StreamReader(ns);
				connected = true;
			}
			catch (Exception e)
			{
				MessageBox.Show("Could not connect to Server","Error",
					MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				statusBar1.Text = "Disconnected";
			}
		}
		private void RegisterWithServer()
		{
			try 
			{
                
				string command = "CONN|" + ChatOut.Text;
				Byte[] outbytes = System.Text.Encoding.ASCII.GetBytes(command.ToCharArray());

                ns.Write(outbytes, 0, outbytes.Length);

                string serverresponse = sr.ReadLine();
                serverresponse.Trim();
                string[] tokens = serverresponse.Split(new Char[] { '|' });
                if (tokens[0] == "LIST")
                {
                    statusBar1.Text = "Connected";
                    btnDisconnect.Enabled = true;
                }
                for (int n = 1; n < tokens.Length - 1; n++)
                    lbChatters.Items.Add(tokens[n].Trim(new char[] { '\r', '\n' }));
                this.Text = clientname + ": Connected to Chat Server";
				
			}
			catch (Exception e)
			{
				MessageBox.Show("Error Registering","Error",
					MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
		
		private void ReceiveChat()
		{
			bool keepalive = true;
			while (keepalive) 
			{
				try
				{
					Byte[] buffer = new Byte[2048];
					ns.Read(buffer,0,buffer.Length);
					string chatter = System.Text.Encoding.ASCII.GetString(buffer);

					string[] tokens = chatter.Split(new Char[]{'|'});

					if (tokens[0] == "CHAT")
					{
						rtbChatIn.AppendText(tokens[1]);
						if(logging)
							logwriter.WriteLine(tokens[1]);
					}
					if (tokens[0] == "PRIV") {
						rtbChatIn.AppendText("Private from ");
						rtbChatIn.AppendText(tokens[1].Trim() );
						rtbChatIn.AppendText(tokens[2] + "\r\n");
						if(logging){
							logwriter.Write("Private from ");
							logwriter.Write(tokens[1].Trim() );
							logwriter.WriteLine(tokens[2] + "\r\n");
						}
					}
					if (tokens[0] == "JOIN")
					{
						rtbChatIn.AppendText(tokens[1].Trim() );
						rtbChatIn.AppendText(" has joined the Chat\r\n");
						if(logging){
							logwriter.WriteLine(tokens[1]+" has joined the Chat");
						}
						string newguy = tokens[1].Trim(new char[]{'\r','\n'});
						lbChatters.Items.Add(newguy);
					}
					if (tokens[0] == "GONE")
					{
						rtbChatIn.AppendText(tokens[1].Trim() );
						rtbChatIn.AppendText(" has left the Chat\r\n");
						if(logging){
							logwriter.WriteLine(tokens[1]+" has left the Chat");
						}
						lbChatters.Items.Remove(tokens[1].Trim(new char[]{'\r','\n'}));
					}
					if (tokens[0] == "QUIT")
					{
						ns.Close();
						clientsocket.Close();
						keepalive = false;
						statusBar1.Text = "Server has stopped";
						connected= false;
						btnSend.Enabled = false;
						btnDisconnect.Enabled = false;
					}
				}
				catch(Exception e){}
			}
		}
		private void QuitChat() 
		{
			if(connected) {
				try{
					string command = "GONE|" + clientname;
					Byte[] outbytes = System.Text.Encoding.ASCII.GetBytes(command.ToCharArray());
					ns.Write(outbytes,0,outbytes.Length);
					clientsocket.Close();
				}
				catch(Exception ex){
				}
			}
			if(logging)
				logwriter.Close();

			if(receive != null && receive.IsAlive)
				receive.Abort();
			this.Text = "ChatClient";
			
		}
		private void StartStopLogging() 
		{
			if(!logging){
				if(!Directory.Exists("logs"))
					Directory.CreateDirectory("logs");
				string fname = "logs\\" + DateTime.Now.ToString("ddMMyyHHmm") + ".txt";
				logwriter = new StreamWriter(new FileStream(fname, FileMode.OpenOrCreate,
					FileAccess.Write));
				logging = true;
				btnLog.Text = "Stop Logging";
				statusBar1.Text = "Connected - Log on";
			}
			else{
				logwriter.Close();
				logging = false;
				btnLog.Text = "Start Logging";
				statusBar1.Text = "Connected - Log off";
			}

		}
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(String[] args) 
		{
			ChatClientForm cf = new ChatClientForm();
			if(args.Length == 0)
                cf.serveraddress = "192.168.0.1";
			else
				cf.serveraddress = args[0];

			Application.Run(cf);
		}

		private void btnConnect_Click(object sender, System.EventArgs e)
		{
			if(ChatOut.Text == ""){
				MessageBox.Show("Enter a name in the box before connecting","Error",
					MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			else
				clientname = ChatOut.Text;
			
			EstablishConnection();
			
			if(connected)
			{
				RegisterWithServer();
				receive = new Thread(new ThreadStart(ReceiveChat));
				receive.Start();
				btnSend.Enabled = true;
				btnConnect.Enabled = false;
				ChatOut.Text = "";
			}
		}

		private void btnSend_Click(object sender, System.EventArgs e)
		{
			try{
				string dclient = "";
				if(!privatemode){
					string pubcommand = "CHAT|" + clientname +": "+ChatOut.Text + "\r\n";
					Byte[] outbytes = System.Text.Encoding.ASCII.GetBytes(pubcommand.ToCharArray());
					ns.Write(outbytes,0,outbytes.Length);
					ChatOut.Text = "";
				}
				else{
					if(lbChatters.SelectedIndex == -1){
						MessageBox.Show("Select a chatter name from the list","Error",
							MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						return;
					}

					string destclient = lbChatters.SelectedItem.ToString();
					string command = "PRIV|" + clientname + "|: " + ChatOut.Text + "|" + destclient;
					Byte[] outbytes = System.Text.Encoding.ASCII.GetBytes(command.ToCharArray());
					ns.Write(outbytes,0,outbytes.Length);
					ChatOut.Text = "";
				}

			}
			catch(Exception ex){
				MessageBox.Show("Connection with Server lost","Error",
					MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				ns.Close();
				clientsocket.Close();
				if(receive != null && receive.IsAlive)
					receive.Abort();
				connected = false;
				statusBar1.Text = "Disconnected";
			}
		}

		private void btnDisconnect_Click(object sender, System.EventArgs e)
		{
            try
            {
                QuitChat();
                btnDisconnect.Enabled = false;
                btnConnect.Enabled = true;
                btnSend.Enabled = false;
                //ns.Close();
                clientsocket.Close();
                receive.Abort();
                connected = false;
                lbChatters.Items.Clear();
                statusBar1.Text = "Disconnected";
            }
            catch (Exception ex) { }
		}

		private void ChatOut_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e) {
			if(e.KeyChar == '\r')
				if(connected)
					btnSend_Click(sender, e);
				else
					btnConnect_Click(sender, e);
		}

		private void btnLog_Click(object sender, System.EventArgs e) {
			StartStopLogging();
		}

		private void cbPrivate_CheckedChanged(object sender, System.EventArgs e) {
			if(cbPrivate.Checked){
				privatemode = true;
				lbChatters.SelectionMode = System.Windows.Forms.SelectionMode.One;
			}
			else{
				privatemode = false;
				lbChatters.SelectionMode = System.Windows.Forms.SelectionMode.None;
			}
		}

        private void ChatClientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnDisconnect_Click(sender, e);   
        }

	}
}