
namespace PROJECT
{
    partial class frmuser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmuser));
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgv_user = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btn_back = new DevComponents.DotNetBar.ButtonX();
            this.btn_delete = new DevComponents.DotNetBar.ButtonX();
            this.btn_save = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txt_pass = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_uname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_search_idemp = new DevComponents.DotNetBar.ButtonX();
            this.btn_edit = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).BeginInit();
            this.groupPanel3.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.dgv_user);
            this.groupPanel1.Controls.Add(this.groupPanel3);
            this.groupPanel1.Controls.Add(this.groupPanel2);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(444, 366);
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
            // dgv_user
            // 
            this.dgv_user.BackgroundColor = System.Drawing.Color.White;
            this.dgv_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_user.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_user.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv_user.Location = new System.Drawing.Point(3, 185);
            this.dgv_user.Name = "dgv_user";
            this.dgv_user.Size = new System.Drawing.Size(432, 174);
            this.dgv_user.TabIndex = 0;
            // 
            // groupPanel3
            // 
            this.groupPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.btn_edit);
            this.groupPanel3.Controls.Add(this.btn_back);
            this.groupPanel3.Controls.Add(this.btn_delete);
            this.groupPanel3.Controls.Add(this.btn_save);
            this.groupPanel3.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel3.Location = new System.Drawing.Point(3, 129);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(432, 50);
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
            this.groupPanel3.TabIndex = 1;
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
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "بازگشت";
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_delete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_delete.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.Location = new System.Drawing.Point(215, 3);
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
            this.btn_save.Location = new System.Drawing.Point(323, 3);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(98, 38);
            this.btn_save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "ذخیره";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // groupPanel2
            // 
            this.groupPanel2.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.btn_search_idemp);
            this.groupPanel2.Controls.Add(this.labelX3);
            this.groupPanel2.Controls.Add(this.labelX2);
            this.groupPanel2.Controls.Add(this.txt_pass);
            this.groupPanel2.Controls.Add(this.txt_uname);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(3, 3);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(432, 120);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 0;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX3.Location = new System.Drawing.Point(287, 59);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(52, 23);
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "رمز عبور";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX2.Location = new System.Drawing.Point(270, 26);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(69, 23);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "نام کاربری";
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
            this.txt_pass.Location = new System.Drawing.Point(124, 59);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PreventEnterBeep = true;
            this.txt_pass.Size = new System.Drawing.Size(140, 20);
            this.txt_pass.TabIndex = 1;
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
            this.txt_uname.Location = new System.Drawing.Point(124, 28);
            this.txt_uname.Name = "txt_uname";
            this.txt_uname.PreventEnterBeep = true;
            this.txt_uname.Size = new System.Drawing.Size(140, 20);
            this.txt_uname.TabIndex = 0;
            // 
            // btn_search_idemp
            // 
            this.btn_search_idemp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_search_idemp.BackColor = System.Drawing.Color.Transparent;
            this.btn_search_idemp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_search_idemp.Location = new System.Drawing.Point(92, 26);
            this.btn_search_idemp.Name = "btn_search_idemp";
            this.btn_search_idemp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_search_idemp.Size = new System.Drawing.Size(26, 22);
            this.btn_search_idemp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_search_idemp.TabIndex = 112;
            this.btn_search_idemp.Text = "؟";
            this.btn_search_idemp.Click += new System.EventHandler(this.btn_search_idemp_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_edit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_edit.Font = new System.Drawing.Font("A  Mitra_5 (MRT)", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.Image")));
            this.btn_edit.Location = new System.Drawing.Point(110, 3);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(98, 38);
            this.btn_edit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_edit.TabIndex = 3;
            this.btn_edit.Text = "ویرایش";
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // frmuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 366);
            this.ControlBox = false;
            this.Controls.Add(this.groupPanel1);
            this.Name = "frmuser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعریف کاربران";
            this.Load += new System.EventHandler(this.frmuser_Load);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).EndInit();
            this.groupPanel3.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_user;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_pass;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_uname;
        private DevComponents.DotNetBar.ButtonX btn_back;
        private DevComponents.DotNetBar.ButtonX btn_delete;
        private DevComponents.DotNetBar.ButtonX btn_save;
        private DevComponents.DotNetBar.ButtonX btn_search_idemp;
        private DevComponents.DotNetBar.ButtonX btn_edit;
    }
}