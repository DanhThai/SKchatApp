﻿
namespace PBL41
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureAvt = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panelMes = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGrvMess = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LViewMessage = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.butSend = new CustomButton.VBButton();
            this.butVideo = new CustomButton.VBButton();
            this.vbButton2 = new CustomButton.VBButton();
            this.vbButton1 = new CustomButton.VBButton();
            this.butFriend = new CustomButton.VBButton();
            this.butSet = new CustomButton.VBButton();
            this.butMess = new CustomButton.VBButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvt)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelMes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrvMess)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.panel1.Controls.Add(this.pictureAvt);
            this.panel1.Controls.Add(this.butFriend);
            this.panel1.Controls.Add(this.butSet);
            this.panel1.Controls.Add(this.butMess);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(126, 615);
            this.panel1.TabIndex = 0;
            // 
            // pictureAvt
            // 
            this.pictureAvt.BackgroundImage = global::PBL41.Properties.Resources.Uchiha_Sasuke1;
            this.pictureAvt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureAvt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureAvt.Location = new System.Drawing.Point(1, 0);
            this.pictureAvt.Margin = new System.Windows.Forms.Padding(0);
            this.pictureAvt.Name = "pictureAvt";
            this.pictureAvt.Size = new System.Drawing.Size(127, 106);
            this.pictureAvt.TabIndex = 7;
            this.pictureAvt.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.vbButton1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.panelMes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(126, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 615);
            this.panel2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(69, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 2);
            this.label5.TabIndex = 15;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(69, 14);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(221, 33);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.Text = "Search";
            // 
            // panelMes
            // 
            this.panelMes.BackColor = System.Drawing.SystemColors.GrayText;
            this.panelMes.Controls.Add(this.label2);
            this.panelMes.Controls.Add(this.label4);
            this.panelMes.Controls.Add(this.dataGrvMess);
            this.panelMes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMes.Location = new System.Drawing.Point(0, 68);
            this.panelMes.Name = "panelMes";
            this.panelMes.Size = new System.Drawing.Size(293, 547);
            this.panelMes.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GrayText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(70, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "List Friend";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(-3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(296, 3);
            this.label4.TabIndex = 16;
            // 
            // dataGrvMess
            // 
            this.dataGrvMess.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dataGrvMess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrvMess.Location = new System.Drawing.Point(0, 58);
            this.dataGrvMess.Name = "dataGrvMess";
            this.dataGrvMess.RowHeadersWidth = 51;
            this.dataGrvMess.RowTemplate.Height = 24;
            this.dataGrvMess.Size = new System.Drawing.Size(290, 486);
            this.dataGrvMess.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.panel3.Controls.Add(this.LViewMessage);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.butSend);
            this.panel3.Controls.Add(this.butVideo);
            this.panel3.Controls.Add(this.txtMessage);
            this.panel3.Controls.Add(this.vbButton2);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(524, 615);
            this.panel3.TabIndex = 2;
            // 
            // LViewMessage
            // 
            this.LViewMessage.BackColor = System.Drawing.Color.White;
            this.LViewMessage.Location = new System.Drawing.Point(-2, 68);
            this.LViewMessage.Name = "LViewMessage";
            this.LViewMessage.Size = new System.Drawing.Size(526, 487);
            this.LViewMessage.TabIndex = 2;
            this.LViewMessage.UseCompatibleStateImageBehavior = false;
            this.LViewMessage.View = System.Windows.Forms.View.List;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(187, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(0, 556);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(458, 59);
            this.txtMessage.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(419, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(524, 615);
            this.panel4.TabIndex = 2;
            // 
            // butSend
            // 
            this.butSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.butSend.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.butSend.BackgroundImage = global::PBL41.Properties.Resources.plane;
            this.butSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butSend.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.butSend.BorderRadius = 20;
            this.butSend.BorderSize = 0;
            this.butSend.FlatAppearance.BorderSize = 0;
            this.butSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSend.ForeColor = System.Drawing.Color.Wheat;
            this.butSend.Location = new System.Drawing.Point(458, 556);
            this.butSend.Name = "butSend";
            this.butSend.Size = new System.Drawing.Size(67, 55);
            this.butSend.TabIndex = 5;
            this.butSend.TextColor = System.Drawing.Color.Wheat;
            this.butSend.UseVisualStyleBackColor = false;
            this.butSend.Click += new System.EventHandler(this.butSend_Click);
            // 
            // butVideo
            // 
            this.butVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.butVideo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.butVideo.BackgroundImage = global::PBL41.Properties.Resources.video;
            this.butVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butVideo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.butVideo.BorderRadius = 20;
            this.butVideo.BorderSize = 0;
            this.butVideo.FlatAppearance.BorderSize = 0;
            this.butVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butVideo.ForeColor = System.Drawing.Color.White;
            this.butVideo.Location = new System.Drawing.Point(449, 12);
            this.butVideo.Name = "butVideo";
            this.butVideo.Size = new System.Drawing.Size(63, 50);
            this.butVideo.TabIndex = 4;
            this.butVideo.TextColor = System.Drawing.Color.White;
            this.butVideo.UseVisualStyleBackColor = false;
            // 
            // vbButton2
            // 
            this.vbButton2.BackColor = System.Drawing.Color.White;
            this.vbButton2.BackgroundColor = System.Drawing.Color.White;
            this.vbButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButton2.BorderRadius = 10;
            this.vbButton2.BorderSize = 0;
            this.vbButton2.FlatAppearance.BorderSize = 0;
            this.vbButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton2.ForeColor = System.Drawing.Color.White;
            this.vbButton2.Location = new System.Drawing.Point(616, 611);
            this.vbButton2.Name = "vbButton2";
            this.vbButton2.Size = new System.Drawing.Size(95, 77);
            this.vbButton2.TabIndex = 0;
            this.vbButton2.TextColor = System.Drawing.Color.White;
            this.vbButton2.UseVisualStyleBackColor = false;
            // 
            // vbButton1
            // 
            this.vbButton1.BackColor = System.Drawing.Color.White;
            this.vbButton1.BackgroundColor = System.Drawing.Color.White;
            this.vbButton1.BackgroundImage = global::PBL41.Properties.Resources.searchh;
            this.vbButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.vbButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButton1.BorderRadius = 20;
            this.vbButton1.BorderSize = 0;
            this.vbButton1.FlatAppearance.BorderSize = 0;
            this.vbButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton1.ForeColor = System.Drawing.Color.White;
            this.vbButton1.Location = new System.Drawing.Point(18, 13);
            this.vbButton1.Name = "vbButton1";
            this.vbButton1.Size = new System.Drawing.Size(45, 44);
            this.vbButton1.TabIndex = 17;
            this.vbButton1.TextColor = System.Drawing.Color.White;
            this.vbButton1.UseVisualStyleBackColor = false;
            // 
            // butFriend
            // 
            this.butFriend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.butFriend.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.butFriend.BackgroundImage = global::PBL41.Properties.Resources.teamuser;
            this.butFriend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butFriend.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.butFriend.BorderRadius = 20;
            this.butFriend.BorderSize = 0;
            this.butFriend.FlatAppearance.BorderSize = 0;
            this.butFriend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butFriend.ForeColor = System.Drawing.Color.White;
            this.butFriend.Location = new System.Drawing.Point(30, 255);
            this.butFriend.Name = "butFriend";
            this.butFriend.Size = new System.Drawing.Size(51, 52);
            this.butFriend.TabIndex = 6;
            this.butFriend.TextColor = System.Drawing.Color.White;
            this.butFriend.UseVisualStyleBackColor = false;
            this.butFriend.Click += new System.EventHandler(this.butFriend_Click);
            // 
            // butSet
            // 
            this.butSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.butSet.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.butSet.BackgroundImage = global::PBL41.Properties.Resources.setting;
            this.butSet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butSet.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.butSet.BorderRadius = 15;
            this.butSet.BorderSize = 0;
            this.butSet.FlatAppearance.BorderSize = 0;
            this.butSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSet.ForeColor = System.Drawing.Color.Black;
            this.butSet.Location = new System.Drawing.Point(30, 372);
            this.butSet.Name = "butSet";
            this.butSet.Size = new System.Drawing.Size(51, 53);
            this.butSet.TabIndex = 5;
            this.butSet.TextColor = System.Drawing.Color.Black;
            this.butSet.UseVisualStyleBackColor = false;
            this.butSet.Click += new System.EventHandler(this.butSet_Click);
            // 
            // butMess
            // 
            this.butMess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.butMess.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.butMess.BackgroundImage = global::PBL41.Properties.Resources.mes1;
            this.butMess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butMess.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.butMess.BorderRadius = 10;
            this.butMess.BorderSize = 0;
            this.butMess.FlatAppearance.BorderSize = 0;
            this.butMess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butMess.ForeColor = System.Drawing.Color.Transparent;
            this.butMess.Location = new System.Drawing.Point(30, 148);
            this.butMess.Name = "butMess";
            this.butMess.Size = new System.Drawing.Size(51, 57);
            this.butMess.TabIndex = 3;
            this.butMess.TextColor = System.Drawing.Color.Transparent;
            this.butMess.UseVisualStyleBackColor = false;
            this.butMess.Click += new System.EventHandler(this.butMess_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 615);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvt)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelMes.ResumeLayout(false);
            this.panelMes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrvMess)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private CustomButton.VBButton butMess;
        private CustomButton.VBButton butSet;
        private CustomButton.VBButton butFriend;
        private System.Windows.Forms.Panel panelMes;
        private System.Windows.Forms.DataGridView dataGrvMess;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.ListView LViewMessage;
        private CustomButton.VBButton vbButton2;
        private CustomButton.VBButton butVideo;
        private CustomButton.VBButton butSend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureAvt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private CustomButton.VBButton vbButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label4;
    }
}