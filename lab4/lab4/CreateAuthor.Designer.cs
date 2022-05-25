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
            this.label3 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.create = new System.Windows.Forms.Button();
            this.workplace = new System.Windows.Forms.ComboBox();
            this.scienceDegree = new System.Windows.Forms.ComboBox();
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Научная степень";
            // 
            // date
            // 
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(31, 109);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(148, 20);
            this.date.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Дата рождения";
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(131, 157);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(137, 23);
            this.create.TabIndex = 20;
            this.create.Text = "Создать";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // workplace
            // 
            this.workplace.DisplayMember = "Name";
            this.workplace.FormattingEnabled = true;
            this.workplace.Location = new System.Drawing.Point(219, 42);
            this.workplace.Name = "workplace";
            this.workplace.Size = new System.Drawing.Size(148, 21);
            this.workplace.TabIndex = 21;
            this.workplace.ValueMember = "Id";
            // 
            // scienceDegree
            // 
            this.scienceDegree.DisplayMember = "Name";
            this.scienceDegree.FormattingEnabled = true;
            this.scienceDegree.Location = new System.Drawing.Point(219, 108);
            this.scienceDegree.Name = "scienceDegree";
            this.scienceDegree.Size = new System.Drawing.Size(148, 21);
            this.scienceDegree.TabIndex = 22;
            this.scienceDegree.ValueMember = "Id";
            // 
            // CreateAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 204);
            this.Controls.Add(this.scienceDegree);
            this.Controls.Add(this.workplace);
            this.Controls.Add(this.create);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fullName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CreateAuthor";
            this.Text = "Новый автор";
            this.Load += new System.EventHandler(this.CreateAuthor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.ComboBox workplace;
        private System.Windows.Forms.ComboBox scienceDegree;
    }
}