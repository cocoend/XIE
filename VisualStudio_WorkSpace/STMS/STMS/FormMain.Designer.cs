namespace STMS
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.skinTabControl1 = new CCWin.SkinControl.SkinTabControl();
            this.skinTabPage1 = new CCWin.SkinControl.SkinTabPage();
            this.UserSkinPanelBody = new CCWin.SkinControl.SkinPanel();
            this.skinDataGridViewPerson = new CCWin.SkinControl.SkinDataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.名前 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性別 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Father = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mother = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Enabled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonSexName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserSkinPanelDown = new CCWin.SkinControl.SkinPanel();
            this.skinTabPage2 = new CCWin.SkinControl.SkinTabPage();
            this.DataGridViewSubject = new CCWin.SkinControl.SkinDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.作成者 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.skinTabPage3 = new CCWin.SkinControl.SkinTabPage();
            this.skinTabPage4 = new CCWin.SkinControl.SkinTabPage();
            this.skinTabControl1.SuspendLayout();
            this.skinTabPage1.SuspendLayout();
            this.UserSkinPanelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinDataGridViewPerson)).BeginInit();
            this.skinTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // skinTabControl1
            // 
            this.skinTabControl1.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.skinTabControl1.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.skinTabControl1.Controls.Add(this.skinTabPage1);
            this.skinTabControl1.Controls.Add(this.skinTabPage2);
            this.skinTabControl1.Controls.Add(this.skinTabPage3);
            this.skinTabControl1.Controls.Add(this.skinTabPage4);
            this.skinTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabControl1.HeadBack = null;
            this.skinTabControl1.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.skinTabControl1.ItemSize = new System.Drawing.Size(70, 36);
            this.skinTabControl1.Location = new System.Drawing.Point(4, 28);
            this.skinTabControl1.Name = "skinTabControl1";
            this.skinTabControl1.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageArrowDown")));
            this.skinTabControl1.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageArrowHover")));
            this.skinTabControl1.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageCloseHover")));
            this.skinTabControl1.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageCloseNormal")));
            this.skinTabControl1.PageDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageDown")));
            this.skinTabControl1.PageHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageHover")));
            this.skinTabControl1.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.skinTabControl1.PageNorml = null;
            this.skinTabControl1.SelectedIndex = 1;
            this.skinTabControl1.Size = new System.Drawing.Size(792, 418);
            this.skinTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.skinTabControl1.TabIndex = 0;
            // 
            // skinTabPage1
            // 
            this.skinTabPage1.BackColor = System.Drawing.Color.White;
            this.skinTabPage1.Controls.Add(this.UserSkinPanelBody);
            this.skinTabPage1.Controls.Add(this.UserSkinPanelDown);
            this.skinTabPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage1.Location = new System.Drawing.Point(0, 36);
            this.skinTabPage1.Name = "skinTabPage1";
            this.skinTabPage1.Size = new System.Drawing.Size(792, 382);
            this.skinTabPage1.TabIndex = 0;
            this.skinTabPage1.TabItemImage = null;
            this.skinTabPage1.Text = "ユーザー";
            // 
            // UserSkinPanelBody
            // 
            this.UserSkinPanelBody.BackColor = System.Drawing.Color.Transparent;
            this.UserSkinPanelBody.Controls.Add(this.skinDataGridViewPerson);
            this.UserSkinPanelBody.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.UserSkinPanelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserSkinPanelBody.DownBack = null;
            this.UserSkinPanelBody.Location = new System.Drawing.Point(0, 0);
            this.UserSkinPanelBody.MouseBack = null;
            this.UserSkinPanelBody.Name = "UserSkinPanelBody";
            this.UserSkinPanelBody.NormlBack = null;
            this.UserSkinPanelBody.Size = new System.Drawing.Size(792, 307);
            this.UserSkinPanelBody.TabIndex = 3;
            // 
            // skinDataGridViewPerson
            // 
            this.skinDataGridViewPerson.AllowUserToAddRows = false;
            this.skinDataGridViewPerson.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.skinDataGridViewPerson.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.skinDataGridViewPerson.BackgroundColor = System.Drawing.SystemColors.Window;
            this.skinDataGridViewPerson.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.skinDataGridViewPerson.ColumnFont = null;
            this.skinDataGridViewPerson.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.skinDataGridViewPerson.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.skinDataGridViewPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skinDataGridViewPerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Password,
            this.名前,
            this.Birthday,
            this.性別,
            this.Telephone,
            this.Address,
            this.Father,
            this.Mother,
            this.RegDate,
            this.UserLevel,
            this.Enabled,
            this.CreateDate,
            this.UpdateTime,
            this.PersonSexName});
            this.skinDataGridViewPerson.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.skinDataGridViewPerson.DefaultCellStyle = dataGridViewCellStyle3;
            this.skinDataGridViewPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinDataGridViewPerson.EnableHeadersVisualStyles = false;
            this.skinDataGridViewPerson.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.skinDataGridViewPerson.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinDataGridViewPerson.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.skinDataGridViewPerson.Location = new System.Drawing.Point(0, 0);
            this.skinDataGridViewPerson.Name = "skinDataGridViewPerson";
            this.skinDataGridViewPerson.ReadOnly = true;
            this.skinDataGridViewPerson.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.skinDataGridViewPerson.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.skinDataGridViewPerson.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.skinDataGridViewPerson.RowTemplate.Height = 23;
            this.skinDataGridViewPerson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.skinDataGridViewPerson.Size = new System.Drawing.Size(792, 307);
            this.skinDataGridViewPerson.TabIndex = 0;
            this.skinDataGridViewPerson.TitleBack = null;
            this.skinDataGridViewPerson.TitleBackColorBegin = System.Drawing.Color.White;
            this.skinDataGridViewPerson.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            this.skinDataGridViewPerson.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.skinDataGridViewPerson_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Visible = false;
            // 
            // 名前
            // 
            this.名前.DataPropertyName = "Name";
            this.名前.HeaderText = "名前";
            this.名前.Name = "名前";
            this.名前.ReadOnly = true;
            // 
            // Birthday
            // 
            this.Birthday.DataPropertyName = "Birthday";
            this.Birthday.HeaderText = "誕生日";
            this.Birthday.Name = "Birthday";
            this.Birthday.ReadOnly = true;
            // 
            // 性別
            // 
            this.性別.DataPropertyName = "SexName";
            this.性別.HeaderText = "性別";
            this.性別.Name = "性別";
            this.性別.ReadOnly = true;
            // 
            // Telephone
            // 
            this.Telephone.DataPropertyName = "Telephone";
            this.Telephone.HeaderText = "携帯電話";
            this.Telephone.Name = "Telephone";
            this.Telephone.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "住所";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Father
            // 
            this.Father.DataPropertyName = "Father";
            this.Father.HeaderText = "父親名";
            this.Father.Name = "Father";
            this.Father.ReadOnly = true;
            // 
            // Mother
            // 
            this.Mother.DataPropertyName = "Mother";
            this.Mother.HeaderText = "母親名";
            this.Mother.Name = "Mother";
            this.Mother.ReadOnly = true;
            // 
            // RegDate
            // 
            this.RegDate.DataPropertyName = "RegDate";
            this.RegDate.HeaderText = "作成時間";
            this.RegDate.Name = "RegDate";
            this.RegDate.ReadOnly = true;
            // 
            // UserLevel
            // 
            this.UserLevel.DataPropertyName = "UserLevel";
            this.UserLevel.HeaderText = "ユーザーレベル";
            this.UserLevel.Name = "UserLevel";
            this.UserLevel.ReadOnly = true;
            // 
            // Enabled
            // 
            this.Enabled.DataPropertyName = "Enabled";
            this.Enabled.HeaderText = "有効化";
            this.Enabled.Name = "Enabled";
            this.Enabled.ReadOnly = true;
            // 
            // CreateDate
            // 
            this.CreateDate.DataPropertyName = "CreateDate";
            this.CreateDate.HeaderText = "CreateDate";
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.ReadOnly = true;
            // 
            // UpdateTime
            // 
            this.UpdateTime.DataPropertyName = "UpdateTime";
            this.UpdateTime.HeaderText = "UpdateTime";
            this.UpdateTime.Name = "UpdateTime";
            this.UpdateTime.ReadOnly = true;
            // 
            // PersonSexName
            // 
            this.PersonSexName.HeaderText = "Sex";
            this.PersonSexName.Name = "PersonSexName";
            this.PersonSexName.ReadOnly = true;
            this.PersonSexName.Visible = false;
            // 
            // UserSkinPanelDown
            // 
            this.UserSkinPanelDown.BackColor = System.Drawing.Color.Transparent;
            this.UserSkinPanelDown.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.UserSkinPanelDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UserSkinPanelDown.DownBack = null;
            this.UserSkinPanelDown.Location = new System.Drawing.Point(0, 307);
            this.UserSkinPanelDown.MouseBack = null;
            this.UserSkinPanelDown.Name = "UserSkinPanelDown";
            this.UserSkinPanelDown.NormlBack = null;
            this.UserSkinPanelDown.Size = new System.Drawing.Size(792, 75);
            this.UserSkinPanelDown.TabIndex = 2;
            // 
            // skinTabPage2
            // 
            this.skinTabPage2.BackColor = System.Drawing.Color.White;
            this.skinTabPage2.Controls.Add(this.DataGridViewSubject);
            this.skinTabPage2.Controls.Add(this.skinPanel1);
            this.skinTabPage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage2.Location = new System.Drawing.Point(0, 36);
            this.skinTabPage2.Name = "skinTabPage2";
            this.skinTabPage2.Size = new System.Drawing.Size(792, 382);
            this.skinTabPage2.TabIndex = 1;
            this.skinTabPage2.TabItemImage = null;
            this.skinTabPage2.Text = "科目";
            // 
            // DataGridViewSubject
            // 
            this.DataGridViewSubject.AllowUserToAddRows = false;
            this.DataGridViewSubject.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.DataGridViewSubject.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewSubject.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DataGridViewSubject.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridViewSubject.ColumnFont = null;
            this.DataGridViewSubject.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewSubject.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewSubject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.作成者});
            this.DataGridViewSubject.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewSubject.DefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridViewSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewSubject.EnableHeadersVisualStyles = false;
            this.DataGridViewSubject.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DataGridViewSubject.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DataGridViewSubject.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.DataGridViewSubject.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewSubject.Name = "DataGridViewSubject";
            this.DataGridViewSubject.ReadOnly = true;
            this.DataGridViewSubject.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewSubject.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DataGridViewSubject.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridViewSubject.RowTemplate.Height = 23;
            this.DataGridViewSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewSubject.Size = new System.Drawing.Size(792, 307);
            this.DataGridViewSubject.TabIndex = 4;
            this.DataGridViewSubject.TitleBack = null;
            this.DataGridViewSubject.TitleBackColorBegin = System.Drawing.Color.White;
            this.DataGridViewSubject.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "科目名称";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "CreateDate";
            this.dataGridViewTextBoxColumn13.HeaderText = "CreateDate";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "UpdateTime";
            this.dataGridViewTextBoxColumn14.HeaderText = "UpdateTime";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // 作成者
            // 
            this.作成者.HeaderText = "作成者";
            this.作成者.Name = "作成者";
            this.作成者.ReadOnly = true;
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(0, 307);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(792, 75);
            this.skinPanel1.TabIndex = 3;
            // 
            // skinTabPage3
            // 
            this.skinTabPage3.BackColor = System.Drawing.Color.White;
            this.skinTabPage3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage3.Location = new System.Drawing.Point(0, 36);
            this.skinTabPage3.Name = "skinTabPage3";
            this.skinTabPage3.Size = new System.Drawing.Size(792, 382);
            this.skinTabPage3.TabIndex = 2;
            this.skinTabPage3.TabItemImage = null;
            this.skinTabPage3.Text = "成績";
            // 
            // skinTabPage4
            // 
            this.skinTabPage4.BackColor = System.Drawing.Color.White;
            this.skinTabPage4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage4.Location = new System.Drawing.Point(0, 36);
            this.skinTabPage4.Name = "skinTabPage4";
            this.skinTabPage4.Size = new System.Drawing.Size(792, 382);
            this.skinTabPage4.TabIndex = 3;
            this.skinTabPage4.TabItemImage = null;
            this.skinTabPage4.Text = "点数";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.skinTabControl1);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.skinTabControl1.ResumeLayout(false);
            this.skinTabPage1.ResumeLayout(false);
            this.UserSkinPanelBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skinDataGridViewPerson)).EndInit();
            this.skinTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSubject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinTabControl skinTabControl1;
        private CCWin.SkinControl.SkinTabPage skinTabPage1;
        private CCWin.SkinControl.SkinTabPage skinTabPage2;
        private CCWin.SkinControl.SkinTabPage skinTabPage3;
        private CCWin.SkinControl.SkinTabPage skinTabPage4;
        private CCWin.SkinControl.SkinPanel UserSkinPanelBody;
        private CCWin.SkinControl.SkinPanel UserSkinPanelDown;
        private CCWin.SkinControl.SkinDataGridView skinDataGridViewPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名前;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性別;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Father;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mother;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Enabled;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonSexName;
        private CCWin.SkinControl.SkinDataGridView DataGridViewSubject;
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn 作成者;
    }
}