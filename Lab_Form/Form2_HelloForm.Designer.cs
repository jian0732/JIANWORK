
namespace Lab_Form
{
    partial class Lab_Form2
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab_Form2));
            this.labname = new System.Windows.Forms.Label();
            this.butCHhI = new System.Windows.Forms.Button();
            this.txtCHname = new System.Windows.Forms.TextBox();
            this.labengname = new System.Windows.Forms.Label();
            this.txtENGname = new System.Windows.Forms.TextBox();
            this.labgender = new System.Windows.Forms.Label();
            this.txtgender = new System.Windows.Forms.TextBox();
            this.labcslt = new System.Windows.Forms.Label();
            this.txtcslt = new System.Windows.Forms.TextBox();
            this.butENGhi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labname
            // 
            this.labname.AutoSize = true;
            this.labname.BackColor = System.Drawing.Color.Transparent;
            this.labname.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labname.Location = new System.Drawing.Point(516, 267);
            this.labname.Name = "labname";
            this.labname.Size = new System.Drawing.Size(82, 37);
            this.labname.TabIndex = 0;
            this.labname.Text = "姓名:";
            this.labname.Click += new System.EventHandler(this.labID_Click);
            // 
            // butCHhI
            // 
            this.butCHhI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butCHhI.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.butCHhI.Image = ((System.Drawing.Image)(resources.GetObject("butCHhI.Image")));
            this.butCHhI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butCHhI.Location = new System.Drawing.Point(459, 508);
            this.butCHhI.Name = "butCHhI";
            this.butCHhI.Size = new System.Drawing.Size(160, 64);
            this.butCHhI.TabIndex = 1;
            this.butCHhI.Text = "Say 哈喽";
            this.butCHhI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butCHhI.UseVisualStyleBackColor = true;
            this.butCHhI.Click += new System.EventHandler(this.butgo_Click);
            this.butCHhI.MouseLeave += new System.EventHandler(this.butCHhI_MouseLeave);
            this.butCHhI.MouseMove += new System.Windows.Forms.MouseEventHandler(this.butCHhI_MouseMove);
            // 
            // txtCHname
            // 
            this.txtCHname.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCHname.Location = new System.Drawing.Point(625, 264);
            this.txtCHname.Name = "txtCHname";
            this.txtCHname.Size = new System.Drawing.Size(170, 46);
            this.txtCHname.TabIndex = 2;
            // 
            // labengname
            // 
            this.labengname.AutoSize = true;
            this.labengname.BackColor = System.Drawing.Color.Transparent;
            this.labengname.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labengname.Location = new System.Drawing.Point(402, 330);
            this.labengname.Name = "labengname";
            this.labengname.Size = new System.Drawing.Size(217, 37);
            this.labengname.TabIndex = 3;
            this.labengname.Text = "English Name:";
            this.labengname.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtENGname
            // 
            this.txtENGname.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtENGname.Location = new System.Drawing.Point(625, 327);
            this.txtENGname.Name = "txtENGname";
            this.txtENGname.Size = new System.Drawing.Size(170, 46);
            this.txtENGname.TabIndex = 4;
            // 
            // labgender
            // 
            this.labgender.AutoSize = true;
            this.labgender.BackColor = System.Drawing.Color.Transparent;
            this.labgender.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labgender.Location = new System.Drawing.Point(516, 390);
            this.labgender.Name = "labgender";
            this.labgender.Size = new System.Drawing.Size(82, 37);
            this.labgender.TabIndex = 5;
            this.labgender.Text = "性別:";
            this.labgender.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtgender
            // 
            this.txtgender.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtgender.Location = new System.Drawing.Point(625, 387);
            this.txtgender.Name = "txtgender";
            this.txtgender.Size = new System.Drawing.Size(170, 46);
            this.txtgender.TabIndex = 6;
            // 
            // labcslt
            // 
            this.labcslt.AutoSize = true;
            this.labcslt.BackColor = System.Drawing.Color.Transparent;
            this.labcslt.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labcslt.Location = new System.Drawing.Point(516, 444);
            this.labcslt.Name = "labcslt";
            this.labcslt.Size = new System.Drawing.Size(82, 37);
            this.labcslt.TabIndex = 7;
            this.labcslt.Text = "星座:";
            // 
            // txtcslt
            // 
            this.txtcslt.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtcslt.Location = new System.Drawing.Point(625, 444);
            this.txtcslt.Name = "txtcslt";
            this.txtcslt.Size = new System.Drawing.Size(170, 46);
            this.txtcslt.TabIndex = 8;
            // 
            // butENGhi
            // 
            this.butENGhi.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.butENGhi.Image = ((System.Drawing.Image)(resources.GetObject("butENGhi.Image")));
            this.butENGhi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butENGhi.Location = new System.Drawing.Point(635, 508);
            this.butENGhi.Name = "butENGhi";
            this.butENGhi.Size = new System.Drawing.Size(160, 64);
            this.butENGhi.TabIndex = 9;
            this.butENGhi.Text = "Say HI";
            this.butENGhi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butENGhi.UseVisualStyleBackColor = true;
            this.butENGhi.Click += new System.EventHandler(this.butENGhi_Click);
            this.butENGhi.MouseLeave += new System.EventHandler(this.butENGhi_MouseLeave);
            this.butENGhi.MouseMove += new System.Windows.Forms.MouseEventHandler(this.butENGhi_MouseMove);
            // 
            // Lab_Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(864, 706);
            this.Controls.Add(this.butENGhi);
            this.Controls.Add(this.txtcslt);
            this.Controls.Add(this.labcslt);
            this.Controls.Add(this.txtgender);
            this.Controls.Add(this.labgender);
            this.Controls.Add(this.txtENGname);
            this.Controls.Add(this.labengname);
            this.Controls.Add(this.txtCHname);
            this.Controls.Add(this.butCHhI);
            this.Controls.Add(this.labname);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Lab_Form2";
            this.Text = "你好!C#";
            this.Load += new System.EventHandler(this.Lab_Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labname;
        private System.Windows.Forms.Button butCHhI;
        private System.Windows.Forms.TextBox txtCHname;
        private System.Windows.Forms.Label labengname;
        private System.Windows.Forms.TextBox txtENGname;
        private System.Windows.Forms.Label labgender;
        private System.Windows.Forms.TextBox txtgender;
        private System.Windows.Forms.Label labcslt;
        private System.Windows.Forms.TextBox txtcslt;
        private System.Windows.Forms.Button butENGhi;
    }
}

