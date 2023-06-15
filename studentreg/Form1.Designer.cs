namespace studentreg
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pictureBox1=new PictureBox();
            label1=new Label();
            panel1=new Panel();
            pictureBox3=new PictureBox();
            groupBox1=new GroupBox();
            txtFee=new TextBox();
            txtCourse=new TextBox();
            txtName=new TextBox();
            label4=new Label();
            label3=new Label();
            label2=new Label();
            button1=new Button();
            button3=new Button();
            dataGridView1=new DataGridView();
            Column1=new DataGridViewTextBoxColumn();
            Column2=new DataGridViewTextBoxColumn();
            Column3=new DataGridViewTextBoxColumn();
            Column4=new DataGridViewTextBoxColumn();
            Edit=new DataGridViewButtonColumn();
            Delete=new DataGridViewButtonColumn();
            button2=new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image=(Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location=new Point(3, 3);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(125, 120);
            pictureBox1.SizeMode=PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex=0;
            pictureBox1.TabStop=false;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location=new Point(369, 9);
            label1.Name="label1";
            label1.Size=new Size(762, 106);
            label1.TabIndex=1;
            label1.Text="Student Registration";
            // 
            // panel1
            // 
            panel1.BackColor=SystemColors.ScrollBar;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock=DockStyle.Top;
            panel1.Location=new Point(0, 0);
            panel1.Name="panel1";
            panel1.Size=new Size(1406, 126);
            panel1.TabIndex=2;
            // 
            // pictureBox3
            // 
            pictureBox3.Image=(Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location=new Point(1269, 3);
            pictureBox3.Name="pictureBox3";
            pictureBox3.Size=new Size(125, 120);
            pictureBox3.SizeMode=PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex=2;
            pictureBox3.TabStop=false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtFee);
            groupBox1.Controls.Add(txtCourse);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location=new Point(35, 181);
            groupBox1.Name="groupBox1";
            groupBox1.Size=new Size(464, 289);
            groupBox1.TabIndex=3;
            groupBox1.TabStop=false;
            groupBox1.Text="Student Registration";
            groupBox1.Enter+=groupBox1_Enter;
            // 
            // txtFee
            // 
            txtFee.Location=new Point(156, 214);
            txtFee.Name="txtFee";
            txtFee.Size=new Size(255, 27);
            txtFee.TabIndex=5;
            // 
            // txtCourse
            // 
            txtCourse.Location=new Point(156, 144);
            txtCourse.Name="txtCourse";
            txtCourse.Size=new Size(255, 27);
            txtCourse.TabIndex=4;
            // 
            // txtName
            // 
            txtName.Location=new Point(156, 74);
            txtName.Name="txtName";
            txtName.Size=new Size(255, 27);
            txtName.TabIndex=3;
            txtName.TextChanged+=textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Location=new Point(15, 214);
            label4.Name="label4";
            label4.Size=new Size(32, 20);
            label4.TabIndex=2;
            label4.Text="Fee";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(15, 144);
            label3.Name="label3";
            label3.Size=new Size(54, 20);
            label3.TabIndex=1;
            label3.Text="Course";
            label3.Click+=label3_Click;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(15, 74);
            label2.Name="label2";
            label2.Size=new Size(104, 20);
            label2.TabIndex=0;
            label2.Text="Student Name";
            label2.Click+=label2_Click;
            // 
            // button1
            // 
            button1.Location=new Point(35, 497);
            button1.Name="button1";
            button1.Size=new Size(136, 46);
            button1.TabIndex=4;
            button1.Text="Save";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // button3
            // 
            button3.Location=new Point(369, 497);
            button3.Name="button3";
            button3.Size=new Size(130, 46);
            button3.TabIndex=6;
            button3.Text="Clear";
            button3.UseVisualStyleBackColor=true;
            button3.Click+=button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor=SystemColors.ScrollBar;
            dataGridView1.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Edit, Delete });
            dataGridView1.Location=new Point(551, 181);
            dataGridView1.Name="dataGridView1";
            dataGridView1.RowHeadersWidth=51;
            dataGridView1.RowTemplate.Height=29;
            dataGridView1.Size=new Size(804, 289);
            dataGridView1.TabIndex=7;
            dataGridView1.CellContentClick+=dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText="ID";
            Column1.MinimumWidth=6;
            Column1.Name="Column1";
            Column1.Width=125;
            // 
            // Column2
            // 
            Column2.HeaderText="Student Name";
            Column2.MinimumWidth=6;
            Column2.Name="Column2";
            Column2.Width=125;
            // 
            // Column3
            // 
            Column3.HeaderText="Course";
            Column3.MinimumWidth=6;
            Column3.Name="Column3";
            Column3.Width=125;
            // 
            // Column4
            // 
            Column4.HeaderText="Fee";
            Column4.MinimumWidth=6;
            Column4.Name="Column4";
            Column4.Width=125;
            // 
            // Edit
            // 
            dataGridViewCellStyle1.Alignment=DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font=new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Edit.DefaultCellStyle=dataGridViewCellStyle1;
            Edit.HeaderText="Edit";
            Edit.MinimumWidth=6;
            Edit.Name="Edit";
            Edit.Text="Edit";
            Edit.UseColumnTextForButtonValue=true;
            Edit.Width=125;
            // 
            // Delete
            // 
            dataGridViewCellStyle2.Alignment=DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font=new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Delete.DefaultCellStyle=dataGridViewCellStyle2;
            Delete.HeaderText="Delete";
            Delete.MinimumWidth=6;
            Delete.Name="Delete";
            Delete.Text="Delete";
            Delete.UseColumnTextForButtonValue=true;
            Delete.Width=125;
            // 
            // button2
            // 
            button2.Location=new Point(1219, 497);
            button2.Name="button2";
            button2.Size=new Size(136, 46);
            button2.TabIndex=8;
            button2.Text="Refresh";
            button2.UseVisualStyleBackColor=true;
            button2.Click+=button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(1406, 623);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name="Form1";
            Text="Gate";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox3;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtFee;
        private TextBox txtCourse;
        private TextBox txtName;
        private Button button1;
        private Button button3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Button button2;
    }
}