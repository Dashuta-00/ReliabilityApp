
namespace НадёжностьЭлементов
{
    partial class ElementsForm
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
            this.labelListOfElement = new System.Windows.Forms.Label();
            this.elementListBox = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonRedact = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelListOfElement
            // 
            this.labelListOfElement.AutoSize = true;
            this.labelListOfElement.Location = new System.Drawing.Point(15, 17);
            this.labelListOfElement.Name = "labelListOfElement";
            this.labelListOfElement.Size = new System.Drawing.Size(159, 20);
            this.labelListOfElement.TabIndex = 0;
            this.labelListOfElement.Text = "Список резисторов:";
            // 
            // elementListBox
            // 
            this.elementListBox.FormattingEnabled = true;
            this.elementListBox.ItemHeight = 20;
            this.elementListBox.Location = new System.Drawing.Point(15, 43);
            this.elementListBox.Name = "elementListBox";
            this.elementListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.elementListBox.Size = new System.Drawing.Size(156, 204);
            this.elementListBox.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(178, 43);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(146, 42);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(178, 91);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(146, 42);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(178, 204);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(146, 42);
            this.buttonAccept.TabIndex = 2;
            this.buttonAccept.Text = "Принять";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // buttonRedact
            // 
            this.buttonRedact.Location = new System.Drawing.Point(178, 140);
            this.buttonRedact.Name = "buttonRedact";
            this.buttonRedact.Size = new System.Drawing.Size(146, 42);
            this.buttonRedact.TabIndex = 2;
            this.buttonRedact.Text = "Редактировать";
            this.buttonRedact.UseVisualStyleBackColor = true;
            this.buttonRedact.Click += new System.EventHandler(this.buttonRedact_Click);
            // 
            // ElementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 258);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.buttonRedact);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.elementListBox);
            this.Controls.Add(this.labelListOfElement);
            this.Name = "ElementsForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelListOfElement;
        private System.Windows.Forms.ListBox elementListBox;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonRedact;
    }
}