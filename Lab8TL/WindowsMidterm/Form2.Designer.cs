namespace WindowsMidterm
{
    partial class Form2
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
            this.btnadd = new System.Windows.Forms.Button();
            this.btnsearchdata = new System.Windows.Forms.Button();
            this.btnupdateperson = new System.Windows.Forms.Button();
            this.btndeleterecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(118, 109);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(152, 68);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsearchdata
            // 
            this.btnsearchdata.Location = new System.Drawing.Point(492, 109);
            this.btnsearchdata.Name = "btnsearchdata";
            this.btnsearchdata.Size = new System.Drawing.Size(152, 68);
            this.btnsearchdata.TabIndex = 1;
            this.btnsearchdata.Text = "Search";
            this.btnsearchdata.UseVisualStyleBackColor = true;
            this.btnsearchdata.Click += new System.EventHandler(this.btnview_Click);
            // 
            // btnupdateperson
            // 
            this.btnupdateperson.Location = new System.Drawing.Point(118, 268);
            this.btnupdateperson.Name = "btnupdateperson";
            this.btnupdateperson.Size = new System.Drawing.Size(152, 68);
            this.btnupdateperson.TabIndex = 2;
            this.btnupdateperson.Text = "Update Record";
            this.btnupdateperson.UseVisualStyleBackColor = true;
            this.btnupdateperson.Click += new System.EventHandler(this.btnupdateperson_Click);
            // 
            // btndeleterecord
            // 
            this.btndeleterecord.Location = new System.Drawing.Point(492, 268);
            this.btndeleterecord.Name = "btndeleterecord";
            this.btndeleterecord.Size = new System.Drawing.Size(152, 68);
            this.btndeleterecord.TabIndex = 3;
            this.btndeleterecord.Text = "Delete Record";
            this.btndeleterecord.UseVisualStyleBackColor = true;
            this.btndeleterecord.Click += new System.EventHandler(this.btndeleterecord_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btndeleterecord);
            this.Controls.Add(this.btnupdateperson);
            this.Controls.Add(this.btnsearchdata);
            this.Controls.Add(this.btnadd);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnsearchdata;
        private System.Windows.Forms.Button btnupdateperson;
        private System.Windows.Forms.Button btndeleterecord;
    }
}