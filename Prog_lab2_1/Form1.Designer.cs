namespace Prog_lab2_1
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.addNewNode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 12);
            this.listBox.Name = "listBox";
            this.listBox.ScrollAlwaysVisible = true;
            this.listBox.Size = new System.Drawing.Size(348, 160);
            this.listBox.TabIndex = 0;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // propertyGrid
            // 
            this.propertyGrid.Location = new System.Drawing.Point(12, 215);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.PropertySort = System.Windows.Forms.PropertySort.Categorized;
            this.propertyGrid.Size = new System.Drawing.Size(348, 196);
            this.propertyGrid.TabIndex = 1;
            // 
            // addNewNode
            // 
            this.addNewNode.Location = new System.Drawing.Point(97, 178);
            this.addNewNode.Name = "addNewNode";
            this.addNewNode.Size = new System.Drawing.Size(169, 23);
            this.addNewNode.TabIndex = 2;
            this.addNewNode.Text = "Добавить новое событие";
            this.addNewNode.UseVisualStyleBackColor = true;
            this.addNewNode.Click += new System.EventHandler(this.addNewNode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 442);
            this.Controls.Add(this.addNewNode);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.propertyGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        internal System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.Button addNewNode;
    }
}

