namespace lab3
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newAuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPublisherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.udcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workplaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scienceDegreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UdcId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublisherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addPublication = new System.Windows.Forms.Button();
            this.removePublication = new System.Windows.Forms.Button();
            this.prevBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.lblPageNumber = new System.Windows.Forms.Label();
            this.change = new System.Windows.Forms.Button();
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countPagesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publicationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAuthorToolStripMenuItem,
            this.newPublisherToolStripMenuItem,
            this.udcToolStripMenuItem,
            this.workplaceToolStripMenuItem,
            this.scienceDegreeToolStripMenuItem,
            this.genreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(685, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newAuthorToolStripMenuItem
            // 
            this.newAuthorToolStripMenuItem.Name = "newAuthorToolStripMenuItem";
            this.newAuthorToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.newAuthorToolStripMenuItem.Text = "Авторы";
            this.newAuthorToolStripMenuItem.Click += new System.EventHandler(this.newAuthorToolStripMenuItem_Click);
            // 
            // newPublisherToolStripMenuItem
            // 
            this.newPublisherToolStripMenuItem.Name = "newPublisherToolStripMenuItem";
            this.newPublisherToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.newPublisherToolStripMenuItem.Text = "Издательства";
            this.newPublisherToolStripMenuItem.Click += new System.EventHandler(this.newPublisherToolStripMenuItem_Click);
            // 
            // udcToolStripMenuItem
            // 
            this.udcToolStripMenuItem.Name = "udcToolStripMenuItem";
            this.udcToolStripMenuItem.Size = new System.Drawing.Size(41, 22);
            this.udcToolStripMenuItem.Text = "УДК";
            this.udcToolStripMenuItem.Click += new System.EventHandler(this.udcToolStripMenuItem_Click);
            // 
            // workplaceToolStripMenuItem
            // 
            this.workplaceToolStripMenuItem.Name = "workplaceToolStripMenuItem";
            this.workplaceToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.workplaceToolStripMenuItem.Text = "Места работы";
            this.workplaceToolStripMenuItem.Click += new System.EventHandler(this.workplaceToolStripMenuItem_Click);
            // 
            // scienceDegreeToolStripMenuItem
            // 
            this.scienceDegreeToolStripMenuItem.Name = "scienceDegreeToolStripMenuItem";
            this.scienceDegreeToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.scienceDegreeToolStripMenuItem.Text = "Ученые степени";
            this.scienceDegreeToolStripMenuItem.Click += new System.EventHandler(this.scienceDegreeToolStripMenuItem_Click);
            // 
            // genreToolStripMenuItem
            // 
            this.genreToolStripMenuItem.Name = "genreToolStripMenuItem";
            this.genreToolStripMenuItem.Size = new System.Drawing.Size(59, 22);
            this.genreToolStripMenuItem.Text = "Жанры";
            this.genreToolStripMenuItem.Click += new System.EventHandler(this.genreToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.countPagesDataGridViewTextBoxColumn,
            this.UdcId,
            this.PublisherId,
            this.creationDateDataGridViewTextBoxColumn,
            this.doiDataGridViewTextBoxColumn,
            this.authorsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.publicationBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(685, 234);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // UdcId
            // 
            this.UdcId.DataPropertyName = "UdcId";
            this.UdcId.HeaderText = "УДК";
            this.UdcId.Name = "UdcId";
            this.UdcId.ReadOnly = true;
            // 
            // PublisherId
            // 
            this.PublisherId.DataPropertyName = "PublisherId";
            this.PublisherId.HeaderText = "Издательство";
            this.PublisherId.Name = "PublisherId";
            this.PublisherId.ReadOnly = true;
            // 
            // authorsDataGridViewTextBoxColumn
            // 
            this.authorsDataGridViewTextBoxColumn.DataPropertyName = "AuthorsIds";
            this.authorsDataGridViewTextBoxColumn.HeaderText = "Авторы";
            this.authorsDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.authorsDataGridViewTextBoxColumn.Name = "authorsDataGridViewTextBoxColumn";
            this.authorsDataGridViewTextBoxColumn.ReadOnly = true;
            this.authorsDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.authorsDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.authorsDataGridViewTextBoxColumn.Width = 200;
            // 
            // addPublication
            // 
            this.addPublication.Location = new System.Drawing.Point(13, 269);
            this.addPublication.Name = "addPublication";
            this.addPublication.Size = new System.Drawing.Size(114, 23);
            this.addPublication.TabIndex = 2;
            this.addPublication.Text = "Добавить работу";
            this.addPublication.UseVisualStyleBackColor = true;
            this.addPublication.Click += new System.EventHandler(this.addPublication_Click);
            // 
            // removePublication
            // 
            this.removePublication.Location = new System.Drawing.Point(133, 269);
            this.removePublication.Name = "removePublication";
            this.removePublication.Size = new System.Drawing.Size(113, 23);
            this.removePublication.TabIndex = 3;
            this.removePublication.Text = "Удалить работу";
            this.removePublication.UseVisualStyleBackColor = true;
            this.removePublication.Click += new System.EventHandler(this.removePublication_Click);
            // 
            // prevBtn
            // 
            this.prevBtn.Location = new System.Drawing.Point(502, 269);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(35, 23);
            this.prevBtn.TabIndex = 4;
            this.prevBtn.Text = "<";
            this.prevBtn.UseVisualStyleBackColor = true;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(638, 269);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(35, 23);
            this.nextBtn.TabIndex = 5;
            this.nextBtn.Text = ">";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // lblPageNumber
            // 
            this.lblPageNumber.Location = new System.Drawing.Point(543, 271);
            this.lblPageNumber.Name = "lblPageNumber";
            this.lblPageNumber.Size = new System.Drawing.Size(89, 18);
            this.lblPageNumber.TabIndex = 6;
            this.lblPageNumber.Text = "Страница 0/0";
            this.lblPageNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(253, 269);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(202, 23);
            this.change.TabIndex = 7;
            this.change.Text = "Просмотр/изменение публикации";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // authorsBindingSource
            // 
            this.authorsBindingSource.DataMember = "AuthorsIds";
            this.authorsBindingSource.DataSource = this.publicationBindingSource;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Название";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countPagesDataGridViewTextBoxColumn
            // 
            this.countPagesDataGridViewTextBoxColumn.DataPropertyName = "CountPages";
            this.countPagesDataGridViewTextBoxColumn.HeaderText = "Количество страниц";
            this.countPagesDataGridViewTextBoxColumn.Name = "countPagesDataGridViewTextBoxColumn";
            this.countPagesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // creationDateDataGridViewTextBoxColumn
            // 
            this.creationDateDataGridViewTextBoxColumn.DataPropertyName = "CreationDate";
            this.creationDateDataGridViewTextBoxColumn.HeaderText = "Дата создания";
            this.creationDateDataGridViewTextBoxColumn.Name = "creationDateDataGridViewTextBoxColumn";
            this.creationDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doiDataGridViewTextBoxColumn
            // 
            this.doiDataGridViewTextBoxColumn.DataPropertyName = "Doi";
            this.doiDataGridViewTextBoxColumn.HeaderText = "DOI";
            this.doiDataGridViewTextBoxColumn.Name = "doiDataGridViewTextBoxColumn";
            this.doiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // publicationBindingSource
            // 
            this.publicationBindingSource.DataSource = typeof(lab3.Work);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 304);
            this.Controls.Add(this.change);
            this.Controls.Add(this.lblPageNumber);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.removePublication);
            this.Controls.Add(this.addPublication);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newAuthorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPublisherToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource publicationBindingSource;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private System.Windows.Forms.Button addPublication;
        private System.Windows.Forms.Button removePublication;
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Label lblPageNumber;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.ToolStripMenuItem udcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workplaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scienceDegreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genreToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countPagesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UdcId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublisherId;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorsDataGridViewTextBoxColumn;
    }
}

