
namespace НадёжностьЭлементов
{
    partial class DB
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.databaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new НадёжностьЭлементов.DatabaseDataSet();
            this.DBdataGridView = new System.Windows.Forms.DataGridView();
            this.resistorsTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.resistorsTableBindingSource = new НадёжностьЭлементов.resistorsTableBindingSource();
            this.databaseSet1 = new НадёжностьЭлементов.DatabaseSet1();
            this.capacitorsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.capacitorsTableTableAdapter = new НадёжностьЭлементов.DatabaseSet1TableAdapters.CapacitorsTableTableAdapter();
            this.resistorsTableTableAdapter = new НадёжностьЭлементов.resistorsTableBindingSourceTableAdapters.ResistorsTableTableAdapter();
            this.resistorsTableBindingSourceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resistorsTableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ElementsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.ButtonSaveChanges = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resistorsTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resistorsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capacitorsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resistorsTableBindingSourceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resistorsTableBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // databaseDataSetBindingSource
            // 
            this.databaseDataSetBindingSource.DataSource = this.databaseDataSet;
            this.databaseDataSetBindingSource.Position = 0;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DBdataGridView
            // 
            this.DBdataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DBdataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DBdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DBdataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.DBdataGridView.Location = new System.Drawing.Point(25, 89);
            this.DBdataGridView.Name = "DBdataGridView";
            this.DBdataGridView.ReadOnly = true;
            this.DBdataGridView.RowHeadersWidth = 62;
            this.DBdataGridView.RowTemplate.Height = 28;
            this.DBdataGridView.Size = new System.Drawing.Size(680, 500);
            this.DBdataGridView.TabIndex = 0;
            // 
            // resistorsTableBindingSource1
            // 
            this.resistorsTableBindingSource1.DataMember = "ResistorsTable";
            this.resistorsTableBindingSource1.DataSource = this.resistorsTableBindingSource;
            // 
            // resistorsTableBindingSource
            // 
            this.resistorsTableBindingSource.DataSetName = "resistorsTableBindingSource";
            this.resistorsTableBindingSource.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // databaseSet1
            // 
            this.databaseSet1.DataSetName = "DatabaseSet1";
            this.databaseSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // capacitorsTableBindingSource
            // 
            this.capacitorsTableBindingSource.DataMember = "CapacitorsTable";
            this.capacitorsTableBindingSource.DataSource = this.databaseSet1;
            // 
            // capacitorsTableTableAdapter
            // 
            this.capacitorsTableTableAdapter.ClearBeforeFill = true;
            // 
            // resistorsTableTableAdapter
            // 
            this.resistorsTableTableAdapter.ClearBeforeFill = true;
            // 
            // resistorsTableBindingSourceBindingSource
            // 
            this.resistorsTableBindingSourceBindingSource.DataSource = this.resistorsTableBindingSource;
            this.resistorsTableBindingSourceBindingSource.Position = 0;
            // 
            // resistorsTableBindingSource2
            // 
            this.resistorsTableBindingSource2.DataMember = "ResistorsTable";
            this.resistorsTableBindingSource2.DataSource = this.resistorsTableBindingSourceBindingSource;
            // 
            // ElementsComboBox
            // 
            this.ElementsComboBox.FormattingEnabled = true;
            this.ElementsComboBox.Location = new System.Drawing.Point(195, 44);
            this.ElementsComboBox.Name = "ElementsComboBox";
            this.ElementsComboBox.Size = new System.Drawing.Size(489, 28);
            this.ElementsComboBox.TabIndex = 1;
            this.ElementsComboBox.SelectedIndexChanged += new System.EventHandler(this.ElementsComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите элемент:";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(25, 608);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(263, 46);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Удалить выбранную строку";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // ButtonSaveChanges
            // 
            this.ButtonSaveChanges.Location = new System.Drawing.Point(294, 608);
            this.ButtonSaveChanges.Name = "ButtonSaveChanges";
            this.ButtonSaveChanges.Size = new System.Drawing.Size(190, 46);
            this.ButtonSaveChanges.TabIndex = 4;
            this.ButtonSaveChanges.Text = "Сохранить изменения";
            this.ButtonSaveChanges.UseVisualStyleBackColor = true;
            this.ButtonSaveChanges.Visible = false;
            this.ButtonSaveChanges.Click += new System.EventHandler(this.ButtonSaveChanges_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(559, 608);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(146, 46);
            this.ButtonBack.TabIndex = 5;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // DB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 666);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonSaveChanges);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ElementsComboBox);
            this.Controls.Add(this.DBdataGridView);
            this.Name = "DB";
            this.Text = "Просмотр базы данных";
            this.Load += new System.EventHandler(this.DB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resistorsTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resistorsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capacitorsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resistorsTableBindingSourceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resistorsTableBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource databaseDataSetBindingSource;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.DataGridView DBdataGridView;
        private DatabaseSet1 databaseSet1;
        private System.Windows.Forms.BindingSource capacitorsTableBindingSource;
        private DatabaseSet1TableAdapters.CapacitorsTableTableAdapter capacitorsTableTableAdapter;
        private resistorsTableBindingSource resistorsTableBindingSource;
        private System.Windows.Forms.BindingSource resistorsTableBindingSource1;
        private resistorsTableBindingSourceTableAdapters.ResistorsTableTableAdapter resistorsTableTableAdapter;
        private System.Windows.Forms.BindingSource resistorsTableBindingSourceBindingSource;
        private System.Windows.Forms.BindingSource resistorsTableBindingSource2;
        private System.Windows.Forms.ComboBox ElementsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button ButtonSaveChanges;
        private System.Windows.Forms.Button ButtonBack;
    }
}