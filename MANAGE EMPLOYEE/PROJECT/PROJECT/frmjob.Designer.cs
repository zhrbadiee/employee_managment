
namespace PROJECT
{
    partial class frmjob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmjob));
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btn_search = new DevComponents.DotNetBar.ButtonX();
            this.txt_description = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_salary = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_namejob = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_idjob = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.btn_back = new DevComponents.DotNetBar.ButtonX();
            this.btn_delete = new DevComponents.DotNetBar.ButtonX();
            this.btn_save = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1.SuspendLayout();
            this.groupPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btn_search);
            this.groupPanel1.Controls.Add(this.txt_description);
            this.groupPanel1.Controls.Add(this.txt_salary);
            this.groupPanel1.Controls.Add(this.txt_namejob);
            this.groupPanel1.Controls.Add(this.txt_idjob);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.groupPanel3);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(498, 255);
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
            // btn_search
            // 
            this.btn_search.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_search.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_search.Location = new System.Drawing.Point(225, 19);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(28, 27);
            this.btn_search.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "+";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_description
            // 
            this.txt_description.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_description.Border.Class = "TextBoxBorder";
            this.txt_description.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_description.DisabledBackColor = System.Drawing.Color.White;
            this.txt_description.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_description.ForeColor = System.Drawing.Color.Black;
            this.txt_description.Location = new System.Drawing.Point(22, 142);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.PreventEnterBeep = true;
            this.txt_description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_description.Size = new System.Drawing.Size(358, 47);
            this.txt_description.TabIndex = 4;
            // 
            // txt_salary
            // 
            this.txt_salary.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_salary.Border.Class = "TextBoxBorder";
            this.txt_salary.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_salary.DisabledBackColor = System.Drawing.Color.White;
            this.txt_salary.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_salary.ForeColor = System.Drawing.Color.Black;
            this.txt_salary.Location = new System.Drawing.Point(259, 102);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.PreventEnterBeep = true;
            this.txt_salary.Size = new System.Drawing.Size(121, 27);
            this.txt_salary.TabIndex = 3;
            // 
            // txt_namejob
            // 
            this.txt_namejob.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_namejob.Border.Class = "TextBoxBorder";
            this.txt_namejob.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_namejob.DisabledBackColor = System.Drawing.Color.White;
            this.txt_namejob.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_namejob.ForeColor = System.Drawing.Color.Black;
            this.txt_namejob.Location = new System.Drawing.Point(174, 60);
            this.txt_namejob.Name = "txt_namejob";
            this.txt_namejob.PreventEnterBeep = true;
            this.txt_namejob.Size = new System.Drawing.Size(206, 27);
            this.txt_namejob.TabIndex = 2;
            // 
            // txt_idjob
            // 
            this.txt_idjob.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_idjob.Border.Class = "TextBoxBorder";
            this.txt_idjob.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_idjob.DisabledBackColor = System.Drawing.Color.White;
            this.txt_idjob.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_idjob.ForeColor = System.Drawing.Color.Black;
            this.txt_idjob.Location = new System.Drawing.Point(259, 19);
            this.txt_idjob.Name = "txt_idjob";
            this.txt_idjob.PreventEnterBeep = true;
            this.txt_idjob.Size = new System.Drawing.Size(121, 27);
            this.txt_idjob.TabIndex = 0;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX4.ForeColor = System.Drawing.Color.Navy;
            this.labelX4.Location = new System.Drawing.Point(386, 137);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 6;
            this.labelX4.Text = "توضیحات";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX3.ForeColor = System.Drawing.Color.Navy;
            this.labelX3.Location = new System.Drawing.Point(386, 102);
            this.labelX3.Name = "labelX3";
            this.labelX3.SingleLineColor = System.Drawing.Color.Navy;
            this.labelX3.Size = new System.Drawing.Size(75, 24);
            this.labelX3.TabIndex = 5;
            this.labelX3.Text = "حقوق";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX2.ForeColor = System.Drawing.Color.Navy;
            this.labelX2.Location = new System.Drawing.Point(386, 59);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 24);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "نام شغل";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX1.ForeColor = System.Drawing.Color.Navy;
            this.labelX1.Location = new System.Drawing.Point(386, 19);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "کدشغل";
            // 
            // groupPanel3
            // 
            this.groupPanel3.BackColor = System.Drawing.Color.White;
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.buttonX1);
            this.groupPanel3.Controls.Add(this.btn_back);
            this.groupPanel3.Controls.Add(this.btn_delete);
            this.groupPanel3.Controls.Add(this.btn_save);
            this.groupPanel3.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel3.Location = new System.Drawing.Point(-3, 202);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(498, 50);
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel3.TabIndex = 2;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonX1.Image = ((System.Drawing.Image)(resources.GetObject("buttonX1.Image")));
            this.buttonX1.Location = new System.Drawing.Point(174, 3);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(98, 38);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 2;
            this.buttonX1.Text = "ویرایش";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // btn_back
            // 
            this.btn_back.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_back.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_back.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_back.Image")));
            this.btn_back.Location = new System.Drawing.Point(3, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(101, 38);
            this.btn_back.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "بازگشت";
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_delete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_delete.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.Location = new System.Drawing.Point(278, 3);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(102, 38);
            this.btn_delete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "حذف";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_save.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.Location = new System.Drawing.Point(386, 3);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(98, 38);
            this.btn_save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "ذخیره";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // frmjob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 255);
            this.ControlBox = false;
            this.Controls.Add(this.groupPanel1);
            this.Font = new System.Drawing.Font("Mj_Baseet", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmjob";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعریف مشاغل";
            this.Load += new System.EventHandler(this.frmjob_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_description;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_salary;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_namejob;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_idjob;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX btn_back;
        private DevComponents.DotNetBar.ButtonX btn_delete;
        private DevComponents.DotNetBar.ButtonX btn_save;
        private DevComponents.DotNetBar.ButtonX btn_search;
    }
}