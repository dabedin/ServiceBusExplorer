﻿namespace Microsoft.WindowsAzure.CAT.ServiceBusExplorer
{
    partial class HandleConsumerGroupControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tabPageDescription = new System.Windows.Forms.TabPage();
            this.grouperName = new Microsoft.WindowsAzure.CAT.ServiceBusExplorer.Grouper();
            this.lblRelativeURI = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grouperConsumerGroupProperties = new Microsoft.WindowsAzure.CAT.ServiceBusExplorer.Grouper();
            this.txtUserMetadata = new System.Windows.Forms.TextBox();
            this.lblUserMetadata = new System.Windows.Forms.Label();
            this.grouperConsumerGroupInformation = new Microsoft.WindowsAzure.CAT.ServiceBusExplorer.Grouper();
            this.propertyListView = new System.Windows.Forms.ListView();
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valueColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.tabPageMetrics = new System.Windows.Forms.TabPage();
            this.grouperDatapoints = new Microsoft.WindowsAzure.CAT.ServiceBusExplorer.Grouper();
            this.dataPointDataGridView = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCancelUpdate = new System.Windows.Forms.Button();
            this.btnCreateDelete = new System.Windows.Forms.Button();
            this.entityInformationContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyPartitionInformationToClipboardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCloseTabs = new System.Windows.Forms.Button();
            this.btnMetrics = new System.Windows.Forms.Button();
            this.tabPageDescription.SuspendLayout();
            this.grouperName.SuspendLayout();
            this.grouperConsumerGroupProperties.SuspendLayout();
            this.grouperConsumerGroupInformation.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.tabPageMetrics.SuspendLayout();
            this.grouperDatapoints.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPointDataGridView)).BeginInit();
            this.entityInformationContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageDescription
            // 
            this.tabPageDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.tabPageDescription.Controls.Add(this.grouperName);
            this.tabPageDescription.Controls.Add(this.grouperConsumerGroupProperties);
            this.tabPageDescription.Controls.Add(this.grouperConsumerGroupInformation);
            this.tabPageDescription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPageDescription.Location = new System.Drawing.Point(4, 24);
            this.tabPageDescription.Name = "tabPageDescription";
            this.tabPageDescription.Size = new System.Drawing.Size(968, 452);
            this.tabPageDescription.TabIndex = 2;
            this.tabPageDescription.Text = "Description";
            // 
            // grouperName
            // 
            this.grouperName.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.grouperName.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouperName.BackgroundGradientMode = Microsoft.WindowsAzure.CAT.ServiceBusExplorer.Grouper.GroupBoxGradientMode.None;
            this.grouperName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperName.BorderThickness = 1F;
            this.grouperName.Controls.Add(this.lblRelativeURI);
            this.grouperName.Controls.Add(this.txtName);
            this.grouperName.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grouperName.ForeColor = System.Drawing.Color.White;
            this.grouperName.GroupImage = null;
            this.grouperName.GroupTitle = "Name";
            this.grouperName.Location = new System.Drawing.Point(16, 8);
            this.grouperName.Name = "grouperName";
            this.grouperName.Padding = new System.Windows.Forms.Padding(20);
            this.grouperName.PaintGroupBox = true;
            this.grouperName.RoundCorners = 4;
            this.grouperName.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouperName.ShadowControl = false;
            this.grouperName.ShadowThickness = 1;
            this.grouperName.Size = new System.Drawing.Size(608, 80);
            this.grouperName.TabIndex = 0;
            // 
            // lblRelativeURI
            // 
            this.lblRelativeURI.AutoSize = true;
            this.lblRelativeURI.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRelativeURI.Location = new System.Drawing.Point(16, 28);
            this.lblRelativeURI.Name = "lblRelativeURI";
            this.lblRelativeURI.Size = new System.Drawing.Size(120, 13);
            this.lblRelativeURI.TabIndex = 22;
            this.lblRelativeURI.Text = "Consumer Group Name:";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtName.Location = new System.Drawing.Point(16, 44);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(576, 20);
            this.txtName.TabIndex = 0;
            // 
            // grouperConsumerGroupProperties
            // 
            this.grouperConsumerGroupProperties.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grouperConsumerGroupProperties.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.grouperConsumerGroupProperties.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouperConsumerGroupProperties.BackgroundGradientMode = Microsoft.WindowsAzure.CAT.ServiceBusExplorer.Grouper.GroupBoxGradientMode.None;
            this.grouperConsumerGroupProperties.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperConsumerGroupProperties.BorderThickness = 1F;
            this.grouperConsumerGroupProperties.Controls.Add(this.txtUserMetadata);
            this.grouperConsumerGroupProperties.Controls.Add(this.lblUserMetadata);
            this.grouperConsumerGroupProperties.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperConsumerGroupProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grouperConsumerGroupProperties.ForeColor = System.Drawing.Color.White;
            this.grouperConsumerGroupProperties.GroupImage = null;
            this.grouperConsumerGroupProperties.GroupTitle = "Consumer Group Properties";
            this.grouperConsumerGroupProperties.Location = new System.Drawing.Point(16, 96);
            this.grouperConsumerGroupProperties.Name = "grouperConsumerGroupProperties";
            this.grouperConsumerGroupProperties.Padding = new System.Windows.Forms.Padding(20);
            this.grouperConsumerGroupProperties.PaintGroupBox = true;
            this.grouperConsumerGroupProperties.RoundCorners = 4;
            this.grouperConsumerGroupProperties.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouperConsumerGroupProperties.ShadowControl = false;
            this.grouperConsumerGroupProperties.ShadowThickness = 1;
            this.grouperConsumerGroupProperties.Size = new System.Drawing.Size(608, 344);
            this.grouperConsumerGroupProperties.TabIndex = 3;
            // 
            // txtUserMetadata
            // 
            this.txtUserMetadata.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserMetadata.BackColor = System.Drawing.SystemColors.Window;
            this.txtUserMetadata.Location = new System.Drawing.Point(16, 48);
            this.txtUserMetadata.Multiline = true;
            this.txtUserMetadata.Name = "txtUserMetadata";
            this.txtUserMetadata.Size = new System.Drawing.Size(576, 280);
            this.txtUserMetadata.TabIndex = 2;
            // 
            // lblUserMetadata
            // 
            this.lblUserMetadata.AutoSize = true;
            this.lblUserMetadata.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUserMetadata.Location = new System.Drawing.Point(16, 28);
            this.lblUserMetadata.Name = "lblUserMetadata";
            this.lblUserMetadata.Size = new System.Drawing.Size(88, 13);
            this.lblUserMetadata.TabIndex = 27;
            this.lblUserMetadata.Text = "User Description:";
            // 
            // grouperConsumerGroupInformation
            // 
            this.grouperConsumerGroupInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grouperConsumerGroupInformation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.grouperConsumerGroupInformation.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouperConsumerGroupInformation.BackgroundGradientMode = Microsoft.WindowsAzure.CAT.ServiceBusExplorer.Grouper.GroupBoxGradientMode.None;
            this.grouperConsumerGroupInformation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperConsumerGroupInformation.BorderThickness = 1F;
            this.grouperConsumerGroupInformation.Controls.Add(this.propertyListView);
            this.grouperConsumerGroupInformation.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperConsumerGroupInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grouperConsumerGroupInformation.ForeColor = System.Drawing.Color.White;
            this.grouperConsumerGroupInformation.GroupImage = null;
            this.grouperConsumerGroupInformation.GroupTitle = "Consumer Group Information";
            this.grouperConsumerGroupInformation.Location = new System.Drawing.Point(640, 8);
            this.grouperConsumerGroupInformation.Name = "grouperConsumerGroupInformation";
            this.grouperConsumerGroupInformation.Padding = new System.Windows.Forms.Padding(20);
            this.grouperConsumerGroupInformation.PaintGroupBox = true;
            this.grouperConsumerGroupInformation.RoundCorners = 4;
            this.grouperConsumerGroupInformation.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouperConsumerGroupInformation.ShadowControl = false;
            this.grouperConsumerGroupInformation.ShadowThickness = 1;
            this.grouperConsumerGroupInformation.Size = new System.Drawing.Size(312, 432);
            this.grouperConsumerGroupInformation.TabIndex = 6;
            // 
            // propertyListView
            // 
            this.propertyListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumnHeader,
            this.valueColumnHeader});
            this.propertyListView.Location = new System.Drawing.Point(16, 32);
            this.propertyListView.Name = "propertyListView";
            this.propertyListView.OwnerDraw = true;
            this.propertyListView.Size = new System.Drawing.Size(279, 384);
            this.propertyListView.TabIndex = 0;
            this.propertyListView.UseCompatibleStateImageBehavior = false;
            this.propertyListView.View = System.Windows.Forms.View.Details;
            this.propertyListView.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.propertyListView_DrawColumnHeader);
            this.propertyListView.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.propertyListView_DrawItem);
            this.propertyListView.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.propertyListView_DrawSubItem);
            this.propertyListView.Resize += new System.EventHandler(this.propertyListView_Resize);
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Text = "Name";
            this.nameColumnHeader.Width = 120;
            // 
            // valueColumnHeader
            // 
            this.valueColumnHeader.Text = "Value";
            this.valueColumnHeader.Width = 115;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabControl.Controls.Add(this.tabPageDescription);
            this.mainTabControl.Controls.Add(this.tabPageMetrics);
            this.mainTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.mainTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTabControl.Location = new System.Drawing.Point(16, 16);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(976, 480);
            this.mainTabControl.TabIndex = 19;
            this.mainTabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.mainTabControl_DrawItem);
            this.mainTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.mainTabControl_Selected);
            // 
            // tabPageMetrics
            // 
            this.tabPageMetrics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.tabPageMetrics.Controls.Add(this.grouperDatapoints);
            this.tabPageMetrics.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPageMetrics.Location = new System.Drawing.Point(4, 24);
            this.tabPageMetrics.Name = "tabPageMetrics";
            this.tabPageMetrics.Size = new System.Drawing.Size(968, 452);
            this.tabPageMetrics.TabIndex = 3;
            this.tabPageMetrics.Text = "Metrics";
            // 
            // grouperDatapoints
            // 
            this.grouperDatapoints.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grouperDatapoints.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.grouperDatapoints.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouperDatapoints.BackgroundGradientMode = Microsoft.WindowsAzure.CAT.ServiceBusExplorer.Grouper.GroupBoxGradientMode.None;
            this.grouperDatapoints.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperDatapoints.BorderThickness = 1F;
            this.grouperDatapoints.Controls.Add(this.dataPointDataGridView);
            this.grouperDatapoints.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperDatapoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grouperDatapoints.ForeColor = System.Drawing.Color.White;
            this.grouperDatapoints.GroupImage = null;
            this.grouperDatapoints.GroupTitle = "Metrics Rules";
            this.grouperDatapoints.Location = new System.Drawing.Point(16, 8);
            this.grouperDatapoints.Name = "grouperDatapoints";
            this.grouperDatapoints.Padding = new System.Windows.Forms.Padding(20);
            this.grouperDatapoints.PaintGroupBox = true;
            this.grouperDatapoints.RoundCorners = 4;
            this.grouperDatapoints.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouperDatapoints.ShadowControl = false;
            this.grouperDatapoints.ShadowThickness = 1;
            this.grouperDatapoints.Size = new System.Drawing.Size(936, 432);
            this.grouperDatapoints.TabIndex = 4;
            // 
            // dataPointDataGridView
            // 
            this.dataPointDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataPointDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.dataPointDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataPointDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPointDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataPointDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.dataPointDataGridView.Location = new System.Drawing.Point(16, 32);
            this.dataPointDataGridView.Name = "dataPointDataGridView";
            this.dataPointDataGridView.RowHeadersWidth = 24;
            this.dataPointDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPointDataGridView.Size = new System.Drawing.Size(904, 384);
            this.dataPointDataGridView.TabIndex = 27;
            this.dataPointDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPointDataGridView_CellClick);
            this.dataPointDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataPointDataGridView_DataError);
            this.dataPointDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataPointDataGridView_RowsAdded);
            this.dataPointDataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataPointDataGridView_RowsRemoved);
            this.dataPointDataGridView.Resize += new System.EventHandler(this.dataPointDataGridView_Resize);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRefresh.Location = new System.Drawing.Point(760, 504);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(72, 24);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            this.btnRefresh.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.btnRefresh.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // btnCancelUpdate
            // 
            this.btnCancelUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.btnCancelUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnCancelUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnCancelUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnCancelUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelUpdate.Location = new System.Drawing.Point(920, 504);
            this.btnCancelUpdate.Name = "btnCancelUpdate";
            this.btnCancelUpdate.Size = new System.Drawing.Size(72, 24);
            this.btnCancelUpdate.TabIndex = 4;
            this.btnCancelUpdate.Text = "Update";
            this.btnCancelUpdate.UseVisualStyleBackColor = false;
            this.btnCancelUpdate.Click += new System.EventHandler(this.btnCancelUpdate_Click);
            this.btnCancelUpdate.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.btnCancelUpdate.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // btnCreateDelete
            // 
            this.btnCreateDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.btnCreateDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnCreateDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnCreateDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnCreateDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCreateDelete.Location = new System.Drawing.Point(840, 504);
            this.btnCreateDelete.Name = "btnCreateDelete";
            this.btnCreateDelete.Size = new System.Drawing.Size(72, 24);
            this.btnCreateDelete.TabIndex = 3;
            this.btnCreateDelete.Text = "Create";
            this.btnCreateDelete.UseVisualStyleBackColor = false;
            this.btnCreateDelete.Click += new System.EventHandler(this.btnCreateDelete_Click);
            this.btnCreateDelete.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.btnCreateDelete.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // entityInformationContextMenuStrip
            // 
            this.entityInformationContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyPartitionInformationToClipboardMenuItem});
            this.entityInformationContextMenuStrip.Name = "registrationContextMenuStrip";
            this.entityInformationContextMenuStrip.Size = new System.Drawing.Size(335, 26);
            // 
            // copyPartitionInformationToClipboardMenuItem
            // 
            this.copyPartitionInformationToClipboardMenuItem.Name = "copyPartitionInformationToClipboardMenuItem";
            this.copyPartitionInformationToClipboardMenuItem.Size = new System.Drawing.Size(334, 22);
            this.copyPartitionInformationToClipboardMenuItem.Text = "Copy Consumer Group Information to Clipboard.";
            this.copyPartitionInformationToClipboardMenuItem.ToolTipText = "Copy consumer group information to clipboard.";
            this.copyPartitionInformationToClipboardMenuItem.Click += new System.EventHandler(this.copyPartitionInformationToClipboardMenuItem_Click);
            // 
            // btnCloseTabs
            // 
            this.btnCloseTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseTabs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.btnCloseTabs.Enabled = false;
            this.btnCloseTabs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnCloseTabs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnCloseTabs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnCloseTabs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseTabs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCloseTabs.Location = new System.Drawing.Point(680, 504);
            this.btnCloseTabs.Name = "btnCloseTabs";
            this.btnCloseTabs.Size = new System.Drawing.Size(72, 24);
            this.btnCloseTabs.TabIndex = 1;
            this.btnCloseTabs.Text = "Close Tabs";
            this.btnCloseTabs.UseVisualStyleBackColor = false;
            this.btnCloseTabs.Click += new System.EventHandler(this.btnCloseTabs_Click);
            // 
            // btnMetrics
            // 
            this.btnMetrics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMetrics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.btnMetrics.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnMetrics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnMetrics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnMetrics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMetrics.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMetrics.Location = new System.Drawing.Point(600, 504);
            this.btnMetrics.Name = "btnMetrics";
            this.btnMetrics.Size = new System.Drawing.Size(72, 24);
            this.btnMetrics.TabIndex = 0;
            this.btnMetrics.Text = "Get Metrics";
            this.btnMetrics.UseVisualStyleBackColor = false;
            this.btnMetrics.Click += new System.EventHandler(this.btnMetrics_Click);
            // 
            // HandleConsumerGroupControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.btnCloseTabs);
            this.Controls.Add(this.btnMetrics);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnCancelUpdate);
            this.Controls.Add(this.btnCreateDelete);
            this.Name = "HandleConsumerGroupControl";
            this.Size = new System.Drawing.Size(1008, 544);
            this.tabPageDescription.ResumeLayout(false);
            this.grouperName.ResumeLayout(false);
            this.grouperName.PerformLayout();
            this.grouperConsumerGroupProperties.ResumeLayout(false);
            this.grouperConsumerGroupProperties.PerformLayout();
            this.grouperConsumerGroupInformation.ResumeLayout(false);
            this.mainTabControl.ResumeLayout(false);
            this.tabPageMetrics.ResumeLayout(false);
            this.grouperDatapoints.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataPointDataGridView)).EndInit();
            this.entityInformationContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TabPage tabPageDescription;
        internal System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCancelUpdate;
        private System.Windows.Forms.Button btnCreateDelete;
        private Grouper grouperName;
        private System.Windows.Forms.Label lblRelativeURI;
        private System.Windows.Forms.TextBox txtName;
        private Grouper grouperConsumerGroupProperties;
        private System.Windows.Forms.TextBox txtUserMetadata;
        private System.Windows.Forms.Label lblUserMetadata;
        private Grouper grouperConsumerGroupInformation;
        private System.Windows.Forms.ListView propertyListView;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader valueColumnHeader;
        private System.Windows.Forms.ContextMenuStrip entityInformationContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem copyPartitionInformationToClipboardMenuItem;
        private System.Windows.Forms.TabPage tabPageMetrics;
        private Grouper grouperDatapoints;
        private System.Windows.Forms.DataGridView dataPointDataGridView;
        private System.Windows.Forms.Button btnCloseTabs;
        private System.Windows.Forms.Button btnMetrics;
    }
}
