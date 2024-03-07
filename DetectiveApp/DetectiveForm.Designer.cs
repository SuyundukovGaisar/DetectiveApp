namespace DetectiveApp
{
    partial class DetectiveForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetectiveForm));
            this.split = new System.Windows.Forms.SplitContainer();
            this.pictureDetective = new System.Windows.Forms.PictureBox();
            this.treeDetective = new System.Windows.Forms.TreeView();
            this.dataGridCases = new System.Windows.Forms.DataGridView();
            this.dataGridSuspect = new System.Windows.Forms.DataGridView();
            this.dataGridDetectives = new System.Windows.Forms.DataGridView();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.Showbutton = new System.Windows.Forms.Button();
            this.Downloadbutton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.split)).BeginInit();
            this.split.Panel1.SuspendLayout();
            this.split.Panel2.SuspendLayout();
            this.split.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDetective)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSuspect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetectives)).BeginInit();
            this.SuspendLayout();
            // 
            // split
            // 
            this.split.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.split.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split.Location = new System.Drawing.Point(0, 0);
            this.split.Name = "split";
            // 
            // split.Panel1
            // 
            this.split.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.split.Panel1.Controls.Add(this.pictureDetective);
            this.split.Panel1.Controls.Add(this.treeDetective);
            this.split.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // split.Panel2
            // 
            this.split.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.split.Panel2.Controls.Add(this.dataGridCases);
            this.split.Panel2.Controls.Add(this.dataGridSuspect);
            this.split.Panel2.Controls.Add(this.dataGridDetectives);
            this.split.Panel2.Controls.Add(this.Exitbutton);
            this.split.Panel2.Controls.Add(this.Showbutton);
            this.split.Panel2.Controls.Add(this.Downloadbutton);
            this.split.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.split.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.split.Size = new System.Drawing.Size(800, 450);
            this.split.SplitterDistance = 242;
            this.split.SplitterWidth = 10;
            this.split.TabIndex = 0;
            // 
            // pictureDetective
            // 
            this.pictureDetective.Image = ((System.Drawing.Image)(resources.GetObject("pictureDetective.Image")));
            this.pictureDetective.Location = new System.Drawing.Point(3, 0);
            this.pictureDetective.Name = "pictureDetective";
            this.pictureDetective.Size = new System.Drawing.Size(236, 137);
            this.pictureDetective.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureDetective.TabIndex = 1;
            this.pictureDetective.TabStop = false;
            // 
            // treeDetective
            // 
            this.treeDetective.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeDetective.Location = new System.Drawing.Point(3, 146);
            this.treeDetective.Name = "treeDetective";
            this.treeDetective.Size = new System.Drawing.Size(236, 301);
            this.treeDetective.TabIndex = 0;
            this.treeDetective.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeDetective_AfterSelect);
            // 
            // dataGridCases
            // 
            this.dataGridCases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCases.Location = new System.Drawing.Point(3, 322);
            this.dataGridCases.Name = "dataGridCases";
            this.dataGridCases.RowHeadersWidth = 51;
            this.dataGridCases.RowTemplate.Height = 24;
            this.dataGridCases.Size = new System.Drawing.Size(543, 125);
            this.dataGridCases.TabIndex = 5;
            // 
            // dataGridSuspect
            // 
            this.dataGridSuspect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSuspect.Location = new System.Drawing.Point(3, 194);
            this.dataGridSuspect.Name = "dataGridSuspect";
            this.dataGridSuspect.RowHeadersWidth = 51;
            this.dataGridSuspect.RowTemplate.Height = 24;
            this.dataGridSuspect.Size = new System.Drawing.Size(542, 128);
            this.dataGridSuspect.TabIndex = 4;
            // 
            // dataGridDetectives
            // 
            this.dataGridDetectives.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDetectives.Location = new System.Drawing.Point(3, 71);
            this.dataGridDetectives.Name = "dataGridDetectives";
            this.dataGridDetectives.RowHeadersWidth = 51;
            this.dataGridDetectives.RowTemplate.Height = 24;
            this.dataGridDetectives.Size = new System.Drawing.Size(542, 123);
            this.dataGridDetectives.TabIndex = 3;
            // 
            // Exitbutton
            // 
            this.Exitbutton.Location = new System.Drawing.Point(362, 5);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(174, 64);
            this.Exitbutton.TabIndex = 2;
            this.Exitbutton.Text = "Выход";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // Showbutton
            // 
            this.Showbutton.Location = new System.Drawing.Point(191, 5);
            this.Showbutton.Name = "Showbutton";
            this.Showbutton.Size = new System.Drawing.Size(165, 64);
            this.Showbutton.TabIndex = 1;
            this.Showbutton.Text = "Показать";
            this.Showbutton.UseVisualStyleBackColor = true;
            this.Showbutton.Click += new System.EventHandler(this.Showbutton_Click);
            // 
            // Downloadbutton
            // 
            this.Downloadbutton.Location = new System.Drawing.Point(13, 5);
            this.Downloadbutton.Name = "Downloadbutton";
            this.Downloadbutton.Size = new System.Drawing.Size(172, 64);
            this.Downloadbutton.TabIndex = 0;
            this.Downloadbutton.Text = "Загрузить";
            this.Downloadbutton.UseVisualStyleBackColor = true;
            this.Downloadbutton.Click += new System.EventHandler(this.Downloadbutton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // DetectiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.split);
            this.Name = "DetectiveForm";
            this.Text = "DetectiveApp";
            this.split.Panel1.ResumeLayout(false);
            this.split.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split)).EndInit();
            this.split.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureDetective)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSuspect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetectives)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer split;
        private System.Windows.Forms.PictureBox pictureDetective;
        private System.Windows.Forms.TreeView treeDetective;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Button Showbutton;
        private System.Windows.Forms.Button Downloadbutton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DataGridView dataGridDetectives;
        private System.Windows.Forms.DataGridView dataGridCases;
        private System.Windows.Forms.DataGridView dataGridSuspect;
    }
}

