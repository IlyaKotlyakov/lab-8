namespace XMLGUI
{
    partial class XMLViewer
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workTree = new System.Windows.Forms.TreeView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.filterToolStripMenuItem,
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem1});
            this.saveToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(74, 32);
            this.saveToolStripMenuItem.Text = "Файл";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.loadToolStripMenuItem.Text = "Загрузить";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Enabled = false;
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem1.Text = "Сохранить";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.SaveToolStripMenuItem1_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setFilterToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.filterToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(83, 32);
            this.filterToolStripMenuItem.Text = "Поиск";
            // 
            // setFilterToolStripMenuItem
            // 
            this.setFilterToolStripMenuItem.Enabled = false;
            this.setFilterToolStripMenuItem.Name = "setFilterToolStripMenuItem";
            this.setFilterToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.setFilterToolStripMenuItem.Text = "Параметр поиска";
            this.setFilterToolStripMenuItem.Click += new System.EventHandler(this.OnSetFilterClick);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Enabled = false;
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.clearToolStripMenuItem.Text = "Очистить поиск";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.ClearToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readerToolStripMenuItem,
            this.bookToolStripMenuItem});
            this.addToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(105, 32);
            this.addToolStripMenuItem.Text = "Вставить";
            // 
            // readerToolStripMenuItem
            // 
            this.readerToolStripMenuItem.Enabled = false;
            this.readerToolStripMenuItem.Name = "readerToolStripMenuItem";
            this.readerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.readerToolStripMenuItem.Text = "Новый читатель";
            this.readerToolStripMenuItem.Click += new System.EventHandler(this.ReaderToolStripMenuItem_Click);
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.Enabled = false;
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bookToolStripMenuItem.Text = "Новая Книга";
            this.bookToolStripMenuItem.Click += new System.EventHandler(this.BookToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Enabled = false;
            this.deleteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(99, 32);
            this.deleteToolStripMenuItem.Text = "Удалить";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click_1);
            // 
            // workTree
            // 
            this.workTree.AllowDrop = true;
            this.workTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workTree.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workTree.Location = new System.Drawing.Point(0, 36);
            this.workTree.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.workTree.Name = "workTree";
            this.workTree.Size = new System.Drawing.Size(800, 414);
            this.workTree.TabIndex = 2;
            // 
            // XMLViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.workTree);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "XMLViewer";
            this.Text = "Библиотека";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.TreeView workTree;
        private System.Windows.Forms.ToolStripMenuItem readerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}

