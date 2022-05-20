
namespace TestConsumeGenCode.Views
{
    partial class EditMUserForm
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
            this.gbx_editmuserform = new System.Windows.Forms.GroupBox();

                
 this.txt_cf_name = new System.Windows.Forms.TextBox();
    
 this.txt_cf_value = new System.Windows.Forms.TextBox();
    
 this.txt_cf_group = new System.Windows.Forms.TextBox();
    
 this.txt_cf_description = new System.Windows.Forms.TextBox();


                
 this.lbl_cf_name =  new System.Windows.Forms.Label();
    
 this.lbl_cf_value =  new System.Windows.Forms.Label();
    
 this.lbl_cf_group =  new System.Windows.Forms.Label();
    
 this.lbl_cf_description =  new System.Windows.Forms.Label();


            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.gbx_editmuserform.SuspendLayout();
            this.gbx_editmuserform.AutoSize = true;
            this.SuspendLayout();

            // add control to groupbox
 
               
 this.gbx_editmuserform.Controls.Add(this.txt_cf_name);
   
 this.gbx_editmuserform.Controls.Add(this.txt_cf_value);
   
 this.gbx_editmuserform.Controls.Add(this.txt_cf_group);
   
 this.gbx_editmuserform.Controls.Add(this.txt_cf_description);


               
 this.gbx_editmuserform.Controls.Add(this.lbl_cf_name);
   
 this.gbx_editmuserform.Controls.Add(this.lbl_cf_value);
   
 this.gbx_editmuserform.Controls.Add(this.lbl_cf_group);
   
 this.gbx_editmuserform.Controls.Add(this.lbl_cf_description);



            // setting goupbox
            this.gbx_editmuserform.Location = new System.Drawing.Point(12, 12);
            this.gbx_editmuserform.Name = "gbx_editmuserform";
            this.gbx_editmuserform.Size = new System.Drawing.Size(776, 372);
            this.gbx_editmuserform.TabIndex = 0;
            this.gbx_editmuserform.TabStop = false;
            this.gbx_editmuserform.Text = "editmuserform Information";
            // 

            // 
                
 this.txt_cf_name.Location = new System.Drawing.Point(210,40);
 this.txt_cf_name.Name = "txt_cf_name";
 this.txt_cf_name.Size = new System.Drawing.Size(390,20);

  this.lbl_cf_name.Location = new System.Drawing.Point(36,40);
 this.lbl_cf_name.Name = "lbl_cf_name";
 this.lbl_cf_name.Size = new System.Drawing.Size(150,14);
 this.lbl_cf_name.Text = "CF_Name";
    
 this.txt_cf_value.Location = new System.Drawing.Point(210,80);
 this.txt_cf_value.Name = "txt_cf_value";
 this.txt_cf_value.Size = new System.Drawing.Size(390,20);

  this.lbl_cf_value.Location = new System.Drawing.Point(36,80);
 this.lbl_cf_value.Name = "lbl_cf_value";
 this.lbl_cf_value.Size = new System.Drawing.Size(150,14);
 this.lbl_cf_value.Text = "CF_Value";
    
 this.txt_cf_group.Location = new System.Drawing.Point(210,120);
 this.txt_cf_group.Name = "txt_cf_group";
 this.txt_cf_group.Size = new System.Drawing.Size(390,20);

  this.lbl_cf_group.Location = new System.Drawing.Point(36,120);
 this.lbl_cf_group.Name = "lbl_cf_group";
 this.lbl_cf_group.Size = new System.Drawing.Size(150,14);
 this.lbl_cf_group.Text = "CF_Group";
    
 this.txt_cf_description.Location = new System.Drawing.Point(210,160);
 this.txt_cf_description.Name = "txt_cf_description";
 this.txt_cf_description.Size = new System.Drawing.Size(390,20);

  this.lbl_cf_description.Location = new System.Drawing.Point(36,160);
 this.lbl_cf_description.Name = "lbl_cf_description";
 this.lbl_cf_description.Size = new System.Drawing.Size(150,14);
 this.lbl_cf_description.Text = "CF_Description";

            // 
            // 
            // btn_save
            // 
            
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(120, 44);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(120, 44);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;

            // 
            // EditMUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.gbx_editmuserform);
            this.Name = "EditMUserForm";
            this.Text = "MUserForm";
            this.AutoScroll = true;
            this.AutoSize = true;
            this.gbx_editmuserform.ResumeLayout(false);
            this.gbx_editmuserform.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            this.btn_save.Location = new System.Drawing.Point(247, this.gbx_editmuserform.Height+20);
            this.btn_cancel.Location = new System.Drawing.Point(418, this.gbx_editmuserform.Height+20);
        }

        #endregion

       
        private System.Windows.Forms.GroupBox gbx_editmuserform;

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;

            
 System.Windows.Forms.TextBox txt_cf_name;    
 System.Windows.Forms.TextBox txt_cf_value;    
 System.Windows.Forms.TextBox txt_cf_group;    
 System.Windows.Forms.TextBox txt_cf_description;

            
 private System.Windows.Forms.Label lbl_cf_name;    
 private System.Windows.Forms.Label lbl_cf_value;    
 private System.Windows.Forms.Label lbl_cf_group;    
 private System.Windows.Forms.Label lbl_cf_description;
    }
}