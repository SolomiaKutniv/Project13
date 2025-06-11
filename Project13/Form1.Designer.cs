namespace Project13
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
            this.listBoxWolves = new System.Windows.Forms.ListBox();
            this.radioButtonArrayList = new System.Windows.Forms.RadioButton();
            this.radioButtonGenericList = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIndex = new System.Windows.Forms.TextBox();
            this.btnShowElement = new System.Windows.Forms.Button();
            this.btnClone = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxWolves
            // 
            this.listBoxWolves.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxWolves.FormattingEnabled = true;
            this.listBoxWolves.ItemHeight = 18;
            this.listBoxWolves.Location = new System.Drawing.Point(10, 89);
            this.listBoxWolves.Name = "listBoxWolves";
            this.listBoxWolves.Size = new System.Drawing.Size(897, 184);
            this.listBoxWolves.TabIndex = 0;
            // 
            // radioButtonArrayList
            // 
            this.radioButtonArrayList.AutoSize = true;
            this.radioButtonArrayList.Location = new System.Drawing.Point(10, 48);
            this.radioButtonArrayList.Name = "radioButtonArrayList";
            this.radioButtonArrayList.Size = new System.Drawing.Size(80, 20);
            this.radioButtonArrayList.TabIndex = 1;
            this.radioButtonArrayList.TabStop = true;
            this.radioButtonArrayList.Text = "ArrayList";
            this.radioButtonArrayList.UseVisualStyleBackColor = true;
            // 
            // radioButtonGenericList
            // 
            this.radioButtonGenericList.AutoSize = true;
            this.radioButtonGenericList.Location = new System.Drawing.Point(135, 48);
            this.radioButtonGenericList.Name = "radioButtonGenericList";
            this.radioButtonGenericList.Size = new System.Drawing.Size(98, 20);
            this.radioButtonGenericList.TabIndex = 2;
            this.radioButtonGenericList.TabStop = true;
            this.radioButtonGenericList.Text = "Generic List";
            this.radioButtonGenericList.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введіть індекс:";
            // 
            // textBoxIndex
            // 
            this.textBoxIndex.Location = new System.Drawing.Point(117, 330);
            this.textBoxIndex.Name = "textBoxIndex";
            this.textBoxIndex.Size = new System.Drawing.Size(100, 22);
            this.textBoxIndex.TabIndex = 4;
            // 
            // btnShowElement
            // 
            this.btnShowElement.Location = new System.Drawing.Point(237, 323);
            this.btnShowElement.Name = "btnShowElement";
            this.btnShowElement.Size = new System.Drawing.Size(147, 36);
            this.btnShowElement.TabIndex = 5;
            this.btnShowElement.Text = "Показати елемент";
            this.btnShowElement.UseVisualStyleBackColor = true;
            this.btnShowElement.Click += new System.EventHandler(this.btnShowElement_Click);
            // 
            // btnClone
            // 
            this.btnClone.Location = new System.Drawing.Point(925, 98);
            this.btnClone.Name = "btnClone";
            this.btnClone.Size = new System.Drawing.Size(101, 48);
            this.btnClone.TabIndex = 6;
            this.btnClone.Text = "Клонувати";
            this.btnClone.UseVisualStyleBackColor = true;
            this.btnClone.Click += new System.EventHandler(this.btnClone_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(924, 193);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(102, 48);
            this.btnSort.TabIndex = 7;
            this.btnSort.Text = "Сортувати";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Оберіть варіант колекції:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(430, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Вивести інформацію про конкретного вовка:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 375);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnClone);
            this.Controls.Add(this.btnShowElement);
            this.Controls.Add(this.textBoxIndex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonGenericList);
            this.Controls.Add(this.radioButtonArrayList);
            this.Controls.Add(this.listBoxWolves);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxWolves;
        private System.Windows.Forms.RadioButton radioButtonArrayList;
        private System.Windows.Forms.RadioButton radioButtonGenericList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIndex;
        private System.Windows.Forms.Button btnShowElement;
        private System.Windows.Forms.Button btnClone;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}