namespace lab3
{
    partial class CreatePublication
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
            this.label1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.doi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.publisher = new System.Windows.Forms.ComboBox();
            this.count = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.create = new System.Windows.Forms.Button();
            this.authorslist = new System.Windows.Forms.ListBox();
            this.publisherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.udc = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(29, 46);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(137, 20);
            this.title.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название публикации";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Код DOI";
            // 
            // doi
            // 
            this.doi.Location = new System.Drawing.Point(29, 103);
            this.doi.Name = "doi";
            this.doi.Size = new System.Drawing.Size(137, 20);
            this.doi.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(395, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "УДК";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(395, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Количество страниц";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Дата создания";
            // 
            // date
            // 
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(209, 43);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(148, 20);
            this.date.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(206, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Издательство";
            // 
            // publisher
            // 
            this.publisher.DisplayMember = "Place";
            this.publisher.FormattingEnabled = true;
            this.publisher.Location = new System.Drawing.Point(209, 102);
            this.publisher.Name = "publisher";
            this.publisher.Size = new System.Drawing.Size(148, 21);
            this.publisher.TabIndex = 12;
            this.publisher.ValueMember = "Id";
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(398, 43);
            this.count.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(148, 20);
            this.count.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(578, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Авторы (выделить нужных)";
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(29, 145);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(75, 23);
            this.create.TabIndex = 18;
            this.create.Text = "Создать";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // authorslist
            // 
            this.authorslist.DisplayMember = "FullName";
            this.authorslist.FormattingEnabled = true;
            this.authorslist.Location = new System.Drawing.Point(581, 42);
            this.authorslist.Name = "authorslist";
            this.authorslist.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.authorslist.Size = new System.Drawing.Size(148, 82);
            this.authorslist.TabIndex = 20;
            this.authorslist.ValueMember = "Id";
            // 
            // publisherBindingSource
            // 
            this.publisherBindingSource.DataSource = typeof(lab3.Publisher);
            // 
            // udc
            // 
            this.udc.DisplayMember = "Name";
            this.udc.FormattingEnabled = true;
            this.udc.Location = new System.Drawing.Point(398, 103);
            this.udc.Name = "udc";
            this.udc.Size = new System.Drawing.Size(148, 21);
            this.udc.TabIndex = 21;
            this.udc.ValueMember = "Id";
            // 
            // CreatePublication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 197);
            this.Controls.Add(this.udc);
            this.Controls.Add(this.authorslist);
            this.Controls.Add(this.create);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.count);
            this.Controls.Add(this.publisher);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.doi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CreatePublication";
            this.Text = "Публикация";
            this.Load += new System.EventHandler(this.CreatePublication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox doi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox publisher;
        private System.Windows.Forms.NumericUpDown count;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.BindingSource publisherBindingSource;
        private System.Windows.Forms.ListBox authorslist;
        private System.Windows.Forms.ComboBox udc;
    }
}