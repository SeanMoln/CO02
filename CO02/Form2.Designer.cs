namespace CO02
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.code = new System.Windows.Forms.TextBox();
            this.stopcode = new System.Windows.Forms.TextBox();
            this.stopname = new System.Windows.Forms.TextBox();
            this.YLine = new System.Windows.Forms.TextBox();
            this.XLine = new System.Windows.Forms.TextBox();
            this.place = new System.Windows.Forms.TextBox();
            this.GoogleMap = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            this.Top = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "代碼:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "站點名稱";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "經度";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "地址";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "站點代碼";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(242, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "緯度";
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(80, 37);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(139, 22);
            this.code.TabIndex = 6;
            // 
            // stopcode
            // 
            this.stopcode.Location = new System.Drawing.Point(301, 37);
            this.stopcode.Name = "stopcode";
            this.stopcode.Size = new System.Drawing.Size(201, 22);
            this.stopcode.TabIndex = 7;
            // 
            // stopname
            // 
            this.stopname.Location = new System.Drawing.Point(80, 76);
            this.stopname.Name = "stopname";
            this.stopname.Size = new System.Drawing.Size(422, 22);
            this.stopname.TabIndex = 8;
            // 
            // YLine
            // 
            this.YLine.Location = new System.Drawing.Point(80, 125);
            this.YLine.Name = "YLine";
            this.YLine.Size = new System.Drawing.Size(109, 22);
            this.YLine.TabIndex = 9;
            // 
            // XLine
            // 
            this.XLine.Location = new System.Drawing.Point(277, 125);
            this.XLine.Name = "XLine";
            this.XLine.Size = new System.Drawing.Size(109, 22);
            this.XLine.TabIndex = 10;
            // 
            // place
            // 
            this.place.Location = new System.Drawing.Point(80, 172);
            this.place.Multiline = true;
            this.place.Name = "place";
            this.place.Size = new System.Drawing.Size(422, 74);
            this.place.TabIndex = 11;
            // 
            // GoogleMap
            // 
            this.GoogleMap.Location = new System.Drawing.Point(402, 123);
            this.GoogleMap.Name = "GoogleMap";
            this.GoogleMap.Size = new System.Drawing.Size(100, 23);
            this.GoogleMap.TabIndex = 12;
            this.GoogleMap.Text = "Google地圖定位";
            this.GoogleMap.UseVisualStyleBackColor = true;
            // 
            // down
            // 
            this.down.Location = new System.Drawing.Point(427, 263);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(75, 23);
            this.down.TabIndex = 13;
            this.down.Text = "下一筆";
            this.down.UseVisualStyleBackColor = true;
            // 
            // Top
            // 
            this.Top.Location = new System.Drawing.Point(346, 263);
            this.Top.Name = "Top";
            this.Top.Size = new System.Drawing.Size(75, 23);
            this.Top.TabIndex = 14;
            this.Top.Text = "上一筆";
            this.Top.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 298);
            this.Controls.Add(this.Top);
            this.Controls.Add(this.down);
            this.Controls.Add(this.GoogleMap);
            this.Controls.Add(this.place);
            this.Controls.Add(this.XLine);
            this.Controls.Add(this.YLine);
            this.Controls.Add(this.stopname);
            this.Controls.Add(this.stopcode);
            this.Controls.Add(this.code);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.TextBox stopcode;
        private System.Windows.Forms.TextBox stopname;
        private System.Windows.Forms.TextBox YLine;
        private System.Windows.Forms.TextBox XLine;
        private System.Windows.Forms.TextBox place;
        private System.Windows.Forms.Button GoogleMap;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.Button Top;
    }
}