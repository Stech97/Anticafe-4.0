﻿namespace Anticafe_2._0
{
    partial class anti
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anti));
            this.Table = new System.Windows.Forms.DataGridView();
            this.NameTabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Flayer = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LogIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHE = new System.Windows.Forms.Button();
            this.SmenaEnd = new System.Windows.Forms.Button();
            this.GuestOut = new System.Windows.Forms.Button();
            this.TimeOnForm = new System.Windows.Forms.Timer(this.components);
            this.WhoWork = new System.Windows.Forms.Label();
            this.trey = new System.Windows.Forms.NotifyIcon(this.components);
            this.WhoOnWork = new System.Windows.Forms.Label();
            this.GuestIn = new System.Windows.Forms.Button();
            this.TaxBut = new System.Windows.Forms.Button();
            this.Time = new System.Windows.Forms.Label();
            this.LTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // Table
            // 
            this.Table.AllowUserToAddRows = false;
            this.Table.AllowUserToDeleteRows = false;
            this.Table.AllowUserToResizeColumns = false;
            this.Table.AllowUserToResizeRows = false;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle29.NullValue = null;
            this.Table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle29;
            this.Table.BackgroundColor = System.Drawing.Color.White;
            this.Table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.Table.ColumnHeadersHeight = 120;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameTabel,
            this.Tax,
            this.Flayer,
            this.LogIn,
            this.LogOut,
            this.TotalTime,
            this.Sum});
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Table.DefaultCellStyle = dataGridViewCellStyle32;
            this.Table.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Table.GridColor = System.Drawing.Color.SandyBrown;
            this.Table.Location = new System.Drawing.Point(27, 105);
            this.Table.Margin = new System.Windows.Forms.Padding(1);
            this.Table.Name = "Table";
            this.Table.ReadOnly = true;
            this.Table.RowHeadersWidth = 10;
            this.Table.Size = new System.Drawing.Size(1084, 815);
            this.Table.TabIndex = 7;
            this.Table.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_CellDoubleClick);
            // 
            // NameTabel
            // 
            this.NameTabel.HeaderText = "Имя";
            this.NameTabel.MaxInputLength = 10;
            this.NameTabel.Name = "NameTabel";
            this.NameTabel.ReadOnly = true;
            this.NameTabel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NameTabel.Width = 120;
            // 
            // Tax
            // 
            this.Tax.HeaderText = "Тип подсчёта";
            this.Tax.Name = "Tax";
            this.Tax.ReadOnly = true;
            this.Tax.Width = 120;
            // 
            // Flayer
            // 
            this.Flayer.HeaderText = "Флаер";
            this.Flayer.Name = "Flayer";
            this.Flayer.ReadOnly = true;
            this.Flayer.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Flayer.Width = 80;
            // 
            // LogIn
            // 
            dataGridViewCellStyle31.Format = "t";
            dataGridViewCellStyle31.NullValue = null;
            this.LogIn.DefaultCellStyle = dataGridViewCellStyle31;
            this.LogIn.HeaderText = "Время прихода";
            this.LogIn.MaxInputLength = 8;
            this.LogIn.Name = "LogIn";
            this.LogIn.ReadOnly = true;
            this.LogIn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.LogIn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LogIn.Width = 120;
            // 
            // LogOut
            // 
            this.LogOut.HeaderText = "Время ухода";
            this.LogOut.MaxInputLength = 8;
            this.LogOut.Name = "LogOut";
            this.LogOut.ReadOnly = true;
            this.LogOut.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.LogOut.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LogOut.Width = 120;
            // 
            // TotalTime
            // 
            this.TotalTime.HeaderText = "Время в минутах";
            this.TotalTime.MaxInputLength = 4;
            this.TotalTime.Name = "TotalTime";
            this.TotalTime.ReadOnly = true;
            this.TotalTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TotalTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TotalTime.Width = 120;
            // 
            // Sum
            // 
            this.Sum.HeaderText = "Сумма к оплате";
            this.Sum.MaxInputLength = 6;
            this.Sum.Name = "Sum";
            this.Sum.ReadOnly = true;
            this.Sum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Sum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Sum.Width = 120;
            // 
            // CHE
            // 
            this.CHE.Font = new System.Drawing.Font("Times New Roman", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.CHE.Location = new System.Drawing.Point(1161, 772);
            this.CHE.Margin = new System.Windows.Forms.Padding(4);
            this.CHE.Name = "CHE";
            this.CHE.Size = new System.Drawing.Size(245, 145);
            this.CHE.TabIndex = 5;
            this.CHE.Text = "Чистота и Уют";
            this.CHE.UseVisualStyleBackColor = true;
            this.CHE.Click += new System.EventHandler(this.CHE_Click);
            // 
            // SmenaEnd
            // 
            this.SmenaEnd.Font = new System.Drawing.Font("Times New Roman", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.SmenaEnd.Location = new System.Drawing.Point(1161, 603);
            this.SmenaEnd.Margin = new System.Windows.Forms.Padding(4);
            this.SmenaEnd.Name = "SmenaEnd";
            this.SmenaEnd.Size = new System.Drawing.Size(245, 145);
            this.SmenaEnd.TabIndex = 4;
            this.SmenaEnd.Text = "Конец смены";
            this.SmenaEnd.UseVisualStyleBackColor = true;
            this.SmenaEnd.Click += new System.EventHandler(this.SmenaEnd_Click);
            // 
            // GuestOut
            // 
            this.GuestOut.Font = new System.Drawing.Font("Times New Roman", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.GuestOut.Location = new System.Drawing.Point(1161, 431);
            this.GuestOut.Margin = new System.Windows.Forms.Padding(4);
            this.GuestOut.Name = "GuestOut";
            this.GuestOut.Size = new System.Drawing.Size(245, 145);
            this.GuestOut.TabIndex = 3;
            this.GuestOut.Text = "Гость уходит";
            this.GuestOut.UseVisualStyleBackColor = true;
            this.GuestOut.Click += new System.EventHandler(this.GuestOut_Click);
            // 
            // TimeOnForm
            // 
            this.TimeOnForm.Tick += new System.EventHandler(this.TimeOnForm_Tick);
            // 
            // WhoWork
            // 
            this.WhoWork.AutoSize = true;
            this.WhoWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.WhoWork.Location = new System.Drawing.Point(475, 18);
            this.WhoWork.Margin = new System.Windows.Forms.Padding(0);
            this.WhoWork.Name = "WhoWork";
            this.WhoWork.Size = new System.Drawing.Size(0, 42);
            this.WhoWork.TabIndex = 16;
            this.WhoWork.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trey
            // 
            this.trey.Icon = ((System.Drawing.Icon)(resources.GetObject("trey.Icon")));
            this.trey.Text = "Сметка антикафе\"Время терпит\"";
            this.trey.Visible = true;
            this.trey.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trey_MouseDoubleClick);
            // 
            // WhoOnWork
            // 
            this.WhoOnWork.AutoSize = true;
            this.WhoOnWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WhoOnWork.Location = new System.Drawing.Point(27, 18);
            this.WhoOnWork.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WhoOnWork.Name = "WhoOnWork";
            this.WhoOnWork.Size = new System.Drawing.Size(354, 42);
            this.WhoOnWork.TabIndex = 6;
            this.WhoOnWork.Text = "Сейчас на смене: ";
            // 
            // GuestIn
            // 
            this.GuestIn.Font = new System.Drawing.Font("Times New Roman", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.GuestIn.Location = new System.Drawing.Point(1161, 267);
            this.GuestIn.Margin = new System.Windows.Forms.Padding(4);
            this.GuestIn.Name = "GuestIn";
            this.GuestIn.Size = new System.Drawing.Size(245, 145);
            this.GuestIn.TabIndex = 2;
            this.GuestIn.Text = "Новый гость";
            this.GuestIn.UseVisualStyleBackColor = true;
            this.GuestIn.Click += new System.EventHandler(this.NewGuest_Click);
            // 
            // TaxBut
            // 
            this.TaxBut.Font = new System.Drawing.Font("Times New Roman", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TaxBut.Location = new System.Drawing.Point(1161, 105);
            this.TaxBut.Margin = new System.Windows.Forms.Padding(4);
            this.TaxBut.Name = "TaxBut";
            this.TaxBut.Size = new System.Drawing.Size(244, 145);
            this.TaxBut.TabIndex = 1;
            this.TaxBut.Text = "Тарифы";
            this.TaxBut.UseVisualStyleBackColor = true;
            this.TaxBut.Click += new System.EventHandler(this.Tarif_Click);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Time.Location = new System.Drawing.Point(1246, 18);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(0, 42);
            this.Time.TabIndex = 17;
            // 
            // LTime
            // 
            this.LTime.AutoSize = true;
            this.LTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LTime.Location = new System.Drawing.Point(837, 19);
            this.LTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTime.Name = "LTime";
            this.LTime.Size = new System.Drawing.Size(314, 42);
            this.LTime.TabIndex = 18;
            this.LTime.Text = "Текущее время:";
            // 
            // anti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1418, 930);
            this.Controls.Add(this.LTime);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.WhoWork);
            this.Controls.Add(this.TaxBut);
            this.Controls.Add(this.CHE);
            this.Controls.Add(this.SmenaEnd);
            this.Controls.Add(this.GuestIn);
            this.Controls.Add(this.GuestOut);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.WhoOnWork);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "anti";
            this.Text = "Антикафе 2.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.anti_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.anti_FormClosed);
            this.Load += new System.EventHandler(this.anti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.Button CHE;
        private System.Windows.Forms.Button SmenaEnd;
        private System.Windows.Forms.Button GuestOut;
        private System.Windows.Forms.Timer TimeOnForm;
        private System.Windows.Forms.Label WhoWork;
        private System.Windows.Forms.NotifyIcon trey;
        private System.Windows.Forms.Label WhoOnWork;
        private System.Windows.Forms.Button GuestIn;
        private System.Windows.Forms.Button TaxBut;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameTabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tax;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Flayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sum;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label LTime;
    }
}