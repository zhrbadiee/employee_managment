
namespace PROJECT
{
    partial class frmlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btn_exit = new DevComponents.DotNetBar.ButtonX();
            this.btn_log = new DevComponents.DotNetBar.ButtonX();
            this.txt_pass = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txt_uname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.groupPanel1.Controls.Add(this.btn_exit);
            this.groupPanel1.Controls.Add(this.btn_log);
            this.groupPanel1.Controls.Add(this.txt_pass);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.pictureBox1);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.txt_uname);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(519, 261);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 0;
            // 
            // btn_exit
            // 
            this.btn_exit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_exit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_exit.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_exit.Location = new System.Drawing.Point(263, 183);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btn_exit.Size = new System.Drawing.Size(80, 35);
            this.btn_exit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "خروج";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_log
            // 
            this.btn_log.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_log.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_log.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_log.Location = new System.Drawing.Point(360, 183);
            this.btn_log.Name = "btn_log";
            this.btn_log.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btn_log.Size = new System.Drawing.Size(80, 35);
            this.btn_log.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btn_log.TabIndex = 2;
            this.btn_log.Text = "ورود به نرم افزار";
            this.btn_log.Click += new System.EventHandler(this.btn_log_Click);
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_pass.Border.Class = "TextBoxBorder";
            this.txt_pass.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_pass.DisabledBackColor = System.Drawing.Color.White;
            this.txt_pass.ForeColor = System.Drawing.Color.Black;
            this.txt_pass.Location = new System.Drawing.Point(268, 121);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.PreventEnterBeep = true;
            this.txt_pass.Size = new System.Drawing.Size(146, 20);
            this.txt_pass.TabIndex = 1;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Mj_Bassam", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX3.Location = new System.Drawing.Point(433, 117);
            this.labelX3.Name = "labelX3";
            this.labelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX3.Size = new System.Drawing.Size(35, 23);
            this.labelX3.TabIndex = 3;
            this.labelX3.Text = "رمزعبور";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Mj_Bassam", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX2.Location = new System.Drawing.Point(419, 75);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(49, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "نام کاربری";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Mj_Bassam", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX1.ForeColor = System.Drawing.Color.Navy;
            this.labelX1.Location = new System.Drawing.Point(154, 9);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(226, 40);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "ورود به سیستم مدیریت کارمندان";
            // 
            // txt_uname
            // 
            this.txt_uname.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_uname.Border.Class = "TextBoxBorder";
            this.txt_uname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_uname.DisabledBackColor = System.Drawing.Color.White;
            this.txt_uname.ForeColor = System.Drawing.Color.Black;
            this.txt_uname.Location = new System.Drawing.Point(268, 79);
            this.txt_uname.Name = "txt_uname";
            this.txt_uname.PreventEnterBeep = true;
            this.txt_uname.Size = new System.Drawing.Size(146, 20);
            this.txt_uname.TabIndex = 0;
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 261);
            this.Controls.Add(this.groupPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX btn_exit;
        private DevComponents.DotNetBar.ButtonX btn_log;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_pass;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_uname;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}