namespace HomeCinema
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label idManufacturerLabel;
            System.Windows.Forms.Label permissionLabel;
            System.Windows.Forms.Label brightnessLabel;
            System.Windows.Forms.Label contrastLabel;
            this.homeCinemaDataSet = new HomeCinema.HomeCinemaDataSet();
            this.homeCinemaSpecificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.homeCinemaSpecificationTableAdapter = new HomeCinema.HomeCinemaDataSetTableAdapters.HomeCinemaSpecificationTableAdapter();
            this.tableAdapterManager = new HomeCinema.HomeCinemaDataSetTableAdapters.TableAdapterManager();
            this.homeCinemaSpecificationBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.homeCinemaSpecificationBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.homeCinemaManufacturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.homeCinemaManufacturerTableAdapter = new HomeCinema.HomeCinemaDataSetTableAdapters.HomeCinemaManufacturerTableAdapter();
            this.homeCinemaManufacturerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeCinemaSpecificationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.homeCinemaSpecificationDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.permissionTextBox = new System.Windows.Forms.TextBox();
            this.brightnessTextBox = new System.Windows.Forms.TextBox();
            this.contrastTextBox = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            idManufacturerLabel = new System.Windows.Forms.Label();
            permissionLabel = new System.Windows.Forms.Label();
            brightnessLabel = new System.Windows.Forms.Label();
            contrastLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.homeCinemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeCinemaSpecificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeCinemaSpecificationBindingNavigator)).BeginInit();
            this.homeCinemaSpecificationBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeCinemaManufacturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeCinemaManufacturerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeCinemaSpecificationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeCinemaSpecificationDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // homeCinemaDataSet
            // 
            this.homeCinemaDataSet.DataSetName = "HomeCinemaDataSet";
            this.homeCinemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // homeCinemaSpecificationBindingSource
            // 
            this.homeCinemaSpecificationBindingSource.DataMember = "HomeCinemaSpecification";
            this.homeCinemaSpecificationBindingSource.DataSource = this.homeCinemaDataSet;
            // 
            // homeCinemaSpecificationTableAdapter
            // 
            this.homeCinemaSpecificationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.HomeCinemaManufacturerTableAdapter = this.homeCinemaManufacturerTableAdapter;
            this.tableAdapterManager.HomeCinemaSpecificationTableAdapter = this.homeCinemaSpecificationTableAdapter;
            this.tableAdapterManager.UpdateOrder = HomeCinema.HomeCinemaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // homeCinemaSpecificationBindingNavigator
            // 
            this.homeCinemaSpecificationBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.homeCinemaSpecificationBindingNavigator.BindingSource = this.homeCinemaSpecificationBindingSource;
            this.homeCinemaSpecificationBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.homeCinemaSpecificationBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.homeCinemaSpecificationBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.homeCinemaSpecificationBindingNavigatorSaveItem});
            this.homeCinemaSpecificationBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.homeCinemaSpecificationBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.homeCinemaSpecificationBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.homeCinemaSpecificationBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.homeCinemaSpecificationBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.homeCinemaSpecificationBindingNavigator.Name = "homeCinemaSpecificationBindingNavigator";
            this.homeCinemaSpecificationBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.homeCinemaSpecificationBindingNavigator.Size = new System.Drawing.Size(916, 25);
            this.homeCinemaSpecificationBindingNavigator.TabIndex = 0;
            this.homeCinemaSpecificationBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // homeCinemaSpecificationBindingNavigatorSaveItem
            // 
            this.homeCinemaSpecificationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.homeCinemaSpecificationBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("homeCinemaSpecificationBindingNavigatorSaveItem.Image")));
            this.homeCinemaSpecificationBindingNavigatorSaveItem.Name = "homeCinemaSpecificationBindingNavigatorSaveItem";
            this.homeCinemaSpecificationBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.homeCinemaSpecificationBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.homeCinemaSpecificationBindingNavigatorSaveItem.Click += new System.EventHandler(this.homeCinemaSpecificationBindingNavigatorSaveItem_Click);
            // 
            // homeCinemaManufacturerBindingSource
            // 
            this.homeCinemaManufacturerBindingSource.DataMember = "HomeCinemaManufacturer";
            this.homeCinemaManufacturerBindingSource.DataSource = this.homeCinemaDataSet;
            // 
            // homeCinemaManufacturerTableAdapter
            // 
            this.homeCinemaManufacturerTableAdapter.ClearBeforeFill = true;
            // 
            // homeCinemaManufacturerDataGridView
            // 
            this.homeCinemaManufacturerDataGridView.AutoGenerateColumns = false;
            this.homeCinemaManufacturerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.homeCinemaManufacturerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.homeCinemaManufacturerDataGridView.DataSource = this.homeCinemaManufacturerBindingSource;
            this.homeCinemaManufacturerDataGridView.Location = new System.Drawing.Point(0, 28);
            this.homeCinemaManufacturerDataGridView.Name = "homeCinemaManufacturerDataGridView";
            this.homeCinemaManufacturerDataGridView.Size = new System.Drawing.Size(243, 220);
            this.homeCinemaManufacturerDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "manufacturer";
            this.dataGridViewTextBoxColumn2.HeaderText = "manufacturer";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // homeCinemaSpecificationBindingSource1
            // 
            this.homeCinemaSpecificationBindingSource1.DataMember = "FK_HomeCinemaSpecification_HomeCinemaManufacturer";
            this.homeCinemaSpecificationBindingSource1.DataSource = this.homeCinemaManufacturerBindingSource;
            // 
            // homeCinemaSpecificationDataGridView
            // 
            this.homeCinemaSpecificationDataGridView.AutoGenerateColumns = false;
            this.homeCinemaSpecificationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.homeCinemaSpecificationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.homeCinemaSpecificationDataGridView.DataSource = this.homeCinemaSpecificationBindingSource1;
            this.homeCinemaSpecificationDataGridView.Location = new System.Drawing.Point(351, 28);
            this.homeCinemaSpecificationDataGridView.Name = "homeCinemaSpecificationDataGridView";
            this.homeCinemaSpecificationDataGridView.Size = new System.Drawing.Size(545, 220);
            this.homeCinemaSpecificationDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn3.HeaderText = "id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "idManufacturer";
            this.dataGridViewTextBoxColumn4.HeaderText = "idManufacturer";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "permission";
            this.dataGridViewTextBoxColumn5.HeaderText = "permission";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "brightness";
            this.dataGridViewTextBoxColumn6.HeaderText = "brightness";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "contrast";
            this.dataGridViewTextBoxColumn7.HeaderText = "contrast";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // idManufacturerLabel
            // 
            idManufacturerLabel.AutoSize = true;
            idManufacturerLabel.Location = new System.Drawing.Point(354, 300);
            idManufacturerLabel.Name = "idManufacturerLabel";
            idManufacturerLabel.Size = new System.Drawing.Size(84, 13);
            idManufacturerLabel.TabIndex = 5;
            idManufacturerLabel.Text = "id Manufacturer:";
            // 
            // idManufacturerTextBox
            // 
            this.idManufacturerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.homeCinemaSpecificationBindingSource1, "idManufacturer", true));
            this.idManufacturerTextBox.Location = new System.Drawing.Point(444, 297);
            this.idManufacturerTextBox.Name = "idManufacturerTextBox";
            this.idManufacturerTextBox.Size = new System.Drawing.Size(100, 20);
            this.idManufacturerTextBox.TabIndex = 6;
            // 
            // permissionLabel
            // 
            permissionLabel.AutoSize = true;
            permissionLabel.Location = new System.Drawing.Point(354, 326);
            permissionLabel.Name = "permissionLabel";
            permissionLabel.Size = new System.Drawing.Size(59, 13);
            permissionLabel.TabIndex = 7;
            permissionLabel.Text = "permission:";
            // 
            // permissionTextBox
            // 
            this.permissionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.homeCinemaSpecificationBindingSource1, "permission", true));
            this.permissionTextBox.Location = new System.Drawing.Point(444, 323);
            this.permissionTextBox.Name = "permissionTextBox";
            this.permissionTextBox.Size = new System.Drawing.Size(100, 20);
            this.permissionTextBox.TabIndex = 8;
            // 
            // brightnessLabel
            // 
            brightnessLabel.AutoSize = true;
            brightnessLabel.Location = new System.Drawing.Point(354, 352);
            brightnessLabel.Name = "brightnessLabel";
            brightnessLabel.Size = new System.Drawing.Size(58, 13);
            brightnessLabel.TabIndex = 9;
            brightnessLabel.Text = "brightness:";
            // 
            // brightnessTextBox
            // 
            this.brightnessTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.homeCinemaSpecificationBindingSource1, "brightness", true));
            this.brightnessTextBox.Location = new System.Drawing.Point(444, 349);
            this.brightnessTextBox.Name = "brightnessTextBox";
            this.brightnessTextBox.Size = new System.Drawing.Size(100, 20);
            this.brightnessTextBox.TabIndex = 10;
            // 
            // contrastLabel
            // 
            contrastLabel.AutoSize = true;
            contrastLabel.Location = new System.Drawing.Point(354, 378);
            contrastLabel.Name = "contrastLabel";
            contrastLabel.Size = new System.Drawing.Size(48, 13);
            contrastLabel.TabIndex = 11;
            contrastLabel.Text = "contrast:";
            // 
            // contrastTextBox
            // 
            this.contrastTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.homeCinemaSpecificationBindingSource1, "contrast", true));
            this.contrastTextBox.Location = new System.Drawing.Point(444, 375);
            this.contrastTextBox.Name = "contrastTextBox";
            this.contrastTextBox.Size = new System.Drawing.Size(100, 20);
            this.contrastTextBox.TabIndex = 12;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(317, 437);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 13;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(413, 437);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(508, 437);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 15;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(599, 437);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 16;
            this.buttonUpdate.Text = "Применить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 485);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(idManufacturerLabel);
            this.Controls.Add(this.idManufacturerTextBox);
            this.Controls.Add(permissionLabel);
            this.Controls.Add(this.permissionTextBox);
            this.Controls.Add(brightnessLabel);
            this.Controls.Add(this.brightnessTextBox);
            this.Controls.Add(contrastLabel);
            this.Controls.Add(this.contrastTextBox);
            this.Controls.Add(this.homeCinemaSpecificationDataGridView);
            this.Controls.Add(this.homeCinemaManufacturerDataGridView);
            this.Controls.Add(this.homeCinemaSpecificationBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.homeCinemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeCinemaSpecificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeCinemaSpecificationBindingNavigator)).EndInit();
            this.homeCinemaSpecificationBindingNavigator.ResumeLayout(false);
            this.homeCinemaSpecificationBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeCinemaManufacturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeCinemaManufacturerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeCinemaSpecificationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeCinemaSpecificationDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HomeCinemaDataSet homeCinemaDataSet;
        private System.Windows.Forms.BindingSource homeCinemaSpecificationBindingSource;
        private HomeCinemaDataSetTableAdapters.HomeCinemaSpecificationTableAdapter homeCinemaSpecificationTableAdapter;
        private HomeCinemaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator homeCinemaSpecificationBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton homeCinemaSpecificationBindingNavigatorSaveItem;
        private HomeCinemaDataSetTableAdapters.HomeCinemaManufacturerTableAdapter homeCinemaManufacturerTableAdapter;
        private System.Windows.Forms.BindingSource homeCinemaManufacturerBindingSource;
        private System.Windows.Forms.DataGridView homeCinemaManufacturerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource homeCinemaSpecificationBindingSource1;
        private System.Windows.Forms.DataGridView homeCinemaSpecificationDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox idManufacturerTextBox;
        private System.Windows.Forms.TextBox permissionTextBox;
        private System.Windows.Forms.TextBox brightnessTextBox;
        private System.Windows.Forms.TextBox contrastTextBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonUpdate;
    }
}

