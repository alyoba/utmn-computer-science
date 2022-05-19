namespace lab3
{
    partial class CreateWorkplace
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
            this.create = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.MaskedTextBox();
            this.label = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(131, 146);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(148, 23);
            this.create.TabIndex = 31;
            this.create.Text = "Создать";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Телефон";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Название";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(29, 46);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(159, 20);
            this.name.TabIndex = 21;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(217, 45);
            this.phone.Mask = "+00000000000";
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(148, 20);
            this.phone.TabIndex = 32;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(26, 85);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(38, 13);
            this.label.TabIndex = 34;
            this.label.Text = "Адрес";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(29, 102);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(336, 20);
            this.address.TabIndex = 35;
            // 
            // CreateWorkplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 194);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.create);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CreateWorkplace";
            this.Text = "Новое место работы";
            this.Load += new System.EventHandler(this.CreatePublisher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.MaskedTextBox phone;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox address;
    }
}