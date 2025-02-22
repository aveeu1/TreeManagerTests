namespace WindowsFormsApp2
{
    partial class Form1
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.textBoxRemoveChildName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReplace = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxInsertChildName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNewChildName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxOldChildName = new System.Windows.Forms.TextBox();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnInsertAfter = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxInsertAfter = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxInsertBefore = new System.Windows.Forms.TextBox();
            this.btnInsertBefore = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxTargetChild = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(259, 377);
            this.treeView1.TabIndex = 0;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(357, 193);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(357, 56);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // textBoxRemoveChildName
            // 
            this.textBoxRemoveChildName.Location = new System.Drawing.Point(357, 132);
            this.textBoxRemoveChildName.Name = "textBoxRemoveChildName";
            this.textBoxRemoveChildName.Size = new System.Drawing.Size(100, 22);
            this.textBoxRemoveChildName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Type child name to remove:";
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(360, 320);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(75, 23);
            this.btnReplace.TabIndex = 5;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Type child name to insert:";
            // 
            // textBoxInsertChildName
            // 
            this.textBoxInsertChildName.Location = new System.Drawing.Point(357, 260);
            this.textBoxInsertChildName.Name = "textBoxInsertChildName";
            this.textBoxInsertChildName.Size = new System.Drawing.Size(100, 22);
            this.textBoxInsertChildName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(610, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Type new child name:";
            // 
            // textBoxNewChildName
            // 
            this.textBoxNewChildName.Location = new System.Drawing.Point(613, 392);
            this.textBoxNewChildName.Name = "textBoxNewChildName";
            this.textBoxNewChildName.Size = new System.Drawing.Size(100, 22);
            this.textBoxNewChildName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Type old child name to be replace:";
            // 
            // textBoxOldChildName
            // 
            this.textBoxOldChildName.Location = new System.Drawing.Point(357, 392);
            this.textBoxOldChildName.Name = "textBoxOldChildName";
            this.textBoxOldChildName.Size = new System.Drawing.Size(100, 22);
            this.textBoxOldChildName.TabIndex = 10;
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(453, 193);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(75, 23);
            this.btnRestore.TabIndex = 12;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnInsertAfter
            // 
            this.btnInsertAfter.Location = new System.Drawing.Point(655, 56);
            this.btnInsertAfter.Name = "btnInsertAfter";
            this.btnInsertAfter.Size = new System.Drawing.Size(100, 23);
            this.btnInsertAfter.TabIndex = 13;
            this.btnInsertAfter.Text = "Insert After";
            this.btnInsertAfter.UseVisualStyleBackColor = true;
            this.btnInsertAfter.Click += new System.EventHandler(this.btnInsertAfter_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(652, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Type after child name:";
            // 
            // textBoxInsertAfter
            // 
            this.textBoxInsertAfter.Location = new System.Drawing.Point(655, 228);
            this.textBoxInsertAfter.Name = "textBoxInsertAfter";
            this.textBoxInsertAfter.Size = new System.Drawing.Size(100, 22);
            this.textBoxInsertAfter.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(809, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Type before child name:";
            // 
            // textBoxInsertBefore
            // 
            this.textBoxInsertBefore.Location = new System.Drawing.Point(812, 228);
            this.textBoxInsertBefore.Name = "textBoxInsertBefore";
            this.textBoxInsertBefore.Size = new System.Drawing.Size(100, 22);
            this.textBoxInsertBefore.TabIndex = 17;
            // 
            // btnInsertBefore
            // 
            this.btnInsertBefore.Location = new System.Drawing.Point(812, 56);
            this.btnInsertBefore.Name = "btnInsertBefore";
            this.btnInsertBefore.Size = new System.Drawing.Size(100, 23);
            this.btnInsertBefore.TabIndex = 16;
            this.btnInsertBefore.Text = "Insert Before";
            this.btnInsertBefore.UseVisualStyleBackColor = true;
            this.btnInsertBefore.Click += new System.EventHandler(this.btnInsertBefore_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(717, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Type target child name:";
            // 
            // textBoxTargetChild
            // 
            this.textBoxTargetChild.Location = new System.Drawing.Point(720, 146);
            this.textBoxTargetChild.Name = "textBoxTargetChild";
            this.textBoxTargetChild.Size = new System.Drawing.Size(100, 22);
            this.textBoxTargetChild.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxTargetChild);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxInsertBefore);
            this.Controls.Add(this.btnInsertBefore);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxInsertAfter);
            this.Controls.Add(this.btnInsertAfter);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxOldChildName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNewChildName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxInsertChildName);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRemoveChildName);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox textBoxRemoveChildName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxInsertChildName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNewChildName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxOldChildName;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnInsertAfter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxInsertAfter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxInsertBefore;
        private System.Windows.Forms.Button btnInsertBefore;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTargetChild;
    }
}

