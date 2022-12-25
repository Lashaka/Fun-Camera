namespace SpyWare
{
    partial class Form1_Window
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
            this.components = new System.ComponentModel.Container();
            this.CapturedVideo = new System.Windows.Forms.PictureBox();
            this.CapturedPicture = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Label_LiveCamera = new System.Windows.Forms.Label();
            this.Label_Screenshot = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Button_IncreaseTra = new System.Windows.Forms.Button();
            this.Button_DecreaseTran = new System.Windows.Forms.Button();
            this.Label_Transparency = new System.Windows.Forms.Label();
            this.Button_Save = new System.Windows.Forms.Button();
            this.Button_Capture = new System.Windows.Forms.Button();
            this.ComboBox_Effect = new System.Windows.Forms.ComboBox();
            this.Label_Effect = new System.Windows.Forms.Label();
            this.Label_ChooseCamera = new System.Windows.Forms.Label();
            this.ComboBox_Camera = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.Label_TranValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CapturedVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CapturedPicture)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // CapturedVideo
            // 
            this.CapturedVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CapturedVideo.Location = new System.Drawing.Point(26, 166);
            this.CapturedVideo.Margin = new System.Windows.Forms.Padding(23);
            this.CapturedVideo.Name = "CapturedVideo";
            this.CapturedVideo.Size = new System.Drawing.Size(663, 503);
            this.CapturedVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CapturedVideo.TabIndex = 1;
            this.CapturedVideo.TabStop = false;
            // 
            // CapturedPicture
            // 
            this.CapturedPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CapturedPicture.Location = new System.Drawing.Point(738, 166);
            this.CapturedPicture.Margin = new System.Windows.Forms.Padding(23);
            this.CapturedPicture.Name = "CapturedPicture";
            this.CapturedPicture.Size = new System.Drawing.Size(663, 503);
            this.CapturedPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CapturedPicture.TabIndex = 3;
            this.CapturedPicture.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.CapturedVideo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.CapturedPicture, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Label_LiveCamera, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Label_Screenshot, 1, 0);
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 77);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1427, 695);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // Label_LiveCamera
            // 
            this.Label_LiveCamera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Label_LiveCamera.AutoSize = true;
            this.Label_LiveCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_LiveCamera.Location = new System.Drawing.Point(70, 3);
            this.Label_LiveCamera.Margin = new System.Windows.Forms.Padding(0);
            this.Label_LiveCamera.Name = "Label_LiveCamera";
            this.Label_LiveCamera.Size = new System.Drawing.Size(575, 137);
            this.Label_LiveCamera.TabIndex = 4;
            this.Label_LiveCamera.Text = "Live Camera";
            // 
            // Label_Screenshot
            // 
            this.Label_Screenshot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Label_Screenshot.AutoSize = true;
            this.Label_Screenshot.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Screenshot.Location = new System.Drawing.Point(810, 3);
            this.Label_Screenshot.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Screenshot.Name = "Label_Screenshot";
            this.Label_Screenshot.Size = new System.Drawing.Size(519, 137);
            this.Label_Screenshot.TabIndex = 5;
            this.Label_Screenshot.Text = "Screenshot";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Button_IncreaseTra
            // 
            this.Button_IncreaseTra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_IncreaseTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_IncreaseTra.Location = new System.Drawing.Point(58, 6);
            this.Button_IncreaseTra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Button_IncreaseTra.Name = "Button_IncreaseTra";
            this.Button_IncreaseTra.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Button_IncreaseTra.Size = new System.Drawing.Size(56, 27);
            this.Button_IncreaseTra.TabIndex = 0;
            this.Button_IncreaseTra.Text = "+";
            this.Button_IncreaseTra.UseVisualStyleBackColor = true;
            this.Button_IncreaseTra.Click += new System.EventHandler(this.Button_IncreaseTra_Click);
            // 
            // Button_DecreaseTran
            // 
            this.Button_DecreaseTran.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_DecreaseTran.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_DecreaseTran.Location = new System.Drawing.Point(122, 6);
            this.Button_DecreaseTran.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Button_DecreaseTran.Name = "Button_DecreaseTran";
            this.Button_DecreaseTran.Size = new System.Drawing.Size(57, 27);
            this.Button_DecreaseTran.TabIndex = 1;
            this.Button_DecreaseTran.Text = "-";
            this.Button_DecreaseTran.UseVisualStyleBackColor = true;
            this.Button_DecreaseTran.Click += new System.EventHandler(this.Button_DecreaseTran_Click);
            // 
            // Label_Transparency
            // 
            this.Label_Transparency.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_Transparency.AutoSize = true;
            this.Label_Transparency.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Transparency.Location = new System.Drawing.Point(4, 0);
            this.Label_Transparency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Transparency.Name = "Label_Transparency";
            this.Label_Transparency.Size = new System.Drawing.Size(182, 22);
            this.Label_Transparency.TabIndex = 10;
            this.Label_Transparency.Text = "Effect Transparency:";
            // 
            // Button_Save
            // 
            this.Button_Save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Button_Save.Location = new System.Drawing.Point(1238, 3);
            this.Button_Save.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(88, 27);
            this.Button_Save.TabIndex = 4;
            this.Button_Save.Text = "Save";
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // Button_Capture
            // 
            this.Button_Capture.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Button_Capture.Location = new System.Drawing.Point(912, 3);
            this.Button_Capture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Button_Capture.Name = "Button_Capture";
            this.Button_Capture.Size = new System.Drawing.Size(166, 27);
            this.Button_Capture.TabIndex = 2;
            this.Button_Capture.Text = "Take A Screenshot";
            this.Button_Capture.UseVisualStyleBackColor = true;
            this.Button_Capture.Click += new System.EventHandler(this.Button_Capture_Click);
            // 
            // ComboBox_Effect
            // 
            this.ComboBox_Effect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ComboBox_Effect.FormattingEnabled = true;
            this.ComboBox_Effect.Items.AddRange(new object[] {
            "No Effect",
            "Blue",
            "Red",
            "Green",
            "Yellow",
            "Orange",
            "Pink",
            "Purple",
            "Black",
            "White",
            "Brown",
            "Disco Party",
            "Rainbow",
            "Chess",
            "Holy",
            "FlipX",
            "FlipY"});
            this.ComboBox_Effect.Location = new System.Drawing.Point(374, 3);
            this.ComboBox_Effect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ComboBox_Effect.Name = "ComboBox_Effect";
            this.ComboBox_Effect.Size = new System.Drawing.Size(134, 23);
            this.ComboBox_Effect.TabIndex = 9;
            this.ComboBox_Effect.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Effect_SelectedIndexChanged);
            // 
            // Label_Effect
            // 
            this.Label_Effect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_Effect.AutoSize = true;
            this.Label_Effect.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Effect.Location = new System.Drawing.Point(266, 0);
            this.Label_Effect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Effect.Name = "Label_Effect";
            this.Label_Effect.Size = new System.Drawing.Size(93, 31);
            this.Label_Effect.TabIndex = 8;
            this.Label_Effect.Text = "Effect:";
            // 
            // Label_ChooseCamera
            // 
            this.Label_ChooseCamera.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_ChooseCamera.AutoSize = true;
            this.Label_ChooseCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ChooseCamera.Location = new System.Drawing.Point(9, 0);
            this.Label_ChooseCamera.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_ChooseCamera.Name = "Label_ChooseCamera";
            this.Label_ChooseCamera.Size = new System.Drawing.Size(96, 26);
            this.Label_ChooseCamera.TabIndex = 7;
            this.Label_ChooseCamera.Text = "Camera:";
            // 
            // ComboBox_Camera
            // 
            this.ComboBox_Camera.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ComboBox_Camera.FormattingEnabled = true;
            this.ComboBox_Camera.Location = new System.Drawing.Point(118, 3);
            this.ComboBox_Camera.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ComboBox_Camera.Name = "ComboBox_Camera";
            this.ComboBox_Camera.Size = new System.Drawing.Size(134, 23);
            this.ComboBox_Camera.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.ComboBox_Camera, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ComboBox_Effect, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.Button_Capture, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.Button_Save, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.Label_ChooseCamera, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Label_Effect, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 4, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(14, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1427, 75);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.Label_Transparency, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(516, 3);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.35294F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.64706F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(191, 68);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel5.Controls.Add(this.Button_DecreaseTran, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.Button_IncreaseTra, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.Label_TranValue, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(4, 25);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(183, 40);
            this.tableLayoutPanel5.TabIndex = 12;
            // 
            // Label_TranValue
            // 
            this.Label_TranValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_TranValue.AutoSize = true;
            this.Label_TranValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label_TranValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TranValue.Location = new System.Drawing.Point(8, 9);
            this.Label_TranValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_TranValue.Name = "Label_TranValue";
            this.Label_TranValue.Size = new System.Drawing.Size(38, 22);
            this.Label_TranValue.TabIndex = 11;
            this.Label_TranValue.Text = "100";
            this.Label_TranValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 786);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(1491, 825);
            this.Name = "Form1_Window";
            this.Text = "Fun Camera";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.CapturedVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CapturedPicture)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox CapturedVideo;
        private System.Windows.Forms.PictureBox CapturedPicture;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label Label_LiveCamera;
        private System.Windows.Forms.Label Label_Screenshot;
        private System.Windows.Forms.Button Button_IncreaseTra;
        private System.Windows.Forms.Button Button_DecreaseTran;
        private System.Windows.Forms.Label Label_Transparency;
        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.Button Button_Capture;
        private System.Windows.Forms.ComboBox ComboBox_Effect;
        private System.Windows.Forms.Label Label_Effect;
        private System.Windows.Forms.Label Label_ChooseCamera;
        private System.Windows.Forms.ComboBox ComboBox_Camera;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label Label_TranValue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    }
}

