
using System.Windows.Forms;

namespace MasterHelper
{
    partial class FormMain
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


        protected override Padding DefaultPadding
        {
            get { return new Padding(0); }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.buttonActivity = new Guna.UI2.WinForms.Guna2Button();
            this.buttonService = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxSlide = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2Button3);
            this.panel1.Controls.Add(this.guna2Button4);
            this.panel1.Controls.Add(this.buttonActivity);
            this.panel1.Controls.Add(this.buttonService);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBoxSlide);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20, 16, 0, 0);
            this.panel1.Size = new System.Drawing.Size(173, 673);
            this.panel1.TabIndex = 0;
            // 
            // guna2Button3
            // 
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderRadius = 20;
            this.guna2Button3.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button3.CheckedState.FillColor = System.Drawing.SystemColors.Control;
            this.guna2Button3.CheckedState.ForeColor = System.Drawing.Color.DarkRed;
            this.guna2Button3.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.DisabledState.Parent = this.guna2Button3;
            this.guna2Button3.FillColor = System.Drawing.Color.DarkRed;
            this.guna2Button3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button3.Image")));
            this.guna2Button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button3.ImageOffset = new System.Drawing.Point(10, 0);
            this.guna2Button3.Location = new System.Drawing.Point(20, 323);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(151, 40);
            this.guna2Button3.TabIndex = 7;
            this.guna2Button3.Text = "Thông báo";
            this.guna2Button3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button3.UseTransparentBackground = true;
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button4.BorderRadius = 20;
            this.guna2Button4.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button4.CheckedState.FillColor = System.Drawing.SystemColors.Control;
            this.guna2Button4.CheckedState.ForeColor = System.Drawing.Color.DarkRed;
            this.guna2Button4.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.guna2Button4.CheckedState.Parent = this.guna2Button4;
            this.guna2Button4.CustomImages.Parent = this.guna2Button4;
            this.guna2Button4.DisabledState.Parent = this.guna2Button4;
            this.guna2Button4.FillColor = System.Drawing.Color.DarkRed;
            this.guna2Button4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.Parent = this.guna2Button4;
            this.guna2Button4.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button4.Image")));
            this.guna2Button4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button4.ImageOffset = new System.Drawing.Point(10, 0);
            this.guna2Button4.Location = new System.Drawing.Point(20, 413);
            this.guna2Button4.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.Size = new System.Drawing.Size(151, 40);
            this.guna2Button4.TabIndex = 5;
            this.guna2Button4.Text = "Tài khoản";
            this.guna2Button4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button4.UseTransparentBackground = true;
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // buttonActivity
            // 
            this.buttonActivity.BackColor = System.Drawing.Color.Transparent;
            this.buttonActivity.BorderRadius = 20;
            this.buttonActivity.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.buttonActivity.CheckedState.FillColor = System.Drawing.SystemColors.Control;
            this.buttonActivity.CheckedState.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonActivity.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.buttonActivity.CheckedState.Parent = this.buttonActivity;
            this.buttonActivity.CustomImages.Parent = this.buttonActivity;
            this.buttonActivity.DisabledState.Parent = this.buttonActivity;
            this.buttonActivity.FillColor = System.Drawing.Color.DarkRed;
            this.buttonActivity.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.buttonActivity.ForeColor = System.Drawing.Color.White;
            this.buttonActivity.HoverState.Parent = this.buttonActivity;
            this.buttonActivity.Image = ((System.Drawing.Image)(resources.GetObject("buttonActivity.Image")));
            this.buttonActivity.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonActivity.ImageOffset = new System.Drawing.Point(10, 0);
            this.buttonActivity.Location = new System.Drawing.Point(20, 232);
            this.buttonActivity.Margin = new System.Windows.Forms.Padding(2);
            this.buttonActivity.Name = "buttonActivity";
            this.buttonActivity.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonActivity.ShadowDecoration.Parent = this.buttonActivity;
            this.buttonActivity.Size = new System.Drawing.Size(151, 40);
            this.buttonActivity.TabIndex = 5;
            this.buttonActivity.Text = "Công việc";
            this.buttonActivity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonActivity.UseTransparentBackground = true;
            this.buttonActivity.Click += new System.EventHandler(this.buttonActivity_Click);
            // 
            // buttonService
            // 
            this.buttonService.BackColor = System.Drawing.Color.Transparent;
            this.buttonService.BorderRadius = 20;
            this.buttonService.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.buttonService.Checked = true;
            this.buttonService.CheckedState.FillColor = System.Drawing.SystemColors.Control;
            this.buttonService.CheckedState.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonService.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.buttonService.CheckedState.Parent = this.buttonService;
            this.buttonService.CustomImages.Parent = this.buttonService;
            this.buttonService.DisabledState.Parent = this.buttonService;
            this.buttonService.FillColor = System.Drawing.Color.DarkRed;
            this.buttonService.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonService.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonService.HoverState.Parent = this.buttonService;
            this.buttonService.Image = ((System.Drawing.Image)(resources.GetObject("buttonService.Image")));
            this.buttonService.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.buttonService.ImageOffset = new System.Drawing.Point(10, 0);
            this.buttonService.Location = new System.Drawing.Point(20, 140);
            this.buttonService.Margin = new System.Windows.Forms.Padding(2);
            this.buttonService.Name = "buttonService";
            this.buttonService.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.buttonService.ShadowDecoration.Parent = this.buttonService;
            this.buttonService.Size = new System.Drawing.Size(151, 40);
            this.buttonService.TabIndex = 3;
            this.buttonService.Text = "Dịch vụ";
            this.buttonService.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonService.UseTransparentBackground = true;
            this.buttonService.Click += new System.EventHandler(this.buttonService_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Helaster";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(53, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 41);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxSlide
            // 
            this.pictureBoxSlide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxSlide.BackgroundImage")));
            this.pictureBoxSlide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSlide.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxSlide.ErrorImage")));
            this.pictureBoxSlide.InitialImage = null;
            this.pictureBoxSlide.Location = new System.Drawing.Point(99, 113);
            this.pictureBoxSlide.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxSlide.Name = "pictureBoxSlide";
            this.pictureBoxSlide.Size = new System.Drawing.Size(75, 91);
            this.pictureBoxSlide.TabIndex = 4;
            this.pictureBoxSlide.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(173, 60);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Padding = new System.Windows.Forms.Padding(0, 8, 8, 8);
            this.panelChildForm.Size = new System.Drawing.Size(827, 613);
            this.panelChildForm.TabIndex = 3;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(628, 19);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(35, 35);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox1.BackColor = System.Drawing.Color.DarkRed;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 36;
            this.iconPictureBox1.Location = new System.Drawing.Point(779, 23);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(36, 36);
            this.iconPictureBox1.TabIndex = 2;
            this.iconPictureBox1.TabStop = false;
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.guna2CirclePictureBox1);
            this.panelTitle.Controls.Add(this.label2);
            this.panelTitle.Controls.Add(this.iconPictureBox1);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(173, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(827, 60);
            this.panelTitle.TabIndex = 2;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(669, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nguyễn Long";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1000, 673);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBoxSlide;
        private Guna.UI2.WinForms.Guna2Button buttonService;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button buttonActivity;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Panel panelChildForm;
        private Panel panelTitle;
        private Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
    }
}