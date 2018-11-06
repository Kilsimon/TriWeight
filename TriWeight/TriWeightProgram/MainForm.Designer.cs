using System;

namespace Wishlist
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
            this.txtEventLocation = new System.Windows.Forms.TextBox();
            this.tabPageBackUp = new System.Windows.Forms.TabPage();
            this.dateTimePickerBackUp = new System.Windows.Forms.DateTimePicker();
            this.tabPageData = new System.Windows.Forms.TabPage();
            this.buttonSearchData = new System.Windows.Forms.Button();
            this.textBoxDataSearch = new System.Windows.Forms.TextBox();
            this.labelDataSearch = new System.Windows.Forms.Label();
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.textBoxDataCompanyId = new System.Windows.Forms.TextBox();
            this.textDataTrivetId = new System.Windows.Forms.TextBox();
            this.labelDataCompanyId = new System.Windows.Forms.Label();
            this.labeDataTrivetID = new System.Windows.Forms.Label();
            this.labelDataId = new System.Windows.Forms.Label();
            this.btnDataSave = new System.Windows.Forms.Button();
            this.btnNewData = new System.Windows.Forms.Button();
            this.txtDataState = new System.Windows.Forms.TextBox();
            this.txtDataWeight = new System.Windows.Forms.TextBox();
            this.txtDataTime = new System.Windows.Forms.TextBox();
            this.txtDataId = new System.Windows.Forms.TextBox();
            this.labelDataState = new System.Windows.Forms.Label();
            this.labelDataWeight = new System.Windows.Forms.Label();
            this.labelDataTime = new System.Windows.Forms.Label();
            this.twDataItems = new System.Windows.Forms.TreeView();
            this.labelData = new System.Windows.Forms.Label();
            this.tabPageTrivet = new System.Windows.Forms.TabPage();
            this.btnTrivetDelete = new System.Windows.Forms.Button();
            this.twTrivet = new System.Windows.Forms.TreeView();
            this.labelTreeNodeTrivetName = new System.Windows.Forms.Label();
            this.groupBoxTrivet = new System.Windows.Forms.GroupBox();
            this.textTrivetCount = new System.Windows.Forms.TextBox();
            this.TrivetCount = new System.Windows.Forms.Label();
            this.btnSaveTrivet = new System.Windows.Forms.Button();
            this.btnNewTrivet = new System.Windows.Forms.Button();
            this.txtTrivetName = new System.Windows.Forms.TextBox();
            this.txtTrivetId = new System.Windows.Forms.TextBox();
            this.labelTrivetName = new System.Windows.Forms.Label();
            this.labelTrivetId = new System.Windows.Forms.Label();
            this.tabPageCompany = new System.Windows.Forms.TabPage();
            this.btnDeleteCompany = new System.Windows.Forms.Button();
            this.groupBoxCompany = new System.Windows.Forms.GroupBox();
            this.btnSaveCompany = new System.Windows.Forms.Button();
            this.btnNewCompany = new System.Windows.Forms.Button();
            this.txtCompanySize = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtCompanyId = new System.Windows.Forms.TextBox();
            this.labelCompanyCount = new System.Windows.Forms.Label();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.labelCompanyID = new System.Windows.Forms.Label();
            this.twCompany = new System.Windows.Forms.TreeView();
            this.labelTreeNodeComapnyName = new System.Windows.Forms.Label();
            this.tabControlTriWeight = new System.Windows.Forms.TabControl();
            this.labelShowCompanyName = new System.Windows.Forms.Label();
            this.tabPageBackUp.SuspendLayout();
            this.tabPageData.SuspendLayout();
            this.groupBoxData.SuspendLayout();
            this.tabPageTrivet.SuspendLayout();
            this.groupBoxTrivet.SuspendLayout();
            this.tabPageCompany.SuspendLayout();
            this.groupBoxCompany.SuspendLayout();
            this.tabControlTriWeight.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEventLocation
            // 
            this.txtEventLocation.Location = new System.Drawing.Point(0, 0);
            this.txtEventLocation.Name = "txtEventLocation";
            this.txtEventLocation.Size = new System.Drawing.Size(100, 20);
            this.txtEventLocation.TabIndex = 0;
            // 
            // tabPageBackUp
            // 
            this.tabPageBackUp.Controls.Add(this.dateTimePickerBackUp);
            this.tabPageBackUp.Location = new System.Drawing.Point(4, 22);
            this.tabPageBackUp.Name = "tabPageBackUp";
            this.tabPageBackUp.Size = new System.Drawing.Size(1162, 589);
            this.tabPageBackUp.TabIndex = 3;
            this.tabPageBackUp.Text = "Back-Up";
            this.tabPageBackUp.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerBackUp
            // 
            this.dateTimePickerBackUp.Location = new System.Drawing.Point(39, 44);
            this.dateTimePickerBackUp.Name = "dateTimePickerBackUp";
            this.dateTimePickerBackUp.Size = new System.Drawing.Size(142, 20);
            this.dateTimePickerBackUp.TabIndex = 8;
            // 
            // tabPageData
            // 
            this.tabPageData.Controls.Add(this.labelShowCompanyName);
            this.tabPageData.Controls.Add(this.buttonSearchData);
            this.tabPageData.Controls.Add(this.textBoxDataSearch);
            this.tabPageData.Controls.Add(this.labelDataSearch);
            this.tabPageData.Controls.Add(this.groupBoxData);
            this.tabPageData.Controls.Add(this.twDataItems);
            this.tabPageData.Controls.Add(this.labelData);
            this.tabPageData.Location = new System.Drawing.Point(4, 22);
            this.tabPageData.Name = "tabPageData";
            this.tabPageData.Size = new System.Drawing.Size(1162, 589);
            this.tabPageData.TabIndex = 2;
            this.tabPageData.Text = "Data";
            this.tabPageData.UseVisualStyleBackColor = true;
            // 
            // buttonSearchData
            // 
            this.buttonSearchData.Location = new System.Drawing.Point(28, 418);
            this.buttonSearchData.Name = "buttonSearchData";
            this.buttonSearchData.Size = new System.Drawing.Size(351, 27);
            this.buttonSearchData.TabIndex = 22;
            this.buttonSearchData.Text = "Search for Data from Company";
            this.buttonSearchData.UseVisualStyleBackColor = true;
            this.buttonSearchData.Click += new System.EventHandler(this.buttonSearchData_Click);
            // 
            // textBoxDataSearch
            // 
            this.textBoxDataSearch.Location = new System.Drawing.Point(118, 383);
            this.textBoxDataSearch.Name = "textBoxDataSearch";
            this.textBoxDataSearch.Size = new System.Drawing.Size(261, 20);
            this.textBoxDataSearch.TabIndex = 23;
            // 
            // labelDataSearch
            // 
            this.labelDataSearch.AutoSize = true;
            this.labelDataSearch.Location = new System.Drawing.Point(30, 386);
            this.labelDataSearch.Name = "labelDataSearch";
            this.labelDataSearch.Size = new System.Drawing.Size(82, 13);
            this.labelDataSearch.TabIndex = 22;
            this.labelDataSearch.Text = "Company Name";
            // 
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.labelDateTime);
            this.groupBoxData.Controls.Add(this.textBoxDataCompanyId);
            this.groupBoxData.Controls.Add(this.textDataTrivetId);
            this.groupBoxData.Controls.Add(this.labelDataCompanyId);
            this.groupBoxData.Controls.Add(this.labeDataTrivetID);
            this.groupBoxData.Controls.Add(this.labelDataId);
            this.groupBoxData.Controls.Add(this.btnDataSave);
            this.groupBoxData.Controls.Add(this.btnNewData);
            this.groupBoxData.Controls.Add(this.txtDataState);
            this.groupBoxData.Controls.Add(this.txtDataWeight);
            this.groupBoxData.Controls.Add(this.txtDataTime);
            this.groupBoxData.Controls.Add(this.txtDataId);
            this.groupBoxData.Controls.Add(this.labelDataState);
            this.groupBoxData.Controls.Add(this.labelDataWeight);
            this.groupBoxData.Controls.Add(this.labelDataTime);
            this.groupBoxData.Location = new System.Drawing.Point(424, 51);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(459, 440);
            this.groupBoxData.TabIndex = 6;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "New Data";
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(219, 166);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(225, 13);
            this.labelDateTime.TabIndex = 23;
            this.labelDateTime.Text = "DATETIME - format: YYYY-MM-DD HH:MI:SS";
            // 
            // textBoxDataCompanyId
            // 
            this.textBoxDataCompanyId.Location = new System.Drawing.Point(99, 126);
            this.textBoxDataCompanyId.Name = "textBoxDataCompanyId";
            this.textBoxDataCompanyId.Size = new System.Drawing.Size(40, 20);
            this.textBoxDataCompanyId.TabIndex = 22;
            // 
            // textDataTrivetId
            // 
            this.textDataTrivetId.Location = new System.Drawing.Point(99, 77);
            this.textDataTrivetId.Name = "textDataTrivetId";
            this.textDataTrivetId.Size = new System.Drawing.Size(40, 20);
            this.textDataTrivetId.TabIndex = 21;
            // 
            // labelDataCompanyId
            // 
            this.labelDataCompanyId.AutoSize = true;
            this.labelDataCompanyId.Location = new System.Drawing.Point(16, 126);
            this.labelDataCompanyId.Name = "labelDataCompanyId";
            this.labelDataCompanyId.Size = new System.Drawing.Size(62, 13);
            this.labelDataCompanyId.TabIndex = 20;
            this.labelDataCompanyId.Text = "CompnayID";
            // 
            // labeDataTrivetID
            // 
            this.labeDataTrivetID.AutoSize = true;
            this.labeDataTrivetID.Location = new System.Drawing.Point(16, 80);
            this.labeDataTrivetID.Name = "labeDataTrivetID";
            this.labeDataTrivetID.Size = new System.Drawing.Size(45, 13);
            this.labeDataTrivetID.TabIndex = 18;
            this.labeDataTrivetID.Text = "TrivetID";
            // 
            // labelDataId
            // 
            this.labelDataId.AutoSize = true;
            this.labelDataId.Location = new System.Drawing.Point(20, 37);
            this.labelDataId.Name = "labelDataId";
            this.labelDataId.Size = new System.Drawing.Size(41, 13);
            this.labelDataId.TabIndex = 15;
            this.labelDataId.Text = "DataID";
            // 
            // btnDataSave
            // 
            this.btnDataSave.Location = new System.Drawing.Point(370, 367);
            this.btnDataSave.Name = "btnDataSave";
            this.btnDataSave.Size = new System.Drawing.Size(79, 45);
            this.btnDataSave.TabIndex = 13;
            this.btnDataSave.Text = "Save";
            this.btnDataSave.UseVisualStyleBackColor = true;
            this.btnDataSave.Click += new System.EventHandler(this.btnDataSave_click);
            // 
            // btnNewData
            // 
            this.btnNewData.Location = new System.Drawing.Point(23, 367);
            this.btnNewData.Name = "btnNewData";
            this.btnNewData.Size = new System.Drawing.Size(79, 45);
            this.btnNewData.TabIndex = 12;
            this.btnNewData.Text = "New";
            this.btnNewData.UseVisualStyleBackColor = true;
            this.btnNewData.Click += new System.EventHandler(this.btnNewData_Click);
            // 
            // txtDataState
            // 
            this.txtDataState.Location = new System.Drawing.Point(99, 273);
            this.txtDataState.Name = "txtDataState";
            this.txtDataState.Size = new System.Drawing.Size(345, 20);
            this.txtDataState.TabIndex = 10;
            // 
            // txtDataWeight
            // 
            this.txtDataWeight.Location = new System.Drawing.Point(99, 233);
            this.txtDataWeight.Name = "txtDataWeight";
            this.txtDataWeight.Size = new System.Drawing.Size(345, 20);
            this.txtDataWeight.TabIndex = 9;
            // 
            // txtDataTime
            // 
            this.txtDataTime.Location = new System.Drawing.Point(99, 192);
            this.txtDataTime.Name = "txtDataTime";
            this.txtDataTime.Size = new System.Drawing.Size(345, 20);
            this.txtDataTime.TabIndex = 7;
            // 
            // txtDataId
            // 
            this.txtDataId.Location = new System.Drawing.Point(99, 34);
            this.txtDataId.Name = "txtDataId";
            this.txtDataId.ReadOnly = true;
            this.txtDataId.Size = new System.Drawing.Size(40, 20);
            this.txtDataId.TabIndex = 6;
            // 
            // labelDataState
            // 
            this.labelDataState.AutoSize = true;
            this.labelDataState.Location = new System.Drawing.Point(20, 276);
            this.labelDataState.Name = "labelDataState";
            this.labelDataState.Size = new System.Drawing.Size(52, 13);
            this.labelDataState.TabIndex = 4;
            this.labelDataState.Text = "State (int)";
            // 
            // labelDataWeight
            // 
            this.labelDataWeight.AutoSize = true;
            this.labelDataWeight.Location = new System.Drawing.Point(20, 236);
            this.labelDataWeight.Name = "labelDataWeight";
            this.labelDataWeight.Size = new System.Drawing.Size(41, 13);
            this.labelDataWeight.TabIndex = 2;
            this.labelDataWeight.Text = "Weight";
            // 
            // labelDataTime
            // 
            this.labelDataTime.AutoSize = true;
            this.labelDataTime.Location = new System.Drawing.Point(20, 195);
            this.labelDataTime.Name = "labelDataTime";
            this.labelDataTime.Size = new System.Drawing.Size(30, 13);
            this.labelDataTime.TabIndex = 0;
            this.labelDataTime.Text = "Time";
            // 
            // twDataItems
            // 
            this.twDataItems.Location = new System.Drawing.Point(28, 51);
            this.twDataItems.Name = "twDataItems";
            this.twDataItems.ShowLines = false;
            this.twDataItems.ShowPlusMinus = false;
            this.twDataItems.ShowRootLines = false;
            this.twDataItems.Size = new System.Drawing.Size(351, 313);
            this.twDataItems.TabIndex = 5;
            this.twDataItems.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.twWishItems_AfterSelect);
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(25, 25);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(30, 13);
            this.labelData.TabIndex = 4;
            this.labelData.Text = "Data";
            // 
            // tabPageTrivet
            // 
            this.tabPageTrivet.Controls.Add(this.btnTrivetDelete);
            this.tabPageTrivet.Controls.Add(this.twTrivet);
            this.tabPageTrivet.Controls.Add(this.labelTreeNodeTrivetName);
            this.tabPageTrivet.Controls.Add(this.groupBoxTrivet);
            this.tabPageTrivet.Location = new System.Drawing.Point(4, 22);
            this.tabPageTrivet.Name = "tabPageTrivet";
            this.tabPageTrivet.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTrivet.Size = new System.Drawing.Size(1162, 589);
            this.tabPageTrivet.TabIndex = 1;
            this.tabPageTrivet.Text = "Trivet";
            this.tabPageTrivet.UseVisualStyleBackColor = true;
            // 
            // btnTrivetDelete
            // 
            this.btnTrivetDelete.Location = new System.Drawing.Point(21, 424);
            this.btnTrivetDelete.Name = "btnTrivetDelete";
            this.btnTrivetDelete.Size = new System.Drawing.Size(319, 23);
            this.btnTrivetDelete.TabIndex = 7;
            this.btnTrivetDelete.Text = "Delete";
            this.btnTrivetDelete.UseVisualStyleBackColor = true;
            // 
            // twTrivet
            // 
            this.twTrivet.Location = new System.Drawing.Point(21, 44);
            this.twTrivet.Name = "twTrivet";
            this.twTrivet.ShowLines = false;
            this.twTrivet.ShowPlusMinus = false;
            this.twTrivet.ShowRootLines = false;
            this.twTrivet.Size = new System.Drawing.Size(320, 368);
            this.twTrivet.TabIndex = 5;
            this.twTrivet.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.twUsers_NodeMouseDoubleClick);
            // 
            // labelTreeNodeTrivetName
            // 
            this.labelTreeNodeTrivetName.AutoSize = true;
            this.labelTreeNodeTrivetName.Location = new System.Drawing.Point(20, 20);
            this.labelTreeNodeTrivetName.Name = "labelTreeNodeTrivetName";
            this.labelTreeNodeTrivetName.Size = new System.Drawing.Size(34, 13);
            this.labelTreeNodeTrivetName.TabIndex = 4;
            this.labelTreeNodeTrivetName.Text = "Trivet";
            // 
            // groupBoxTrivet
            // 
            this.groupBoxTrivet.Controls.Add(this.textTrivetCount);
            this.groupBoxTrivet.Controls.Add(this.TrivetCount);
            this.groupBoxTrivet.Controls.Add(this.btnSaveTrivet);
            this.groupBoxTrivet.Controls.Add(this.btnNewTrivet);
            this.groupBoxTrivet.Controls.Add(this.txtTrivetName);
            this.groupBoxTrivet.Controls.Add(this.txtTrivetId);
            this.groupBoxTrivet.Controls.Add(this.labelTrivetName);
            this.groupBoxTrivet.Controls.Add(this.labelTrivetId);
            this.groupBoxTrivet.Location = new System.Drawing.Point(373, 44);
            this.groupBoxTrivet.Name = "groupBoxTrivet";
            this.groupBoxTrivet.Size = new System.Drawing.Size(726, 403);
            this.groupBoxTrivet.TabIndex = 6;
            this.groupBoxTrivet.TabStop = false;
            this.groupBoxTrivet.Text = "New Trivet";
            // 
            // textTrivetCount
            // 
            this.textTrivetCount.Location = new System.Drawing.Point(116, 145);
            this.textTrivetCount.Name = "textTrivetCount";
            this.textTrivetCount.Size = new System.Drawing.Size(251, 20);
            this.textTrivetCount.TabIndex = 27;
            // 
            // TrivetCount
            // 
            this.TrivetCount.AutoSize = true;
            this.TrivetCount.Location = new System.Drawing.Point(20, 148);
            this.TrivetCount.Name = "TrivetCount";
            this.TrivetCount.Size = new System.Drawing.Size(52, 13);
            this.TrivetCount.TabIndex = 26;
            this.TrivetCount.Text = "Type (Int)";
            // 
            // btnSaveTrivet
            // 
            this.btnSaveTrivet.Location = new System.Drawing.Point(288, 323);
            this.btnSaveTrivet.Name = "btnSaveTrivet";
            this.btnSaveTrivet.Size = new System.Drawing.Size(79, 45);
            this.btnSaveTrivet.TabIndex = 11;
            this.btnSaveTrivet.Text = "Save";
            this.btnSaveTrivet.UseVisualStyleBackColor = true;
            this.btnSaveTrivet.Click += new System.EventHandler(this.btnSaveTrivet_Click);
            // 
            // btnNewTrivet
            // 
            this.btnNewTrivet.Location = new System.Drawing.Point(23, 323);
            this.btnNewTrivet.Name = "btnNewTrivet";
            this.btnNewTrivet.Size = new System.Drawing.Size(79, 45);
            this.btnNewTrivet.TabIndex = 12;
            this.btnNewTrivet.Text = "New";
            this.btnNewTrivet.UseVisualStyleBackColor = true;
            this.btnNewTrivet.Click += new System.EventHandler(this.btnNewTrivet_Click);
            // 
            // txtTrivetName
            // 
            this.txtTrivetName.Location = new System.Drawing.Point(116, 87);
            this.txtTrivetName.Name = "txtTrivetName";
            this.txtTrivetName.Size = new System.Drawing.Size(251, 20);
            this.txtTrivetName.TabIndex = 6;
            // 
            // txtTrivetId
            // 
            this.txtTrivetId.Location = new System.Drawing.Point(116, 34);
            this.txtTrivetId.Name = "txtTrivetId";
            this.txtTrivetId.ReadOnly = true;
            this.txtTrivetId.Size = new System.Drawing.Size(40, 20);
            this.txtTrivetId.TabIndex = 5;
            // 
            // labelTrivetName
            // 
            this.labelTrivetName.AutoSize = true;
            this.labelTrivetName.Location = new System.Drawing.Point(20, 90);
            this.labelTrivetName.Name = "labelTrivetName";
            this.labelTrivetName.Size = new System.Drawing.Size(65, 13);
            this.labelTrivetName.TabIndex = 1;
            this.labelTrivetName.Text = "Trivet Name";
            // 
            // labelTrivetId
            // 
            this.labelTrivetId.AutoSize = true;
            this.labelTrivetId.Location = new System.Drawing.Point(20, 37);
            this.labelTrivetId.Name = "labelTrivetId";
            this.labelTrivetId.Size = new System.Drawing.Size(45, 13);
            this.labelTrivetId.TabIndex = 0;
            this.labelTrivetId.Text = "TrivetID";
            // 
            // tabPageCompany
            // 
            this.tabPageCompany.Controls.Add(this.btnDeleteCompany);
            this.tabPageCompany.Controls.Add(this.groupBoxCompany);
            this.tabPageCompany.Controls.Add(this.twCompany);
            this.tabPageCompany.Controls.Add(this.labelTreeNodeComapnyName);
            this.tabPageCompany.Location = new System.Drawing.Point(4, 22);
            this.tabPageCompany.Name = "tabPageCompany";
            this.tabPageCompany.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCompany.Size = new System.Drawing.Size(1162, 589);
            this.tabPageCompany.TabIndex = 0;
            this.tabPageCompany.Text = "Company";
            this.tabPageCompany.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCompany
            // 
            this.btnDeleteCompany.Location = new System.Drawing.Point(21, 424);
            this.btnDeleteCompany.Name = "btnDeleteCompany";
            this.btnDeleteCompany.Size = new System.Drawing.Size(319, 23);
            this.btnDeleteCompany.TabIndex = 3;
            this.btnDeleteCompany.Text = "Delete";
            this.btnDeleteCompany.UseVisualStyleBackColor = true;
            this.btnDeleteCompany.Click += new System.EventHandler(this.btnDeleteCompany_Click);
            // 
            // groupBoxCompany
            // 
            this.groupBoxCompany.Controls.Add(this.btnSaveCompany);
            this.groupBoxCompany.Controls.Add(this.btnNewCompany);
            this.groupBoxCompany.Controls.Add(this.txtCompanySize);
            this.groupBoxCompany.Controls.Add(this.txtCompanyName);
            this.groupBoxCompany.Controls.Add(this.txtCompanyId);
            this.groupBoxCompany.Controls.Add(this.labelCompanyCount);
            this.groupBoxCompany.Controls.Add(this.labelCompanyName);
            this.groupBoxCompany.Controls.Add(this.labelCompanyID);
            this.groupBoxCompany.Location = new System.Drawing.Point(371, 44);
            this.groupBoxCompany.Name = "groupBoxCompany";
            this.groupBoxCompany.Size = new System.Drawing.Size(401, 411);
            this.groupBoxCompany.TabIndex = 2;
            this.groupBoxCompany.TabStop = false;
            this.groupBoxCompany.Text = "New Company";
            // 
            // btnSaveCompany
            // 
            this.btnSaveCompany.Location = new System.Drawing.Point(274, 331);
            this.btnSaveCompany.Name = "btnSaveCompany";
            this.btnSaveCompany.Size = new System.Drawing.Size(79, 45);
            this.btnSaveCompany.TabIndex = 3;
            this.btnSaveCompany.Text = "Save";
            this.btnSaveCompany.UseVisualStyleBackColor = true;
            this.btnSaveCompany.Click += new System.EventHandler(this.btnSaveCompany_Click);
            // 
            // btnNewCompany
            // 
            this.btnNewCompany.Location = new System.Drawing.Point(17, 331);
            this.btnNewCompany.Name = "btnNewCompany";
            this.btnNewCompany.Size = new System.Drawing.Size(79, 45);
            this.btnNewCompany.TabIndex = 4;
            this.btnNewCompany.Text = "New";
            this.btnNewCompany.UseVisualStyleBackColor = true;
            this.btnNewCompany.Click += new System.EventHandler(this.btnNewCompany_Click);
            // 
            // txtCompanySize
            // 
            this.txtCompanySize.Location = new System.Drawing.Point(102, 138);
            this.txtCompanySize.Name = "txtCompanySize";
            this.txtCompanySize.Size = new System.Drawing.Size(251, 20);
            this.txtCompanySize.TabIndex = 8;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(102, 87);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(251, 20);
            this.txtCompanyName.TabIndex = 1;
            // 
            // txtCompanyId
            // 
            this.txtCompanyId.Location = new System.Drawing.Point(102, 34);
            this.txtCompanyId.Name = "txtCompanyId";
            this.txtCompanyId.ReadOnly = true;
            this.txtCompanyId.Size = new System.Drawing.Size(40, 20);
            this.txtCompanyId.TabIndex = 0;
            // 
            // labelCompanyCount
            // 
            this.labelCompanyCount.AutoSize = true;
            this.labelCompanyCount.Location = new System.Drawing.Point(20, 141);
            this.labelCompanyCount.Name = "labelCompanyCount";
            this.labelCompanyCount.Size = new System.Drawing.Size(82, 13);
            this.labelCompanyCount.TabIndex = 3;
            this.labelCompanyCount.Text = "Company Count";
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Location = new System.Drawing.Point(20, 90);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(82, 13);
            this.labelCompanyName.TabIndex = 1;
            this.labelCompanyName.Text = "Company Name";
            // 
            // labelCompanyID
            // 
            this.labelCompanyID.AutoSize = true;
            this.labelCompanyID.Location = new System.Drawing.Point(20, 37);
            this.labelCompanyID.Name = "labelCompanyID";
            this.labelCompanyID.Size = new System.Drawing.Size(65, 13);
            this.labelCompanyID.TabIndex = 0;
            this.labelCompanyID.Text = "Compnay ID";
            // 
            // twCompany
            // 
            this.twCompany.Location = new System.Drawing.Point(21, 44);
            this.twCompany.Name = "twCompany";
            this.twCompany.ShowLines = false;
            this.twCompany.ShowPlusMinus = false;
            this.twCompany.ShowRootLines = false;
            this.twCompany.Size = new System.Drawing.Size(320, 368);
            this.twCompany.TabIndex = 1;
            // 
            // labelTreeNodeComapnyName
            // 
            this.labelTreeNodeComapnyName.AutoSize = true;
            this.labelTreeNodeComapnyName.Location = new System.Drawing.Point(20, 20);
            this.labelTreeNodeComapnyName.Name = "labelTreeNodeComapnyName";
            this.labelTreeNodeComapnyName.Size = new System.Drawing.Size(59, 13);
            this.labelTreeNodeComapnyName.TabIndex = 0;
            this.labelTreeNodeComapnyName.Text = "Companies";
            // 
            // tabControlTriWeight
            // 
            this.tabControlTriWeight.Controls.Add(this.tabPageCompany);
            this.tabControlTriWeight.Controls.Add(this.tabPageTrivet);
            this.tabControlTriWeight.Controls.Add(this.tabPageData);
            this.tabControlTriWeight.Controls.Add(this.tabPageBackUp);
            this.tabControlTriWeight.Location = new System.Drawing.Point(20, 20);
            this.tabControlTriWeight.Name = "tabControlTriWeight";
            this.tabControlTriWeight.SelectedIndex = 0;
            this.tabControlTriWeight.Size = new System.Drawing.Size(1170, 615);
            this.tabControlTriWeight.TabIndex = 0;
            // 
            // labelShowCompanyName
            // 
            this.labelShowCompanyName.AutoSize = true;
            this.labelShowCompanyName.Location = new System.Drawing.Point(297, 25);
            this.labelShowCompanyName.Name = "labelShowCompanyName";
            this.labelShowCompanyName.Size = new System.Drawing.Size(82, 13);
            this.labelShowCompanyName.TabIndex = 24;
            this.labelShowCompanyName.Text = "Company Name";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 647);
            this.Controls.Add(this.tabControlTriWeight);
            this.Name = "MainForm";
            this.Text = " ";
            this.tabPageBackUp.ResumeLayout(false);
            this.tabPageData.ResumeLayout(false);
            this.tabPageData.PerformLayout();
            this.groupBoxData.ResumeLayout(false);
            this.groupBoxData.PerformLayout();
            this.tabPageTrivet.ResumeLayout(false);
            this.tabPageTrivet.PerformLayout();
            this.groupBoxTrivet.ResumeLayout(false);
            this.groupBoxTrivet.PerformLayout();
            this.tabPageCompany.ResumeLayout(false);
            this.tabPageCompany.PerformLayout();
            this.groupBoxCompany.ResumeLayout(false);
            this.groupBoxCompany.PerformLayout();
            this.tabControlTriWeight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtEventLocation;
        private System.Windows.Forms.TabPage tabPageBackUp;
        private System.Windows.Forms.TabPage tabPageData;
        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.Label labelDataId;
        private System.Windows.Forms.Button btnDataSave;
        private System.Windows.Forms.Button btnNewData;
        private System.Windows.Forms.TextBox txtDataState;
        private System.Windows.Forms.TextBox txtDataWeight;
        private System.Windows.Forms.TextBox txtDataTime;
        private System.Windows.Forms.TextBox txtDataId;
        private System.Windows.Forms.Label labelDataState;
        private System.Windows.Forms.Label labelDataWeight;
        private System.Windows.Forms.Label labelDataTime;
        private System.Windows.Forms.TreeView twDataItems;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.TabPage tabPageTrivet;
        private System.Windows.Forms.Button btnTrivetDelete;
        private System.Windows.Forms.TreeView twTrivet;
        private System.Windows.Forms.Label labelTreeNodeTrivetName;
        private System.Windows.Forms.GroupBox groupBoxTrivet;
        private System.Windows.Forms.TextBox textTrivetCount;
        private System.Windows.Forms.Label TrivetCount;
        private System.Windows.Forms.Button btnSaveTrivet;
        private System.Windows.Forms.Button btnNewTrivet;
        private System.Windows.Forms.TextBox txtTrivetName;
        private System.Windows.Forms.TextBox txtTrivetId;
        private System.Windows.Forms.Label labelTrivetName;
        private System.Windows.Forms.Label labelTrivetId;
        private System.Windows.Forms.TabPage tabPageCompany;
        private System.Windows.Forms.Button btnDeleteCompany;
        private System.Windows.Forms.GroupBox groupBoxCompany;
        private System.Windows.Forms.Button btnSaveCompany;
        private System.Windows.Forms.Button btnNewCompany;
        private System.Windows.Forms.TextBox txtCompanySize;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtCompanyId;
        private System.Windows.Forms.Label labelCompanyCount;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Label labelCompanyID;
        private System.Windows.Forms.TreeView twCompany;
        private System.Windows.Forms.Label labelTreeNodeComapnyName;
        private System.Windows.Forms.TabControl tabControlTriWeight;
        private System.Windows.Forms.Label labeDataTrivetID;
        private System.Windows.Forms.Label labelDataCompanyId;
        private System.Windows.Forms.TextBox textDataTrivetId;
        private System.Windows.Forms.DateTimePicker dateTimePickerBackUp;
        private System.Windows.Forms.Button buttonSearchData;
        private System.Windows.Forms.TextBox textBoxDataSearch;
        private System.Windows.Forms.Label labelDataSearch;
        private System.Windows.Forms.TextBox textBoxDataCompanyId;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Label labelShowCompanyName;
    }
}

