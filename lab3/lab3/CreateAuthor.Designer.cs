namespace lab3
{
    partial class CreateAuthor
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
            this.label2 = new System.Windows.Forms.Label();
            this.fullName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.work = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.scienceDegree = new System.Windows.Forms.TextBox();
            this.citationIndex = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.create = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.citationIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ФИО (латинские и кириллица)";
            // 
            // fullName
            // 
            this.fullName.Location = new System.Drawing.Point(31, 42);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(159, 20);
            this.fullName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Место работы";
            // 
            // work
            // 
            this.work.Location = new System.Drawing.Point(219, 42);
            this.work.Name = "work";
            this.work.Size = new System.Drawing.Size(148, 20);
            this.work.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Научная степень";
            // 
            // scienceDegree
            // 
            this.scienceDegree.Location = new System.Drawing.Point(398, 42);
            this.scienceDegree.Name = "scienceDegree";
            this.scienceDegree.Size = new System.Drawing.Size(137, 20);
            this.scienceDegree.TabIndex = 7;
            // 
            // citationIndex
            // 
            this.citationIndex.Location = new System.Drawing.Point(31, 109);
            this.citationIndex.Maximum = new decimal(new int[] {
            3000000,
            0,
            0,
            0});
            this.citationIndex.Name = "citationIndex";
            this.citationIndex.Size = new System.Drawing.Size(159, 20);
            this.citationIndex.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Индекс цитируемости";
            // 
            // date
            // 
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(219, 110);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(148, 20);
            this.date.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Дата рождения";
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(398, 108);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(137, 23);
            this.create.TabIndex = 20;
            this.create.Text = "Создать";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // CreateAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 165);
            this.Controls.Add(this.create);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.citationIndex);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.scienceDegree);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.work);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fullName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CreateAuthor";
            this.Text = "Новый автор";
            ((System.ComponentModel.ISupportInitialize)(this.citationIndex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox work;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox scienceDegree;
        private System.Windows.Forms.NumericUpDown citationIndex;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button create;
    }
}