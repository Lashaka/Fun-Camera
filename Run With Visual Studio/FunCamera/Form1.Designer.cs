namespace Smart_Camera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1_Window));
            this.CapturedVideo = new System.Windows.Forms.PictureBox();
            this.CapturedPicture = new System.Windows.Forms.PictureBox();
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
            this.Label_TranValue = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.CapturedVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CapturedPicture)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CapturedVideo
            // 
            this.CapturedVideo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CapturedVideo.Dock = System.Windows.Forms.DockStyle.Left;
            this.CapturedVideo.Location = new System.Drawing.Point(23, 23);
            this.CapturedVideo.Margin = new System.Windows.Forms.Padding(23);
            this.CapturedVideo.Name = "CapturedVideo";
            this.CapturedVideo.Size = new System.Drawing.Size(696, 407);
            this.CapturedVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CapturedVideo.TabIndex = 1;
            this.CapturedVideo.TabStop = false;
            // 
            // CapturedPicture
            // 
            this.CapturedPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CapturedPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CapturedPicture.Dock = System.Windows.Forms.DockStyle.Right;
            this.CapturedPicture.Location = new System.Drawing.Point(765, 23);
            this.CapturedPicture.Margin = new System.Windows.Forms.Padding(23);
            this.CapturedPicture.Name = "CapturedPicture";
            this.CapturedPicture.Size = new System.Drawing.Size(696, 407);
            this.CapturedPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CapturedPicture.TabIndex = 3;
            this.CapturedPicture.TabStop = false;
            // 
            // Label_LiveCamera
            // 
            this.Label_LiveCamera.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_LiveCamera.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.Label_LiveCamera.Location = new System.Drawing.Point(0, 0);
            this.Label_LiveCamera.Margin = new System.Windows.Forms.Padding(0);
            this.Label_LiveCamera.Name = "Label_LiveCamera";
            this.Label_LiveCamera.Size = new System.Drawing.Size(742, 56);
            this.Label_LiveCamera.TabIndex = 4;
            this.Label_LiveCamera.Text = "Live Camera";
            this.Label_LiveCamera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Screenshot
            // 
            this.Label_Screenshot.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Screenshot.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.Label_Screenshot.Location = new System.Drawing.Point(0, 0);
            this.Label_Screenshot.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Screenshot.Name = "Label_Screenshot";
            this.Label_Screenshot.Size = new System.Drawing.Size(742, 56);
            this.Label_Screenshot.TabIndex = 5;
            this.Label_Screenshot.Text = "Screenshot";
            this.Label_Screenshot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Button_IncreaseTra
            // 
            this.Button_IncreaseTra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Button_IncreaseTra.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Button_IncreaseTra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_IncreaseTra.FlatAppearance.BorderSize = 0;
            this.Button_IncreaseTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_IncreaseTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_IncreaseTra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_IncreaseTra.Location = new System.Drawing.Point(1127, 3);
            this.Button_IncreaseTra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Button_IncreaseTra.Name = "Button_IncreaseTra";
            this.Button_IncreaseTra.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Button_IncreaseTra.Size = new System.Drawing.Size(60, 60);
            this.Button_IncreaseTra.TabIndex = 0;
            this.Button_IncreaseTra.Text = "+";
            this.Button_IncreaseTra.UseVisualStyleBackColor = false;
            this.Button_IncreaseTra.Click += new System.EventHandler(this.Button_IncreaseTra_Click_1);
            this.Button_IncreaseTra.Paint += new System.Windows.Forms.PaintEventHandler(this.Button_IncreaseTra_Paint);
            // 
            // Button_DecreaseTran
            // 
            this.Button_DecreaseTran.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Button_DecreaseTran.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Button_DecreaseTran.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_DecreaseTran.FlatAppearance.BorderSize = 0;
            this.Button_DecreaseTran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_DecreaseTran.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_DecreaseTran.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button_DecreaseTran.Location = new System.Drawing.Point(1406, 3);
            this.Button_DecreaseTran.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Button_DecreaseTran.Name = "Button_DecreaseTran";
            this.Button_DecreaseTran.Size = new System.Drawing.Size(60, 60);
            this.Button_DecreaseTran.TabIndex = 1;
            this.Button_DecreaseTran.Text = "-";
            this.Button_DecreaseTran.UseVisualStyleBackColor = false;
            this.Button_DecreaseTran.Click += new System.EventHandler(this.Button_DecreaseTran_Click_1);
            // 
            // Label_Transparency
            // 
            this.Label_Transparency.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_Transparency.AutoSize = true;
            this.Label_Transparency.Font = new System.Drawing.Font("Roboto", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Transparency.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.Label_Transparency.Location = new System.Drawing.Point(777, 15);
            this.Label_Transparency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Transparency.Name = "Label_Transparency";
            this.Label_Transparency.Size = new System.Drawing.Size(297, 37);
            this.Label_Transparency.TabIndex = 10;
            this.Label_Transparency.Text = "Effect Transparency:";
            this.Label_Transparency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button_Save
            // 
            this.Button_Save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Save.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Button_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Save.FlatAppearance.BorderSize = 2;
            this.Button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Save.Font = new System.Drawing.Font("Roboto", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_Save.Location = new System.Drawing.Point(988, 8);
            this.Button_Save.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(250, 110);
            this.Button_Save.TabIndex = 4;
            this.Button_Save.Text = "Save";
            this.Button_Save.UseVisualStyleBackColor = false;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            this.Button_Save.Paint += new System.Windows.Forms.PaintEventHandler(this.Button_Save_Paint);
            // 
            // Button_Capture
            // 
            this.Button_Capture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Capture.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Button_Capture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Capture.FlatAppearance.BorderSize = 2;
            this.Button_Capture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Capture.Font = new System.Drawing.Font("Roboto", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Capture.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_Capture.Location = new System.Drawing.Point(246, 8);
            this.Button_Capture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Button_Capture.Name = "Button_Capture";
            this.Button_Capture.Size = new System.Drawing.Size(250, 110);
            this.Button_Capture.TabIndex = 2;
            this.Button_Capture.Text = "Take A Screenshot";
            this.Button_Capture.UseVisualStyleBackColor = false;
            this.Button_Capture.Click += new System.EventHandler(this.Button_Capture_Click);
            this.Button_Capture.Paint += new System.Windows.Forms.PaintEventHandler(this.Button_Capture_Paint);
            // 
            // ComboBox_Effect
            // 
            this.ComboBox_Effect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComboBox_Effect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBox_Effect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_Effect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Effect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_Effect.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_Effect.ForeColor = System.Drawing.Color.MediumTurquoise;
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
            "Vertical Flip",
            "Horizontal Flip"});
            this.ComboBox_Effect.Location = new System.Drawing.Point(562, 14);
            this.ComboBox_Effect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ComboBox_Effect.Name = "ComboBox_Effect";
            this.ComboBox_Effect.Size = new System.Drawing.Size(170, 39);
            this.ComboBox_Effect.TabIndex = 9;
            this.ComboBox_Effect.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ComboBox_Effect_DrawItem);
            this.ComboBox_Effect.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Effect_SelectedIndexChanged);
            // 
            // Label_Effect
            // 
            this.Label_Effect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_Effect.AutoSize = true;
            this.Label_Effect.Font = new System.Drawing.Font("Roboto", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Effect.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.Label_Effect.Location = new System.Drawing.Point(409, 15);
            this.Label_Effect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Effect.Name = "Label_Effect";
            this.Label_Effect.Size = new System.Drawing.Size(106, 37);
            this.Label_Effect.TabIndex = 8;
            this.Label_Effect.Text = "Effect:";
            // 
            // Label_ChooseCamera
            // 
            this.Label_ChooseCamera.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_ChooseCamera.AutoSize = true;
            this.Label_ChooseCamera.Font = new System.Drawing.Font("Roboto", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Label_ChooseCamera.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.Label_ChooseCamera.Location = new System.Drawing.Point(24, 16);
            this.Label_ChooseCamera.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_ChooseCamera.Name = "Label_ChooseCamera";
            this.Label_ChooseCamera.Size = new System.Drawing.Size(136, 35);
            this.Label_ChooseCamera.TabIndex = 7;
            this.Label_ChooseCamera.Text = "Camera:";
            // 
            // ComboBox_Camera
            // 
            this.ComboBox_Camera.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComboBox_Camera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBox_Camera.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_Camera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Camera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_Camera.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_Camera.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.ComboBox_Camera.FormattingEnabled = true;
            this.ComboBox_Camera.Location = new System.Drawing.Point(192, 14);
            this.ComboBox_Camera.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ComboBox_Camera.Name = "ComboBox_Camera";
            this.ComboBox_Camera.Size = new System.Drawing.Size(170, 39);
            this.ComboBox_Camera.TabIndex = 0;
            this.ComboBox_Camera.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ComboBox_Camera_DrawItem);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.Controls.Add(this.Label_Transparency, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.Button_IncreaseTra, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.Button_DecreaseTran, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.ComboBox_Effect, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.Label_TranValue, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.Label_ChooseCamera, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Label_Effect, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.ComboBox_Camera, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1484, 68);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // Label_TranValue
            // 
            this.Label_TranValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_TranValue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label_TranValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_TranValue.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TranValue.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.Label_TranValue.Location = new System.Drawing.Point(1220, 9);
            this.Label_TranValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_TranValue.Name = "Label_TranValue";
            this.Label_TranValue.Size = new System.Drawing.Size(150, 50);
            this.Label_TranValue.TabIndex = 11;
            this.Label_TranValue.Text = "100";
            this.Label_TranValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.CapturedVideo, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.CapturedPicture, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.flowLayoutPanel2, 1, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 194);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1484, 567);
            this.tableLayoutPanel4.TabIndex = 7;
            this.tableLayoutPanel4.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tableLayoutPanel4_CellPaint_1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Label_LiveCamera);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 456);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(736, 73);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.Label_Screenshot);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(745, 456);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(736, 73);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Button_Capture, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Button_Save, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 68);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1484, 126);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // Form1_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(1350, 800);
            this.Name = "Form1_Window";
            this.Text = "Fun Camera";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_Window_ResizeEnd);
            this.Resize += new System.EventHandler(this.Form1_Window_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.CapturedVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CapturedPicture)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox CapturedVideo;
        private System.Windows.Forms.PictureBox CapturedPicture;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}

