namespace DSAKnap
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Listbox1 = new System.Windows.Forms.ListBox();
            this.dataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ItemName_TB = new MaterialSkin.Controls.MaterialTextBox2();
            this.ItemValue_TB = new MaterialSkin.Controls.MaterialTextBox2();
            this.ItemWeight_TB = new MaterialSkin.Controls.MaterialTextBox2();
            this.label9 = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.label2 = new MaterialSkin.Controls.MaterialLabel();
            this.label5 = new MaterialSkin.Controls.MaterialLabel();
            this.label8 = new MaterialSkin.Controls.MaterialLabel();
            this.Calculate_Btn = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.ShowCart_Btn = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label3 = new MaterialSkin.Controls.MaterialLabel();
            this.KnapsackWeght_Lbl = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.label7 = new MaterialSkin.Controls.MaterialLabel();
            this.label6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Listbox1
            // 
            this.Listbox1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic);
            this.Listbox1.FormattingEnabled = true;
            this.Listbox1.ItemHeight = 18;
            this.Listbox1.Items.AddRange(new object[] {
            "Selected Items"});
            this.Listbox1.Location = new System.Drawing.Point(440, 98);
            this.Listbox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Listbox1.Name = "Listbox1";
            this.Listbox1.Size = new System.Drawing.Size(94, 238);
            this.Listbox1.TabIndex = 11;
            this.Listbox1.Visible = false;
            // 
            // dataGrid
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGrid.ColumnHeadersHeight = 25;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGrid.EnableHeadersVisualStyles = false;
            this.dataGrid.GridColor = System.Drawing.Color.White;
            this.dataGrid.Location = new System.Drawing.Point(6, 471);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(832, 137);
            this.dataGrid.TabIndex = 27;
            this.dataGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.dataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGrid.ThemeStyle.HeaderStyle.Height = 25;
            this.dataGrid.ThemeStyle.ReadOnly = false;
            this.dataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGrid.ThemeStyle.RowsStyle.Height = 22;
            this.dataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // ItemName_TB
            // 
            this.ItemName_TB.AnimateReadOnly = false;
            this.ItemName_TB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ItemName_TB.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ItemName_TB.Depth = 0;
            this.ItemName_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ItemName_TB.HideSelection = true;
            this.ItemName_TB.Hint = "Enter Item Names";
            this.ItemName_TB.LeadingIcon = null;
            this.ItemName_TB.Location = new System.Drawing.Point(134, 85);
            this.ItemName_TB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ItemName_TB.MaxLength = 32767;
            this.ItemName_TB.MouseState = MaterialSkin.MouseState.OUT;
            this.ItemName_TB.Name = "ItemName_TB";
            this.ItemName_TB.PasswordChar = '\0';
            this.ItemName_TB.PrefixSuffixText = null;
            this.ItemName_TB.ReadOnly = false;
            this.ItemName_TB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ItemName_TB.SelectedText = "";
            this.ItemName_TB.SelectionLength = 0;
            this.ItemName_TB.SelectionStart = 0;
            this.ItemName_TB.ShortcutsEnabled = true;
            this.ItemName_TB.Size = new System.Drawing.Size(230, 48);
            this.ItemName_TB.TabIndex = 28;
            this.ItemName_TB.TabStop = false;
            this.ItemName_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ItemName_TB.TrailingIcon = null;
            this.ItemName_TB.UseSystemPasswordChar = false;
            // 
            // ItemValue_TB
            // 
            this.ItemValue_TB.AnimateReadOnly = false;
            this.ItemValue_TB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ItemValue_TB.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ItemValue_TB.Depth = 0;
            this.ItemValue_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ItemValue_TB.HideSelection = true;
            this.ItemValue_TB.Hint = "Enter Item Values";
            this.ItemValue_TB.LeadingIcon = null;
            this.ItemValue_TB.Location = new System.Drawing.Point(134, 196);
            this.ItemValue_TB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ItemValue_TB.MaxLength = 32767;
            this.ItemValue_TB.MouseState = MaterialSkin.MouseState.OUT;
            this.ItemValue_TB.Name = "ItemValue_TB";
            this.ItemValue_TB.PasswordChar = '\0';
            this.ItemValue_TB.PrefixSuffixText = null;
            this.ItemValue_TB.ReadOnly = false;
            this.ItemValue_TB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ItemValue_TB.SelectedText = "";
            this.ItemValue_TB.SelectionLength = 0;
            this.ItemValue_TB.SelectionStart = 0;
            this.ItemValue_TB.ShortcutsEnabled = true;
            this.ItemValue_TB.Size = new System.Drawing.Size(230, 48);
            this.ItemValue_TB.TabIndex = 29;
            this.ItemValue_TB.TabStop = false;
            this.ItemValue_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ItemValue_TB.TrailingIcon = null;
            this.ItemValue_TB.UseSystemPasswordChar = false;
            // 
            // ItemWeight_TB
            // 
            this.ItemWeight_TB.AnimateReadOnly = false;
            this.ItemWeight_TB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ItemWeight_TB.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ItemWeight_TB.Depth = 0;
            this.ItemWeight_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ItemWeight_TB.HideSelection = true;
            this.ItemWeight_TB.Hint = "Enter Item Weights";
            this.ItemWeight_TB.LeadingIcon = null;
            this.ItemWeight_TB.Location = new System.Drawing.Point(134, 142);
            this.ItemWeight_TB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ItemWeight_TB.MaxLength = 32767;
            this.ItemWeight_TB.MouseState = MaterialSkin.MouseState.OUT;
            this.ItemWeight_TB.Name = "ItemWeight_TB";
            this.ItemWeight_TB.PasswordChar = '\0';
            this.ItemWeight_TB.PrefixSuffixText = null;
            this.ItemWeight_TB.ReadOnly = false;
            this.ItemWeight_TB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ItemWeight_TB.SelectedText = "";
            this.ItemWeight_TB.SelectionLength = 0;
            this.ItemWeight_TB.SelectionStart = 0;
            this.ItemWeight_TB.ShortcutsEnabled = true;
            this.ItemWeight_TB.Size = new System.Drawing.Size(230, 48);
            this.ItemWeight_TB.TabIndex = 30;
            this.ItemWeight_TB.TabStop = false;
            this.ItemWeight_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ItemWeight_TB.TrailingIcon = null;
            this.ItemWeight_TB.UseSystemPasswordChar = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Depth = 0;
            this.label9.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label9.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.label9.Location = new System.Drawing.Point(28, 98);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.MouseState = MaterialSkin.MouseState.HOVER;
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 19);
            this.label9.TabIndex = 31;
            this.label9.Text = "Item Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.label1.Location = new System.Drawing.Point(28, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = "Item Weight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Depth = 0;
            this.label2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.label2.Location = new System.Drawing.Point(28, 206);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.MouseState = MaterialSkin.MouseState.HOVER;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "Item Value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Depth = 0;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.label5.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            this.label5.Location = new System.Drawing.Point(376, 159);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.MouseState = MaterialSkin.MouseState.HOVER;
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 14);
            this.label5.TabIndex = 34;
            this.label5.Text = "KG";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Depth = 0;
            this.label8.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.label8.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            this.label8.Location = new System.Drawing.Point(376, 211);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.MouseState = MaterialSkin.MouseState.HOVER;
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 14);
            this.label8.TabIndex = 35;
            this.label8.Text = "RS.";
            // 
            // Calculate_Btn
            // 
            this.Calculate_Btn.BorderColor = System.Drawing.Color.White;
            this.Calculate_Btn.BorderRadius = 20;
            this.Calculate_Btn.CheckedState.Parent = this.Calculate_Btn;
            this.Calculate_Btn.CustomImages.Parent = this.Calculate_Btn;
            this.Calculate_Btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(212)))), ((int)(((byte)(250)))));
            this.Calculate_Btn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.Calculate_Btn.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.Calculate_Btn.ForeColor = System.Drawing.Color.White;
            this.Calculate_Btn.HoverState.Parent = this.Calculate_Btn;
            this.Calculate_Btn.Location = new System.Drawing.Point(32, 406);
            this.Calculate_Btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Calculate_Btn.Name = "Calculate_Btn";
            this.Calculate_Btn.PressedColor = System.Drawing.Color.White;
            this.Calculate_Btn.ShadowDecoration.Parent = this.Calculate_Btn;
            this.Calculate_Btn.Size = new System.Drawing.Size(142, 41);
            this.Calculate_Btn.TabIndex = 36;
            this.Calculate_Btn.Text = "Calculate";
            this.Calculate_Btn.Click += new System.EventHandler(this.Calculate_Btn_Click_1);
            // 
            // ShowCart_Btn
            // 
            this.ShowCart_Btn.BorderColor = System.Drawing.Color.White;
            this.ShowCart_Btn.BorderRadius = 20;
            this.ShowCart_Btn.CheckedState.Parent = this.ShowCart_Btn;
            this.ShowCart_Btn.CustomImages.Parent = this.ShowCart_Btn;
            this.ShowCart_Btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(212)))), ((int)(((byte)(250)))));
            this.ShowCart_Btn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.ShowCart_Btn.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ShowCart_Btn.ForeColor = System.Drawing.Color.White;
            this.ShowCart_Btn.HoverState.Parent = this.ShowCart_Btn;
            this.ShowCart_Btn.Location = new System.Drawing.Point(230, 406);
            this.ShowCart_Btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ShowCart_Btn.Name = "ShowCart_Btn";
            this.ShowCart_Btn.PressedColor = System.Drawing.Color.White;
            this.ShowCart_Btn.ShadowDecoration.Parent = this.ShowCart_Btn;
            this.ShowCart_Btn.Size = new System.Drawing.Size(142, 41);
            this.ShowCart_Btn.TabIndex = 37;
            this.ShowCart_Btn.Text = "Show Chart";
            this.ShowCart_Btn.Click += new System.EventHandler(this.ShowCart_Btn_Click_1);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(412, 68);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(424, 390);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 38;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Depth = 0;
            this.label3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(28, 283);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.MouseState = MaterialSkin.MouseState.HOVER;
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 19);
            this.label3.TabIndex = 39;
            this.label3.Text = "Knapsack Weight";
            // 
            // KnapsackWeght_Lbl
            // 
            this.KnapsackWeght_Lbl.AutoSize = true;
            this.KnapsackWeght_Lbl.Depth = 0;
            this.KnapsackWeght_Lbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.KnapsackWeght_Lbl.Location = new System.Drawing.Point(194, 283);
            this.KnapsackWeght_Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.KnapsackWeght_Lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.KnapsackWeght_Lbl.Name = "KnapsackWeght_Lbl";
            this.KnapsackWeght_Lbl.Size = new System.Drawing.Size(1, 0);
            this.KnapsackWeght_Lbl.TabIndex = 40;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(28, 318);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(91, 19);
            this.materialLabel1.TabIndex = 41;
            this.materialLabel1.Text = "Total Weight";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Depth = 0;
            this.label7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label7.Location = new System.Drawing.Point(166, 318);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.MouseState = MaterialSkin.MouseState.HOVER;
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 19);
            this.label7.TabIndex = 42;
            this.label7.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Depth = 0;
            this.label6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label6.Location = new System.Drawing.Point(166, 350);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.MouseState = MaterialSkin.MouseState.HOVER;
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 19);
            this.label6.TabIndex = 45;
            this.label6.Text = "0";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(28, 350);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(88, 19);
            this.materialLabel5.TabIndex = 44;
            this.materialLabel5.Text = "Total Benifit";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(845, 469);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.KnapsackWeght_Lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.ShowCart_Btn);
            this.Controls.Add(this.Calculate_Btn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ItemWeight_TB);
            this.Controls.Add(this.ItemValue_TB);
            this.Controls.Add(this.ItemName_TB);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.Listbox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(-50, 60);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(2, 64, 2, 3);
            this.Sizable = false;
            this.Text = "Fractional Knapsack";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox Listbox1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGrid;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private MaterialSkin.Controls.MaterialTextBox2 ItemName_TB;
        private MaterialSkin.Controls.MaterialTextBox2 ItemWeight_TB;
        private MaterialSkin.Controls.MaterialTextBox2 ItemValue_TB;
        private MaterialSkin.Controls.MaterialLabel label9;
        private MaterialSkin.Controls.MaterialLabel label1;
        private MaterialSkin.Controls.MaterialLabel label2;
        private MaterialSkin.Controls.MaterialLabel label5;
        private MaterialSkin.Controls.MaterialLabel label8;
        private Guna.UI2.WinForms.Guna2GradientTileButton ShowCart_Btn;
        private Guna.UI2.WinForms.Guna2GradientTileButton Calculate_Btn;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private MaterialSkin.Controls.MaterialLabel label3;
        private MaterialSkin.Controls.MaterialLabel KnapsackWeght_Lbl;
        private MaterialSkin.Controls.MaterialLabel label7;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel label6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        //private BunifuThinButton2 Calculate_Btn;
        //private BunifuThinButton2 ShowCart_Btn;
    }
}

