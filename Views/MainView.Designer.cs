namespace Supermarket_mvp.Views
{
    partial class MainView
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
            panel1 = new Panel();
            BtnCustomer = new Button();
            BtnProduct = new Button();
            BtnExit = new Button();
            BtnPayMode = new Button();
            pictureBox1 = new PictureBox();
            BtnCategory = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnCategory);
            panel1.Controls.Add(BtnCustomer);
            panel1.Controls.Add(BtnProduct);
            panel1.Controls.Add(BtnExit);
            panel1.Controls.Add(BtnPayMode);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(279, 743);
            panel1.TabIndex = 0;
            // 
            // BtnCustomer
            // 
            BtnCustomer.BackgroundImage = Properties.Resources.cliente;
            BtnCustomer.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCustomer.Location = new Point(4, 319);
            BtnCustomer.Name = "BtnCustomer";
            BtnCustomer.Size = new Size(273, 119);
            BtnCustomer.TabIndex = 4;
            BtnCustomer.UseVisualStyleBackColor = true;
            // 
            // BtnProduct
            // 
            BtnProduct.BackgroundImage = Properties.Resources.products;
            BtnProduct.BackgroundImageLayout = ImageLayout.Zoom;
            BtnProduct.Location = new Point(3, 194);
            BtnProduct.Name = "BtnProduct";
            BtnProduct.Size = new Size(273, 119);
            BtnProduct.TabIndex = 3;
            BtnProduct.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            BtnExit.BackgroundImage = Properties.Resources.salida;
            BtnExit.BackgroundImageLayout = ImageLayout.Zoom;
            BtnExit.Dock = DockStyle.Bottom;
            BtnExit.Location = new Point(0, 624);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(279, 119);
            BtnExit.TabIndex = 2;
            BtnExit.UseVisualStyleBackColor = true;
            // 
            // BtnPayMode
            // 
            BtnPayMode.BackgroundImage = Properties.Resources.buy;
            BtnPayMode.BackgroundImageLayout = ImageLayout.Zoom;
            BtnPayMode.Location = new Point(3, 69);
            BtnPayMode.Name = "BtnPayMode";
            BtnPayMode.Size = new Size(273, 119);
            BtnPayMode.TabIndex = 1;
            BtnPayMode.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sell;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(276, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // BtnCategory
            // 
            BtnCategory.BackgroundImage = Properties.Resources.categorias;
            BtnCategory.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCategory.Location = new Point(3, 444);
            BtnCategory.Name = "BtnCategory";
            BtnCategory.Size = new Size(273, 119);
            BtnCategory.TabIndex = 5;
            BtnCategory.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 743);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "MainView";
            Text = "Supermarket";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button BtnPayMode;
        private Button BtnExit;
        private Button BtnProduct;
        private Button BtnCustomer;
        private Button BtnCategory;
    }
}