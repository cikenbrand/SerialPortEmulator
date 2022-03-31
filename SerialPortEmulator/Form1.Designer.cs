
namespace SerialPortEmulator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.AvailablePortsListBox = new System.Windows.Forms.ListBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddedPortsListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.VirtualPort1ComboBox = new System.Windows.Forms.ComboBox();
            this.VirtualPort2ComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Available Ports:";
            // 
            // AvailablePortsListBox
            // 
            this.AvailablePortsListBox.FormattingEnabled = true;
            this.AvailablePortsListBox.Location = new System.Drawing.Point(15, 56);
            this.AvailablePortsListBox.Name = "AvailablePortsListBox";
            this.AvailablePortsListBox.Size = new System.Drawing.Size(115, 160);
            this.AvailablePortsListBox.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(137, 84);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(103, 41);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(137, 131);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(103, 45);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddedPortsListBox
            // 
            this.AddedPortsListBox.FormattingEnabled = true;
            this.AddedPortsListBox.Location = new System.Drawing.Point(246, 56);
            this.AddedPortsListBox.Name = "AddedPortsListBox";
            this.AddedPortsListBox.Size = new System.Drawing.Size(122, 160);
            this.AddedPortsListBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Added Ports:";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(259, 257);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(109, 51);
            this.ConnectButton.TabIndex = 6;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(156, 257);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 51);
            this.button4.TabIndex = 8;
            this.button4.Text = "Disconnect";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Virtual Ports:";
            // 
            // VirtualPort1ComboBox
            // 
            this.VirtualPort1ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VirtualPort1ComboBox.FormattingEnabled = true;
            this.VirtualPort1ComboBox.Location = new System.Drawing.Point(18, 259);
            this.VirtualPort1ComboBox.Name = "VirtualPort1ComboBox";
            this.VirtualPort1ComboBox.Size = new System.Drawing.Size(121, 21);
            this.VirtualPort1ComboBox.TabIndex = 11;
            // 
            // VirtualPort2ComboBox
            // 
            this.VirtualPort2ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VirtualPort2ComboBox.FormattingEnabled = true;
            this.VirtualPort2ComboBox.Location = new System.Drawing.Point(18, 287);
            this.VirtualPort2ComboBox.Name = "VirtualPort2ComboBox";
            this.VirtualPort2ComboBox.Size = new System.Drawing.Size(121, 21);
            this.VirtualPort2ComboBox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 335);
            this.Controls.Add(this.VirtualPort2ComboBox);
            this.Controls.Add(this.VirtualPort1ComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddedPortsListBox);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.AvailablePortsListBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox AvailablePortsListBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.ListBox AddedPortsListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox VirtualPort1ComboBox;
        private System.Windows.Forms.ComboBox VirtualPort2ComboBox;
    }
}

