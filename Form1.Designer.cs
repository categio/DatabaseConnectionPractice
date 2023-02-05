
namespace DatabaseConnectionPractice
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purposeforTravelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tripDatesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.travelCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.travelRequestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.travelDataSet = new DatabaseConnectionPractice.TravelDataSet();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.fillBynameToolStrip = new System.Windows.Forms.ToolStrip();
            this.lastNameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.lastNameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.firstNameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.firstNameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.purposeforTravelToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.purposeforTravelToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.locationToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.locationToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.tripDatesToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.tripDatesToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillBynameToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.travelRequestsTableAdapter = new DatabaseConnectionPractice.TravelDataSetTableAdapters.TravelRequestsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelRequestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.searchGroupBox.SuspendLayout();
            this.fillBynameToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.purposeforTravelDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.tripDatesDataGridViewTextBoxColumn,
            this.travelCostDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.travelRequestsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(10, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(779, 215);
            this.dataGridView1.TabIndex = 0;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // purposeforTravelDataGridViewTextBoxColumn
            // 
            this.purposeforTravelDataGridViewTextBoxColumn.DataPropertyName = "PurposeforTravel";
            this.purposeforTravelDataGridViewTextBoxColumn.HeaderText = "PurposeforTravel";
            this.purposeforTravelDataGridViewTextBoxColumn.Name = "purposeforTravelDataGridViewTextBoxColumn";
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            // 
            // tripDatesDataGridViewTextBoxColumn
            // 
            this.tripDatesDataGridViewTextBoxColumn.DataPropertyName = "TripDates";
            this.tripDatesDataGridViewTextBoxColumn.HeaderText = "TripDates";
            this.tripDatesDataGridViewTextBoxColumn.Name = "tripDatesDataGridViewTextBoxColumn";
            // 
            // travelCostDataGridViewTextBoxColumn
            // 
            this.travelCostDataGridViewTextBoxColumn.DataPropertyName = "TravelCost";
            this.travelCostDataGridViewTextBoxColumn.HeaderText = "TravelCost";
            this.travelCostDataGridViewTextBoxColumn.Name = "travelCostDataGridViewTextBoxColumn";
            // 
            // travelRequestsBindingSource
            // 
            this.travelRequestsBindingSource.DataMember = "TravelRequests";
            this.travelRequestsBindingSource.DataSource = this.travelDataSet;
            // 
            // travelDataSet
            // 
            this.travelDataSet.DataSetName = "TravelDataSet";
            this.travelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.travelRequestsBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.saveButton});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1055, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "travelBindingNavigator";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // saveButton
            // 
            this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(23, 22);
            this.saveButton.Text = "Save";
            this.saveButton.ToolTipText = "Save";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.searchButton);
            this.searchGroupBox.Controls.Add(this.searchTextBox);
            this.searchGroupBox.Controls.Add(this.searchLabel);
            this.searchGroupBox.Location = new System.Drawing.Point(10, 386);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(778, 91);
            this.searchGroupBox.TabIndex = 2;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Access Data";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(240, 39);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(91, 24);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Find";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(13, 42);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(215, 20);
            this.searchTextBox.TabIndex = 1;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(14, 23);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(130, 13);
            this.searchLabel.TabIndex = 0;
            this.searchLabel.Text = "Enter any field to find data";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(20, 343);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(107, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Traveler\'s Last Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.travelRequestsBindingSource, "LastName", true));
            this.nameTextBox.Location = new System.Drawing.Point(143, 340);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(147, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(692, 336);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(96, 24);
            this.nextButton.TabIndex = 5;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            // 
            // fillBynameToolStrip
            // 
            this.fillBynameToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lastNameToolStripLabel,
            this.lastNameToolStripTextBox,
            this.firstNameToolStripLabel,
            this.firstNameToolStripTextBox,
            this.purposeforTravelToolStripLabel,
            this.purposeforTravelToolStripTextBox,
            this.locationToolStripLabel,
            this.locationToolStripTextBox,
            this.tripDatesToolStripLabel,
            this.tripDatesToolStripTextBox,
            this.fillBynameToolStripButton});
            this.fillBynameToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillBynameToolStrip.Name = "fillBynameToolStrip";
            this.fillBynameToolStrip.Size = new System.Drawing.Size(1055, 25);
            this.fillBynameToolStrip.TabIndex = 6;
            this.fillBynameToolStrip.Text = "fillBynameToolStrip";
            this.fillBynameToolStrip.Visible = false;
            // 
            // lastNameToolStripLabel
            // 
            this.lastNameToolStripLabel.Name = "lastNameToolStripLabel";
            this.lastNameToolStripLabel.Size = new System.Drawing.Size(63, 22);
            this.lastNameToolStripLabel.Text = "LastName:";
            this.lastNameToolStripLabel.Visible = false;
            // 
            // lastNameToolStripTextBox
            // 
            this.lastNameToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lastNameToolStripTextBox.Name = "lastNameToolStripTextBox";
            this.lastNameToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // firstNameToolStripLabel
            // 
            this.firstNameToolStripLabel.Name = "firstNameToolStripLabel";
            this.firstNameToolStripLabel.Size = new System.Drawing.Size(64, 22);
            this.firstNameToolStripLabel.Text = "FirstName:";
            // 
            // firstNameToolStripTextBox
            // 
            this.firstNameToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.firstNameToolStripTextBox.Name = "firstNameToolStripTextBox";
            this.firstNameToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // purposeforTravelToolStripLabel
            // 
            this.purposeforTravelToolStripLabel.Name = "purposeforTravelToolStripLabel";
            this.purposeforTravelToolStripLabel.Size = new System.Drawing.Size(98, 22);
            this.purposeforTravelToolStripLabel.Text = "PurposeforTravel:";
            // 
            // purposeforTravelToolStripTextBox
            // 
            this.purposeforTravelToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.purposeforTravelToolStripTextBox.Name = "purposeforTravelToolStripTextBox";
            this.purposeforTravelToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // locationToolStripLabel
            // 
            this.locationToolStripLabel.Name = "locationToolStripLabel";
            this.locationToolStripLabel.Size = new System.Drawing.Size(56, 22);
            this.locationToolStripLabel.Text = "Location:";
            // 
            // locationToolStripTextBox
            // 
            this.locationToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.locationToolStripTextBox.Name = "locationToolStripTextBox";
            this.locationToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // tripDatesToolStripLabel
            // 
            this.tripDatesToolStripLabel.Name = "tripDatesToolStripLabel";
            this.tripDatesToolStripLabel.Size = new System.Drawing.Size(58, 22);
            this.tripDatesToolStripLabel.Text = "TripDates:";
            // 
            // tripDatesToolStripTextBox
            // 
            this.tripDatesToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tripDatesToolStripTextBox.Name = "tripDatesToolStripTextBox";
            this.tripDatesToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillBynameToolStripButton
            // 
            this.fillBynameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBynameToolStripButton.Name = "fillBynameToolStripButton";
            this.fillBynameToolStripButton.Size = new System.Drawing.Size(69, 22);
            this.fillBynameToolStripButton.Text = "FillByname";
            this.fillBynameToolStripButton.Click += new System.EventHandler(this.fillBynameToolStripButton_Click);
            // 
            // travelRequestsTableAdapter
            // 
            this.travelRequestsTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 492);
            this.Controls.Add(this.fillBynameToolStrip);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelRequestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.fillBynameToolStrip.ResumeLayout(false);
            this.fillBynameToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private TravelDataSet travelDataSet;
        private System.Windows.Forms.BindingSource travelRequestsBindingSource;
        private TravelDataSetTableAdapters.TravelRequestsTableAdapter travelRequestsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purposeforTravelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tripDatesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn travelCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.ToolStrip fillBynameToolStrip;
        private System.Windows.Forms.ToolStripLabel lastNameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox lastNameToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel firstNameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox firstNameToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel purposeforTravelToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox purposeforTravelToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel locationToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox locationToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel tripDatesToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox tripDatesToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillBynameToolStripButton;
    }
}

