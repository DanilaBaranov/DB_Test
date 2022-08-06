
namespace BD_Test {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.queryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dropToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rowsAndColomnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.createToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dropToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dropToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.DataBase_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Table_Name_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Colomns_Name_Text = new System.Windows.Forms.TextBox();
            this.SQL_Query_Button = new System.Windows.Forms.Button();
            this.SQL_Text = new System.Windows.Forms.TextBox();
            this.Result_Text = new System.Windows.Forms.TextBox();
            this.renameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.queryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(718, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // queryToolStripMenuItem
            // 
            this.queryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.queryToolStripMenuItem1,
            this.toolStripSeparator1,
            this.tableToolStripMenuItem,
            this.dBToolStripMenuItem});
            this.queryToolStripMenuItem.Name = "queryToolStripMenuItem";
            this.queryToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.queryToolStripMenuItem.Text = "Templates";
            // 
            // queryToolStripMenuItem1
            // 
            this.queryToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectToolStripMenuItem,
            this.toolStripSeparator2,
            this.insertToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator3,
            this.updateToolStripMenuItem});
            this.queryToolStripMenuItem1.Name = "queryToolStripMenuItem1";
            this.queryToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.queryToolStripMenuItem1.Text = "Query";
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selectToolStripMenuItem.Text = "Select";
            this.selectToolStripMenuItem.Click += new System.EventHandler(this.selectToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.insertToolStripMenuItem.Text = "Insert";
            this.insertToolStripMenuItem.Click += new System.EventHandler(this.insertToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // tableToolStripMenuItem
            // 
            this.tableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterToolStripMenuItem,
            this.toolStripSeparator4,
            this.clearToolStripMenuItem,
            this.toolStripSeparator5,
            this.createToolStripMenuItem1,
            this.dropToolStripMenuItem1});
            this.tableToolStripMenuItem.Name = "tableToolStripMenuItem";
            this.tableToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tableToolStripMenuItem.Text = "Table";
            // 
            // alterToolStripMenuItem
            // 
            this.alterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.dropToolStripMenuItem2,
            this.modifiToolStripMenuItem,
            this.renameToolStripMenuItem1});
            this.alterToolStripMenuItem.Name = "alterToolStripMenuItem";
            this.alterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alterToolStripMenuItem.Text = "Alter";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // dropToolStripMenuItem2
            // 
            this.dropToolStripMenuItem2.Name = "dropToolStripMenuItem2";
            this.dropToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.dropToolStripMenuItem2.Text = "Drop";
            this.dropToolStripMenuItem2.Click += new System.EventHandler(this.dropToolStripMenuItem2_Click);
            // 
            // modifiToolStripMenuItem
            // 
            this.modifiToolStripMenuItem.Name = "modifiToolStripMenuItem";
            this.modifiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modifiToolStripMenuItem.Text = "Modify(-)";
            this.modifiToolStripMenuItem.Click += new System.EventHandler(this.modifiToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(105, 6);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rowsToolStripMenuItem,
            this.rowsAndColomnsToolStripMenuItem});
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // rowsToolStripMenuItem
            // 
            this.rowsToolStripMenuItem.Name = "rowsToolStripMenuItem";
            this.rowsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.rowsToolStripMenuItem.Text = "Rows";
            this.rowsToolStripMenuItem.Click += new System.EventHandler(this.rowsToolStripMenuItem_Click);
            // 
            // rowsAndColomnsToolStripMenuItem
            // 
            this.rowsAndColomnsToolStripMenuItem.Name = "rowsAndColomnsToolStripMenuItem";
            this.rowsAndColomnsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.rowsAndColomnsToolStripMenuItem.Text = "Rows and Colomns (-)";
            this.rowsAndColomnsToolStripMenuItem.Click += new System.EventHandler(this.rowsAndColomnsToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(105, 6);
            // 
            // createToolStripMenuItem1
            // 
            this.createToolStripMenuItem1.Name = "createToolStripMenuItem1";
            this.createToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.createToolStripMenuItem1.Text = "Create";
            this.createToolStripMenuItem1.Click += new System.EventHandler(this.createToolStripMenuItem1_Click);
            // 
            // dropToolStripMenuItem1
            // 
            this.dropToolStripMenuItem1.Name = "dropToolStripMenuItem1";
            this.dropToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.dropToolStripMenuItem1.Text = "Drop";
            this.dropToolStripMenuItem1.Click += new System.EventHandler(this.dropToolStripMenuItem1_Click);
            // 
            // dBToolStripMenuItem
            // 
            this.dBToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.dropToolStripMenuItem});
            this.dBToolStripMenuItem.Name = "dBToolStripMenuItem";
            this.dBToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dBToolStripMenuItem.Text = "DB (-)";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.createToolStripMenuItem.Text = "Create (-)";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // dropToolStripMenuItem
            // 
            this.dropToolStripMenuItem.Name = "dropToolStripMenuItem";
            this.dropToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.dropToolStripMenuItem.Text = "Drop (-)";
            this.dropToolStripMenuItem.Click += new System.EventHandler(this.dropToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "DB:";
            // 
            // DataBase_Name
            // 
            this.DataBase_Name.Location = new System.Drawing.Point(59, 27);
            this.DataBase_Name.Name = "DataBase_Name";
            this.DataBase_Name.Size = new System.Drawing.Size(100, 23);
            this.DataBase_Name.TabIndex = 0;
            this.DataBase_Name.Text = "DB_1.mdb";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "SQL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result";
            // 
            // Table_Name_text
            // 
            this.Table_Name_text.Location = new System.Drawing.Point(59, 56);
            this.Table_Name_text.Name = "Table_Name_text";
            this.Table_Name_text.Size = new System.Drawing.Size(200, 23);
            this.Table_Name_text.TabIndex = 7;
            this.Table_Name_text.Text = "Table_1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tables:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-1, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Colomns:";
            // 
            // Colomns_Name_Text
            // 
            this.Colomns_Name_Text.Location = new System.Drawing.Point(59, 88);
            this.Colomns_Name_Text.Name = "Colomns_Name_Text";
            this.Colomns_Name_Text.Size = new System.Drawing.Size(200, 23);
            this.Colomns_Name_Text.TabIndex = 11;
            this.Colomns_Name_Text.Text = "*";
            // 
            // SQL_Query_Button
            // 
            this.SQL_Query_Button.Location = new System.Drawing.Point(184, 27);
            this.SQL_Query_Button.Name = "SQL_Query_Button";
            this.SQL_Query_Button.Size = new System.Drawing.Size(75, 23);
            this.SQL_Query_Button.TabIndex = 12;
            this.SQL_Query_Button.Text = "SQL_Query";
            this.SQL_Query_Button.UseVisualStyleBackColor = true;
            this.SQL_Query_Button.Click += new System.EventHandler(this.SQL_Query_Button_Click);
            // 
            // SQL_Text
            // 
            this.SQL_Text.Location = new System.Drawing.Point(12, 149);
            this.SQL_Text.Multiline = true;
            this.SQL_Text.Name = "SQL_Text";
            this.SQL_Text.Size = new System.Drawing.Size(300, 100);
            this.SQL_Text.TabIndex = 13;
            // 
            // Result_Text
            // 
            this.Result_Text.Location = new System.Drawing.Point(318, 149);
            this.Result_Text.Multiline = true;
            this.Result_Text.Name = "Result_Text";
            this.Result_Text.ReadOnly = true;
            this.Result_Text.Size = new System.Drawing.Size(300, 100);
            this.Result_Text.TabIndex = 14;
            // 
            // renameToolStripMenuItem1
            // 
            this.renameToolStripMenuItem1.Name = "renameToolStripMenuItem1";
            this.renameToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.renameToolStripMenuItem1.Text = "Rename";
            this.renameToolStripMenuItem1.Click += new System.EventHandler(this.renameToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 492);
            this.Controls.Add(this.Result_Text);
            this.Controls.Add(this.SQL_Text);
            this.Controls.Add(this.SQL_Query_Button);
            this.Controls.Add(this.Colomns_Name_Text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Table_Name_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataBase_Name);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "SQL Query";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem queryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dropToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dropToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem alterToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DataBase_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Table_Name_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Colomns_Name_Text;
        private System.Windows.Forms.Button SQL_Query_Button;
        private System.Windows.Forms.TextBox SQL_Text;
        private System.Windows.Forms.TextBox Result_Text;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dropToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem modifiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rowsAndColomnsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem1;
    }
}

