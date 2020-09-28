namespace WindowsFormsAppEntityHW.Views
{
    partial class Window
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TableTabPage = new System.Windows.Forms.TabControl();
            this.StudentsTabPage = new System.Windows.Forms.TabPage();
            this.StudentsListBox = new System.Windows.Forms.ListBox();
            this.GroupsTabPage = new System.Windows.Forms.TabPage();
            this.GroupsListBox = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ResetButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.StudentInfoPanel = new System.Windows.Forms.Panel();
            this.GroupInfoPanel = new System.Windows.Forms.Panel();
            this.GroupsTitleTextBox = new System.Windows.Forms.TextBox();
            this.GroupsIdTextBox = new System.Windows.Forms.TextBox();
            this.GroupTitleLabel = new System.Windows.Forms.Label();
            this.GroupsIdLabel = new System.Windows.Forms.Label();
            this.GroupIdLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.GroupIdTextBox = new System.Windows.Forms.TextBox();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.DeleteAllButton = new System.Windows.Forms.Button();
            this.UpdtaeButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.TableTabPage.SuspendLayout();
            this.StudentsTabPage.SuspendLayout();
            this.GroupsTabPage.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.StudentInfoPanel.SuspendLayout();
            this.GroupInfoPanel.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AllowDrop = true;
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(832, 556);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TableTabPage);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 550);
            this.panel1.TabIndex = 2;
            // 
            // TableTabPage
            // 
            this.TableTabPage.Controls.Add(this.StudentsTabPage);
            this.TableTabPage.Controls.Add(this.GroupsTabPage);
            this.TableTabPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableTabPage.Location = new System.Drawing.Point(0, 0);
            this.TableTabPage.Name = "TableTabPage";
            this.TableTabPage.SelectedIndex = 0;
            this.TableTabPage.Size = new System.Drawing.Size(410, 512);
            this.TableTabPage.TabIndex = 2;
            this.TableTabPage.SelectedIndexChanged += new System.EventHandler(this.TableTabPage_SelectedIndexChanged);
            // 
            // StudentsTabPage
            // 
            this.StudentsTabPage.Controls.Add(this.StudentsListBox);
            this.StudentsTabPage.Location = new System.Drawing.Point(4, 22);
            this.StudentsTabPage.Name = "StudentsTabPage";
            this.StudentsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.StudentsTabPage.Size = new System.Drawing.Size(402, 486);
            this.StudentsTabPage.TabIndex = 0;
            this.StudentsTabPage.Text = "Students";
            this.StudentsTabPage.UseVisualStyleBackColor = true;
            // 
            // StudentsListBox
            // 
            this.StudentsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentsListBox.FormattingEnabled = true;
            this.StudentsListBox.Location = new System.Drawing.Point(3, 3);
            this.StudentsListBox.Name = "StudentsListBox";
            this.StudentsListBox.Size = new System.Drawing.Size(396, 480);
            this.StudentsListBox.TabIndex = 0;
            // 
            // GroupsTabPage
            // 
            this.GroupsTabPage.Controls.Add(this.GroupsListBox);
            this.GroupsTabPage.Location = new System.Drawing.Point(4, 22);
            this.GroupsTabPage.Name = "GroupsTabPage";
            this.GroupsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.GroupsTabPage.Size = new System.Drawing.Size(402, 486);
            this.GroupsTabPage.TabIndex = 1;
            this.GroupsTabPage.Text = "Groups";
            this.GroupsTabPage.UseVisualStyleBackColor = true;
            // 
            // GroupsListBox
            // 
            this.GroupsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupsListBox.FormattingEnabled = true;
            this.GroupsListBox.Location = new System.Drawing.Point(3, 3);
            this.GroupsListBox.Name = "GroupsListBox";
            this.GroupsListBox.Size = new System.Drawing.Size(396, 480);
            this.GroupsListBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 512);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(410, 38);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.ResetButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(410, 38);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // ResetButton
            // 
            this.ResetButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResetButton.Location = new System.Drawing.Point(3, 3);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(199, 32);
            this.ResetButton.TabIndex = 0;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(208, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.tableLayoutPanel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(419, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(410, 550);
            this.panel3.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.StudentInfoPanel);
            this.panel6.Location = new System.Drawing.Point(4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(403, 336);
            this.panel6.TabIndex = 1;
            // 
            // StudentInfoPanel
            // 
            this.StudentInfoPanel.Controls.Add(this.GroupInfoPanel);
            this.StudentInfoPanel.Controls.Add(this.GroupIdLabel);
            this.StudentInfoPanel.Controls.Add(this.AgeLabel);
            this.StudentInfoPanel.Controls.Add(this.NameLabel);
            this.StudentInfoPanel.Controls.Add(this.GroupIdTextBox);
            this.StudentInfoPanel.Controls.Add(this.AgeTextBox);
            this.StudentInfoPanel.Controls.Add(this.NameTextBox);
            this.StudentInfoPanel.Controls.Add(this.IdTextBox);
            this.StudentInfoPanel.Controls.Add(this.IdLabel);
            this.StudentInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.StudentInfoPanel.Name = "StudentInfoPanel";
            this.StudentInfoPanel.Size = new System.Drawing.Size(403, 336);
            this.StudentInfoPanel.TabIndex = 1;
            // 
            // GroupInfoPanel
            // 
            this.GroupInfoPanel.Controls.Add(this.GroupsTitleTextBox);
            this.GroupInfoPanel.Controls.Add(this.GroupsIdTextBox);
            this.GroupInfoPanel.Controls.Add(this.GroupTitleLabel);
            this.GroupInfoPanel.Controls.Add(this.GroupsIdLabel);
            this.GroupInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.GroupInfoPanel.Name = "GroupInfoPanel";
            this.GroupInfoPanel.Size = new System.Drawing.Size(403, 336);
            this.GroupInfoPanel.TabIndex = 2;
            // 
            // GroupsTitleTextBox
            // 
            this.GroupsTitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupsTitleTextBox.Location = new System.Drawing.Point(6, 59);
            this.GroupsTitleTextBox.Name = "GroupsTitleTextBox";
            this.GroupsTitleTextBox.Size = new System.Drawing.Size(391, 20);
            this.GroupsTitleTextBox.TabIndex = 5;
            // 
            // GroupsIdTextBox
            // 
            this.GroupsIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupsIdTextBox.Location = new System.Drawing.Point(4, 19);
            this.GroupsIdTextBox.Name = "GroupsIdTextBox";
            this.GroupsIdTextBox.Size = new System.Drawing.Size(393, 20);
            this.GroupsIdTextBox.TabIndex = 4;
            // 
            // GroupTitleLabel
            // 
            this.GroupTitleLabel.AutoSize = true;
            this.GroupTitleLabel.Location = new System.Drawing.Point(3, 42);
            this.GroupTitleLabel.Name = "GroupTitleLabel";
            this.GroupTitleLabel.Size = new System.Drawing.Size(27, 13);
            this.GroupTitleLabel.TabIndex = 1;
            this.GroupTitleLabel.Text = "Title";
            // 
            // GroupsIdLabel
            // 
            this.GroupsIdLabel.AutoSize = true;
            this.GroupsIdLabel.Location = new System.Drawing.Point(3, 2);
            this.GroupsIdLabel.Name = "GroupsIdLabel";
            this.GroupsIdLabel.Size = new System.Drawing.Size(16, 13);
            this.GroupsIdLabel.TabIndex = 0;
            this.GroupsIdLabel.Text = "Id";
            // 
            // GroupIdLabel
            // 
            this.GroupIdLabel.AutoSize = true;
            this.GroupIdLabel.Location = new System.Drawing.Point(9, 130);
            this.GroupIdLabel.Name = "GroupIdLabel";
            this.GroupIdLabel.Size = new System.Drawing.Size(45, 13);
            this.GroupIdLabel.TabIndex = 7;
            this.GroupIdLabel.Text = "GroupId";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(6, 87);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(26, 13);
            this.AgeLabel.TabIndex = 6;
            this.AgeLabel.Text = "Age";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(6, 48);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Name";
            // 
            // GroupIdTextBox
            // 
            this.GroupIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupIdTextBox.Location = new System.Drawing.Point(6, 146);
            this.GroupIdTextBox.Name = "GroupIdTextBox";
            this.GroupIdTextBox.Size = new System.Drawing.Size(388, 20);
            this.GroupIdTextBox.TabIndex = 4;
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AgeTextBox.Location = new System.Drawing.Point(6, 103);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(388, 20);
            this.AgeTextBox.TabIndex = 3;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(6, 64);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(388, 20);
            this.NameTextBox.TabIndex = 2;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdTextBox.Location = new System.Drawing.Point(6, 21);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(388, 20);
            this.IdTextBox.TabIndex = 1;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(3, 2);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(16, 13);
            this.IdLabel.TabIndex = 0;
            this.IdLabel.Text = "Id";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.AddButton, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.DeleteButton, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.DeleteAllButton, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.UpdtaeButton, 0, 3);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 346);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.48454F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.51546F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(410, 204);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddButton.Location = new System.Drawing.Point(3, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(404, 43);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteButton.Location = new System.Drawing.Point(3, 52);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(404, 44);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DeleteAllButton
            // 
            this.DeleteAllButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteAllButton.Location = new System.Drawing.Point(3, 102);
            this.DeleteAllButton.Name = "DeleteAllButton";
            this.DeleteAllButton.Size = new System.Drawing.Size(404, 47);
            this.DeleteAllButton.TabIndex = 2;
            this.DeleteAllButton.Text = "Delete All";
            this.DeleteAllButton.UseVisualStyleBackColor = true;
            this.DeleteAllButton.Click += new System.EventHandler(this.DeleteAllButton_Click);
            // 
            // UpdtaeButton
            // 
            this.UpdtaeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpdtaeButton.Location = new System.Drawing.Point(3, 155);
            this.UpdtaeButton.Name = "UpdtaeButton";
            this.UpdtaeButton.Size = new System.Drawing.Size(404, 46);
            this.UpdtaeButton.TabIndex = 3;
            this.UpdtaeButton.Text = "Update";
            this.UpdtaeButton.UseVisualStyleBackColor = true;
            this.UpdtaeButton.Click += new System.EventHandler(this.UpdtaeButton_Click);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 556);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Window";
            this.Text = "Window";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.TableTabPage.ResumeLayout(false);
            this.StudentsTabPage.ResumeLayout(false);
            this.GroupsTabPage.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.StudentInfoPanel.ResumeLayout(false);
            this.StudentInfoPanel.PerformLayout();
            this.GroupInfoPanel.ResumeLayout(false);
            this.GroupInfoPanel.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl TableTabPage;
        private System.Windows.Forms.TabPage StudentsTabPage;
        private System.Windows.Forms.ListBox StudentsListBox;
        private System.Windows.Forms.TabPage GroupsTabPage;
        private System.Windows.Forms.ListBox GroupsListBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button DeleteAllButton;
        private System.Windows.Forms.Button UpdtaeButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel StudentInfoPanel;
        private System.Windows.Forms.Label GroupIdLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox GroupIdTextBox;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Panel GroupInfoPanel;
        private System.Windows.Forms.Label GroupsIdLabel;
        private System.Windows.Forms.TextBox GroupsTitleTextBox;
        private System.Windows.Forms.TextBox GroupsIdTextBox;
        private System.Windows.Forms.Label GroupTitleLabel;
        private System.Windows.Forms.Panel panel6;
    }
}